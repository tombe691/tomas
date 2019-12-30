<?php 
// collection ger möjlighet att bifoga, attach, frikoppla, detach modeller från en huvudmodells som här är owner elemet
namespace App\Core\Classes
{
    use App\Core\ManyToManyController;

    class Collection
    {
        protected $elements,
                  $owner;  

        public function __construct($array, $owner)
        {
            $this->elements = $array;
            $this->owner = $owner;
        }

        public function each($callback)
        {
            foreach ($this->elements as $key => $value){
                $callback($value, $key);
            }
            return $this;
        }

        public function reverse()
        {
            return $this->createNew(array_reverse($this->elements));
        }

        public function attach($object, $params = [])
        {
            if (empty($this->elements) || (!empty($this->elements) && $object instanceof $this->elements[array_keys($this->elements)[0]])){
                if (!empty($object->object_tracker)){
                    $object->save(); // om objektet finns inte i databasen eller om det har tillförts några ändringar, spara dessa
                }
                if (isset(ManyToManyController::$relations[$this->owner->model])){
                    global $container;
                    $relation = $container->get(ManyToManyController::$relations[$this->owner->model]['model']);
                    //$relation->first_model = $this->owner;
                    $relation->setFirstModel($this->owner);
                    //$relation->second_model = $object;
                    $relation->setSecondModel($object);
                    //$relation->first_key = ManyToManyController::$relations[$this->owner->model][$this->owner->model];
                    $relation->setFirstKey(ManyToManyController::$relations[$this->owner->model][$this->owner->model]);
                    //$relation->second_key = ManyToManyController::$relations[$this->owner->model][$object->model];
                    $relation->setSecondKey(ManyToManyController::$relations[$this->owner->model][$object->model]);
                    $relation->instantiate('something');
                    if ($params){ // params kan vara andra fält i relationstabellen än de foregin key constraints som status
                        if ($this->isNested($params)){
                            foreach ($params as $entry){
                                $relation->object[$entry[0]] = $entry[1];
                            }
                        } else{
                            $relation->object[$params[0]] = $params[1];
                        }
                    }
                    $relation->save('something');
                    $this->owner->relationships[$relation->object['id']] = $relation;
                    $object->relationships[$relation->object['id']] = $relation;
                }
            }
        } // attach bara lägger in en ny rad/objekt i relaitonstabellen

        public function detach($object)
        {
            if ($object instanceof $this->elements[array_keys($this->elements)[0]]){
                if (is_array($object->relationships)){
                    foreach ($object->relationships as $relation){
                        if (($relation->getFirstModel())->id == $this->owner->id){
                            unset($this->owner->relationships[$relation->object['id']]);
                            unset($object->relationships[$relation->object['id']]);
                            $this->elements = $this->remove($object);
                            $relation->delete();
                        }
                    }
                }
            }
        } // detach bara tar bort raden/objektet från relationstabellen

        // några ytterliga funktioner för collection
        
        public function all()
        {
            return array_values($this->elements);
        }

        public function filterNot($callable = '')
        {
            return $this->filterInternal($callable, false);
        }

        public function filter($callable = '')
        {
            return $this->filterInternal($callable, true);
        }

        protected function filterInternal($callable, $keep)
        {
            if ($callable){
                $new_array = array();
                foreach ($this->elements as $element){
                    if ($keep !== call_user_func($callable, $element)){
                        continue;
                    }
                    $new_array[] = $element;
                }
                return $this->createNew($new_array, $this->owner);
            }
            return $this->createNew(array_filter($this->toArray($this)), $this->owner);
        }

        protected function createNew($elements, $owner = '')
        {
            if (!$owner){
                $owner = $this->owner;
            }
            return new static($elements, $owner);
        }
    
        public function keys()
        {
            return $this->createNew(array_keys($this->elements), $this->owner);
        }

        public function values()
        {
            return $this->createNew(array_values($this->elements), $this->owner);
        }

        public function remove($element)
        {
            return array_filter($this->elements, function ($value) use($element){
                return ($value->object['id'] != $element->object['id']);
            });
        }

        public function map($callback)
        {
            $keys = $this->keys()->all();
            $results = array_map($callback, $this->elements, $keys);
            return $this->createNew(array_combine($keys, $results), $this->owner);
        }

        public function first()
        {
            if (count($this->elements)){
                $array = $this->elements;
                $element = $this->filterInternal(function ($value) use ($array){
                    return (array_search(array_search ($value, $array), array_keys($array)) === 1);
                }, false);
                return $element->toArray()[array_keys($element->toArray())[0]];
            }
            return false;
        }

        public function last($count = 0)
        {
            if (count($this->elements)){
                if (!$count){
                    $lastKey = key(array_slice($this->elements, -1, 1, true));
                    return $this->elements[$lastKey];
                }
                return array_slice($this->elements, -$count, -$count, true);
            }
            return false;
        }

        public function toArray()
	    {
            return $this->elements;
        }

        public function isNested($array) 
        {
            foreach ($array as $entry) {
                if (is_array($entry)) return true;
            }
            return false;
        }
    }
}