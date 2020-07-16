<?php 

namespace App\Core\Classes
{
    abstract class BasicEnum 
    {
        private static $constCacheArray = NULL;
    
        public static function getConstants() 
        {
            if (self::$constCacheArray == NULL){
                self::$constCacheArray = [];
            }
            $calledClass = get_called_class();
            if (!array_key_exists($calledClass, self::$constCacheArray)){
                $reflect = new \ReflectionClass($calledClass);
                self::$constCacheArray[$calledClass] = $reflect->getConstants();
            }
            return self::$constCacheArray[$calledClass];
        }
    
        public static function isValidName($name, $strict = false) 
        {
            $constants = self::getConstants();
            if ($strict){
                return array_key_exists($name, $constants);
            }
            $keys = array_map('strtolower', array_keys($constants));
            return in_array(strtolower($name), $keys);
        }
    
        public static function isValidValue($value, $strict = true) 
        {
            $values = array_values(self::getConstants());
            return in_array($value, $values, $strict);
        }
    }

    class GenreEnums extends BasicEnum 
    {
        const NoGenre = 0;
        const Action = 1;
        const Adventure = 2;
        const Comedy = 3;
        const Documentary = 4;
        const Drama = 5;
        const Family = 6;
        const Horror = 7;
        const Romance = 8;
        const Thriller = 9;
    }
}