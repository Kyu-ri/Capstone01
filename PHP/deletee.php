<?php
$mysqli = new mysqli("localhost", "root", "12345", "wldbs1993"); 
   
if($mysqli === false){ 
    die("ERROR: Could not connect. " . $mysqli->connect_error); 
} 
  
  
 $username = $_POST["name"];
 $fname = $_POST["fname"]; 
  
$sql = "DELETE FROM favorite WHERE username='$username'and pick='$fname'"; 
if($mysqli->query($sql) === true){ 
    echo "Record was deleted successfully."; 
} else{ 
    echo "ERROR: Could not able to execute $sql. "  
                                         . $mysqli->error; 
} 
  
$mysqli->close(); 
?> 

