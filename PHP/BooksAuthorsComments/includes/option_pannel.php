<?php
if(isset($_SESSION['loggedUser']))
{
    $loggedUser= $_SESSION['loggedUser'];
}
$pannel_string = '<div id="option_holder"><input type="button" onClick="redirectBookIndex()" value="Начало" /><input type="button" onclick="redirectLogin()" value="Логни се"/><input type="button" onclick="redirectRegister()" value="Регистрирай се"/></div>';
if (isset($_SESSION['isLogged']) == true) {
    $pannel_string = '<div id="option_holder"><input type="button" onclick="redirectAddBooks()" value = "Добави книга" /><input type="button" value="Добави автор" onClick = "redirectAddAuthor()" /> | <input type="button" onClick="redirectBookIndex()" value="Начало" /><input type="button" onclick="logOut()" value="Излез"/></div>';
    echo '<div>Логнат сте като <b>'. $loggedUser.'</b> '.$pannel_string.'</div>';
}
else
{
    echo $pannel_string;
}
?>