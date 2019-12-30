<?php

namespace App\Models
{
    use App\Core\ManyToManyController;

    class GenresMoviesMany extends ManyToManyController
    {
        public function __construct()
        {
            $this->table_name = 'genres_movies';
            $this->class = __CLASS__;
            parent::__construct();
        }

        public static function __callStatic($name, $arguments)
        {
            $requested_method = '';
            switch ($name){
                case 'findUser':
                    $requested_method = 'find';
                    break;
                case 'findByUser':
                    $requested_method = 'findByMany';
                    break;
            }
            global $container;
            return ($container->get(__CLASS__))->$requested_method(...$arguments);
        }
        
    }
}