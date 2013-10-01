<?php
    session_start();
    $file_name = $_GET['file'];
    $file_url = realpath('users').DIRECTORY_SEPARATOR.$_SESSION['loggedUser'].DIRECTORY_SEPARATOR.$file_name;
    
        header('Content-Type: application/octetstream');
        header("Content-Transfer-Encoding: Binary");
        header("Content-disposition: attachment; filename=\"" .basename($file_name). "\"");
        readfile($file_url);
//    echo $file_url;
//    session_destroy();
?>
