<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title> عناوين الدروس</title>
    </head>
    <body>
<h1>html</h1>
<p>
	<?php
		require("db.php");
		
		$find_videos = mysql_query("SELECT * FROM `video` WHERE `type`='PHP'");
		while($row = mysql_fetch_assoc($find_videos))
		{
			$id = $row['id'];
			$name = $row['name'];
			
			echo "<a href='watch.php?id=$id'>$name</a>";
		}
	?>
</p>
    </body>
</html>
