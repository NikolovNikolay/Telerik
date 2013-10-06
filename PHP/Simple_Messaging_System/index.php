<?php
ob_start();
$pageTitle = 'Влез в системата';
include 'includes/header.php';
$nonfilled = false;

//Моля уверете се, че браузърът ви е нагласен на UTF8 encoding
if(isset($_SESSION['isLogged'])== true)
{
    header('Location: messages.php');
    exit;
}
else {
   
if ($_POST) {
    //$_SESSION['isLogged'] = false;
    $usernameraw = trim($_POST['user']);
    $username = mysqli_real_escape_string($connection,$usernameraw);
    $passwordraw = trim($_POST['pass']);
    $password = mysqli_real_escape_string($connection,$passwordraw);
    if($username == null || $password == null)
    {
        echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Двете полета са задължителни');
                    }
                    </script></h1>";
        $nonfilled = true;
    }
    
    $query = mysqli_query($connection, "SELECT * FROM userdata WHERE username = '$username' AND password ='$password'");
    if (!$query) {
        echo mysqli_error($connection);
    }

    $rows = mysqli_num_rows($query);

    if ($rows == 1) {
        $row = $query->fetch_assoc();
        if ($row['username'] == $username && $row['password'] == $password) {
            $_SESSION['isLogged'] = true;
            $_SESSION['loggedUser'] = $username;
            header('Location: messages.php');
            exit;
        }
    } else {
        // the user couldn't log in, so we check if the username exists at all
        $query = mysqli_query($connection, "SELECT * FROM userdata WHERE username = '$username'");
        $rows = mysqli_num_rows($query);
        if ($rows <= 0 && !$nonfilled) {
            echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Няма такъв потребител');
                    }
                    </script></h1>";
        } elseif($rows > 0 && !$nonfilled) {
            echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Грешна парола');
                    }
                    </script></h1>";
        }
    }
}
}
?>
<script type="text/javascript">
    function redirect(){
        window.location = 'register.php';
    }
</script>
<div id="main" align="center">
    <div id="wrapper">
        <form method="POST" id="loginform">
            <div><input type="text" name="user" placeholder=" Потребителско име"/></div>
            <div><input type="password" name="pass" placeholder=" Парола"/></div>
            <div><input type="submit" value="Влез">&nbsp;&nbsp;<input type="button" onclick="redirect()" value="Регистрация"/></div>
        </form>
    </div>
</div>
    
<?php
include 'includes/footer.php';