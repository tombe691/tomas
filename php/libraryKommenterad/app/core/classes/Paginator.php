<?php

namespace App\Core\Classes
{
    class Paginator
    {
        protected $totalItems,
                $numPages,
                $itemsPerPage,
                $currentPage,
                $urlPattern,
                $maxPagesToShow = 10,
                $previousText = 'Previous',
                $nextText = 'Next';

        public function __construct($totalItems = 100, $itemsPerPage = 5, $currentPage = 1, $urlPattern = '')
        {
            $this->totalItems = $totalItems;
            $this->itemsPerPage = $itemsPerPage;
            $this->currentPage = $currentPage;
            $this->urlPattern = $urlPattern;
            $this->updateNumPages();
        }

        protected function updateNumPages()
        {
            $this->numPages = ($this->itemsPerPage == 0 ? 0 : (int) ceil($this->totalItems/$this->itemsPerPage));
        }

        public function setMaxPagesToShow($maxPagesToShow)
        {
            $this->maxPagesToShow = $maxPagesToShow;
        }

        public function getMaxPagesToShow()
        {
            return $this->maxPagesToShow;
        }

        public function setCurrentPage($currentPage)
        {
            $this->currentPage = $currentPage;
        }

        public function getCurrentPage()
        {
            return $this->currentPage;
        }

        public function setItemsPerPage($itemsPerPage)
        {
            $this->itemsPerPage = $itemsPerPage;
            $this->updateNumPages();
        }

        public function getItemsPerPage()
        {
            return $this->itemsPerPage;
        }

        public function setTotalItems($totalItems)
        {
            $this->totalItems = $totalItems;
            $this->updateNumPages();
        }

        public function getTotalItems()
        {
            return $this->totalItems;
        }

        public function getNumPages()
        {
            return $this->numPages;
        }
  
        public function setUrlPattern($urlPattern)
        {
            $this->urlPattern = $urlPattern;
        }
 
        public function getUrlPattern()
        {
            return $this->urlPattern;
        }

        public function getPageUrl($pageNum)
        {
            return str_replace('(:num)', $pageNum, $this->urlPattern);
        }
        public function getNextPage()
        {
            if ($this->currentPage < $this->numPages) {
                return $this->currentPage + 1;
            }
            return null;
        }
        public function getPrevPage()
        {
            if ($this->currentPage > 1) {
                return $this->currentPage - 1;
            }
            return null;
        }
        public function getNextUrl()
        {
            if (!$this->getNextPage()) {
                return null;
            }
            return $this->getPageUrl($this->getNextPage());
        }
   
        public function getPrevUrl()
        {
            if (!$this->getPrevPage()) {
                return null;
            }
            return $this->getPageUrl($this->getPrevPage());
        }

        public function getCurrentPageFirstItem()
        {
            $first = ($this->currentPage - 1) * $this->itemsPerPage + 1;
            if ($first > $this->totalItems) {
                return null;
            }
            return $first;
        }
        public function getCurrentPageLastItem()
        {
            $first = $this->getCurrentPageFirstItem();
            if ($first === null) {
                return null;
            }
            $last = $first + $this->itemsPerPage - 1;
            if ($last > $this->totalItems) {
                return $this->totalItems;
            }
            return $last;
        }
        public function setPreviousText($text)
        {
            $this->previousText = $text;
            return $this;
        }
        public function setNextText($text)
        {
            $this->nextText = $text;
            return $this;
        }
    }

}