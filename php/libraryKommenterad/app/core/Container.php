<?php

namespace App\Core
{
    class Container
    {
        protected $resolved = [];
        protected $instances = [];

        public function set($abstract, $singelton = false, $concrete = null)
        {
            if ($concrete === null) {
                $concrete = $abstract;
            }
            $this->instances[$abstract] = [
                'concrete' => $concrete,
                'singelton' => $singelton
            ];
        } // håller en rekord över klasser, onödig om klassen inte ska ha singleton

        public function get($abstract, $parameters = [])
        {
            if (!isset($this->instances[$abstract])) {
                $this->set($abstract);
            }
            if ($this->instances[$abstract]['singelton']){
                if ($this->containsInstance($abstract)){
                    return $this->resolved[$abstract];
                } 
            }
            return $this->resolve($abstract, $parameters);
        } // kallar resolve

        public function resolve($abstract, $parameters)
        {
            $concrete = $this->instances[$abstract]['concrete'];
            if ($concrete instanceof \Closure) {
                return $concrete($this, $parameters);
            }
            $reflector = new \ReflectionClass($concrete);
            if (!$reflector->isInstantiable()){
                throw new \Exception("Class {$concrete} is not instantiable");
            }
            $new_instance = '';
            $constructor = $reflector->getConstructor();
            if (is_null($constructor)){
                $new_instance = $reflector->newInstance();
            } else{
                $parameters   = $constructor->getParameters();
                $dependencies = $this->getDependencies($parameters);
                $new_instance = $reflector->newInstanceArgs($dependencies);
            }
            if ($this->instances[$abstract]['singelton']){
                $this->resolved[$abstract] = $new_instance;
            }
            return $new_instance;
        } // resolve använder reflection för att få constructor, ha paremeterar, av vilka kan vara också objekt som resolveras i sin tur genom funktionen getDependencies

        public function getDependencies($parameters)
        {
            $dependencies = [];
            foreach ($parameters as $parameter) {
                $dependency = $parameter->getClass(); // type hinting är absolut nödvändig för att kunna determinera vilken klass det handlar om
                if ($dependency === NULL) {
                    if ($parameter->isDefaultValueAvailable()) {
                        $dependencies[] = $parameter->getDefaultValue();
                    } else {
                        throw new \Exception("Can not resolve class dependency {$parameter->name}"); // parametrar som inte är object eller som saknar default values kan inte resolveras och då inte heller kan dependency injection göras
                    }
                } else {
                    $dependencies[] = $this->get($dependency->name);
                }
            }
            return $dependencies;
        }

        protected function containsInstance($abstract)
        {
            foreach ($this->resolved as $entry){
                if ($entry instanceof $this->instances[$abstract]['concrete'] && !is_subclass_of($entry, $this->instances[$abstract]['concrete'])){
                    return true;
                }
            }
            return false;
        } // kollar om container har redan en instans av ett singleton objekt
    }
}