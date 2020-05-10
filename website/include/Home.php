<?php  
session_start();

$username = "dbi427262";
$password = "parola1234";
if(isset($_SESSION['username']))  
 {  
      echo '<h3>Login Success, Welcome - ' . $_SESSION['username'] . '</h3>';  
 }  
 
 ?> 
<!DOCTYPE html>
<html>

<head>
  <link rel="stylesheet" type="text/css" href="../Styles.css">

</head>

<body>
<?php include('NavBar.php');
?>
 
<div class="nextShift">

<h1>Your next shift is going to be on :</h1>
</div>
<div class ="annoucements"> 
<h1>Annoucemnts!</h1>
<?php
$conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi427262", $username,  $password);
$conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

$sql = "SELECT title AS title, text AS text FROM announcement";
$sth = $conn->prepare($sql);
$sth->execute();
$succ = $sth->rowCount();
if ($succ > 0)
{
    $result = $sth->fetchAll();
    // output data of each row
    foreach($result as $row) {
        echo "<br> Title: ". $row['title']. " - Name: ". $row['text'] . "<br>";
    }
} else {
    echo "0 results";
}

$conn=null;
// $conn = new mysqli("studmysql01.fhict.local", $username,  $password);
// // Check connection
// if ($conn->connect_error) {
//     die("Connection failed: " . $conn->connect_error);
// }

// $sql = "SELECT title, text FROM announcement";
// $result = $conn->query($sql);

// if ($result->num_rows > 0) {
//     // output data of each row
//     while($row = $result->fetch_assoc()) {
//         echo "<br> Title: ". $row["title"]. " - Name: ". $row["text"] . "<br>";
//     }
// } else {
//     echo "0 results";
// }

// $conn->close();
?>

</div>
</body>
</html>

