<?php
// här är det inträdespunkten för programmet och tjänar som den så kallade autoloader
define('DS', DIRECTORY_SEPARATOR);
define('ROOT', dirname(__DIR__) . DIRECTORY_SEPARATOR);
define('APP', ROOT . 'app' . DIRECTORY_SEPARATOR);
define('CORE', APP . 'core' . DIRECTORY_SEPARATOR);
define('CONTROLLERS', APP . 'controllers' . DIRECTORY_SEPARATOR);
define('VIEWS', APP . 'views' . DIRECTORY_SEPARATOR);
define('MODELS', APP . 'models' . DIRECTORY_SEPARATOR);
define('CLASSES', CORE . 'classes' . DIRECTORY_SEPARATOR);
define('RESOURCES', ROOT . 'public' . DIRECTORY_SEPARATOR . 'resources' . DIRECTORY_SEPARATOR);
define('PUBLICPRO', 'http://localhost:8090/libraryKommenterad/public/' . DIRECTORY_SEPARATOR); // konstant som används vid Redirect.php och som du behöver ändra på enligt din localhost konfiguration
define('LAYOUTS', VIEWS . 'layouts' . DIRECTORY_SEPARATOR);
define('DEFAULT_LAYOUT', 'default');
define('SITE_TITLE', 'default');
define('LOGGEDUSER', 'LoggedUserSession');

$modules = [
    ROOT,
    APP,
    CORE,
    CONTROLLERS,
    VIEWS,
    MODELS,
    CLASSES
];
$namespaces = [
    'Core' => [
        'Core',
        'Core\Classes'
    ],
    'Controllers' => [
        'Controllers'
    ]
];

set_include_path(get_include_path() . PATH_SEPARATOR . implode(PATH_SEPARATOR, $modules)); // instruerar php att de directories där filer för detta projekt ska sökas efter finns inom de mapp som definerades med konstanter här ovan.
spl_autoload_register(function($className) {
    $className = str_replace("\\", DIRECTORY_SEPARATOR, $className);
    $include = $_SERVER['DOCUMENT_ROOT'] . '/libraryKommenterad/' . $className . '.php';
    try{
        include_once $include;
    } catch (Exception $e){
        die($include);
    }
}); // autloader för namespaced klasser, ger php en sista chans att hämta en fil innan programmet kraschar, try, catch borde fungera för php 7.3
// require_once 'core/Router.php';
// require_once 'core/App.php';
// require_once 'core/View.php';
// require_once 'core/Controller.php';
// require_once 'core/DBController.php';
// require_once 'core/classes/Input.php';
// require_once 'core/Validator.php';
// require_once 'database.php';
function dd($var)
{
    var_dump($var);
    die();
} // en funktion som fanns i laravel och som jag måsta ha använt mer än en tusen gång under debugging
$container = new \App\Core\Container(); // en global container defineras för att konfigurera dependency injection.
$container->set(\App\Core\Router::class, true); // true för att ha ett enda objekt för hela programmet
$container->set(\App\Core\Classes\Redirect::class, true);
$container->set(\App\Core\Validator::class, true);
$container->set(\App\Controllers\HomeController::class); // det behövs inte att använda set funktionen för att få container att resolvera dependencies för klassen, om man inte använder singleton funktionaliteten
$container->set(\App\Controllers\loginController::class);
$container->set(\App\Models\User::class);
$container->set(\App\Models\Book::class);
$container->set(\App\Models\UsersBooksMany::class);

ini_set('xdebug.var_display_max_depth', '10');
ini_set('xdebug.var_display_max_children', '256');
ini_set('xdebug.var_display_max_data', '1024');