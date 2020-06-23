<?php

class DepartmentControl
{
    public $departments = array();

    public function __construct()
    {
        $this->departments = $this->getDepartmentsFromDatabase();
    }

    public function getDepartmentsFromDatabase()
    {
        $servername = 'studmysql01.fhict.local';
        $uid = 'dbi427262';
        $pid = 'parola1234';

        try {
            $conn = new PDO("mysql:host=$servername;dbname=dbi427262", $uid, $pid);
            $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        }
        catch(PDOException $e){
            var_dump("Database connection failed to execute.");
        }

        $query = $conn->prepare("SELECT department_id AS id, name FROM department");
        $query->execute();
        $result = $query->fetchAll();
        $allDepartments = array();
        foreach ($result as $item) {
            $dep = new Department($item["id"],$item["name"]);
            array_push($allDepartments, $dep);
        }

        return $allDepartments;
    }

    public function getDepartments()
    {
        return $this->departments;
    }

    public function getDepartmentById($id)
    {
        foreach ($this->departments as $dep)
        {
            if ($dep->departmentId == $id)
            {
                return $dep;
            }
        }
    }
}