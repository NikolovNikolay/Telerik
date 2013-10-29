<?php
$pageTitle = 'Нов автор';
include 'includes/header.php';

if (!isset($_SESSION['isLogged']) == true) {
    header('Location: login.php');
    exit;
}

if ($_POST) {
    $name = mysqli_escape_string($connection, trim($_POST['author_name']));
    $authorExists = false;

    if (mb_strlen($name, 'UTF-8') >= 3) {
        $checkup = mysqli_query($connection, "Select author_name, COUNT(*) from authors WHERE author_name = '$name'");
        $num = $checkup->fetch_assoc();
        if ($num['COUNT(*)'] > 0) {
            $authorExists = true;
        }

        if (!$authorExists) {
            $insert_query = mysqli_query($connection, "INSERT INTO authors (author_name) VALUES ('$name')");
            if (!$insert_query) {
                echo mysqli_error($connection);
            } else {
                echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Авторът е добавен')
                    }
                    </script></h1>";
            }
        } else {
            echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Авторът съществува')
                    }
                    </script></h1>";
        }
    } else {
        echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Невалидно име')
                    }
                    </script></h1>";
    }
}
?>
<div class="wrapper">
    <form method ="post">
        <div><strong>Автор:</strong>&nbsp;<input type="text" name="author_name"/><input type="submit" value="Добави"/></div>
    </form>
    <?php
    $get_authors = mysqli_query($connection, "SELECT * from authors");
    echo '<table border="1"><tr class="first_row"><td><b>Автори</b></td></tr>';
    while ($author = $get_authors->fetch_assoc()) {
        $author_name = $author['author_name'];
        echo '<tr><td><a href = "books_from_author.php?authorname=' . $author_name . '">' . $author_name . '</a></td></tr>';
    }
    echo '</table></div>';
    ?>
    <?php
    include 'includes/footer.php';
    ?>