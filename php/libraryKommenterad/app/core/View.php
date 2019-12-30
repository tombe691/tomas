<?php

namespace App\Core
{

    use App\Core\Classes\HTMLGenerator;
    use App\Core\Classes\Paginator;

    class View 
    {
        protected $paginator,
                $html,
                $head, 
                $body,
                $footer, 
                $title, 
                $buffer, 
                $layout,
                $viewData,
                $mode;
        
        public function __construct(Paginator $paginator, HTMLGenerator $html, $title = SITE_TITLE, $layout = DEFAULT_LAYOUT)
        {
            $this->paginator = $paginator;
            $this->html = $html;
            $this->title = $title;
            $this->layout = $layout;
        } // har ett paginator objekt, htmlgenerator objekt, titel och även en layout

        public function render($view_name)
        {
            if(file_exists(VIEWS . $view_name . '.php')){
                include_once VIEWS . $view_name . '.php';
                include_once LAYOUTS . $this->layout . '.php';
            } else{
                throw new \Exception('The view \"' . $view_name . '\" does not exist.');
            }
        } // render är den funktion som sammanför det valda filet med resten av dokumentet

        public function content($type) 
        {
            if ($type == 'head'){
                return $this->head;
            } elseif ($type == 'body'){
                return $this->body;
            } elseif ($type == 'footer'){
                return $this->footer;
            }
            return false;
        } // här sätts in de avdelningar av html sidan
      
        public function start($type) 
        {
            $this->buffer = $type;
            ob_start();
        } // output buffer startas så att den kan tömmas på de tre avdelningar av html - head, body och footer
      
        public function end()
        {
            if ($this->buffer == 'head'){
                $this->head = ob_get_clean();
            } elseif ($this->buffer == 'body'){
                $this->body = ob_get_clean();
            } elseif ($this->buffer == 'footer'){
                $this->footer = ob_get_clean();
            } else{
                die('You must first run the start method.');
            }
        } // här befrias värden från buffret och överlämnas till de olika avdelningarna efter att buffret har fått htmlelement genererade av htmlgeneratorn

        public function setLayout($path) 
        {
            $this->layout = $path;
        }
    
        public function setTitle($title) 
        {
            $this->title = $title;
        }

        public function getTitle()
        {
            return $this->title;
        }
    
        public function setModel($model)
        {
            $this->model = $model;
        }
    
        public function setDataPair($key, $value) 
        {
            $this->viewData[$key] = $value;
        }

        public function setData($data)
        {
            $this->viewData = $data;
        }  

        public function insert($path)
        {
            include_once VIEWS . $path . '.php';
        } // helt andra element kan också fås med i html sidan
      
        public function partial($group, $partial)
        {
            include_once VIEWS. $group . DS . 'partials' . DS . $partial . '.php';
        } // ger möjlighet för att injecera andra gemensamma delar för programmet
      
    }
}