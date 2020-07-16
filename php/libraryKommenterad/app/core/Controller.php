<?php

namespace App\Core
{
    use App\Core\Classes\Session;
    use App\Core\Classes\Input;

    class Controller
    {
        public $view, $model, $calling_method;

        public function __construct(View $view, DBController $model)
        {
            Session::init();
            $this->view = $view;
            $this->model = $model;
        } // intitialiserar modellen till en instans av DBController (har inte implementerat något system som injicerar ärvda klasser), och view till ett View objekt

    }
}