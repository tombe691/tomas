<?php

// Router är den klass som tar emot både get och post reuqests och processerar dessa för att determinera vilkne controller ska användas
namespace App\Core
{

    use App\Core\Classes\Input;
    use App\Core\Classes\Redirect;

    class Router 
    {
        public $domains = []; // domainer som är registrerade
        public $routes = [], // routes som innehåller data om en domainer
                $domain_tree, // trästruktur av domainer för att hjälpa med sökning
                $selected_route = '',
                $selected_method = '',
                $selected_params = [],
                $success = true;
        protected $object;
        private static $regex_patterns = [
            'int' => '\d+',
            'string' => '[a-z-]+',
            'mixed' => '[a-z0-9-]+'
        ];
        private $callables = []; // ensamma funktioner som inte tillhör någon klass eller controller, utan routern

        private function addCallable($callable, $name, $params = []) 
        {
            $this->callables[$name] = [
                'callable' => \Closure::bind($callable, $this, get_class()),
                'params' => $params
            ];
        } // tillägg en ny kallable, sker automatiskt när en funktion tilläggs via get eller post metoder utan någon angiven klass

        public function __get($name) 
        { 
            if(array_key_exists($name, $this->object)){
                return $this->object[$name];
            }
            return null;
        }

        public function addProperty($name, $value)
        {
            if (!array_key_exists($name, $this->object)){
                return $this->object[$name] = $value;
            }
        } // adderar egenskaper till objektet

        public function __call($name, $args) 
        {
            if(is_callable($this->callables[$name]))
            {
                return call_user_func_array($this->callables[$name], $args);
            }
        } // magic method för de callables som har lagrats i egenskapen callables

        public function traverseDomainTree($url_bit)
        {
            $this->domain_tree = $this->makeTree($this->domains, '/', true);
            $results = $this->iterate($url_bit, $this->domain_tree);
            $traversal = '';
            if ($results){
                foreach ($results as $result){
                    if (is_string($result)){
                        if (array_key_exists($result, $this->routes)){
                            $traversal = $result;
                            break;
                        }
                    } elseif (is_array($result)){
                        $iterator = new \RecursiveIteratorIterator(
                            new \RecursiveArrayIterator($result), 
                            \RecursiveIteratorIterator::CHILD_FIRST
                        );
                        $max_depth = 2;
                        $items = [];
                        foreach ($iterator as $item){
                            $depth = $iterator->getDepth();
                            if ($depth > $max_depth){       
                                break;
                            }
                            if (is_string($item)){
                                $items[$depth] = $item;
                            }
                        }
                        $traversal = $items;
                    }
                }
            }
            return $traversal;
        } // traverserar trästruktren för att hitta närmaste index funktionen till en angiven route och används av Redirect::to

