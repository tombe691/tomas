<?php

namespace App\Core\Classes
{
    interface INotifyPropertyChanged
    {
        function PropertyChanged($name);
        function RegisterChangeCallback($callback);
    }
}

