<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
       </head>
    <body>
<?php

require("db.php");

$id = $_GET['id'];

$find_video = mysql_query("SELECT * FROM `video` WHERE `id`='$id'");
while($row = mysql_fetch_assoc($find_video))
{
	$name = $row['name'];
	$code = $row['newlink'];
}

?>

<title><?php echo $name; ?></title>
<h1><?php echo $name; ?></h1>


<div style="position:relative;height:0;padding-bottom:56.25%"><iframe src="https://www.youtube.com/embed/<?php echo $code;?>" width="640" height="360" frameborder="0" style="position:absolute;width:100%;height:100%;left:0" allowfullscreen></iframe></div>

    </body>
</html>
