<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title> تجمع المبرمجين والمطورين العرب</title>
    </head>
    <body>
        <h1>الصفحة الرئيسية</h1>
<p><a href="php.php">PHP Videos</a> || <a href="javascript.php">html Videos</a></p>

<p>
<form action="addvideo.php" method="POST">
	<input type="text" name="name" placeholder="Video Name..." /><br />
    <select name="type">
    	<option>PHP</option>
        <option>html</option>
    </select><br />
    <input type="text" name="link" placeholder="Share Link"><br />
    <input type="submit" value="Share!">
</form>
<?php if($_GET['added']){$added=$_GET['added'];echo "Added $added to the video list";} ?>
</p>
    </body>
</html>
