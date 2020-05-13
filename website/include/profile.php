<?php
    $header = 'Edit account info';
    $username = "dbi427262";
    $password = "parola1234";
    session_start();
    //update email and password
    $formPersonal = '
    <form method="post" id="passCheckForm" class="changePassForm"> 
        <div>
            <label id="label" for="password">Enter you password to countinue!</label> <br> <input type="password" name="oldPassword" id="oldPasswordTB" class="textbox">
        </div>
        <div>
            <button type="submit" id="CheckPass" name="checkPassBtn">Submit</button>
        </div>
    </form>
    ';

    if(isset($_POST['checkPassBtn'])){
        $pass = $_POST['oldPassword'];
        if($pass == $_SESSION['user_pass']){
            $formPersonal = '
            <form method="post" class="changePassForm" id="changeEmailForm"> 
                <div>
                    <label id="label" for="email">Email:</label> <br> <input type="text" name="email" id="emailTB" class="textbox">
                </div>
                <div>
                    <label id="label" for="password">Password:</label> <br> <input type="password" name="password" id="passwordTB" class="textbox">
                </div>
                <div>
                    <label id="label" for="password">Confirm Password:</label> <br> <input type="password" name="confirmPassword" id="confirmPasswordTB" class="textbox">
                </div>
                <div>
                    <button type="submit" id="submitBT" name="changePersonal">Submit</button>
                </div>
            </form>
            ';       
        }
        else{
            echo'<label class="text-danger">Wrong password!</label>';
        }
    }

    //Update the actual info
    if(isset($_POST['changePersonal'])){
        if($_POST['password'] == $_POST['confirmPassword']){
            $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi427262", $username,  $password);
            $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
            try 
            {
                $sql = 'UPDATE user SET email = :email, password = :pass WHERE id = :id;';
                $sth = $conn->prepare($sql);
                $sth->execute([':email' => $_POST['email'], ':pass' => $_POST['password'], ':id' => $_SESSION['user_id']]);
                $succ = $sth->rowCount();
                if ($succ > 0)
                {                
                    $result = $sth->fetch();
                    $this->conn = null;                
                }
                else
                {
                    $this->conn = null;                
                }
            }       
            catch(PDOException $e) 
            {
                echo $e->getMessage();
            }
        }
        else{
            echo'<label class="text-danger">Passwords do not match</label>';
        }
        
    }

    //update the address
    $formAddress= '
    <form method="post" class = "changeAddressForm" id="changeAddressForm"> 
        <div>
            <label id="label" for="city">City</label> <br> <input type="text" name="city" id="cityTB" class="textbox">
        </div>
        <div>
            <label id="label" for="zipcode">Zipcode</label> <br> <input type="text" name="zipcode" id="zipcodeTB" class="textbox">
        </div>
        <div>
            <label id="label" for="address">Address</label> <br> <input type="text" name="address" id="addressTB" class="textbox">
        </div>
        <div>
            <button type="submit" id="submitBT" name="changeAddress">Submit</button>
        </div>
    </form>
    ';

    if(isset($_POST['changeAddress'])){  
        $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi427262", $username,  $password);
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        try 
        {
            $sql = 'UPDATE user SET city = :city, zipcode = :zipcode, address = :address WHERE id = :id;';
            $sth = $conn->prepare($sql);
            $sth->execute([':city' => $_POST['city'], ':zipcode' => $_POST['zipcode'], ':address' => $_POST['address'], ':id' => $_SESSION['user_id']]);
            $succ = $sth->rowCount();
            if ($succ > 0)
            {                
                $result = $sth->fetch();
                $conn = null;                
            }
            else
            {
                $conn = null;                
            }
        } 
        catch(PDOException $e) 
        {
            echo $e->getMessage();
        }
    }
    
?>

<!DOCTYPE html>
<html>
  <head>
    <link rel="stylesheet" type="text/css" href="../Styles.css">
  </head>
  <body>
    <?php include('Navbar.php'); ?> 
    
    <div id= "containerChangeInfo">
        <?php echo $formAddress; ?> 
        <?php echo $formPersonal; ?>
    </div>

    <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.min.js"></script>
     
      <script src="../inputControl.js"></script>'; 
  </body>
</html>