<?php
// klassen ligger till grund för kommunicering med databasen, skapande av modeller, och representation av för nu many-to-many relationer
namespace App\Core
{
    use App\Core\Classes\INotifyPropertyChanged;
    use App\Core\Classes\Collection;

    class DBController implements INotifyPropertyChanged
    {
        public  $changes, 
                $track_changes;
        
        public $pdo,
                $table, 
                $query, // lagrar query som samlas av de olika funktionerna som where, in, notIn...
                $qurey_params = [], // här lagras values för queries för en eventuell bindning i query funktionen
                $where = 'WHERE',
                $error = false, 
                $result = null, 
                $count = 0,
                $object,
                $object_tracker,
                $object_map, // map innehåller en karta över varje fält/egenskap i tabellen/modellen
                $identifier = false, // identifier samlar på sig väsentlig informaion som är unik för en rad/ett objekt, detta är främst id då
                $updated,
                $model,
                $relationships;

        private $callback, 
                $condTypes = ['AND', 'OR'];

        protected $s = false;

        public function __construct($table, $model = '')
        {
            $this->table = $table;
            $this->track_changes = true;
            try{
                $this->pdo = new \PDO('mysql:host=localhost;dbname=library;', 'marcus', 'setTrimmedpass');
                if ($model != ''){
                    $this->model = $model;
                    $this->objBootstrap();
                }
            } catch (\PDOException $exception){
                die($exception->getMessage());
            }
        } // jag har använt pdo istället för mysql(i), för den möjligheten att den kan forma datan från tabellen i stdClasser och lämna modeller, dock har den funktionaliteten aldrig använts, istället gör jag fetch_associative,
          // så pdo eller mysqli skulle vara bra för uppgiften

        public static function arrayToObject(array $array, $className) {
            return unserialize(sprintf(
                'O:%d:"%s"%s',
                strlen($className),
                $className,
                strstr(serialize($array), ':')
            ));
        } // konverterar en array till en stdObject som sedan serialiseras till den modell du vill, har hittat den på stackoverflow, och den kom aldrig att användas

        public static function objectToObject($instance, $className) {
            return unserialize(sprintf(
                'O:%d:"%s"%s',
                strlen($className),
                $className,
                strstr(strstr(serialize($instance), '"'), ':')
            ));
        } // en stdObject till en objekt med rikting klass, en modell

        public function PropertyChanged($name)
        {
            if($this->callback != null){
                call_user_func($this->callback, $name);
            }
            if(!isset($this->changes)){
                $this->changes = Array();
            }
            if(!in_array($name, $this->changes)){
                $this->changes[$name][count($this->changes[$name])] = $this->$name;
            } else {
                $this->changes[$name][count($this->changes[$name])] = $this->$name;
            }
        } // implemenationen för min interface från .Net 

        public function __set($name, $value) 
        { 
            global $container;
            if (array_key_exists($name, $this->object)){
                if (($container->get(Validator::class))->parseValidate($value, $this->object_map[$name])){
                    $prev = $this->$name;
                    if($this->track_changes && $prev !== $value) {         
                        $this->PropertyChanged($name);
                        $this->object[$name] = $value;
                        $this->setUpdated(true);
                        $this->object_tracker[$name] = 'updated';
                    }
                }
            }
        } // setters som spårar ändringar i objektens värde för en eventuell save

        public function __get($name) 
        { 
            if(array_key_exists($name, $this->object)){
                return $this->object[$name];
            }
            return null;
        } // getters för att hämta värden

        public function addProperty($name, $value = '')
        {
            if (!array_key_exists($name, $this->object)){
                $this->object[$name] = $value;
            }
        }

