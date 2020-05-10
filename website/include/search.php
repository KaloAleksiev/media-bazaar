<?php
        $username = "dbi427262";
        $password = "parola1234"; 
        $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi427262", $username,  $password);
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        if(!empty($_POST["referal"]))
        {
          $referal = trim(strip_tags(stripcslashes(htmlspecialchars($_POST["referal"]))));
          $sql = "SELECT * from item WHERE name LIKE :referal";
          $sth = $conn->prepare($sql);
          $sth->execute([':referal'=> "%" . $referal . "%"]);
          $succ = $sth->rowCount();
            if ($succ > 0)
            {
              $result = $sth->fetchAll();
              $content = null;
              echo "
              <table>
              <tr>
                <th> ID </th>
                <th> Name </th>
                <th> Description </th>
                <th> Department </th>
                <th> Amount in stock </th>
              </tr>
              ";
              foreach ($result as $row)
              {
                echo  "
                <tr>
                  <div class=\"tableCell\"><td> " . $row['item_id'] . "</td></div>
                  <div class=\"tableCell\"><td> " . $row['name'] . " </td></div>
                  <div class=\"tableCell\"><td> " . $row['description'] . " </td></div>
                  <div class=\"tableCell\"><td> " . $row['department_id'] . " </td></div>
                  <div class=\"tableCell\"><td> " . $row['amount_in_stock'] . " </td></div>
                </tr>
              ";
              }
              echo "</table>";
              $conn = null;
            }
        }
      ?>