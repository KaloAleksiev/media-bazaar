<?php  
session_start();
$username = "dbi427262";
$password = "parola1234";
 if(isset($_SESSION['name']))  
 {  
      echo '<h3>Login Success, Welcome - ' . $_SESSION['name'] . '</h3>';  
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

<h1>Your next shift is going to be on :
<?php
$username = "dbi427262";
$password = "parola1234";
$now = new DateTime();
$conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi427262", $username,  $password);
$conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
//next shift
$sql = "SELECT 	MIN(shift.date) as date
FROM	shift_user
INNER 	JOIN shift	ON shift.shift_id = shift_user.shift_id
WHERE	shift_user.user_id = '".$_SESSION['user_id'] ."'";
 $sth = $conn->prepare($sql);
 $sth->execute();
 $succ = $sth->rowCount();
if ($succ > 0)
{
    $result = $sth->fetchAll();
   // output data of each row
    foreach($result as $row)
     {
        echo "<br> ". $row['date'] . "<br>";
    }
 } else {
     echo "0 results";
 }
//end next shift
$conn=null;
?>
</h1>
</div>

<div class ="annoucements"> 
<h1>Announcements</h1>
<?php
$now = new DateTime();
$conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi427262", $username,  $password);
$conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

$sql = "SELECT title AS title, text AS text FROM announcement WHERE end_date > DATE_SUB(CURRENT_TIMESTAMP, INTERVAL 1 DAY)";
$sth = $conn->prepare($sql);
$sth->execute();
$succ = $sth->rowCount();
if ($succ > 0)
{
    $result = $sth->fetchAll();
    // output data of each row
    foreach($result as $row) {
        echo "<h4> Title: ". $row['title']. "       Description: ". $row['text'] . "</h4>";
    }
} else {
    echo "0 results";
}

$conn=null;

?>

</div>
</body>
</html>

