<?php

namespace App\Models
{
    use App\Core\DBController;

    class Book extends DBController
    {
        private $table_name = 'books';

        public function __construct()
        {
            parent::__construct($this->table_name, __CLASS__);
        }

        public static function __callStatic($name, $arguments)
        {
            $requested_method = '';
            switch ($name){
                case 'findUser':
                    $requested_method = 'find';
                    break;
                case 'findByUser':
                    $requested_method = 'findBy';
                    break;
            }
            global $container;
            return ($container->get(__CLASS__))->$requested_method(...$arguments);
        }

        public function users()
        {
            global $container;
            return $this->belongsToMany($container->get(\App\Models\User::class), 'users_books');
        }

        public function authors()
        {
            global $container;
            return $this->belongsToMany($container->get(\App\Models\Author::class), 'authors_books');
        }

    }
}