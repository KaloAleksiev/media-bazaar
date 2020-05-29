<?php
    $header = 'Edit preferences';
    $username = "dbi427262";
    $password = "parola1234";
    $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi427262", $username,  $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    session_start();
    $shift;
    $day1;
    $day2;
    $day3;
    $idUser = $_SESSION['user_id'];
    //Get the preferences from the DB
    $formPreference = '
        <form method="post" class="preferenceForm">
    ';

    $sql = "SELECT pref_shift, pref_day_1, pref_day_2, pref_day_3 from user_preference WHERE user_id LIKE :id";
    $sth = $conn->prepare($sql);
    $sth->execute([':id'=> $idUser]);
    
    $result = $sth->fetchAll();
    foreach($result as $row){
        if(empty($row['pref_shift'])){
            $shift = 'none';
        }
        else{
            $shift = $row['pref_shift'];
        }
        if(empty($row['pref_day_1'])){
            $day1 = 'none';
        }
        else{
            $day1 = $row['pref_day_1'];
        }
        if(empty($row['pref_day_2'])){
            $day2 = 'none';
        }
        else{
            $day2 = $row['pref_day_2'];
        }
        if(empty($row['pref_day_3'])){
            $day3 = 'none';
        }
        else{
            $day3 = $row['pref_day_3'];
        }
    }
    

    $formPreference .= '
        <label for="shift">Shift preference: '.$shift.'</label>
        <button type="submit" id="submitBT" class= "btn" name="selectShift">Change Shift</button> 
        <label for="day1">Day preference 1: '.$day1.'</label>
        <button type="submit" id="day1" class= "btn" name="selectDay" value= "1">Change day 1</button> 
        <label for="day2">Day preference 2: '.$day2.'</label>
        <button type="submit" id="day2" class= "btn" name="selectDay" value= "2">Change day 2</button> 
        <label for="day3">Day preference 3: '.$day3.'</label>
        <button type="submit" id="day3" class= "btn" name="selectDay" value= "3">Change day 3</button> 
    ';   
    
    $formPreference .= '             
        </form>   
    ';

    //SELECT THE SHIFT IN ORDER TO CHANGE IT 
    if(isset($_POST['selectShift'])){
        $formPreference = '
        <form method="post" class="preferenceForm">
            <label for="shift">Choose preffered shift:</label>     
            <select  name="shift" id="shift" class="textbox">
                <option value="Morning">Morning</option>
                <option value="Noon">Noon</option>
                <option value="Evening">Evening</option>            
            </select>
            <button type="submit" id="submitBT" class= "btn" name="updateShift" >Submit</button>    
        </form>
        ';
    }
    //CHANGE THE SHIFT
    if(isset($_POST['updateShift'])){
        
        $sql = 'UPDATE user_preference SET pref_shift = :shift WHERE user_id = :id;';
        $sth = $conn->prepare($sql);
        $sth->execute([':shift' => $_POST['shift'], ':id' => $idUser]);
        header("Refresh:0");
        
    }

    //SELECT THE DAY TO BE CHANGED
    if(isset($_POST['selectDay'])){
        $_SESSION['selDay'] = $_POST['selectDay'];
        $formPreference = '
        <form method="post" class="preferenceForm">        
            <label for="day">Choose a day you cannot work on for your '.$_POST['selectDay'].' Preference:</label>     
            <select  name="day" id="day" class="textbox">
                <option value="Monday">Monday</option>
                <option value="Tuesday">Tuesday</option>
                <option value="Wednesday">Wednesday</option>
                <option value="Thursday">Thursday</option>
                <option value="Friday">Friday</option>
                <option value="Saturday">Saturday</option>   
            </select>       
            <button type="submit" id="submitBT" class= "btn" name="updateDay">Submit</button>    
        </form>
        ';
    
    }

    //CHANGE THE DAY
    if(isset($_POST['updateDay'])){
        $sql = 'UPDATE user_preference SET pref_day_'.$_SESSION['selDay'].' = :day WHERE user_id = :id;';
        $sth = $conn->prepare($sql);
        $sth->execute([':day' => $_POST['day'], ':id' => $idUser]);
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
    <?php include('Navbar.php'); ?> 
    
    <div id= "containerChangeInfo">
        <?php echo $formPreference; ?> 
    </div>

    <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.min.js"></script>
     
      <script src="../inputControl.js"></script>
  </body>
</html>