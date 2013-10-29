<?php
$pageTitle = 'Регистрация';
include 'includes/header.php';

if (isset($_SESSION['isLogged']) == true) {
    session_destroy();
    echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Ако преди това сте влезли в системата, сега сте извън нея')
                    }
                    </script></h1>";
    header('Location: register.php');
}


if ($_POST) {
    $chosenNameRaw = trim($_POST['namechoose']);
    $chosenName = mysqli_real_escape_string($connection, $chosenNameRaw);
    $chosenPasswordRaw = trim($_POST['choosepass']);
    $chosenPassword = mysqli_real_escape_string($connection, $chosenPasswordRaw);
    $repeatPassRaw = trim($_POST['choosepassrep']);
    $repeatPass = mysqli_real_escape_string($connection, $repeatPassRaw);
    $nonfilled = false;
    $takenUsername = false;
    $tooShort = false;

    if ($chosenName == null || $chosenPassword == null || $repeatPass == null) {
        echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Всички полета са задължителни');
                    }
                    </script></h1>";
        $nonfilled = true;
    }

    if (mb_strlen($chosenName) < 2 || mb_strlen($chosenPassword) < 2) {
        $tooShort = true;
        echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Името или паролата са по-къси от 5 символа');
                    }
                    </script></h1>";
    } else {
        if ($chosenPassword != $repeatPass) {
            echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Паролите не съответстват');
                    }
                    </script></h1>";
        }
    }

    $query = mysqli_query($connection, "SELECT * FROM users WHERE username ='$chosenName'");
    if (!$query) {
        echo mysqli_error($connection);
    }
    $rows = mysqli_num_rows($query);
    if ($rows >= 1) {
        echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Потребителското име е заето');
                    }
                    </script></h1>";
        $takenUsername = true;
    }

    if (!$takenUsername && !$tooShort && !$nonfilled) {
        $query = mysqli_query($connection, "INSERT INTO users(username,userpass) VALUES('$chosenName','$chosenPassword')");
        if (!$query) {
            echo mysqli_error($connection);
        } else {
            echo "<h1><script type='text/javascript'>
                        {
                            window.alert('Успешна регистрация. Може да се логнете');
                        }
                        </script></h1>";
        }
    }
}
?>
<div id="main">
    <div id="wrapper">
        <form id="regform" method="POST">
            <div><input type="text" name="namechoose" placeholder=" Изберете име"/></iv>
                <div><input type="password" name="choosepass" placeholder=" Изберете парола"/></iv>
                    <div><input type="password" name="choosepassrep" placeholder=" Повторете паролата"/></iv>
                        <div><input type="submit" value="Регистрирай ме"/></div>
                        <div><input type="button" onclick="redirectLogin()" value="Логни се"/></div>
                        </form>
                    </div>
                </div>
<?
include 'includes/footer.php';
?>
