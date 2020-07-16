<?php
// Denna kallas behandlar hämtning, sanering och validering av inputs
namespace App\Core\Classes
{
    use App\Core\Validator;

    class Input
    {
        public static function request_exists($type = 'post')
        {
            switch ($type){
                case 'post':
                    return (empty($_POST)) ? false : true;
                break;
                case 'get':
                    return (empty($_GET)) ? false : true;
                break;
                default:
                    return false;
                break;
            }
        }

        public static function exists($method = '')
        {
            if (!$method){
                if ($_POST){
                    return true;
                } elseif ($_GET){
                    return true;
                }
                return false;
            } elseif ($method == 'GET'){
                return isset($_GET);
            }
            return isset($_POST);
        }

        public static function get($item = false)
        {
            if (!$item){
                $data = [];
                foreach($_REQUEST as $field => $value){
                    $data[$field] = self::sanitize($value);
                }
                return $data;
            }
            if (isset($_POST[$item])){
                return $_POST[$item];
            } elseif (isset($_GET[$item])){
                return $_GET[$item];
            }
            return false;
        } // hämtar antingen ett värde eller allt som har kommit in via _Request

        public static function sanitize($text) 
        {
            if (!is_array($text)){
                $text = trim(strip_tags($text));
                if (get_magic_quotes_gpc()) {
                    $text = stripslashes($text);
                }
                return $text;
            } else{
                $new_array = [];
                foreach ($text as $key => $value){
                    $new_array[self::sanitize($key)] = self::sanitize($value);
                }
                return $new_array;
            }
        } // kan sanera både enstaka värden eller arrays, vilket behövs för directorer är en array från en select option html element

        public static function check($source, $inputs) 
        {
            if (!self::exists()){
                return false;
            }
            if (!isset($source["token"]) || !Session::checkToken($source["token"])){
                Session::addMsg('danger', 'error token validation.');
                return false;
            }
            global $container;
            if (!($container->get(Validator::class))->validate($source, $inputs)->passed()){
                Session::set('inputValidation', ($container->get(Validator::class))->errors);
                return false;
            }
            return true;
        } // en one for all lösning för att både kontrollera token, och validera inputs
    }
}