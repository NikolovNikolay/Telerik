<?php
$pageTitle = 'Login';
include 'includes/header.php';
mb_internal_encoding('UTF-8');
?>




<form method="post">
    <div>
        
        <input type="text" id="name" name="username" placeholder=" Input username"/>
    </div>
    <div>
        
        <input type="password" id="pass" name="pass" placeholder=" Input password"/>
    </div>
    <div>
        <input type="submit" value="Login" />&nbsp;&nbsp;<a href="register.php">Register</a>
    </div>
</form>


<?php
if(isset($_SESSION['isLogged']))
{
    header('Location: upload.php');
}
else
{
    if($_POST)
{
    /*if(isset($_POST['username']) || isset($_POST['pass']))
    {
        echo 'Both username and password are mandatory fields!';
        exit;
    }*/
    
    $logUser = trim($_POST['username']);
    $logPass = trim($_POST['pass']);
    
    $path = realpath('userInfo.txt');
    $handle = @fopen($path, 'r');
    $logged = false;
    if ($handle) {
    while (($line = fgets($handle, 4096)) !== false)
    {
        $components = explode('!', $line);
        if($components[0] == $logUser && trim($components[1]) == $logPass)
        {
            $_SESSION['isLogged'] = true;
            $_SESSION['loggedUser'] = $logUser;
            $logged = true;
            header('Location: upload.php');
            exit;
        }
    }
    if (!feof($handle)) {
        echo "Error: unexpected fgets() fail"."<br>";
        $error = true;
    }
    
    fclose($handle);
    }
    
    if($logged)
    {
        echo 'You are now logged in!';
    }
    else
    {
        echo 'Wrong pass or username!';
    }
}
}
?>
<?php 
include 'includes/footer.php';
?>