        public function query($sql_in = '', $param_value_array_in = [])
        {
            $this->where = 'WHERE';
            $this->error = false;
            $this->result = null;
            $this->count = 0;
            $sql = (empty($sql_in)) ? $this->query : $sql_in;
            if (preg_match('/(\'\?\')/', $sql) || preg_match('/(\'\%\?\%\')/', $sql)){ // regex tar bort ' från '?' för att prepared statements ska kunna bindas
                $sql = preg_replace('/\'/', '', $sql);
            }
            if (preg_match('/[\p{L}]+\.[\p{L}]+/', $sql)){
                $sql = preg_replace('/\`/', '', $sql); // även ` från `field` tas bort om det finns många tabeller vid sql join
            }
            if ($stmt = $this->pdo->prepare($sql)){
                $param_value_array = (empty($param_value_array_in)) ? $this->qurey_params : $param_value_array_in;
                /* if ($this->s){
                    var_dump($param_value_array);
                    dd($sql);
                } */
                if (!empty($param_value_array)){
                    $x = 1;
                    foreach ($param_value_array as $param){
                        $stmt->bindValue($x, $param);
                        $x++;
                    }
                }
                if ($stmt->execute()){
                    $this->result = $stmt->fetchAll(\PDO::FETCH_ASSOC);
                    $this->count = $stmt->rowCount();
                } else{
                    $this->error = true;
                }
            }
            $this->query = '';
            $this->qurey_params = [];
            return $this;
        } // den huvudsakliga funktionen varigenom alla queries mot databasen går

        public function objProperties($optionals = false)
        {
            $sql = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'library' AND TABLE_NAME = '{$this->table}'";
            if ($optionals){
                $sql .= "AND IS_NULLABLE='YES'";
            }
            $this->query($sql);
            return $this;
        } // ger data för object

        public function tableProperties()
        {
            $sql = "EXPLAIN {$this->table};  DESCRIBE {$this->table}; SHOW FIELDS FROM {$this->table}; SHOW COLUMNS FROM {$this->table};";
            $this->query($sql);
            return $this;
        } // ger data för object_map, onödigt eftersom en query har redan genomförts av objProperties, men som sagt i rapporten, jag är inte efter maximerad prestanda

        public function objBootstrap()
        {
            $this->objProperties();
            $all_props = array_fill_keys(array_column($this->result, 'COLUMN_NAME') , '');
            $this->objProperties(true);
            $optional_props = array_fill_keys(array_column($this->result, 'COLUMN_NAME') , '');
            $required_props = array_diff_key($all_props, $optional_props);
            unset($required_props['created_at'], $required_props['updated_at']);
            unset($all_props['created_at'], $all_props['updated_at']);
            $this->object = $all_props;
            $this->tableProperties();
            $optional_keyed_props = [];
            $required_keyed_props = [];
            if ($this->s){
                var_dump($this);
                dd($this->result);
            }
            foreach ($this->result as $res){
                if ($res['Null'] == 'YES'){
                    $optional_keyed_props[$res['Field']] = (!empty($res['Key'])) ? 'key:' . $res['Key'] . '|' : '';
                    $optional_keyed_props[$res['Field']] .= (!empty($res['Type'])) ? 'type:' . $res['Type'] . '|' : '';
                    $optional_keyed_props[$res['Field']] .= (!empty($res['Default'])) ? 'default:' . $res['Default'] . '|' : '';
                    $optional_keyed_props[$res['Field']] .= 'required:optional|';
                } else{
                    $required_keyed_props[$res['Field']] = (!empty($res['Key'])) ? 'key:' . $res['Key'] . '|' : '';
                    $required_keyed_props[$res['Field']] .= (!empty($res['Type'])) ? 'type:' . $res['Type'] . '|' : '';
                    $required_keyed_props[$res['Field']] .= (!empty($res['Default'])) ? 'default:' . $res['Default'] . '|' : '';
                    $required_keyed_props[$res['Field']] .= 'required:required|';
                }
            }
            $this->object_map = array_merge($optional_keyed_props, $required_keyed_props);
            unset($this->object_map['created_at'], $this->object_map['updated_at']);
            $this->object_tracker = array_fill_keys($this->object, '');
        } // skapar object och object_map

