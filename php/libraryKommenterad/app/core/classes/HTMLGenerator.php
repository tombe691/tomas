<?php

namespace App\Core\Classes
{
    class HTMLGenerator
    {
        
        public function inputBlock($type, $label, $name, $value='', $inputAttrs=[], $divAttrs=[])
        {
            $divString = $this->stringifyAttrs($divAttrs);
            $inputString = $this->stringifyAttrs($inputAttrs);
            $html = '<div' . $divString . '>';
            $html .= '<label for="'.$name.'">'.$label.'</label>';
            $html .= '<input type="'.$type.'" id="'.$name.'" name="'.$name.'" value="'.$value.'"'.$inputString.' />';
            $html .= '</div>';
            return $html;
        }

        public function textArea($label, $name, $value='', $rows = 5, $colums = 3, $inputAttrs=[], $divAttrs=[])
        {
            $divString = $this->stringifyAttrs($divAttrs);
            $inputString = $this->stringifyAttrs($inputAttrs);
            $html = '<div' . $divString . '>';
            $html .= '<label for="'.$name.'">'.$label.'</label>';
            $html .= '<textarea id="'.$name.'" name="'.$name.'" value="'.$value.'"'. $inputString . '>';
            $html .= Input::sanitize($value);
            $html .= '</textarea>';
            $html .= '</div>';
            return $html;
        }

        public function inputHidden($name, $value='')
        {
            return '<input type="hidden" name="' . $name . '" id="' . $name . '" value="' . $value . '" />';
        }
        
        public function submitTag($buttonText, $inputAttrs=[])
        {
            $inputString = $this->stringifyAttrs($inputAttrs);
            $html = '<input type="submit" value="'.$buttonText.'"'.$inputString.' />';
            return $html;
        }
        
        public function submitBlock($buttonText, $inputAttrs=[], $divAttrs=[])
        {
            $divString = $this->stringifyAttrs($divAttrs);
            $inputString = $this->stringifyAttrs($inputAttrs);
            $html = '<div'.$divString.'>';
            $html .= '<input type="submit" value="'.$buttonText.'"'.$inputString.' />';
            $html .= '</div>';
            return $html;
        }
        
        public function checkboxBlock($label,$name,$checked=false,$inputAttrs=[],$divAttrs=[])
        {
            $divString = $this->stringifyAttrs($divAttrs);
            $inputString = $this->stringifyAttrs($inputAttrs);
            $checkString = ($checked)? ' checked="checked"' : '';
            $html = '<div'.$divString.'>';
            $html .= '<label for="'.$name.'">'.$label.' <input type="checkbox" id="'.$name.'" name="'.$name.'" value="on"'.$checkString.$inputString.'></label>';
            $html .= '</div>';
            return $html;
        }

        public function select($label, $name, $options=[], $selected = [], $size = 3, $inputAttrs=[], $divAttrs=[])
        {
            $divString = $this->stringifyAttrs($divAttrs);
            $inputString = $this->stringifyAttrs($inputAttrs);
            $html = '<div' . $divString . '>';
            $html .= '<label for="'.$name.'">'.$label.'</label>';
            $html .= '<select multiple name="'.$name . '[]" size="' . $size . '" id="' . $label . '"'. $inputString . '>';
            foreach ($options as $key => $option){
                $html .= '<option value="'. $key .'"' . $selected[$key] . '>' . $option . '</option>';
            }
            $html .= '</select>';
            $html .= '</div>';
            return $html;
        }

        public function table($name, $columns=[], $values=[], $inputAttrs=[], $divAttrs=[])
        {
            $divString = $this->stringifyAttrs($divAttrs);
            $inputString = $this->stringifyAttrs($inputAttrs);
            $html = '<div' . $divString . '>';
            $html .= '<table id="'.$name.'"'. $inputString . '>';
            $html .= '<tr>';
            foreach ($columns as $column){
                $html .= '<th>' . $column . '</th>';
            }
            $html .= '</tr>';
            foreach ($values as $value){
                $html .= '<tr>';
                foreach ($value as $subValue){
                    $html .= '<td>' . $subValue . '</td>';
                }
                $html .= '</tr>';
            }
            $html .= '</table>';
            $html .= '</div>';
            return $html;
        }

