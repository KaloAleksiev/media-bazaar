<!--?php
include('config.php');
if(!isset($_SESSION['login_user'])){
header("location: index.php"); // Redirecting To Home Page
}
?-->
<!DOCTYPE html>
<html>

<head>
  <link rel="stylesheet" type="text/css" href="Styles.css">

</head>

<body>
<?php include('Navbar.php');?>

<div class="nextShift">
<h1>Your next shift is going to be on :</h1>
</div>
<div class ="annoucements"> 
<h1>Annoucemnts!</h1>
</div>
</body>
</html>