        private function action($action, $cond = [])
        {
            if (count($cond) == 3){
                $operators = ['=', '>', '<', '>=', '<='];
                $fieled = $cond[0];
                $operator = $cond[1];
                $value = $cond[2];
                if (in_array($operator, $operators)){
                    $sql = "{$action} FROM " . $this->table . " WHERE `{$fieled}` {$operator} ?";
                    $this->query($sql, [$value]);
                }
            } else{
                // inga prepared statements har, för det är vanligen id, created_at fält som kommer in från identifier
                $sql = "{$action} FROM " . $this->table . " WHERE";
                $x = 1;
                foreach ($this->identifier as $field => $value){
                    if (is_numeric($value)){
                        $sql .= " {$field} = {$value}";
                    } else{
                        $sql .= " {$field} = '{$value}'";
                    }
                    if ($x < count($this->identifier)){
                        $sql .= ' AND';
                    }
                    $x++;
                }
                $this->qurey_params = [];
                $this->query = '';
                $this->query($sql);
            }
            return $this;
        } // delete och update använder sig av action

        public function insert($data = [])
        {
            $fields = array_keys($data);
            $values = '';
            $x = 1;
            foreach ($fields as $field){
                $values .= "'?',";
                if ($x == count($fields)){
                    $values = substr($values, 0, -1);
                }
                $x++;
            }
            $sql = "INSERT INTO " . $this->table . " (`" . implode("`,`", $fields) . "`) VALUES ($values)";
            $this->query($sql, array_values($data));
            return $this;
        }

        public function update($cond = [[]], $data = [])
        {
            $set = '';
            $x = 1;
            foreach ($data as $field => $value){
                $set .= "`$field`='?',";
                if ($x == count($data)){
                    $set = substr($set, 0, -1);
                }
                $x++;
            }
            $and = $cond[0];
            $or = $cond[1];
            $where = '(';
            $x = 1;
            foreach ($and as $field => $value){
                $where .= "`$field`='?' AND ";
                if ($x == count($and)){
                    $where = substr($where, 0, -5);
                    $where .= ")";
                }
                $x++;
            }
            $x = 1;
            foreach ($or as $field => $value){
                if ($x == 1){
                    $where .= ' OR (';
                }
                $where .= "`$field`='?' AND ";
                if ($x == count($or)){
                    $where = substr($where, 0, -5);
                    $where .= ')';
                }
                $x++;
            }
            $sql = "UPDATE " . $this->table . " SET $set WHERE $where";
            $values = array_merge(array_values($data), array_merge(array_values($and), array_values($or)));
            if (!$this->query($sql, $values)->error()){
                return true;
            }
            return false;
        } // update verkar vara komplicerad, men det är inget mer än enkla sträng manipulationer och formateringar 

        public function where($field, $operator, $value = false)
        {
            if($value === false){
                $value = $operator;
                $operator = '=';
            }
            $this->query .= " {$this->where} `{$field}` {$operator} '?'";
            $this->qurey_params[] = $value;
            $this->where = 'AND';
            return $this;
        } // en av de metoder som kan länkas på varandra, dessa samlar sina query i egenskapen query och de motsvarande values i samma ordning de förekommer i query i query_params

        // de kommande funktionerna säger sig själva och behöver inga kommentarer, upp till belongsToMany
        public function parseWhere($cond = [], $type = "AND")
        {
            $this->query .= " {$type} (";
            foreach ($cond as $con => $rule){
                if(is_array($rule)){
                    if (is_numeric($con)){
                        $this->query .= " `{$rule[0]}` {$rule[1]} '?' ";
                        $this->qurey_params[] = $rule[2];
                    }
                    else{
                        if ($this->isCond($con)){
                            $this->query .= " $con `{$rule[0]}` {$rule[1]} '?' ";
                            $this->qurey_params[] = $rule[2];
                        }
                    }
                }
                else{
                    $this->query .= " `{$cond[0]}` {$cond[1]} '?' ";
                    $this->qurey_params[] = $cond[2];
                    break;
                }	
            }
            $this->query .= ")";
            return $this;
        }

