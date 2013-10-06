<?php
ob_start();
session_start();
$pageTitle = 'Login';
include 'includes/header.php';
mb_internal_encoding('UTF-8');
?>
<script type="text/javascript">
<!--
function redirect() {
	window.location = "register.php";
}
//-->
</script>
<div id="main">
    <div id="wrapper">
        <form method="post" action="index.php" id="form">
            <div>

                <input type="text" id="name" name="username" placeholder=" Input username"/>
            </div>
            <div>
                <input type="password" id="pass" name="pass" placeholder=" Input password"/>
            </div>
            <div>
                <input type="submit" value="Login" />&nbsp;&nbsp;<input type="button" onclick="redirect()" value="Register">
            </div>
        </form>
        <div id="texter">
            <?php
            if (isset($_SESSION['isLogged'])) {
                header('Location: upload.php');
            } else {
                if ($_POST) {
                    $logUser = trim($_POST['username']);
                    $logPass = trim($_POST['pass']);

                    $path = realpath('users' . DIRECTORY_SEPARATOR . 'userInfo.txt');
                    $handle = @fopen($path, 'r');
                    $logged = false;
                    if ($handle) {
                        while (($line = fgets($handle, 4096)) !== false) {
                            $components = explode('!', $line);
                            if ($components[0] == $logUser && trim($components[1]) == $logPass) {
                                $_SESSION['isLogged'] = true;
                                $_SESSION['loggedUser'] = $logUser;
                                $logged = true;
                                header('Location: upload.php');
                                exit;
                            }
                        }
                        if (!feof($handle)) {
                            echo "Error: unexpected fgets() fail" . "<br>";
                            $error = true;
                        }
                        fclose($handle);
                    }

                    if ($logged) {
                        echo 'You are now logged in!';
                    } else {
                        echo 'Wrong pass or username!';
                    }
                }
            }
            ?>
        </div>
        <div>
        </div>
<?php 
include 'includes/footer.php';
?>