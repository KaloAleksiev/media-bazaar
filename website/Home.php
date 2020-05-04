


<!DOCTYPE html>
<html>

<head>
  <link rel="stylesheet" type="text/css" href="Styles.css">

</head>

<body>
<!--?php include('Navbar.php');
?-->
 
<?php  
 //session_start();
 echo '<h3>'.$_SESSION['username']. '</h3>';
 if(isset($_SESSION['username']))  
 {  
      echo '<h3>Login Success, Welcome - '.$_SESSION['username'].'</h3>';  
 }  
 else  
 {  
      include("login.php");  
 }  
 ?> 
<div class="nextShift">
<h1>Your next shift is going to be on :</h1>
</div>
<div class ="annoucements"> 
<h1>Annoucemnts!</h1>
</div>
</body>
</html>