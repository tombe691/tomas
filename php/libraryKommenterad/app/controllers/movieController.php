<?php
// här finns programmet som efterfrågas i uppgiften, vilket påminner om winfomrs, hur koden bakom en vy stod i ett enda fil
namespace App\Controllers
{

    use App\Core\Auth;
    use App\Core\Controller;
    use App\Core\DBController;
    use App\Core\Validator;
    use App\Models\User;
    use App\Core\Classes\Collection;
    use App\Core\Classes;
    use App\Core\Classes\GenreEnums;
    use App\Core\Classes\Input;
    use App\Core\Classes\Redirect;
    use App\Core\Classes\Session;
    use App\Core\View;
    use App\Models\Book;
    use App\Models\Director;
    use App\Models\Genre;
    use App\Models\Movie;

class MovieController extends Controller
    {
        public function __construct(View $view, User $user)
        {
            parent::__construct($view, $user);
            $this->view->setTitle('Library');
        }

        public function index()
        {
            /* $movie = new Movie();
            $movie->title = 'the dark knight';
            $movie->publish_date = time();
            $movie->synopsis = 'batman is christian bale';
            User::findUser(3)->movies()->attach($movie); */
            // har kan du uppleva fördröjningar, om du har många element
            $genre_enum = GenreEnums::getConstants(); // hämtar konstantlistan från genreenums
            $movies = Movie::findAll(); // hämtar alla rekorder av movies
            if ($movies){
                $values = [];
                foreach ((array)$movies->toArray() as $movie){
                    $genres = $movie->genres()->toArray(); // genres för varje movie hämtas
                    $directors = $movie->directors()->toArray(); // directors för varje movie hämtas
                    $genre_catig = '';
                    $director_catig = '';
                    $x = 1;
                    foreach ($genres as $genre){
                        $result = array_search($genre->genre, $genre_enum);
                        if ($result !== false){
                            $genre_catig .= $result;
                        }
                        if ($x < count($genres)){
                            $genre_catig .= '|';
                        }
                        $x++;
                    } // genres formuleras med en seperator |
                    $x = 1;
                    foreach ($directors as $director){
                        $director_catig .= $director->first_name . ' ' . $director->last_name;
                        if ($x < count($directors)){
                            $director_catig .= '|';
                        }
                        $x++;
                    } // directors formulers med first_name, last_name| annan_first_name, annan_last_name
                    $values[] = [
                        $movie->title,
                        $director_catig,
                        date('d/m/Y', strtotime($movie->publish_date)), 
                        $genre_catig,
                        '<a href="' . PUBLICPRO . 'App/Controllers/moviecontroller/edit' . '/' . $movie->id . '">Update</a>',
                        '<a href="' . PUBLICPRO . 'App/Controllers/moviecontroller/edit' . '/' . $movie->id . '">Delete</a>'
                    ];
                }
                $this->view->setDataPair('values', $values); // data skickas till vyn för att hamna i htm tabell
                $this->view->setDataPair('columns', [
                    'Title',
                    'Director(s)',
                    'Year',
                    'Genre(s)',
                    'Update',
                    'Delete'
                ]);
                $this->view->setDataPair('page_header', 'My library');
                $this->view->render('movie/index');
            }
            Redirect::to('App/Controllers/MovieController/add');
            // så ser html tabellen ut, med den strukturen bör du få de olika rekorder av movies presenterade
            $table = '<table>
            <tr>
                <th class="c1">Title</th>
                <th class="c2">Director</th>
                <th class="c3">Year</th>
                <th class="c4">Genre(s)</th>
                <th class="c4">Update</th>
                <th class="c4">Delete</th>

            </tr>
            <tr>
                <td class="c1">' . $movie->title . '</td>
                <td class="c2">' . $director_catig . '</td>
                <td class="c3">' . $movie->publish_date . '</td>
                <td class="c4">' . $genre_catig . '</td>
                // de update och delete länkar kunde ha varit i en form och kunde ha skickat en post request för bättre säkerhet
                <td class="c4"><a href="' . PUBLICPRO . 'App/Controllers/moviecontroller/edit' . '/' . $movie->id . '">Update</a></td>
                <td class="c4"><a href="' . PUBLICPRO . 'App/Controllers/moviecontroller/edit' . '/' . $movie->id . '">Delete</a></td>
            </tr>
          </table>';
        }

