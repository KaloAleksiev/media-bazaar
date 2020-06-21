<?php 
session_start();
$username = "dbi427262";
$password = "parola1234"; 
$conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi427262", $username,  $password);
$conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
if(!empty($_POST["referal"]))
{
  $referal = trim(strip_tags(stripcslashes(htmlspecialchars($_POST["referal"]))));
  $sql = "SELECT * from user WHERE firstName LIKE :referal";
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
        <th> First Name </th>
        <th> Last Name </th>
      </tr>
      ";
      foreach ($result as $row)
      {
        echo  "
        <tr>
          <div class=\"tableCell\"><td> " . $row['id'] . "</td></div>
          <div class=\"tableCell\"><td> " . $row['firstName'] . " </td></div>
          <div class=\"tableCell\"><td> " . $row['lastName'] . " </td></div>
        </tr>
      ";
      }
      echo "</table>";
      $conn = null;
    }
}