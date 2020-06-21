<?php

require "../classes/shift.class.php";

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

session_start();



function build_calendar($month,$year) {

     $daysOfWeek = array('Sunday','Monday','Tuesday','Wednesday','Thursday','Friday','Saturday');
     $firstDayOfMonth = mktime(0,0,0,$month,1,$year);
     $numberDays = date('t',$firstDayOfMonth);
     $dateComponents = getdate($firstDayOfMonth);
     $monthName = $dateComponents['month'];
     $dayOfWeek = $dateComponents['wday'];
     $calendar = "<table class='calendar'>";
     $calendar .= "<caption><h1>Schedule - $monthName $year</h1></caption>";
     $calendar .= "<tr>";

     global $conn;
     $query = $conn->prepare("SELECT
     s.date,
     s.type,
     s.position,
     s.department_id,
     su.user_id,
     u.firstName,
     u.lastName
     FROM
     shift AS s
     INNER JOIN shift_user AS su
     ON
     s.shift_id = su.shift_id
     INNER JOIN USER AS u
     ON
     su.user_id = u.id");

     $username = $_SESSION['user_id'];
     $query->execute();
    
     $result = $query->fetchAll();
     $allShifts = array();

     foreach ($result as $item) {
     $shift = new Shift($item["user_id"],$item["date"],$item["type"], $item["position"]);
     $shift->setFirstName($item["firstName"]);
     $shift->setLastName($item["lastName"]);
     $shift->setDepartmentId($item["department_id"]);
     array_push($allShifts, $shift);
     }

     foreach($daysOfWeek as $day) {
          $calendar .= "<th class='header'>$day</th>";
     } 

     $currentDay = 1;

     $calendar .= "</tr><tr>";

     if ($dayOfWeek > 0) { 
          $calendar .= "<td colspan='$dayOfWeek'>&nbsp;</td>"; 
     }
     
     $month = str_pad($month, 2, "0", STR_PAD_LEFT);


     for ($i = 1; $i <= $numberDays; $i++) {
          if ($dayOfWeek == 7) {
               $dayOfWeek = 0;
               $calendar .= "</tr><tr>";
          }
          $currentDayRel = str_pad($currentDay, 2, "0", STR_PAD_LEFT);
          $date = "$year-$month-$currentDayRel";
          
          $calendar .= "<td class='day' rel='$date'><h2>$currentDay</h2>";

          foreach ($allShifts as $item) {
               if (substr($item->getDate(), -2) == (string)$currentDay)
               {
                    $shiftType = $item->type;
                    $shiftFirstName = $item->firstName;
                    $shiftLastName = $item->lastName;
                    $shiftPosition = $item->position;
                    $shiftDepartment = $item->departmentId;
                    if ($shiftDepartment == 1)
                    {
                         $calendar .= "<div class='shiftCardPhones'>$shiftFirstName $shiftLastName - $shiftType</div>";
                    }
                    else if ($shiftDepartment == 2)
                    {
                         $calendar .= "<div class='shiftCardComputers'>$shiftFirstName $shiftLastName - $shiftType</div>";
                    }
                    else
                    {
                         $calendar .= "<div class='shiftCardTVs'>$shiftFirstName $shiftLastName - $shiftType</div>";
                    }
               }
          }
          
          $calendar .= "</td>";
          
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