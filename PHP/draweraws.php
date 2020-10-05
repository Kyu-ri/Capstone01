<?php
$servername = "localhost";
$username = "root";
$password = "12345";
$dbname = "wldbs1993";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 





 $width = $_POST["sw"];
 $length= $_POST["sl"];
  $height = $_POST["sh"];

$sql = "SELECT * FROM furniture where category='chair ' and width<'$width' and length<'$length' and height<'$height'";
$result = $conn->query($sql);


if ($result->num_rows > 0) {
	
    // output data of each row
    while($row = $result->fetch_assoc()) {
		
		
      echo "   name: " .$row['name']." width: ".$row['width']."cm  "."  length:   ".$row['length']."cm  "."  height:   ".$row['height']."cm";
		
	}  
} else {
    echo "0 result";
}

 $conn->close();
?>



