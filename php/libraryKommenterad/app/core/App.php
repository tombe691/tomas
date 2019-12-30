<?php

namespace App\Core
{
    use App\Core\Classes\Redirect;
    use App\Core\Classes\Session;

class App
    {
        public $app_context;

        public function __construct()
        {
            global $container;
            $container->get(Router::class)->get('', function() use ($container){
                $container->get(Router::class)->dispatch('App/Controllers/HomeController/index');
            });
            $container->get(Router::class)->get('{home}/', function() use ($container){
                $container->get(Router::class)->dispatch('App/Controllers/HomeController/index');
            });
            // så här skulle en url se ut, om det inte vore för Router::addRoute
            /* $container->get(Router::class)->get('{user}/{id:\d+}(/{password:[a-z-]+})?/{username:[a-z-]+}', function ($id, $username, $password = '') {
                
            }); */
            $url = $this->urlParser();
            $dispatcher = $container->get(Router::class)->dispatch($url);
            if ($dispatcher){
                if ($dispatcher['validation'] !== false){
                    $this->app_context['route'] = [
                        $dispatcher,
                        Session::get('errors')
                    ];
                    $dispatcher['callable'][0]->errors = Session::get('errors');
                    $dispatcher['callable'](...$dispatcher['params']);
                } else{
                    Redirect::to('index');
                }
            } else{
                Redirect::to('index');
            }
        }

        public function __get($name)
        {
            if (array_key_exists($name, $this->app_context)){
                return $this->app_context[$name];
            } 
            return '';
        }

        public function __set($name, $value)
        {
            if (array_key_exists($name, $this->app_context)){
                $old_value = $this->app_context[$name];
                $this->app_context[$name] = $value;
                return $old_value;
            }
            return $this->app_context[$name] = $value;
        }

        protected function urlParser($url = '')
        {
            if (isset($_GET['url'])){
                return explode('/', filter_var(rtrim($_GET['url'], '/'), FILTER_SANITIZE_URL));
            }
        } // urlen filtreras och delas till en array

        protected function addDestination($callable, $url = '', $class = '', $method = 'GET')
        {
            global $container;
            if (!$class){
                if ($method == 'GET'){
                    $container->get(Router::class)->get($url, $callable);
                } else{
                    $container->get(Router::class)->post($url, $callable);
                }
            } elseif (!$url){
                $container->get(Router::class)->addRoute($class, $callable, $method);
            }
        } // här kan man addera en destination geom app_contexten men det blev inte så mycket av det

    }
}