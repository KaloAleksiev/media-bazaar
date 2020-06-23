<?php

class Department
{
    public $departmentId;
    public $departmentName;
    public $color;

    public function __construct($departmentId, $departmentName)
    {
        $this->departmentId = $departmentId;
        $this->departmentName = $departmentName;
        $this->setDepartmentColor();
    }

    public function setDepartmentId($depId)
    {
        $this->departmentId = $depId;
    }

    public function getDepartmentId()
    {
        return $this->departmentId;
    }

    public function setDepartmentColor()
    {
        $this->color = sprintf( '#%02X%02X%02X', rand(0, 255), rand(0, 255), rand(0, 255) );
    }

    public function getDepartmentColor()
    {
        return $this->color;
    }

    public function setDepartmentName($depName)
    {
        $this->departmentName = $depName;
    }

    public function getDepartmentName()
    {
        return $this->departmentName;
    }
}