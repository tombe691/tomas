<?php
// klassen som abstraherar bort arbete med sessions
namespace App\Core\Classes
{
    class Session
    {
        // metoderna är självklara och behöver inte kommentarer, upp till banner
        public static function exists($name)
        {
            return (isset($_SESSION[$name]));
        }

        public static function set($name, $value)
        {
            return $_SESSION[$name] = $value;
        }

        public static function get($name)
        {
            if (self::exists($name)){
                $return = $_SESSION[$name];
                if ($name == 'errors'){
                    self::delete($name);
                }
                return $return;
            }
            return false;
        }

        public static function destroy() 
        {
            session_destroy();
        }
        
        public static function delete($name)
        {
            if (self::exists($name)){
                unset($_SESSION[$name]);
            }
        }

        public static function init() 
        {
            if (session_id() == "") {
                session_start();
            }
        }

        public static function banner($name, $message = '')
        {
            if (self::exists($name)){
                $session = self::get($name);
                self::delete($name);
                return $session;
            } else{
                self::set($name, $message);
            }
            return '';
        } // banner eller flash används för att visa ett engångs meddelande som sedan försvinner

        public static function generateToken($name = 'token') 
        {
            $maxTime = 60 * 60;
            $token = self::get($name);
            $tokenTime = self::get($name . '_time');
            if ($maxTime + $tokenTime <= time() or empty($token)) {
                self::set($name, md5(uniqid(rand(), true)));
                self::set($name . '_time', time());
            }
            return self::get($name);
        } // generar den unika token en gång per timme

        public static function checkToken($value, $name = 'token')
        {
            $maxTime = 60 * 60 * 24;
            if (self::exists($name)){
                if (self::get($name) === $value){
                    if (self::get($name . '_time') + $maxTime < time()){
                        self::delete($name);
                        return false;
                    }
                    self::delete($name);
                    return true;
                }
                self::delete($name);
                return false;
            }
            return false;
        } // kontrollerar token

        public static function addMsg($type, $message)
        {
            $sessionName = 'alert-' .  $type;
            self::set($sessionName, $message);
        } // bootstrap har sina egna notiser och ibland kan dessa föredras att användas över banner
        
        public static function displayMsg()
        {
            $alerts = ['alert-info','alert-success','alert-warning','alert-danger'];
            $html = '';
            foreach($alerts as $alert){
              if(self::exists($alert)){
                $html .= '<div class="alert '. $alert .' alert-dismissible" role="alert">';
                $html .= '<button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>';
                $html .= self::get($alert);
                $html .= '</div>';
                self::delete($alert);
              }
            }
            return $html;
        }
        

    }
}