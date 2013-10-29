<?php
session_start();
mb_internal_encoding('UTF-8');
$connection = mysqli_connect('localhost', 'arreatface', 'power', 'books_authors_comments');
if (!$connection) {
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
        <script LANGUAGE="JavaScript" SRC="JavaScript/js.js"></script>
        <script LANGUAGE="JavaScript" SRC="JavaScript/async_alerts.js"></script>
        <link rel="stylesheet" type="text/css" href="CSS/CSS.css">
    </head>
    <body>
        <?php
        include 'includes/option_pannel.php';
        ?>
