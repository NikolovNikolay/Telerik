<?php

session_start();
session_destroy();
header('Location: index.php');
$_SESSION['isLogged'] = false;
?>
