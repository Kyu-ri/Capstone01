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

$input_color = $_POST["color"];


$sql = "SELECT *  FROM recommand  where input='$input_color'";
$sql2= "SELECT *  FROM recommand, furniture where input='$input_color' and recommand.output = furniture.color ";

echo "Output color is ";


$result = $conn->query($sql);
$result2 = $conn->query($sql2);


if ($result->num_rows > 0) {
	
	
	
	 while($row = $result->fetch_assoc()) {	
      		echo"  ".$row['output']."   ";
	
	 }

	 
	 while($row = $result2->fetch_assoc()) {	
      	echo "     [name]: " .$row['name']. "   color:" .$row['color'];
	 
			
	}  
} else {
    echo "Mistmatch";
}

 $conn->close();

?>
