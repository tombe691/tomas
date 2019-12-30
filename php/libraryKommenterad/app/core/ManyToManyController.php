<?php
// denna klass definerar vad en many-to-many relationship är genom att företräda en relationstabell som innehåller foregin key constraints
namespace App\Core
{
    class ManyToManyController extends DBController
    {
        protected $table_name,
                $first_model,
                $second_model,
                $first_key,
                $second_key,
                $class;
        public static $relations;

        public function __construct()
        {
            parent::__construct($this->table_name, $this->class);
        }

        public static function instantiateStatic($first_key, $second_key, $first_model, $second_model, $class)
        {
            if (!isset(ManyToManyController::$relations[$first_model]) || !isset(ManyToManyController::$relations[$second_model])){
                self::$relations[$first_model] = [
                    'model' => $class,
                    $first_model => $first_key,
                    $second_model => $second_key
                ];
                self::$relations[$second_model] = [
                    'model' => $class,
                    $first_model => $first_key,
                    $second_model => $second_key
                ];
            }
        } // man kan instantiera även om inga object/rader i relationstabellen finns
          
        public function instantiate($s = '')
        {
            if (!isset(ManyToManyController::$relations[$this->first_model->model]) || !isset(ManyToManyController::$relations[$this->second_model->model])){
                self::$relations[$this->first_model->model] = [
                    'model' => $this->class,
                    $this->first_model->model => $this->first_key,
                    $this->second_model->model => $this->second_key
                ];
                self::$relations[$this->second_model->model] = [
                    'model' => $this->class,
                    $this->first_model->model => $this->first_key,
                    $this->second_model->model => $this->second_key
                ];
            }
            $this->object[$this->first_key] = $this->first_model->id;
            $this->object[$this->second_key] = $this->second_model->id;
        } // allt görs för både ingående modeller, för att relationen är many-to-many, ömsesidig

        public function setFirstModel($value)
        {
            $this->first_model = $value;
        }

        public function getFirstModel()
        {
            return $this->first_model;
        }

        public function setSecondModel($value)
        {
            $this->second_model = $value;
        }

        public function getSecondModel()
        {
            return $this->second_model;
        }

        public function setFirstKey($value)
        {
            $this->first_key = $value;
        }

        public function getFirstKey()
        {
            return $this->first_key;
        }

        public function setSecondKey($value)
        {
            $this->second_key = $value;
        }

        public function getSecondKey()
        {
            return $this->second_key;
        }

    }
}