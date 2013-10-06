<?php
session_start();
mb_internal_encoding('UTF-8');
$connection = mysqli_connect('localhost', 'arreatface', 'power', 'homework_test');
if(!$connection)
{
    echo 'No database connection';
    exit;
}
mysqli_query($connection, 'SET NAMES utf8');        
?>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title><?= $pageTitle ?></title>
        <SCRIPT LANGUAGE="JavaScript" SRC="JavaScript/async_alerts.js"></SCRIPT>
    </head>
    <body>
