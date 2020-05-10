<?php
        $username = "dbi427262";
        $password = "parola1234"; 
        $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi427262", $username,  $password);
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        if(!empty($_POST["referal"]))
        {
            $referal = trim(strip_tags(stripcslashes(htmlspecialchars($_POST["referal"]))));
            $sql = "SELECT name AS name from item WHERE name LIKE :referal";
            $sth = $conn->prepare($sql);
            $sth->execute([':referal'=> "%" . $referal . "%"]);
            $succ = $sth->rowCount();
            if ($succ > 0)
            {
              $result = $sth->fetchAll();
              foreach ($result as $row)
              {
                echo "\n<li>".$row["name"]."</li>";
              }
            }
        }
      ?>