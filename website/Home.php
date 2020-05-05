

<?php  
session_start();
if(isset($_SESSION['username']))  
 {  
      echo '<h3>Login Success, Welcome - '.$_SESSION['username'].'</h3>';  
 }  
 
 ?> 
<!DOCTYPE html>
<html>

<head>
  <link rel="stylesheet" type="text/css" href="Styles.css">

</head>

<body>
<?php include('Navbar.php');
?>
 

 

 
<div class="nextShift">

<h1>Your next shift is going to be on :</h1>
</div>
<div class ="annoucements"> 
<h1>Annoucemnts!</h1>
<?php
$conn = new mysqli("studmysql01.fhict.local", "dbi427262", "parola1234","dbi427262");
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$sql = "SELECT title, text FROM announcement";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
        echo "<br> Title: ". $row["title"]. " - Name: ". $row["text"] . "<br>";
    }
} else {
    echo "0 results";
}

$conn->close();
?>
</div>
</body>
</html>