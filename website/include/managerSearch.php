<?php
    session_start();
    $username = "dbi427262";
    $password = "parola1234"; 
    $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi427262", $username,  $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    $content;
    $result;
    $succ;
    $searchBar = '<input type="text" name="referal" placeholder="Search for employee..." value="" class="who"  autocomplete="off">';
    if (isset($_POST['referal']))
    {
      $searchBar = null;
      $referal = trim(strip_tags(stripcslashes(htmlspecialchars($_POST["referal"]))));
      $sql = "SELECT * from user WHERE firstName LIKE :referal";
      $sth = $conn->prepare($sql);
      $sth->execute([':referal'=> "%" . $referal . "%"]);
      $succ = $sth->rowCount();
      $result = $sth->fetchAll();
    }
    else
    {
      $sql = "SELECT * FROM user";
      $sth = $conn->prepare($sql);
      $sth->execute();
      $succ = $sth->rowCount();
      $result = $sth->fetchAll();
    }
      
     if ($succ > 0)
     {
        $content = "
        <table>
        <tr>
          <th> ID </th>
          <th> First Name </th>
          <th> Last Name </th>
          <th> Position </th>
          <th> Phone Number </th>
        </tr>
        ";
        foreach ($result as $row)
        {
          $content .= "
          <tr>
          <div class=\"tableCell\"><td> " . $row['id'] . "</td></div>
          <div class=\"tableCell\"><td> " . $row['firstName'] . " </td></div>
          <div class=\"tableCell\"><td> " . $row['lastName'] . " </td></div>
          <div class=\"tableCell\"><td> " . $row['position'] . " </td></div>
          <div class=\"tableCell\"><td> " . $row['phone_number'] . " </td></div>
          </tr>
        ";
        }
        $content .= "</table>";
     }
     else
     {
        $content = "No such employee.";
     }
?>

<!DOCTYPE html>
<html>
  <head>
    <link rel="stylesheet" type="text/css" href="../Styles.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="../searchEmployee.js"></script>
  </head>
  <body>
    <?php include('Navbar.php'); ?>
    <?php echo $searchBar; ?>
    <ul class="search_result"> 
      <?php echo $content; ?>
    </ul>
    
    
  </body>
</html>