        public function get($url, $closure, $class = '', $params = [])
        { 
            // routern är en mästerklass på regex och här används preg_match för att extrahera namnet på klassen, parameterar, optionella eller obligatoriska
            preg_match('/(?<=\@)(.*?)(?=\~\{)/', $url, $method_name);
            $url = preg_replace('/^\@.*?(?=\~\{)/', '', $url);
            preg_match_all('/(?<=\~\{)([^\}\{\s]*[a-zA-Z-]+)(?=(?:\:))/', $url, $route_sig_param);
            preg_match_all('/(?<=\~\{)((?!\:).)*(?=\})/', $url, $route_sig);
            preg_match_all('/(?<=\~\{)([^\}\{\s]*[a-zA-Z-]+)(?=(?:\:.*\}\d))/', $url, $non_required);
            $route = implode('/', array_merge($route_sig[0], $route_sig_param[0]));
            $url = preg_replace('/\~(?=\{)/', '', $url);
            $url = preg_replace('/(?<=\})\d/', '', $url);
            $regex = $this->convertUrlToPreg($url);
            preg_match_all('/(?<=\(\/\{)([^\}\s]*)(?=\:.*\})/', $url, $params_optional); 
            preg_match_all('/(?<=[^(]\/\{)([^\}\s]*)(?=\:.*\})/', $url . '/', $params_required);
            if (!$route){
                preg_match_all('/(?<=^\{)([^\}\s]*[a-zA-Z-]+)(?=\})/', $url . '/', $route);
                $route = $route[0][0];
            }
            if (!empty($non_required[0])){
                $params_required = array_diff($params_required[0], $non_required[0]);
                if (!in_array($method_name[0], $non_required[0])){
                    $route .=  '/' . $method_name[0];
                }
            } else{
                $params_required = $params_required[0];
            }
            $params_optional = array_fill_keys($params_optional[0], '');
            $params_required = array_fill_keys($params_required, '');
            $class_map = $this->getClassMap($class);
            if (!$route){
                for ($i = 0; $i < 1000; $i++){
                    if (!array_key_exists($i, $this->routes)){
                        $route = $i;
                        break;
                    }
                    if ($i == 999){
                        return false;
                    }
                }
            }
            if (strpos($route, '/') !== false){
                $this->domains[$route] = $route;
            } elseif (!$class){
                $this->addCallable($closure, $route, $params);
                $this->domains[$route] = $route;
            }
            $this->domain_tree = $this->makeTree($this->domains, '/', true);
            if (!array_key_exists($route, $this->routes)){
                $this->routes[$route] = [
                    'regex' => $regex,
                    'params' => [
                        'required' => $params_required,
                        'optional' => $params_optional
                    ],
                    'method' => 'GET',
                    'callable' => $closure,
                    'class' => (!empty($class)) ? $class_map['class'] : '',
                    'namespace' => (!empty($class)) ? $class_map['namespace'] : '',
                    'namespaced' => (!empty($class)) ? $class : ''
                ];
            }
            return $this;
        } // tillägg en ny get route antigen genom att ange klass, eller genom att ange en callable

        public function post($url, $closure, $class = '', $params = [])
        {
            // här repeteras mycket av vad som finns i get, borde ha gjort en refaktor till gemensam funktion
            preg_match('/(?<=\@)(.*?)(?=\~\{)/', $url, $method_name);
            $url = preg_replace('/^\@.*?(?=\~\{)/', '', $url);
            preg_match_all('/(?<=\~\{)([^\}\{\s]*[a-zA-Z-]+)(?=(?:\:))/', $url, $route_sig_param);
            preg_match_all('/(?<=\~\{)((?!\:).)*(?=\})/', $url, $route_sig);
            preg_match_all('/(?<=\~\{)([^\}\{\s]*[a-zA-Z-]+)(?=(?:\:.*\}\d))/', $url, $non_required);
            $route = implode('/', array_merge($route_sig[0], $route_sig_param[0]));
            $url = preg_replace('/\~(?=\{)/', '', $url);
            $url = preg_replace('/(?<=\})\d/', '', $url);
            $regex = $this->convertUrlToPreg($url);
            preg_match_all('/(?<=\(\/\{)([^\}\s]*)(?=\:.*\})/', $url, $params_optional); 
            preg_match_all('/(?<=[^(]\/\{)([^\}\s]*)(?=\:.*\})/', $url . '/', $params_required);
            if (!$route){
                preg_match_all('/(?<=^\{)([^\}\s]*[a-zA-Z-]+)(?=\})/', $url . '/', $route);
                $route = $route[0][0];
            }
            if (!empty($non_required[0])){
                $params_required = array_diff($params_required[0], $non_required[0]);
                if (!in_array($method_name[0], $non_required[0])){
                    $route .=  '/' . $method_name[0];
                }
            } else{
                $params_required = $params_required[0];
            }
            $params_optional = array_fill_keys($params_optional[0], '');
            $params_required = array_fill_keys($params_required, '');
            $class_map = $this->getClassMap($class);
            if (!$route){
                for ($i = 0; $i < 1000; $i++){
                    if (!array_key_exists($i, $this->routes)){
                        $route = $i;
                        break;
                    }
                    if ($i == 999){
                        return false;
                    }
                }
            }
            if (strpos($route, '/') !== false){
                $this->domains[$route] = $route;
            } elseif (!$class){
                $this->addCallable($closure, $route, $params);
                $this->domains[$route] = $route;
            }
            $this->domain_tree = $this->makeTree($this->domains, '/', true);
            if (!array_key_exists($route, $this->routes)){
                $this->routes[$route] = [
                    'regex' => $regex,
                    'params' => [
                        'required' => $params_required,
                        'optional' => $params_optional
                    ],
                    'method' => 'POST',
                    'callable' => $closure,
                    'class' => (!empty($class)) ? $class_map['class'] : '',
                    'namespace' => (!empty($class)) ? $class_map['namespace'] : '',
                    'namespaced' => (!empty($class)) ? $class : ''
                ];
            }
            return $this;
        } // tillägg en ny post route antigen genom att ange klass, eller genom att ange en callable
    
