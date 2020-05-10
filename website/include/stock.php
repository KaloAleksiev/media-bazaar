<?php
    $_SESSION["foundItems"] = "nothing";
    $username = "dbi427262";
    $password = "parola1234"; 
    $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi427262", $username,  $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    $content;
    $foundItems = $_SESSION["foundItems"];
    echo $_POST['referal'];
    $result;
    if (isset($_POST['referal']))
    {
      echo "<h1>Hello</h1>";
      $referal = trim(strip_tags(stripcslashes(htmlspecialchars($_POST["referal"]))));
      $sql = "SELECT * from item WHERE name LIKE :referal";
      $sth = $conn->prepare($sql);
      $sth->execute([':referal'=> "%" . $referal . "%"]);
      $succ = $sth->rowCount();
      $result = $sth->fetchAll();
    }
    else
    {
      echo "<h1>Hi</h1>";
      $sql = "SELECT * FROM item";
      $sth = $conn->prepare($sql);
      $sth->execute();
      $succ = $sth->rowCount();
      $result = $sth->fetchAll();
    }
      
     
      $content = "
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
        $content .= "
        <tr>
          <div class=\"tableCell\"><td> " . $row['item_id'] . "</td></div>
          <div class=\"tableCell\"><td> " . $row['name'] . " </td></div>
          <div class=\"tableCell\"><td> " . $row['description'] . " </td></div>
          <div class=\"tableCell\"><td> " . $row['department_id'] . " </td></div>
          <div class=\"tableCell\"><td> " . $row['amount_in_stock'] . " </td></div>
        </tr>
      ";
      }
      $content .= "</table>";
    $conn = null;
?>

<!DOCTYPE html>
<html>
  <head>
    <link rel="stylesheet" type="text/css" href="../Styles.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="../search.js"></script>
  </head>
  <body>
    <?php include('Navbar.php'); ?>
    <br> <br> <br> <br> <br>
    <input type="text" name="referal" placeholder="Search for items..." value="" class="who"  autocomplete="off">
    <div class="search_result"> 
    </div>
    
    <?php echo $content; ?>
    
    
  </body>
</html>