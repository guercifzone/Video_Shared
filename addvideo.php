<?php

require("db.php");

$name = mysql_real_escape_string($_POST['name']);
$type = mysql_real_escape_string($_POST['type']);
$link = mysql_real_escape_string($_POST['link']);

$newlink = substr($link,32);

mysql_query("INSERT INTO `video` VALUES('','$name','$type','$newlink')");

header("location: index.php?added=$name");

?>