        public function addRoute($class, $callable = 'index', $method = 'GET') 
        {
            try{
                $reflection = new \ReflectionMethod($class, $callable);
                $method_params = $reflection->getParameters();
            } catch (\Exception $e){
                return false;
            }
            $class_map = $this->getClassMap($class);
            $namespace = array_filter(explode('\\', $class_map['namespace']));
            $class_name = $class_map['class'];
            $url = "@{$reflection->name}~{{$namespace[0]}}";
            array_shift($namespace);
            foreach ($namespace as $entry){
                $url .= "/~{{$entry}:" . self::$regex_patterns['mixed'] . "}1";
            }
            $url .= "/~{{$class_name}:" . self::$regex_patterns['mixed'] . "}1";
            $url .= "/~{{$reflection->name}:" . self::$regex_patterns['mixed'] . "}1";
            foreach ($method_params as $param){
                $type = $param->getType();
                $name = $param->getName();
                foreach (self::$regex_patterns as $key => $pattern){
                    if ($key == $type){
                        $type = $key;
                        break;  
                    }
                }
                if ($param->isOptional()){
                    $url .= "(/{{$name}:" . self::$regex_patterns[$type] . "})?";
                } else{
                    $url .= "/{{$name}:" . self::$regex_patterns[$type] . "}";
                }
            }
            global $container;
            $obj = $container->get($class);
            $obj->calling_method = $callable;
            if ($method == 'POST'){
                $this->post($url, [$obj, $callable], $class);
            } else{
                $this->get($url, [$obj, $callable], $class);
            }
            
        } // automiserar processen av att addera en klass metod, så att man behöver inte komplex, krånglade url patterns

