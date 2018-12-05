<?php
//host address
$dbhost = 'www.666wxy.com';
//databse name
$dbname = 'wxycom_high_score';
//table name
$dbtablename = 'highscore';
//user name
$dbuser = 'wxycom_sherry';
//user password
$dbpassword = 'sherry1994';



//mysql connection
$conn = mysqli_connect($dbhost, $dbuser, $dbpassword) or die(mysql_error());
//database connect
mysqli_select_db($conn, $dbname) or die(mysql_error());
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
if ($_POST['download']!= NULL) {
	//echo in unity's console
	echo 'score download';

	$query = "select * from $dbtablename order by score desc";
	$result = mysqli_query($conn, $query) or die(mysql_error());
	$rows = mysqli_num_rows($result);

	for ($cnt=0; $cnt < $rows ; $cnt++) { 

		$row = mysqli_fetch_array($result);
		echo "Name = ".$row[1];
		echo "Score = ".$row[2];
	}
}
} else { 
	print("Hey this works");
}
?>