<?php

class Shift
{
    public $userId;
    public $date;
    public $type;
    public $position;

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
}

?>