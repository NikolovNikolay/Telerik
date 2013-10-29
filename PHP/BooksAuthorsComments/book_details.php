<?php

ob_start();
date_default_timezone_set('Europe/Sofia');
$bookName = $_GET['book_name'];
$pageTitle = $bookName;
include 'includes/header.php';

echo '<div><h2><b>Заглавие: </b><i>\'<a href="#">' . $bookName . '</a>\'</i></h2></div>';
$getAuthors = mysqli_query($connection, "SELECT * FROM books LEFT JOIN books_authors ON books.book_id = books_authors.book_id LEFT JOIN authors ON authors.author_id = books_authors.author_id WHERE books.book_title ='$bookName'");
while ($row = mysqli_fetch_assoc($getAuthors)) {
    $result[$row['book_id']]['book_title'] = $row['book_title'];
    $result[$row['book_id']]['authors'][] = $row['author_name'];
}
foreach ($result as $value) {
    $data = array();
    foreach ($value['authors'] as $inner_value) {
        $data[] = '<a href = "books_from_author.php?authorname=' . $inner_value . '">' . $inner_value . '</a>';
    }
    echo '<div><h2><b>Автори: </b>' . implode(' | ', $data) . '</h2></div>';
    echo '&nbsp;</td></tr>';
}
$comments = mysqli_query($connection, "SELECT * FROM messages WHERE about_book = '$bookName' ORDER by date DESC");
$rows = mysqli_num_rows($comments);
if ($rows > 0) {
    while ($row = $comments->fetch_assoc()) {
        if (isset($_SESSION['loggedUser'])) {
            if ($row['user'] == $_SESSION['loggedUser']) {
                $row['user'] = 'Вие';
            }
        }
        echo '<b><span style="color: blue"><a href="user.php?user=' . $row['user'] . '">' . $row['user'] . '</a></span></b> на <b><i><span style="color: red">' . $row['date'] . '</span></i></b>' . "</br>" . '&nbsp;&nbsp;&nbsp;' . $row['message'] . '<hr width="100%">' . "<br>";
    }
} else {
    echo '<b>Нама коментари за книгата</b>' . "</br>";
    echo '<hr width = 100%>'."</br>";
}

if ($_POST) {
    $textRaw = str_replace('<', '', trim($_POST['text']));
    $text = str_replace('>', '', $textRaw);
    $text = mysqli_real_escape_string($connection, $text);

    if (mb_strlen($text) == 0) {
        echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Не може да добавите празен коментар');
                    }
                    </script></h1>";
    } else {
        $user = $_SESSION['loggedUser'];
        $today = date("Y-m-d H:i:s");
        $query = mysqli_query($connection, "INSERT INTO messages(user,message,date, about_book) VALUES('$user','$text','$today','$bookName')");

        if (!$query) {
            echo mysqli_error($connection);
        } else {
            echo "<h1><script type='text/javascript'>
                    {
                            location.reload();                   
                    }
                    </script></h1>";
        }
    }
}


if (isset($_SESSION['isLogged']) == true) {
    echo '<form method="POST">
    <div><b><label for="text">Нов коментар:</label></b></div>
    <div><textarea rows="5" cols ="50" maxlength="250" name="text" id="text"></textarea></div>
    <div><input type="submit" value="Добави"/><input type="button" onClick ="clearTextArea()" value="Изчисти"/>
    </div>
</form>';
} else {
    echo '* За да оставите коментар трябва да влезете в системата. Ако нямате регистрация, натиснете <a href="register.php">тук</a>';
}
?>
