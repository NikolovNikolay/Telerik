<?php
session_start();
$pageTitle = 'Files';
include 'includes/header.php';
mb_internal_encoding('UTF-8');

if($_SESSION['isLogged'] != true)
{
    header('Location: index.php');
}
?>
<script type="text/javascript">
<!--
function redirect_upload() {
	window.location = "upload.php";
}
function redirect_out() {
	window.location = "includes/destroy.php";
}
//-->
</script>
<?php

echo "<div><input type='button' onclick='redirect_upload()' value='Upload new file'>&nbsp;&nbsp;<input type='button' onclick='redirect_out()' value='Log Out'>";
$realPath = 'users'.DIRECTORY_SEPARATOR.$_SESSION['loggedUser'].DIRECTORY_SEPARATOR;
if(is_dir($realPath)){
    $filesInDir = scandir($realPath);
    $fileCounter = 1;
    echo '<div id="filecontainer"><table id="filetable" border = "0" width ="700px" cellpadding="0" cellspacing="0">
            <tr>
                <td collspan = "3"><h2>'.$_SESSION['loggedUser'].'\'s files:</h2></td>
            </tr>';
    for($i = 2; $i < count($filesInDir);$i++)
    {
        $size = filesize(realpath('users').DIRECTORY_SEPARATOR.$_SESSION['loggedUser'].DIRECTORY_SEPARATOR.$filesInDir[$i]) / 1048576;
        $type = explode('.', realpath('users').DIRECTORY_SEPARATOR.$_SESSION['loggedUser'].DIRECTORY_SEPARATOR.$filesInDir[$i]);
        $getType = end($type);
        echo '<tr> 
                    <td width="500px">'.$fileCounter.'. '.'<a href="download.php?file='. $filesInDir[$i].'">'.$filesInDir[$i].'</a></td>
                    <td width="100px">Size: '.round($size,2).' Mb</td>
                    <td width="100px">Type: '.$getType.'</td></div>';
        $fileCounter++;
    }
}
?>
<?php
include 'includes/footer.php';
?>