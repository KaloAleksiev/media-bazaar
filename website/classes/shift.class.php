<?php

class Shift
{
    public $userId;
    public $date;
    public $type;
    public $position;
    public $firstName;
    public $lastName;
    public $departmentId;

    public function __construct($userId, $date, $type, $position)
    {
        $this->userId = $userId;
        $this->date = $date;
        $this->type = $type;
        $this->position = $position; 
    }

    public function getDate()
    {
        return $this->date;
    }
    
    public function setFirstName($name)
    {
        $this->firstName = $name;
    }

    public function getFirstName()
    {
        return $this->firstName;
    }

    public function setLastName($name)
    {
        $this->lastName = $name;
    }

    public function getLastName()
    {
        return $this->lastName;
    }

    public function setDepartmentId($depId)
    {
        $this->departmentId = $depId;
    }

    public function getDepartmentId()
    {
        return $this->departmentId;
    }
}

?>