        public function whereBetween($field, $values = [])
        {
            if(count($values)){
                $this->query .= " {$this->where} `{$field}` BETWEEN '{$values[0]}' AND '?'";
                $this->qurey_params[] = $values[1];
                $this->where = "AND";
            }
            return $this;
        }

        public function likeWhere($field, $value)
        {
            $this->query .= " {$this->where} `{$field}` LIKE '%?%'";
            $this->qurey_params[] = $value;
            $this->where = "AND";
            return $this;
        }

        public function orWhere($field, $operator, $value = false)
        {
            if($value === false){
                $value = $operator;
                $operator = "=";
            }
            $this->query .= " OR `{$field}` {$operator} '?'";
            $this->qurey_params[] = $value;
            $this->where = "AND";
            return $this;
        }

        public function andWhere($field, $operator, $value = false)
        {
            if($value === false){
                $value = $operator;
                $operator = "=";
            }
            $this->query .= " AND `{$field}` {$operator} '?'";
            $this->qurey_params[] = $value;
            $this->where = "AND";
            return $this;
        }
        
        public function in($field, $values = [])
        {
            if(!empty($values)){
                $value_subs = array_fill(0, count($values), '?');
                $this->query .= " {$this->where} `{$field}` IN ('" . implode("','", $value_subs) . "')";
                $this->qurey_params = array_merge($this->qurey_params, $values);
                $this->where = "AND";
            }
            return $this;
        }

        public function notIn($field, $values = [])
        {
            if(!empty($values)){
                $value_subs = array_fill(0, count($values), '?');
                $this->query .= " {$this->where} `{$field}` NOT IN ('" . implode("','", $value_subs) . "')";
                $this->qurey_params = array_merge($this->qurey_params, $values);
                $this->where = "AND";
            }
            return $this;
        }

        public function find($id)
        {
            $this->identifier['id'] = $id;
            return $this->where('id', $id)->first();
        }
        
        public function findBy($column, $value)
        {
            $this->identifier[$column] = $value;
            return $this->where($column, $value)->select();
        }

        public function findByMany($params)
        {
            $x = 0;
            foreach ($params as $param){
                $this->identifier[$param[0]] = $param[1];
                if ($x == 0){
                    $this->where($param[0], $param[1]);
                }
                $this->parseWhere([$param[0], '=', $param[1]]);
                $x++;
            }
            return $this->select();
        }

        public function select($fields = ['*'])
        {
            $sql = '';
            $from = '';
            if (count($fields) == 1 && $fields[0] == '*'){
                $sql = "SELECT ";
                $from = " FROM ";
            } else{
                $sql = "SELECT `";
                $from = "` FROM ";
            }
            $sql .= implode("`,`", $fields) . $from . $this->table . " {$this->query}";
            $this->query = $sql;
            $this->query();
            if (count($this->result)){
                // här skapas de object som matchar en query
                global $container;
                $objects = [];
                foreach ($this->result as $entry){
                    $object = $container->get($this->model);
                    if (!$this->identifier){
                        $this->identifier = [array_keys($entry)[1] => $entry[array_keys($entry)[1]]];
                    }
                    // data överförs för att göra fullständiga modeller
                    $object->identifier = array_merge(['id' => $entry['id']], $this->identifier);
                    $object->object = array_intersect_key($entry, $this->object);
                    $object->object_map =  $this->object_map;
                    $object->object_tracker = $this->object_tracker;
                    $objects[$entry['id']] = $object;
                    $this->identifier = false;
                }
                return new Collection($objects, $this);
            }
            return false;
        } // select är alltid den sista metoden i metod-chaining och den som anropar query och formaterar resultat

