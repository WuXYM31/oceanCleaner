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
$conn = mysqli_connect($dbhost, $dbuser,$dbpassword) or die(mysql_error());
//database connect
mysqli_select_db($conn,$dbname) or die(mysql_error());

if ($_SERVER['REQUEST_METHOD'] == 'POST'){
	if ($_POST['name']!= NULL && $_POST['score']!=NULL) {
	//echo in unity's console
	echo 'score update';
	$name = $_POST['name'];
	$score = (int) $_POST['score'];

	$query = "insert into $dbtablename(id,name,score) values(null,'$name','$score')";
	$result = mysqli_query($conn, $query) or die(mysql_error());
}
} else { 
	print("Hey this works");
}
?>