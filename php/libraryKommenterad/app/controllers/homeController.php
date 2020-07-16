<?php

namespace App\Controllers
{
    use App\Core\Controller as Controller;
    use App\Core\DBController as DBController;
    use App\Core\Validator as Validator;
    use App\Models\User;
    use App\Core\Classes\Collection;
    use App\Core\Classes;
    use App\Core\Classes\Redirect;
    use App\Models\Book;
    use App\Core\View;

    class HomeController extends Controller
    {
        public function __construct(View $view, User $user)
        {
            parent::__construct($view, $user);
        }

        // här presenteras de möjliga saker som kan göras med DBcontroller jag har använt dessa vid testing
        
        public function index()
        {
            Redirect::to('App/Controllers/MovieController/index');
            /* $this->view('home/index')->render(
                [
                    'name' => $name
                ]
            ); */
            //dd('here');
            //$user = $this->model('User');
            //$user->name = $name;
            /* var_dump(DBController::singelton('users')->insert([
                'username' => 'dan',
                'email' => 'dan@mail.com',
                'first_name' => 'danny',
                'last_name' => 'hermond',
                'password' => 'something'
            ])->error()); */
            /* $user = new \App\Models\User();
            $user->password = 'password';
            $user->username = 'marcus';
            $user->email = 'marcus@mail.com';
            $user->first_name = 'marcus';
            $user->last_name = 'polos';
            $user->save(); 

            $marcus = User::findUser(4);
            $marcus->password = 'rubbish';
            $marcus->save();*/

            /* $users = User::findByUser('password', 'password');
            $users[1]->username = 'dan';
            $users[1]->save();
            $rick = $users[1]->books()->first();
            $rick->title = 'rick and morty';
            $rick->save(); */

            /* $book = new \App\Models\Book();
            $book->title = 'house md';
            $book->synopsis = 'a crazy but genious doctor.';
            $book->publisher = 'fox';
            $book->save(); */

            /*$book = new \App\Models\Book();
            $book->title = 'mouse md';
            $book->synopsis = 'a crazy but genious doctor.';
            $book->publisher = 'fox';
            $users = User::findByUser('password', 'password');
            $users[1]->books()->attach($book);
            $users[1]->books->detach($book);*/

            /*$user = new \App\Models\User();
            $user->username = 'dan the man';
            $user->email = 'dan@mail.com';
            $user->password = 'passtheWord';
            $user->first_name = 'daniel';
            $user->last_name = 'kafka';
            $book = Book::findUser(1);
            $uses = $book->users()->first();
            $uses->username = 'uses the username';
            $uses->save();*/
            $author = new \App\Models\Author();
            $author->first_name = 'goerge';
            $author->last_name = 'r.r.martin';
            $book = Book::findUser(1);
            $book->authors()->attach($author);

            //$book->users->detach($user);
            //var_dump($db->where('id', 7)->andWhere('first_name', 'danny')->select()->result());
            var_dump((new Validator())->validate($soruce = [
                'username' => 'dan',
                'email' => 'dan@mail.com',
                'first_name' => 'danny',
                'last_name' => 'hermond',
                'password' => 'something',
                'password_again' => 'something'
            ], [
                'username' => [
                    'min' => '3',
                    'required',
                    'unique' => \App\Models\User::class
                ], 'email' => [
                    'max' => '255'
                ], 'password_again' => [
                    'matches' => 'password'
                ]
            ]));
            //$this->view('home/index', ['name' => $user->name]);
        }

        public function home()
        {

        }
        
        public $name = 'home';

    }
}