        public function add()
        {
            $directors = Director::findAll();
            $director_values = [];
            foreach ($directors->toArray() as $director){
                $director_values[$director->id] = $director->first_name . ' ' . $director->last_name;
            }
            $genres = GenreEnums::getConstants();
            unset($genres['NoGenre']);
            $genres = array_fill_keys(array_keys($genres), false);
            $this->view->setDataPair('directors', $director_values);
            $this->view->setDataPair('genres', $genres);
            $this->view->displayErrors = isset($this->errors) ? $this->errors : Session::get('inputValidation');
            $this->view->render('movie/add');
        } // add hämtar alla directors plus alla genres

        public function registerAdd()
        {
            if (Input::exists()){
                $check = Input::check($_POST, [
                    'title' => [
                        'required' => true,
                        'pattern' => 'text'
                    ], 'publish_date' => [
                        'required' => true,
                        'pattern' => 'date'
                    ], 'synopsis' => [
                        'required' => false,
                        'pattern' => 'text'
                    ]
                ]);
                if ($check){
                    $inputs = Input::get();
                    $inputs['directors'] = (is_array($inputs['directors'])) ? $inputs['directors'] : [];
                    $movie = new Movie(); // en ny movie objekt skapas
                    $movie->title = $inputs['title'];
                    $movie->publish_date = date('Y-m-d H:i:s', strtotime($inputs['publish_date']));
                    $movie->synopsis = $inputs['synopsis'];
                    $movie->save(); // den förs över till databasen
                    unset($inputs['title'], $inputs['publish_date'], $inputs['synopsis']);
                    $selected_genres = [];
                    foreach (array_keys($inputs) as $key){
                        if (preg_match('/^genre\d+$/', $key, $matches)){
                            preg_match('/\d+/', $matches[0], $matches_digits);
                            $selected_genres[] = $matches_digits[0];
                        }
                    } // numeriska värden på genres hämtas
                    $genre_enum = GenreEnums::getConstants();
                    foreach ($selected_genres as $selected_genre){
                        if (!array_search($selected_genre, $genre_enum)){
                            continue;
                        }
                        $genre = Genre::findByUser('genre', $selected_genre)->first();
                        if (!$genre){ // det kan bara finnas 10 genres, om en inte finns så kan den skapas
                            $genre = new Genre();
                            $genre->genre = $selected_genre;
                            $genre->save();
                        }
                        $movie->genres()->attach($genre); // genres bifogas relationen
                    }
                    foreach ($inputs['directors'] as $value) {
                        $director = Director::findUser($value);
                        if ($director){
                            $movie->directors()->attach($director);
                        }
                    } // directors id används för att koppla directors till filmen
                    Redirect::to('App/Controllers/MovieController/index');
                } else{
                    //$this->displayErrors = Session::get('inputValidation');
                    //$this->view->render('movie/add');
                    Redirect::objTo('App/Controllers/MovieController/add')->withErrors(Session::get('inputValidation'));
                }
            } else{
                Redirect::to('App/Controllers/MovieController/index');
            }
        } // add registreras och behandlas här via en post request

        public function edit(int $id)
        {
            $genres = GenreEnums::getConstants();
            $movie = Movie::findUser($id);
            $true_genres = [];
            foreach ($movie->genres()->toArray() as $genre){
                $result = array_search($genre->genre, $genres);
                if ($result !== false){
                    $true_genres[$result] = true;
                }
            }
            $directors = Director::findAll();
            $director_values = [];
            foreach ($directors->toArray() as $director){
                $director_values[$director->id] = $director->first_name . ' ' . $director->last_name;
            }
            $movie_directors = $movie->directors()->toArray();
            $selected = [];
            foreach ($movie_directors as $movie_director){
                $selected[$movie_director->id] = 'selected';
            }
            $this->view->setDataPair('genres', $true_genres);
            $this->view->setDataPair('directors', $director_values);
            $this->view->setDataPair('selected', $selected);
            $this->view->displayErrors = isset($this->errors) ? $this->errors : Session::get('inputValidation');
            $this->view->setModel($movie);
            $this->view->render('movie/edit');
        } // förbereder och populerar vyn med data från alla genre och directors

