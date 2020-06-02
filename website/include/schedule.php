<?php

//require "../databaseConn.php";

$servername = 'studmysql01.fhict.local';
$uid = 'dbi427262';
$pid = 'parola1234';

try {
    $conn = new PDO("mysql:host=$servername;dbname=dbi427262", $uid, $pid);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
}
catch(PDOException $e){
    var_dump("Database connection failed to execute.");
}


require "../classes/shift.class.php";
session_start();


/*
$query = $conn->prepare("SELECT s.date, s.type, s.position, su.user_id
    FROM shift as s
    INNER JOIN shift_user as su
    ON s.shift_id = su.shift_id
    WHERE su.user_id = :userId");

$query->execute([':userId' => $username]);
    
$result = $query->fetchAll();
$allShifts = array();


foreach ($result as $item) {
    $shift = new Shift($item["user_id"],$item["date"],$item["type"], $item["position"]);
    array_push($allShifts, $shift);
}
*/



function build_calendar($month,$year) {

     $daysOfWeek = array('Sunday','Monday','Tuesday','Wednesday','Thursday','Friday','Saturday');
     $firstDayOfMonth = mktime(0,0,0,$month,1,$year);
     $numberDays = date('t',$firstDayOfMonth);
     $dateComponents = getdate($firstDayOfMonth);
     $monthName = $dateComponents['month'];
     $dayOfWeek = $dateComponents['wday'];
     $calendar = "<table class='calendar'>";
     $calendar .= "<caption>$monthName $year</caption>";
     $calendar .= "<tr>";

     global $conn;
     $query = $conn->prepare("SELECT s.date, s.type, s.position, su.user_id
    FROM shift as s
    INNER JOIN shift_user as su
    ON s.shift_id = su.shift_id
    WHERE su.user_id = :userId");

     $username = $_SESSION['user_id'];
     $query->execute([':userId' => $username]);
    
     $result = $query->fetchAll();
     $allShifts = array();

     foreach ($result as $item) {
     $shift = new Shift($item["user_id"],$item["date"],$item["type"], $item["position"]);
     array_push($allShifts, $shift);
     }

     $test = "test";

     foreach($daysOfWeek as $day) {
          $calendar .= "<th class='header'>$day</th>";
     } 

     $currentDay = 1;

     $calendar .= "</tr><tr>";

     if ($dayOfWeek > 0) { 
          $calendar .= "<td colspan='$dayOfWeek'>&nbsp;</td>"; 
     }
     
     $month = str_pad($month, 2, "0", STR_PAD_LEFT);

     
     while ($currentDay <= $numberDays) {

          if ($dayOfWeek == 7) {
               $dayOfWeek = 0;
               $calendar .= "</tr><tr>";
          }
          $currentDayRel = str_pad($currentDay, 2, "0", STR_PAD_LEFT);
          $date = "$year-$month-$currentDayRel";
          
          
          foreach ($allShifts as $item) {
               if (substr($item->getDate(), -2) == (string)$currentDay)
               {
                    $shiftType = $item->type;
                    $shiftDay = true;
                    break;
               }
               else
               {
                    $shiftDay = false;
               }
          }
          
          if ($shiftDay == true)
          {
               $calendar .= "<td class='day' rel='$date'>$currentDay - $shiftType</td>"; // here
          }
          else
          {
               $calendar .= "<td class='day' rel='$date'>$currentDay</td>"; // here
          }
          
          $currentDay++;
          $dayOfWeek++;
     }
     


     if ($dayOfWeek != 7) { 
     
          $remainingDays = 7 - $dayOfWeek;
          $calendar .= "<td colspan='$remainingDays'>&nbsp;</td>";
     }
     
     $calendar .= "</tr>";
     $calendar .= "</table>";
     return $calendar;
}

$dateComponents = getdate();
$month = $dateComponents['mon']; 			     
$year = $dateComponents['year'];


?>

<!DOCTYPE html>
<html>
  <head>
    <link rel="stylesheet" type="text/css" href="../scheduleStyles.css">
  </head>
  <body>
    <?php include('Navbar.php'); 

    echo build_calendar($month,$year);
    
    ?>

     <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
     <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.min.js"></script>
     <script src="../inputControl.js"></script>
  </body>
</html>