        public function updateWhere($values = [])
	    {
            $this->updated = false;
            $set = '';
            $x = 1;
            foreach($values as $field => $value) {
                $set .= "`{$field}`='?',";
                if ($x == count($values)){
                    $set = substr($set, 0, -1);
                }
                $x++;
            }
            $sql = "UPDATE {$this->table} SET {$set} " . $this->query;
            $this->query = $sql;
            $this->qurey_params = array_merge(array_values($values), $this->qurey_params);
            $this->query();
            $this->object_tracker = [];
            return $this;
        }
        
        public function save($s = '')
	    {
            global $container;
            if ($this->identifier === false){
                if (($container->get(Validator::class))->parseValidate($this->object, $this->object_map)){
                    $this->insert($this->object);
                    $this->object['id'] = $this->lastInsertedId();
                    $this->identifier['id'] = $this->object['id'];
                    return $this->error;
                } else {
                    $this->error = true;
                    return ($container->get(Validator::class))->errors;
                }
            }
            if ($this->identifier && $this->updated){
                $x = 1;
                $this->query = "WHERE";
                foreach($this->identifier as $field => $value){
                    $this->query .= " `{$field}` = '?'";
                    if($x < count($this->identifier)) {
                        $this->query .= " AND";
                    }
                    $x++;
                }
                $this->qurey_params = array_merge($this->qurey_params, array_values($this->identifier));
                $updated_object = array_intersect_key($this->object, array_filter($this->object_tracker));
                return $this->updateWhere($updated_object);
            }
	    } // save har två funktioner, den ena är insert, om objektet harstämmar från koden och inte databasen och den andra att spara ändringar på objekt som har motsvarigheter i tabeller

        public function first()
        {
            $result = $this->select();
            if($result){
                return $result->first();
                /* if (isset($this->model)){
                    $this->identifier = array_merge(['id' => $result[0]['id']], $this->identifier);
                    $this->object = array_intersect_key($result[0], $this->object);
                    return $this;
                } */
            }
            return [];
        }
        
        public function last($count = 0)
        {
            $reverse = array_reverse($this->result());
            if(!$count){
                return isset($reverse[0]) ? $reverse[0] : [];
            }
            $lastRecords = [];
            $j = 0;
            for($i = 0; $i < $count; $i++){
                $lastRecords[$j] = $reverse[$i];
                $j++;
            }
            return $lastRecords;
        }

        public function foreach(callable $callback)
        {
            foreach ($this->result as $key => $value){
                $callback($key, $value);
            }
            return $this;
        }

        public function filter(callable $callback = null)
        {
            if($callback){
                return array_filter($this->result, $callback);
            }
            return array_filter($this->result);
        }

        public function merge($items = [])
        {
            $this->result = array_merge($this->result, $items);
            return $this;
        }

        public function get($cond = [])
        {
            return $this->action('SELECT *', $cond);
        }

        public function delete($cond = [])
        {
            if (!$cond){
                if (count($this->identifier) >= 2 || isset($this->identifier['id'])){
                    return $this->action('DELETE');
                }
                return false;
            }
            return $this->action('DELETE', $cond);
        } // delete har också två funktioner, en av dem att ta bort en rad annan än objectens själv, och den andra att ta bort objekten själv

        public function lastInsertedId()
        {
            return $this->pdo->lastInsertId();
        }

        private function isCond($cond)
        {
            return in_array(strtoupper($cond), $this->condTypes);
        }

