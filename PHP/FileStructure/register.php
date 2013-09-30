<?php
$pageTitle = 'Register';
include 'includes/header.php';
mb_internal_encoding('UTF-8');
?>

<form method="post">
    <div>
        <input type="text" placeholder="Choose username" id="name" name="username"/>
    </div>
    <br>
    <div>
        <input type="password" placeholder="Choose password" id="pass" name="passMain"/>
    </div>
    <br>
    <div>
        <input type="password" placeholder="Repeat password" id="pass" name="passConfirm"/>
    </div>
    <div>
        <input type="submit" value="Register" />&nbsp;&nbsp;<a href="index.php">To Login form</a>
    </div>
</form>

<?php
if($_POST)
{
    /*if((!isset($_POST['username']) || !isset($_POST['passMain']) || !isset($_POST['passConfirm'])))
    {
        echo 'Username, pass and confirmation fields are required!';
        exit;
    }*/

    $error = false;
    $user = str_replace('!','',trim($_POST['username']));
    if(!(strlen($user) >= 4 && strlen($user) <= 10))
    {
        echo 'Username must be longer or equal to 4, and less or equal to 10 chars.'."<br>";
        $error = true;
        
    }
    $path = realpath('userInfo.txt');
    $handle = @fopen($path, 'r');
    if ($handle) {
    while (($line = fgets($handle, 4096)) !== false)
    {
        $components = explode('!', $line);
        if($components[0] == $user)
        {
            echo 'Username <strong>'.$user.'</strong> has been already taken'."<br>";
            $error = true;
        }
    }
    if (!feof($handle)) {
        echo "Error: unexpected fgets() fail"."<br>";
        $error = true;
    }
    
    fclose($handle);
    }   
    
    if($_POST['passMain'] == $_POST['passConfirm'])
    {
        if(strlen(($_POST['passMain'])) >= 6)
            $pass = str_replace('!','', trim($_POST['passMain']));
        else
        {
            echo 'Password must be atleast 6 symbols, excluding any \'!\'.'."<br>";
            $error = true;
            
        }
    }
    else 
    {
        echo "<script type=\"text/javascript\">
            { alert('Password missmatch!'); };
            </script>";
        $error = true;
    }
    
    if(!$error)
    {
        file_put_contents('userInfo.txt', $user.'!'.$pass."\n", FILE_APPEND);
        echo 'User <strong>'.$user.'</strong> registered successfully!'.'<br>';
        echo "Click <a href=\"index.php\">here</a> to log in.";
        mkdir(realpath('users').DIRECTORY_SEPARATOR.$user);
    }
    
}
?>

<?
include 'include/footer.php';
?>