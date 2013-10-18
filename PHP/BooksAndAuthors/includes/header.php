<?php
mb_internal_encoding('UTF-8');
$connection = mysqli_connect('localhost', 'arreatface', 'power', 'books');

if (!$connection) {
    echo 'An error came up setting up the database';
    exit;
}
mysqli_query($connection, 'SET NAMES utf8');
?>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title><?= $pageTitle ?></title>
        <SCRIPT LANGUAGE="JavaScript" SRC="JavaScript/js.js"></SCRIPT>
        <link rel="stylesheet" type="text/css" href="CSS/css.css">
    </head>
    <body>
