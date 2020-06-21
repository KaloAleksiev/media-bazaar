<?php
    $header = 'Edit preferences';
    $username = "dbi427262";
    $password = "parola1234";
    $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi427262", $username,  $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    session_start();
    $startDate;
    $endDate;
    $idUser = $_SESSION['user_id'];

    $formLeave = '
        <form method="post" class="preferenceForm">

        <div class="startPicker">
        <div>
        <label for="start">Start date:</label>
        </div>
        <input type="date" id="start" name="startDate"
            value="2020-06-25"
            min="2020-06-25" max="2022-12-31">
        </div>

        <div class="endPicker">
        <div>
        <label for="end">End date:</label>
        </div>
        <input type="date" id="end" name="endDate"
            value="2020-06-25"
            min="2020-06-25" max="2022-12-31">
        </div>
        
        <button type="submit" id="leave" class= "btn" name="leaveRequest"> Send to administration </button>
        </form>
    ';

    if(isset($_POST['leaveRequest'])){
        $startDate = $_POST['startDate'];
        $endDate = $_POST['endDate'];
        $sql = "INSERT INTO `leaverequest`(`user_id`, `start_date`, `end_date`) VALUES ($idUser, '$startDate', '$endDate')";
        $sth = $conn->prepare($sql);
        $sth->execute();
        header("Refresh:0");
    }
    
?>
<!DOCTYPE html>
<html>
  <head>
    <link rel="stylesheet" type="text/css" href="../Styles.css">
  </head>
  <body>
  <br><br><br><br><br><br><br><br>
    <?php include('NavBar.php'); ?> 
    
    <h1 class="leaveRequest"> Leave Request </h1>

    <div id= "containerChangeInfo">
        <?php echo $formLeave; ?> 
    </div>

    <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.min.js"></script>
     
      <script src="../inputControl.js"></script>
  </body>
</html>