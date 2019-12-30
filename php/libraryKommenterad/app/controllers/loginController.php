<?php

namespace App\Controllers
{

    use App\Core\Auth;
    use App\Core\Controller;
    use App\Core\DBController;
    use App\Core\Validator;
    use App\Models\User;
    use App\Core\Classes\Collection;
    use App\Core\Classes;
    use App\Core\View;
    use App\Models\Book;

    class loginController extends Controller
    {
        public function __construct(View $view, User $user)
        {
            parent::__construct($view, $user);
            $this->view->setTitle('Log in');
        }

        public function index()
        {
            $this->view->render('login/index');
        }

        public function login(string $username, string $password)
        {
            global $container;
            $valid = ($container->get(Validator::class))->validate([
                'username' => $username,
                'password' => $password
            ], [
                'username' => [
                    'min' => '3',
                    'required' => 'required',
                ],
                'password' => [
                    'min' => '8',
                    'required' => 'required',
                    'type' => 'alphanum'
                ]
            ])->passed();
            if ($valid){
                if (!Auth::login($username, $password)){
                    $this->view->displayErrors = Auth::$errors;
                }
            } else{
                $this->view->displayErrors = ($container->get(Validator::class))->errors;
            }
            $this->view->render('login/index');
        }

        

    }
}