        public function belongsToMany($model, $mutual_table = '', $first_key = '', $second_key = '')
        {
            $first_table = rtrim($this->table, 's');
            $first_key = ($first_key) ?: "{$first_table}_id";
            $second_table = rtrim($model->table, 's');
            $second_key = ($second_key) ?: "{$second_table}_id";
            $mutual_table = ($mutual_table) ?: "{$this->table}_{$model->table}";
            $this->where = "WHERE";
            $this->qurey_params = [];
            $this->query = "SELECT {$this->table}.id as {$first_key}, {$model->table}.id as {$second_key} FROM {$this->table}";
            $this->join($mutual_table, ["{$this->table}.id", '=', "{$mutual_table}.{$first_key}"])
                ->join($model->table, ["{$mutual_table}.{$second_key}", '=', "{$model->table}.id"])
                ->parseWhere(["{$this->table}.id", '=', $this->id])
                ->orderBy("{$this->table}.id")
                ->query();
            $objects = [];
            if (count($this->result)){
                foreach ($this->result as $entry){
                    $objects[$entry[$second_key]] = $model->model::findUser($entry[$second_key]);
                }
            }
            $property_name = debug_backtrace()[1]['function'];
            $this->addProperty($property_name, new Collection($objects, $this));
            $mutual_class = 'App\Models\\' . preg_replace('/\s+/', '', ucwords(preg_replace('/\_/', ' ', $mutual_table))) . 'Many';
            foreach ($objects as $object){
                $relationship = ($mutual_class::findByUser([
                    [$first_key, $this->object['id']],
                    [$second_key, $object->object['id']]
                ]))->toArray();
                // de objekt som finns i modellen som slutar på Many härstammar från relationstabellen
                $relationship = $relationship[array_keys($relationship)[0]];
                $relationship->setFirstModel($this);
                $relationship->setSecondModel($object);
                $relationship->setFirstKey($first_key);
                $relationship->setSecondKey($second_key);
                //$relationship->first_model = $this;
                //$relationship->second_model = $object;
                //$relationship->first_key = $first_key;
                //$relationship->second_key = $second_key;
                $relationship->instantiate();
                $this->relationships[$relationship->object['id']] = $relationship;
                $object->relationships[$relationship->object['id']] = $relationship;
            }
            if (!count($objects)){
                $mutual_class::instantiateStatic($first_key, $second_key, $this->model, $model->model, $mutual_class); // om det finns inga objekt kallas den statiska intiatateStatic
            }
            return $this->object[$property_name];
            /* $stmt = $this->pdo->prepare("SELECT users.id as user_id, books.id as book_id
            FROM users
            INNER JOIN users_books
            ON users.id = users_books.user_id
            INNER JOIN books
            ON users_books.book_id = books.id
            ORDER BY books.title");
            $stmt->execute();
            $res = $stmt->fetchAll(\PDO::FETCH_ASSOC); */
            /* "SELECT users.id as user_id, books.id as book_id
            FROM users
            INNER JOIN users_books
            ON users.id = users_books.user_id
            INNER JOIN books
            ON users_books.book_id = books.id
            ORDER BY books.title" */
        } // belongsToMany har varit den stora utmaningen i den klassen och utför ett par join statements för att få id fält associerade med modellen

        public function join($table, $condition = [], $join = 'inner')
	    {
            $this->query .= " " . strtoupper($join) . " JOIN {$table} ON {$condition[0]} {$condition[1]} {$condition[2]}";
            return $this;
        }

        public function all()
        {
            $this->query = '';
            $this->qurey_params = [];
            return $this->select();
        }

        public function orderBy($field)
        {
            $this->query .= " ORDER BY {$field}";
            return $this;
        }
        
        public function result()
        {
            return $this->result;
        }

        public function error()
        {
            return $this->error;
        }

        public function count()
        {
            return $this->count;
        }

        public function updated()
        {
            return $this->updated;
        }

        public function setUpdated($value)
        {
            if ($this->identifier !== false){
                $this->updated = $value;
            } else{
                $this->updated = false;
            }
        }

        public function toJson()
        {
            return json_encode($this->result);
        }

        public function __toString()
        {
            return $this->toJson();
        }

        public function RegisterChangeCallback($callback) 
        { 
            $this->callback = $callback;
        }
        
        public function setTable($table)
        {
            if ($this->table != $table){
                $this->table = $table;
            }
        }

        public function getTable()
        {
            return $this->table;
        }
        
        public function __destruct()
        {
            $this->pdo = null;
        }
    }
}