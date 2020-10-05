<?php
$servername = "localhost";
$username = "root";
$passworddb = "12345";
$dbname = "wldbs1993";

// Create connection
$conn = new mysqli($servername, $username, $passworddb, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 



 $user = $_POST["checkname"];
 $password = $_POST["checkpassword"];
 
$sql = "SELECT * FROM mytable where username='$user'and pw='$password'";
$result = $conn->query($sql);


if ($result->num_rows > 0) {
	
    // output data of each row
    while($row = $result->fetch_assoc()) {
		
		
      echo "ok";
		
	}  
} else {
    echo "Mistmatch";
}

 $conn->close();
?>



