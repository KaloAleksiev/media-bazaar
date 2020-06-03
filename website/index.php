<?php
if (session_status() == PHP_SESSION_NONE) {
    session_start();
  }
$host = "localhost";
$username = "dbi427262";
$password = "parola1234";
$database = "website";
$message = "";
try
{
    //conection to database
  $connect = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi427262", $username,  $password);
  //handling exeptions
  $connect->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
  if(isset($_POST["login"]))
  {//check if textboxes are empty
      if(empty($_POST["username"]) || empty($_POST["password"]))
      {
         $message = '<label> Make sure you fill up yor username and password</label>';
      }
      else
      {
          $query = "SELECT * FROM user WHERE email = :username AND password = :password";
          $statement = $connect->prepare($query);
          $statement->execute(
              array(
                  'username'     =>     $_POST["username"],
                  'password'     =>     $_POST["password"]
              )
              );
              $result = $statement->fetch();
              $count = $statement->rowCount();
              if($count > 0)
              {
                $message = '<label>Heey!</label>';
                  $_SESSION['name'] = $result['firstName'];
                  $_SESSION['user_id'] = $result['id'];
                  $_SESSION['position'] = $result['position'];
                  $_SESSION['department'] = $result['department_id'];
                  $_SESSION['user_pass'] = $_POST["password"];
                  header('location: include/Home.php');
              }
              else{
                  $message = '<label>Wrong data!</label>';
              }

      }
  }
}
catch(PDOException $error)
{
    //display error message
 $message = $error->getMessage();
}

?>


<!DOCTYPE html>
<html>

<head>
  <link rel="stylesheet" type="text/css" href="Styles.css">

</head>

<body>

<img class="loginLogo" src="logo.jpeg">
    <div class="container">
  
        <div class="img">
        </div>
        <div class="login-content">
     
            <form action="" method="post">
           
                <h2 class="title">Welcome</h2>
                <?php
                if(isset($message))
                {
                    echo'<label class="text-danger">'.$message.'</label>';
                }
                ?>
                <div class="input-div one">
                
                    <div class="i">
                    </div>
                    <div class="div">
                        <h5>Username</h5>
                        <input type="text" class="form-control" name="username" >
                    </div>
                </div>
                <div class="input-div pass">
                    <div class="i">
                    </div>
                    <div class="div">
                        <h5>Password</h5>
                        <input type="password" class="form-control" name="password" >
                    </div>
                </div>
               
                <input name="login" type="submit" class="btn"  value="Login">
                
            </form>
        </div>
    </div>
</body>
</html>

<script>
const inputs = document.querySelectorAll(".form-control");


function addcl(){
	let parent = this.parentNode.parentNode;
	parent.classList.add("focus");
}

function remcl(){
	let parent = this.parentNode.parentNode;
	if(this.value == ""){
		parent.classList.remove("focus");
	}
}


inputs.forEach(input => {
	input.addEventListener("focus", addcl);
	input.addEventListener("blur", remcl);
});
</script>