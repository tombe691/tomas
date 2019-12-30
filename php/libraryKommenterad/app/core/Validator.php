<?php

// Validatorn gör all validering åt controllers och DBcontroller för att verifiera att data som läggs in i databasen, eller emottas är giltig
namespace App\Core
{
    use App\Core\Classes\Input as Input;
    
    class Validator 
    {
        private $success = false;
        private $patterns = [
            'url'   => '[A-Za-z0-9-:.\/_?&=#]+',
            'alpha' => '[\p{L}]+',
            'words' => '[\p{L}\s]+',
            'alphanum' => '[\p{L}\p{N}\s]+',
            'int'=> '[-+]?[0-9]+',
            'float' => '[-+]?[0-9]*\.?[0-9]+',
            'text'  => '[\p{L}0-9\s-.,;:!"%&()?+\'°#\/@]+',
            'date'  => '(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})',
            'email' => '[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+[.]+[a-z-A-Z]'
        ]; // regex patterns för det mesta man vill match
        public static $sql_types = [
            '/(varchar\(\d+\))/i' => 'string',
            '/(int\(\d+\))/i' => 'int'
        ];

        public $field, 
               $value,
               $errors = [];

        public function int($value = false)
        {
            if ($value === false){
                if(!filter_var($this->value, FILTER_VALIDATE_INT)){
                    $this->errors['int'] = "{$this->field} needs to be an integer.";
                    return $this;
                }
            }
            return (filter_var($value, FILTER_VALIDATE_INT) === false) ? false : true;
        } // validerar int, genom phps inbyggda filter_var
        
        public function float($value = false)
        {
            if ($value === false){
                if(!filter_var($this->value, FILTER_VALIDATE_FLOAT)){
                    $this->errors['float'] = "{$this->field} needs to be a float.";
                    return $this;
                }
            }
            return (filter_var($value, FILTER_VALIDATE_FLOAT) === false) ? false : true;
        } // validerar float, genom phps inbyggda filter_var
        
        public function alpha($value = false)
        {
            if ($value === false){
                if(!filter_var($this->value, FILTER_VALIDATE_REGEXP, array('options' => array('regexp' => '/^(' . $this->patterns['alpha'] . ')$/i')))){
                    $this->errors['alpha'] = "{$this->field} is not an alphabetical.";
                    return $this;
                }
            }
            return (filter_var($value, FILTER_VALIDATE_REGEXP, array('options' => array('regexp' => '/^(' . $this->patterns['alpha'] . ')$/i'))) === false) ? false : true;
        } // validerar alpha, genom phps inbyggda filter_var och regex pattern för en alpha
        
        public function alphanum($value = false)
        {
            if ($value === false){
                if(!filter_var($this->value, FILTER_VALIDATE_REGEXP, array('options' => array('regexp' => '/^(' . $this->patterns['alphanum'] . ')$/i')))){
                    $this->errors['alphanum'] = "{$this->field} is not an alphanumerical.";
                    return $this;
                }
            }
            return (filter_var($value, FILTER_VALIDATE_REGEXP, array('options' => array('regexp' => '/^(' . $this->patterns['alphanum'] . ')$/i'))) === false) ? false : true;
        } // validerar alphanum, genom phps inbyggda filter_var och regex pattern för en alphanum

        public function url($value = false)
        {
            if ($value === false){
                if(!filter_var($this->value, FILTER_VALIDATE_URL)){
                    $this->errors['url'] = "{$this->field} needs to be a valid url.";
                    return $this;
                }
            }
            return (filter_var($value, FILTER_VALIDATE_URL) === false) ? false : true;
        } // validerar url, genom phps inbyggda filter_var

        public function bool($value = false)
        {
            if ($value === false){
                if(!filter_var($this->value, FILTER_VALIDATE_BOOLEAN, FILTER_NULL_ON_FAILURE)){
                    $this->errors['bool'] = "{$this->field} is not a boolean.";
                    return $this;
                }
            }
            return is_bool(filter_var($value, FILTER_VALIDATE_BOOLEAN, FILTER_NULL_ON_FAILURE));
        } // validerar bool, genom phps inbyggda filter_var som antigen returnerar false eller filtrerad data som här är true eller false eller annat, sedan får is_bool avgöra vad det är för data

