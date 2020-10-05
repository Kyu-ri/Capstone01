<?php
$servername = "localhost";
$user = "root";
$password = "12345";
$dbname = "wldbs1993";

// Create connection
$conn = new mysqli($servername, $user, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 


 $username = $_POST["name"];
 

$sql = "SELECT * FROM favorite INNER JOIN links ON favorite.pick = links.fname WHERE username='$username' " ;


$result = $conn->query($sql);




if ($result->num_rows > 0) {
   
    // output data of each row
    while($row = $result->fetch_assoc()) {
      
      
      echo "[name]: " .$row['username']." favorite: " .$row['fname']." url: ".$row['urls'];
  
      
   }  
} else {
    echo "0 result";
}

 $conn->close();
?>


