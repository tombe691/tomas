<?php
namespace App\Core
{

    use App\Core\Classes\Redirect;
    use App\Core\Classes\Session;
    use App\Models\User;

    class Auth 
    {
        public static $loggedInUser = null,
                    $errors = [];

        public static function login($username, $password)
        {
            Session::init();
            $result = User::findByUser('username', $username);
            if ($result){
                $user = $result->first();
                if (password_verify($password, $user->password)){
                    self::$loggedInUser = $user;
                    Session::set(LOGGEDUSER, $user->id);
                    Redirect::to('index');
                } else{
                    $errors['wrongPassword'] = 'password entered is wrong.';
                    return false;
                }
            } else{
                $errors['noUser'] = 'No user was found with the entered username.';
                return false;
            }
        }

        public static function currentUser() 
        {
            Session::init();
            if(!isset(self::$loggedInUser) && Session::exists(LOGGEDUSER)) {
              $user = User::findUser((int)Session::get(LOGGEDUSER));
              self::$loggedInUser = $user;
            }
            return self::$loggedInUser;
        }

        public static function checkAuthenticated($redirect = "App/Controllers/loginController/login")
        {
            Session::init();
            if (!Session::exists(LOGGEDUSER)) {
                Session::destroy();
                Redirect::to($redirect);
            }
        }

        public static function logout($redirect = 'App/Controllers/homecontroller/index') 
        {
            Session::init();
            Session::delete(LOGGEDUSER);
            self::$loggedInUser = null;
            Redirect::to($redirect);
        } 
        
        
        public function registerAction($user_fields) 
        {
            $newUser = new User();
            foreach ($user_fields as $field => $value){
                $newUser->{$field} = $value;
            }
            $result = $newUser->save();
            if ($newUser->save() !== false){
                $errors = $result;
                return false;
            }
            return true;
        }
        
        
    }
}