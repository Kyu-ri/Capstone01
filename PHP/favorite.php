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
 $fname= $_POST["fname"];


$sql  = " INSERT INTO favorite (username,pick) VALUES ( '$username','$fname')";
$sql2 = "SELECT *  FROM favorite  where username='$username'";



$result = $conn->query($sql);
$result2 = $conn->query($sql2);

if($result == false){
    echo mysqli_error($conn);
}


if ($result2->num_rows > 0) {
	
	

	


	
	 while($row = $result2->fetch_assoc()) {	
	 
	 	echo" the user is	".$row['username']."   ";
		
		break;
		
	 }
	 
	 
	 while($row = $result2->fetch_assoc()) {	
	 
	 	echo"    	".$row['pick']."   ";

	 }
	 
	 
	 
	 
}


 $conn->close();
?>