        public function registerEdit()
        {
            if (Input::exists()){
                $check = Input::check($_POST, [
                    'id' => [
                        'required' => true,
                        'type' => 'int'
                    ], 'title' => [
                        'required' => true,
                        'pattern' => 'text'
                    ], 'publish_date' => [
                        'required' => true,
                        'pattern' => 'date'
                    ], 'synopsis' => [
                        'required' => false,
                        'pattern' => 'text'
                    ]
                ]);
                if ($check){
                    $genres = GenreEnums::getConstants();
                    $selected_genres = [];
                    foreach (array_keys($_POST) as $key){
                        if (preg_match('/^genre\d+$/', $key, $matches)){
                            preg_match('/\d+/', $matches[0], $matches_digits);
                            if (in_array($matches_digits[0], $genres)){
                                $selected_genres[] = $matches_digits[0];
                            }
                        }
                    } // genres hämtas just som i registerAdd
                    $inputs = Input::get();
                    $movie = Movie::findUser($inputs['id']);
                    unset($inputs['id']);
                    $inputs['publish_date'] = date('Y-m-d H:i:s', strtotime($inputs['publish_date']));
                    foreach ($inputs as $field => $value){
                        if (array_key_exists($field, $movie->object_map)){
                            $movie->{$field} = $value;
                        }
                    }
                    $movie->save();
                    $movie_genres = $movie->genres();
                    $omitted = $movie_genres->filter(function ($value) use($selected_genres){
                        return (!in_array($value->genre, $selected_genres));
                    })->toArray(); // de genres som ska bort filtereras
                    foreach ($omitted as $entry){
                        $movie->genres->detach($entry);
                    }
                    $numbered_genres = [];
                    foreach ($movie_genres->toArray() as $movie_genre){
                        $numbered_genres[] = $movie_genre->genre;
                    }
                    $added = array_diff($selected_genres, $numbered_genres); // de genres som bör adderas
                    foreach ($added as $add){
                        $genre_to_add = Genre::findByUser('genre', $add);
                        if ($genre_to_add === false){
                            $genre_to_add = new Genre();
                            $genre_to_add->genre = $add;
                        } else{
                            $genre_to_add = $genre_to_add->first();
                        }
                        $movie->genres->attach($genre_to_add);
                    }
                    $selected_directors = array_values($inputs['directors']);
                    $movie_directors = $movie->directors();
                    $director_ids = [];
                    $omitted = $movie_directors->filter(function ($value) use($selected_directors, $director_ids){
                        $director_ids[] = $value->id;
                        return (!in_array($value->id, $selected_directors));
                    })->toArray(); // direktors som ska tas bort och även director_ids populeras för användning vid array_diff
                    foreach ($omitted as $omit){
                        $movie->directors->detach($omit);
                    }
                    $added_directors = array_diff($selected_directors, $director_ids); // array_diff ger de element som finns i selected_directors som inte finns med i filmens associerade directors
                    foreach ($added_directors as $entry){
                        $director = Director::findUser($entry);
                        if ($director){
                            $movie->directors->attach($director);
                        }
                    }
                    Redirect::to('App/Controllers/MovieController/index');
                } else{
                    //$this->displayErrors = Session::get('inputValidation');
                    //$this->view->render('movie/edit');
                    Redirect::objTo('App/Controllers/MovieController/edit', [Input::get('id')])->withErrors(Session::get('inputValidation'));
                }
            } else{
                Redirect::to('App/Controllers/MovieController/index');
            }
        } // registrerar edit request via post

        public function registerDelete(int $id)
        {
            if (Input::exists()){
                $check = Input::check($_POST, [
                    'id' => [
                        'required' => true,
                        'type' => 'int'
                    ]
                ]);
                if ($check){
                    $movie = Movie::findUser(Input::get('id'));
                    $movie->delete();
                    Redirect::to('App/Controllers/MovieController/index');
                } else{
                    Redirect::to('App/Controllers/MovieController/index');
                }
            } else{
                Redirect::to('App/Controllers/MovieController/index');
            }
        } // registrerar delete requests via post

        public function registerAddDirector(string $first_name, string $last_name)
        {
            $check = Input::check($_POST, [
                'first_name' => [
                    'required' => true,
                    'type' => 'string'
                ], 'last_name' => [
                    'required' => false,
                    'type' => 'string'
                ]
            ]);
            if ($check){
                $first_name = Input::sanitize($first_name);
                $last_name = Input::sanitize($last_name);
                $director = new Director(); // ny director skapas för att sedan sparas med de värden som kommit in via post request
                $director->first_name = $first_name;
                $director->last_name = $last_name;
                $director->save();
                Redirect::to('App/Controllers/MovieController/index');
            } else{
                //$this->displayErrors = Session::get('inputValidation');
                //$this->view->render('movie/edit');
                Redirect::objTo('App/Controllers/MovieController/add')->withErrors(Session::get('inputValidation'));
            }
        } // adderar en ny direktor att använda som director för filmen

        // saknas att ta bort en direktor, men eftersom processen är så pass lika den för movies, och ännu enklare anser jag att det blir repetitivt
        // saknas att redigera en director
        // att addera genres är också en möjlighet då php tillåter runtime addering av konstanter 
    }
}