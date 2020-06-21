<?php
  if ($_SESSION['position'] == "Manager" || $_SESSION['position'] == "Administrator")
  {
    include('navbarManager.php');
  }
  else
  {
    include('navbarEmployee.php');
  }
?>
    