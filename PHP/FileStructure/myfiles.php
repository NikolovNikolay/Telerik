<?php
$pageTitle = 'Files';
include 'includes/header.php';
mb_internal_encoding('UTF-8');

if($_SESSION['isLogged'] != true)
{
    header('Location: index.php');
}
?>

<?php
echo "<div><a href='upload.php'>Upload new file</a>&nbsp;&nbsp;<a href='includes/destroy.php'>Log Out</a></div>";
$realPath = 'users'.DIRECTORY_SEPARATOR.$_SESSION['loggedUser'].DIRECTORY_SEPARATOR;
if(is_dir($realPath)){
    $filesInDir = scandir($realPath,SCANDIR_SORT_ASCENDING);
    $fileCounter = 1;
    echo '<table border = "0" width ="700px" cellpadding="0" cellspacing="0">
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
                    <td width="100px">Type: '.$getType.'</td>  ';
        
        /*echo '<tr> 
                    <td width="500px">'.$fileCounter.'. '.'<a href='.$realPath.$filesInDir[$i].' download='.$filesInDir[$i].'>'.$filesInDir[$i].'</a></td>
                    <td width="100px">Size: '.round($size,2).' Mb</td>
                    <td width="100px">Type: '.$getType.'</td>  ';*/
                    
        //echo $fileCounter.'. '.'<a href='.$realPath.$filesInDir[$i].' download='.$filesInDir[$i].'>'.$filesInDir[$i].'</a>''.' Size: '.round($size,2).' Mb'."<br>";
        $fileCounter++;
    }
}


?>

<?php
include 'includes/footer.php';
?>
