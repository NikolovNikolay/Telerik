<?php
$pageTitle = 'Влез в системата';
include 'includes/header.php';

if (isset($_SESSION['isLogged']) == true) {
    header('Location: index.php');
    exit;
}

if ($_POST) {
    //$_SESSION['isLogged'] = false;
    $usernameraw = trim($_POST['user']);
    $username = mysqli_real_escape_string($connection, $usernameraw);
    $passwordraw = trim($_POST['pass']);
    $password = mysqli_real_escape_string($connection, $passwordraw);
    $nonfilled = false;
    if ($username == null || $password == null) {
        echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Двете полета са задължителни');
                    }
                    </script></h1>";
        $nonfilled = true;
    }

    $query = mysqli_query($connection, "SELECT * FROM users WHERE username = '$username' AND userpass ='$password'");
    if (!$query) {
        echo mysqli_error($connection);
    }

    $rows = mysqli_num_rows($query);

    if ($rows == 1) {
        $row = $query->fetch_assoc();
        if ($row['username'] == $username && $row['userpass'] == $password) {
            $_SESSION['isLogged'] = true;
            $_SESSION['loggedUser'] = $username;
            header('Location: index.php');
            exit;
        }
    } else {
        // the user couldn't log in, so we check if the username exists at all
        $query = mysqli_query($connection, "SELECT * FROM users WHERE username = '$username'");
        $rows = mysqli_num_rows($query);
        if ($rows <= 0 && !$nonfilled) {
            echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Няма такъв потребител');
                    }
                    </script></h1>";
        } elseif ($rows > 0 && !$nonfilled) {
            echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Грешна парола');
                    }
                    </script></h1>";
        }
    }
}
?>
<div id="main">
    <div id="wrapper">
        <form method="POST" id="loginform">
            <div><input type="text" name="user" placeholder=" Потребителско име"/></div>
            <div><input type="password" name="pass" placeholder=" Парола"/></div>
            <div><input type="submit" value="Влез"></div>
        </form>
    </div>
</div>
<?
include 'includes/footer.php';
?>