        public function email($value = false)
        {
            if ($value === false){
                if(!filter_var($this->value, FILTER_VALIDATE_EMAIL)){
                    $this->errors['email'] = "{$this->field} needs to be a valid email.";
                    return $this;
                }
            }
            return (filter_var($this->value, FILTER_VALIDATE_EMAIL) === false) ? false : true;
        } // validerar email, genom phps inbyggda filter_var

        public function timestamp($value = false) 
        {
            if ($value === false){
                if(!ctype_digit($this->value) || strtotime(date('Y-m-d H:i:s', $this->value)) !== (int)$this->value){
                    $this->errors['timestamp'] = "{$this->field} is not a valid unix timestamp.";
                } 
                return $this;
            }
            if(ctype_digit($value) && strtotime(date('Y-m-d H:i:s', $value)) === (int)$value){
                return true;
            } 
            return false;
        } // validerar timestamp, genom att utföra strtototime checks och se om värdet är numerisk till att börja med

        public function min($min, $value = false)
        {
            if ($value === false){
                if (is_string($this->value)){
                    if (strlen($this->value) < $min){
                        $this->errors['min'] = "{$this->field} should be at least {$min} characters.";
                    }
                } elseif (is_numeric($this->value)){
                    if ($this->value < $min){
                        $this->errors['min'] = "{$this->field} should be at least {$min}.";
                    }
                } elseif (is_array($this->value)){
                    if (count($this->value) < $min){
                        $this->errors['min'] = "{$this->field} should be at least {$min}-elements.";
                    }
                }
                return $this;
            }
            if (is_string($value)){
                if (strlen($value) < $min){
                    return false;
                } else{
                    return true;
                }
            } elseif (is_numeric($value)){
                if ($value < $min){
                    return false;
                } else{
                    return true;
                }
            }
            return false;
        } // validerar att ett värde inte understiger ett visst minimum
        
        public function max($max, $value = false)
        {
            if ($value === false){
                if (is_string($this->value)){
                    if (strlen($this->value) > $max){
                        $this->errors['max'] = "{$this->field} should be at most {$max} characters.";
                    }
                } elseif (is_numeric($this->value)){
                    if ($this->value > $max){
                        $this->errors['max'] = "{$this->field} should be at most {$max}.";
                    }
                } elseif (is_array($this->value)){
                    if (count($this->value) > $max){
                        $this->errors['max'] = "{$this->field} should be at least {$max}-elements.";
                    }
                }
                return $this;
            }
            if (is_string($value)){
                if (strlen($value) > $max){
                    return false;
                } else{
                    return true;
                }
            } elseif (is_numeric($value)){
                if ($value > $max){
                    return false;
                } else{
                    return true;
                }
            }
            return false;
        } // validerar att ett värde inte överstiger ett visst maximum

        public function between($range, $value = false)
        {
            $min = $range[0];
            $max = $range[1];
            if ($value === false){
                if (!is_numeric($this->value) || $this->value < $min || $this->value > $max){
                    $this->errors['between'] = "{$this->field} should be at between {$min} and {$max}.";
                }
                return $this;
            }
            if (!is_numeric($this->value) || $this->value < $min || $this->value > $max){
                return false;
            }
            return true;
        } // validerar att ett värde är mellan två gränser

        public function pattern($pattern, $value = false)
        {
            $regex = '/^' . $this->patterns[$pattern] . '$/i';
            if ($value === false){
                if(!preg_match($regex, $this->value)){
                    $this->errors[$this->field] = "{$this->field} doesn't match the pattern for a(n) {$pattern}.";
                }
                return $this;
            } 
            return preg_match($regex, $value);
        } // validerar genom ett pattern match
        
        public function customPattern($custom_pattern, $value = false){
            $regex = '/^' . $custom_pattern . '$/i';
            if ($value === false){
                if(!preg_match($regex, $this->value)){
                    $this->errors[$this->field] = "{$this->field} doesn't match the provided pattern.";
                }
                return $this;
            } 
            return preg_match($regex, $value);
        } // validerar genom ett pattern match med ett givet pattern
       

