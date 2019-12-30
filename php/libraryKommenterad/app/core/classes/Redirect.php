<?php 
// denna klass får ses som en utökning på router.php
namespace App\Core\Classes
{
    use App\Core\Router;
    use App\Core\View;

    class Redirect
    {
        public $errors = [],
                $route, 
                $params;

        public static function to($page, $params = [])
        {
            global $container;
            if (is_numeric($page)){
                switch ($page) {
                    case 404:
                        header('HTTP/1.0 404 Not Found');
                        ($container->get(View::class))->render('errors/404');
                        exit();
                        break;
                }
            }
            if (array_key_exists($page, $container->get(Router::class)->domains)){
                self::redirect($page, $params);
            } elseif (strpos($page, '/') !== false){
                $url = explode('/', $page);
                $items = [];
                $x = 0;
                foreach ($url as $url_bit){
                    $items[$x] = $container->get(Router::class)->traverseDomainTree($url_bit); // algoritmen borde ta de element som finns i närliggande djupet av strängen i frågan, page, i trästruktren och sedan välja index
                    $x++;
                }
                $path = self::takeMin($items); // min borde välja det element som ligger minsta avstånd från page
                if ($path){
                    self::redirect($path);
                }
            }
        } // ger möjlighet för att göra en redirection

        public static function redirect($location, $params = [])
        {
            foreach ($params as $param){
                $location .= '/' . $param;
            }
            header('Location: ' . PUBLICPRO . preg_replace('/\\\/', '/', ltrim($location, '/')));
            exit();
        } // gör header och skickar även med andra parametrar

        public static function takeMin($array)
        {
            if (is_array($array)){
                return self::takeMin(min($array));
            }
            return $array;
        } // recursivt tar min av arrays

        public static function objTo($page, $params = [])
        {
            global $container;
            $container->get(Redirect::class)->route = $page;
            $container->get(Redirect::class)->params = $params;
            return $container->get(Redirect::class);
        }

        public function withErrors($errors)
        {
            Session::set('errors', $errors);
            return self::to($this->route, $this->params);
        }

    }
}