        public function stringifyAttrs($attrs)
        {
            $string = '';
            foreach($attrs as $key => $val){
                $string .= ' ' . $key . '="' . $val . '"';
            }
            return $string;
        }
        
        public function csrfInput()
        {
            return '<input type="hidden" name="token" id="token" value="' . Session::generateToken() . '" />';
        }
        
        public function sanitize($dirty)
        {
            return htmlentities($dirty, ENT_QUOTES, 'UTF-8');
        }
        
        public function posted_values($post)
        {
            $clean_ary = [];
            foreach($post as $key => $value) {
                $clean_ary[$key] = Input::sanitize($value);
            }
            return $clean_ary;
        }
        
        public function displayErrors($errors)
        {
            $errors = is_array($errors) ? $errors : [];
            $hasErrors = (!empty($errors))? ' has-errors' : '';
            $html = '<div class="form-errors"><ul class="bg-danger'.$hasErrors.'">';
            foreach($errors as $field => $errorArr) {
                $errorArr = is_array($errorArr) ? $errorArr : [];
                $html .= '<li class="text-danger">'.$field.':'.'</li>';
                foreach ($errorArr as $key => $value) {
                    $html .= '<li class="text-danger">'.$key . ':' . $value . '</li>';
                }
            }
            $html .= '</ul></div>';
            return $html;
        }

        private function pages($paginator)
        {
            $pages = [];
            if ($this->numPages <= 1){
                return [];
            }
            if ($paginator->numPages <= $paginator->maxPagesToShow){
                for ($i = 1; $i <= $paginator->numPages; $i++){
                    $pages[] = $this->createPage($paginator, $i, $i == $paginator->currentPage);
                }
            } else{
                $numAdjacents = (int) floor(($paginator->maxPagesToShow - 3) / 2);
                if ($paginator->currentPage + $numAdjacents > $paginator->numPages){
                    $slidingStart = $paginator->numPages - $paginator->maxPagesToShow + 2;
                } else{
                    $slidingStart = $paginator->currentPage - $numAdjacents;
                }
                if ($slidingStart < 2) $slidingStart = 2;
                $slidingEnd = $slidingStart + $paginator->maxPagesToShow - 3;
                if ($slidingEnd >= $paginator->numPages) $slidingEnd = $paginator->numPages - 1;
                $pages[] = $this->createPage($paginator, 1, $paginator->currentPage == 1);
                if ($slidingStart > 2){
                    $pages[] = $this->createPageEllipsis();
                }
                for ($i = $slidingStart; $i <= $slidingEnd; $i++) {
                    $pages[] = $this->createPage($paginator, $i, $i == $paginator->currentPage);
                }
                if ($slidingEnd < $paginator->numPages - 1) {
                    $pages[] = $this->createPageEllipsis();
                }
                $pages[] = $this->createPage($paginator, $paginator->numPages, $paginator->currentPage == $paginator->numPages);
            }
            return $pages;
        }

        protected function createPage($paginator, $pageNum, $isCurrent = false)
        {
            return array(
                'num' => $pageNum,
                'url' => $paginator->getPageUrl($pageNum),
                'isCurrent' => $isCurrent,
            );
        }

        protected function createPageEllipsis()
        {
            return array(
                'num' => '...',
                'url' => null,
                'isCurrent' => false,
            );
        }

        public function paginator($paginator)
        {
            if ($paginator->numPages <= 1) {
                return '';
            }
            $html = '<ul class="pagination">';
            if ($paginator->getPrevUrl()) {
                $html .= '<li><a href="' . htmlspecialchars($paginator->getPrevUrl()) . '">&laquo; '. $paginator->previousText .'</a></li>';
            }
            foreach ($this->pages($paginator) as $page) {
                if ($page['url']) {
                    $html .= '<li' . ($page['isCurrent'] ? ' class="active"' : '') . '><a href="' . htmlspecialchars($page['url']) . '">' . htmlspecialchars($page['num']) . '</a></li>';
                } else {
                    $html .= '<li class="disabled"><span>' . htmlspecialchars($page['num']) . '</span></li>';
                }
            }
            if ($paginator->getNextUrl()) {
                $html .= '<li><a href="' . htmlspecialchars($paginator->getNextUrl()) . '">'. $paginator->nextText .' &raquo;</a></li>';
            }
            $html .= '</ul>';
            return $html;
        }

        public function __toString()
        {
            return $this->html;
        }
    }
}