        public function parseValidate($source, $inputs)
        {
            if (is_array($source)){
                $parsed = [];
                foreach ($source as $key => $value){
                    if (strpos($key, 'id') !== false){
                        continue;
                    }
                    $partly_parsed = [];
                    foreach (array_filter(explode('|', $inputs[$key])) as $entry){
                        $pair = explode(':', $entry);
                        if ($pair[0] == 'type'){
                            foreach (self::$sql_types as $reg_key => $reg_value){
                                if (preg_match($reg_key, $pair[1])){
                                    $pair[1] = $reg_value;
                                }
                            }
                        }
                        $partly_parsed[$pair[0]] = $pair[1];
                    }
                    $parsed[$key] = $partly_parsed;
                }
                $this->validate($source, $parsed);
            } else{
                $parsed = [];
                foreach (array_filter(explode('|', $inputs)) as $entry){
                    $pair = explode(':', $entry);
                    if ($pair[0] == 'type'){
                        foreach (self::$sql_types as $key => $value){
                            if (preg_match($key, $pair[1])){
                                $pair[1] = $value;
                            }
                        }
                    }
                    $parsed[$pair[0]] = $pair[1];
                }
                $this->validate([$source => $source], [$source => $parsed]);
            }
            return $this->success;
        } // parser validering för object_map av en DBController object

        public function validate($source = [], $inputs = [])
        {
            $this->success = false;
            $fields_errors = [];
            foreach ($inputs as $input => $rules){
                foreach ($rules as $rule => $rule_value){
                    $field_errors = [];
                    $value = trim(Input::sanitize($source[$input]));
                    if (is_numeric($rule)){
                        $rule = $rule_value;
                    }
                    switch ($rule){
                        case 'required':
                            if (empty($value) && ($rule_value == 'required' || !isset($rule))){
                                $field_errors['required'] = "{$input} is required.";
                            }
                        break;
                        case 'min':
                            if (!empty($value) && !$this->min($rule_value, $value)){
                                $field_errors['min'] = "{$input} should be at least {$rule_value} characters long.";
                            }
                        break;
                        case 'max':
                            if (!empty($value) && !$this->max($rule_value, $value)){
                                $field_errors['max'] = "{$input} should be at most {$rule_value} characters long.";
                            }
                        break;
                        case 'matches':
                            if (!empty($value) && $value !== $rule_value){
                                $field_errors['matches'] = "{$input} should match {$rule_value}.";
                            }
                        break;
                        case 'email':
                            if (!empty($value) && !$this->email($value)){
                                $field_errors['email'] = "{$input} is not a valid email.";
                            }
                        break;
                        case 'pattern':
                            if (!empty($value) && !$this->pattern($rule_value, $value)){
                                $field_errors['pattern'] = "{$input} doesn't match the pattern for a {$rule_value}";
                            }
                        break;
                        case 'type':
                            if (!empty($value)){
                                switch ($rule_value) {
                                    case 'int':
                                        if (!$this->int($value)){
                                            $field_errors['type'] = "{$input} needs to be an integer.";
                                        }
                                    break;
                                    case 'alpha':
                                        if (!$this->alpha($value)){
                                            $field_errors['type'] = "{$input} needs to be a string with no digits.";
                                        }
                                    break;
                                    case 'alphanum':
                                        if (!$this->alphanum($value)){
                                            $field_errors['type'] = "{$input} needs to be a string with numbers.";
                                        }
                                    break;
                                }
                            }
                        break;
                        case 'url':
                            if (!empty($value) && !$this->url($value)){
                                $field_errors['url'] = "{$input} needs to be a valid url.";
                            }
                        break;
                        case 'timestamp':
                            if (!empty($value) && !$this->timestamp($value)){
                                $field_errors['timestamp'] = "{$input} needs to be a valid unix timestamp.";
                            }
                        break;
                        case 'unique':
                            if (!empty($value)){
                                $check = (new $rule_value)->get([$input, '=', $value]);
                                if ($check->count()){
                                    $field_errors['unique'] = "{$input} is already taken.";
                                }
                            }
                        break;
                    }
                    if (!empty($field_errors)){
                        $fields_errors[$input] = $field_errors;
                    }
                }

            }
            $this->errors = $fields_errors;
            $this->check($fields_errors);
            return $this;

        } // validate görs switch som löpar värden, använder den gemmensama key för att ha tillgång till regler och sedan gå igenom varje regel för varje värde

        private function check($validation_result = [])
        {
            $valid = true;
            foreach ($validation_result as $input => $field_errors){
                if (!empty($field_errors)){
                    $valid = false;
                    break;
                }
            }
            $this->success = $valid;
            return $validation_result;
        }

        public function passed()
        {
            return $this->success;
        }
    }
}