        public function dispatch($url) 
        {
            // här adderas alla routes som kommer att användas inom programmet
            $this->addRoute(\App\Controllers\HomeController::class, 'index');
            $this->addRoute(\App\Controllers\HomeController::class, 'home');
            $this->addRoute(\App\Controllers\MovieController::class, 'index');
            $this->addRoute(\App\Controllers\MovieController::class, 'edit');
            $this->addRoute(\App\Controllers\MovieController::class, 'registerEdit', 'POST');
            $this->addRoute(\App\Controllers\MovieController::class, 'registerDelete', 'POST');
            $this->addRoute(\App\Controllers\MovieController::class, 'add');
            $this->addRoute(\App\Controllers\MovieController::class, 'registerAdd', 'POST');
            $this->addRoute(\App\Controllers\MovieController::class, 'registerAddDirector', 'POST');
            if (!$url){
                $url = [min(array_keys($this->routes))]; // om det finns inga element i url:en tilldelas den route 0, som borde referea en callable som gör en Redirect till HomeController/index
            }
            $this->success = true;
            $found = false;
            $route = '';
            // kollar om filet existerar för då behövs det inga nya sökningar, detta är en relik från routerns byggenlse, och då hade jag helt andra system för routing
            if(array_key_exists($url[0], $this->routes) && (file_exists('../app/controllers/' . $url[0] . 'Controller.php') || file_exists(ROOT . $this->routes[$this->selected_route]['namespace'] . $this->routes[$this->selected_route]['class'] . '.php'))){
                $found = true;
                $route = $url[0];
            } else{
                // här inleds de komplexa processer vari en route förhoppningsvis kan matchas, det är oeffektivt och det implementeras många lösningar som man skulle kunna bedömna vara onödiga
                foreach ((array)$url as $entry){
                    $results = $this->iterate($entry, $this->domain_tree);
                    if ($results){
                        foreach ($results as $result){
                            if (is_string($result)){
                                if (array_key_exists($result, $this->routes)){
                                    $found = true;
                                    $route = $result;
                                }
                            }
                        }
                        if (!$found && !is_array($results[array_keys($results)[0]])){
                            if (array_key_exists($results[array_keys($results)[0]], $this->callables)){
                                return $this->callables[$results[array_keys($results)[0]]]['callable']();
                            }
                        } else {
                            $iterator = new \RecursiveIteratorIterator(
                                new \RecursiveArrayIterator($this->domain_tree), 
                                \RecursiveIteratorIterator::CHILD_FIRST
                            );
                            $items = [];
                            foreach ($iterator as $item){
                                $items[] = $iterator->key();
                            }
                            $formed = implode('/', array_intersect(array_map('strtolower', $url), array_map('strtolower', $items)));
                            if ($search = array_search($formed, array_map('strtolower', array_keys($this->routes)))){
                                $found = true;
                                $route = array_keys($this->routes)[$search];
                            }
                        }
                    }
                }
                if (!$found){
                    for ($i = count($url) - 1; $i >= 0; $i--){
                        $results = $this->iterate($url[$i], $this->domains);
                        foreach ($results as $res){
                            if (is_array($res) && !$this->isNestedArray($res)){
                                foreach ($res as $result){
                                    if (is_string($result)){
                                        if (array_search($result, $res) == 'index'){
                                            $found = true;
                                            $route = $result;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }      
                }
            }
            if($found){
                $this->selected_route = $route;
                $this->selected_params = $this->routes[$this->selected_route]['params'];
                if ($this->routes[$this->selected_route]['method'] == $_SERVER['REQUEST_METHOD']){ // tittar om request method - get eller post - matchar med det angivna sättet
                    preg_match($this->routes[$this->selected_route]['regex'], implode('/', $url), $matches); // en sista matchning med regex pattern
                    foreach ($matches as $key => $value){
                        if (is_string($key)){
                            if (array_key_exists($key, $this->selected_params['optional'])){
                                $this->selected_params['optional'][$key] = $value;
                            } elseif (array_key_exists($key, $this->selected_params['required'])){
                                $this->selected_params['required'][$key] = $value;
                            }
                        }
                    }
                    foreach ($this->selected_params['required'] as $key => $value){
                        if (empty($this->selected_params['required'][$key])){
                            $this->success = false;
                        }
                    }
                    $reflection = '';
                    if (is_array($this->routes[$this->selected_route]['callable'])){
                        $reflection = new \ReflectionMethod(...$this->routes[$this->selected_route]['callable']);
                    } else{
                        $reflection = new \ReflectionFunction($this->routes[$this->selected_route]['callable']);
                    }
                    if ($this->success && $reflection->getNumberOfRequiredParameters() == count($this->selected_params['required'])){ // post kommer aldrig att gå igenom här för att parametrar skickas inte via url:en
                        $callable_parameters = array_filter(array_merge(array_values($this->selected_params['required']), array_values($this->selected_params['optional'])));
                        if ($this->routes[$this->selected_route]['namespaced']){
                            $url = implode('/', $url);
                            $this->selected_params = array_map('end', array_filter(array_values($this->selected_params)));
                            $validation = '';
                            if ($this->object[$this->selected_route]['validate']){
                                $validation = (new Validator())->validate($this->selected_params, $this->object[$this->selected_route]['rules'])->passed();
                            }
                            return $this->object[$this->selected_route] = [
                                'callable' => $this->routes[$this->selected_route]['callable'],
                                'params' => $callable_parameters,
                                'validation' => $validation
                            ]; // ett objekt med callable som är funktionen inom klassen skickas till App för vidare hantering
                        }
                        return $this->routes[$this->selected_route]['callable'](...$callable_parameters);
                    } elseif ($this->routes[$this->selected_route]['method'] == 'POST' && Input::request_exists()){ // här behövs Input klassen att användas för att kontrollera om alla parametrar är med
                        $intersection_optional = array_intersect_key($_POST, $this->selected_params['optional']);
                        $intersection_required = array_intersect_key($_POST, $this->selected_params['required']);
                        if (count($intersection_required) == count($this->selected_params['required'])){
                            if ($this->object[$this->selected_route]['validate']){
                                $validation = (new Validator())->validate(array_merge($intersection_required, $intersection_optional), $this->object[$this->selected_route]['rules'])->passed();
                            }
                            return $this->object[$this->selected_route] = [
                                'callable' => $this->routes[$this->selected_route]['callable'],
                                'params' => array_merge(array_values($intersection_required), array_values($intersection_optional)),
                                'validation' => $validation
                            ];
                        }
                    } else{
                        dd('cannot determine route');
                    }
                } 
            } else{
                Redirect::to('index');
            }
            return false;
        } // matchar inkommande url:en med en route, testar gilitghet och överlämnar till appen och någon controller, vid framgång eller gör en redirecting vid misslyckande

        public function where($rules = [])
        {
            $this->object[$this->selected_route]['validate'] = true;
            $this->object[$this->selected_route]['rules'] = $rules;
        } // en möjlighet till validering

        public function convertUrlToPreg($url)
        {
            //$url = '{controller}/{obligatorisk parameter:type}/?({inte obligatorisk:type})?';
            $url = preg_replace('/\//', '\\/', $url); // göra escaping för alla /
            $url = preg_replace('/\{([a-zA-Z-]+)\}/', '(?P<\1>[a-z-]+)', $url); // controller fångas upp och görs till en egen grupp
            $url = preg_replace('/\{([a-zA-Z-]+):(([^\}]\+?)+)\}/', '(?P<\1>\2)', $url); // parametrar och typer fångs upp till egna grupper
            return '/' . $url . '/i'; // bortse från versilering
            //$url = '/(?P<controller>type)/(?P<obligatorisk parameter>type)/i'
        }

        public function getClassMap($class_name)
        {
            if (!empty($class_name)){
                $class = new \ReflectionClass($class_name);
                if ($class->inNamespace()){
                    return [
                        'namespace' => $class->getNamespaceName() . '\\',
                        'class' => preg_replace('/[\w\\\]+\\\(?=\w+$)/', '', $class->getName())
                    ];
                }
                return ['class' => $class->getName()];
            }
            return '';
        } // hämtar fram klassens namespace genom reflection

        public function iterate($needle, $array, $results = []) 
        {
            $results = [];
            foreach($array as $key => $value){
                if(strtolower($key) == strtolower($needle) && $value !== ''){
                    $results = array_merge($results, [$value]);
                }
                if(is_array($value)){
                    $results = array_merge($results, $this->iterate($needle, $value, $results));
                }
            }
            return $results;
        } // recurisve sökning för trästrukturen

        private function isNestedArray($array)
        {
            foreach ($array as $entry){
                if (is_array($entry)) return true;
            }
            return false;
        } // om array innehåller andra arrays eller inte

        private function makeTree($array, $delimiter = '/', $baseval = false)
        {   
            if(!is_array($array)) return false;
            $splitRE   = '/' . preg_quote($delimiter, '/') . '/'; // gör escaping för seperatorn
            $returnArr = [];
            foreach ($array as $key => $val){
                $parts	= preg_split($splitRE, $key, -1, PREG_SPLIT_NO_EMPTY); // gör skärningen för varje key vid seperatorn
                $leafPart = array_pop($parts); // sista element blir grenens löv
                $parentArr = &$returnArr;
                foreach ($parts as $part){
                    if (!isset($parentArr[$part])){
                        $parentArr[$part] = [];
                    } elseif (!is_array($parentArr[$part])){
                        if ($baseval) {
                            $parentArr[$part] = ['branch' => $parentArr[$part]];
                        } else {
                            $parentArr[$part] = []; // för varje kvarlämnad part av keys görs en nested array som sedan blir nested och så vidare
                        }
                    }
                    $parentArr = &$parentArr[$part];
                }
                if (empty($parentArr[$leafPart])){
                    $parentArr[$leafPart] = $val; // värdet tilläggs
                } elseif ($baseval && is_array($parentArr[$leafPart])){
                    $parentArr[$leafPart]['branch'] = $val;
                }
            }
            return $returnArr;
        } // skapar trästrukturen

    }
}