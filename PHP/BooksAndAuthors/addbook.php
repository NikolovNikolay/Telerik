<?php
$pageTitle = 'Нова книга';
include 'includes/header.php';

if ($_POST) {
    $title = mysqli_escape_string($connection, trim($_POST['title']));
    $bookExists = false;
    if (isset($_POST['authors'])) {
        $authors_array = $_POST['authors'];
    }
    if (mb_strlen($title, 'UTF-8') >= 3) {
        $bookCheck = mysqli_query($connection, "Select book_title, COUNT(*) from books WHERE  book_title = '$title'");
        $count = $bookCheck->fetch_assoc();
        if ($count['COUNT(*)'] > 0) {
            $bookExists = true;
        }

        if (!$bookExists) {
            $insert_bookquery = mysqli_query($connection, "INSERT INTO books (book_title) VALUES ('$title')");
            $id = mysqli_insert_id($connection);
            for ($i = 0; $i < count($authors_array); $i++) {
                $insert_mixedquery = mysqli_query($connection, "INSERT into books_authors (book_id,author_id) 
                                                                SELECT book_id, author_id from books, authors
                                                                WHERE books.book_title = '$title' 
                                                                    and authors.author_name = '$authors_array[$i]'");
                if (!$insert_mixedquery) {
                    echo mysqli_error($connection);
                }
            }

            if (!$insert_bookquery || !$insert_mixedquery) {
                echo mysqli_error($connection);
            } else if ($insert_bookquery && $insert_mixedquery) {
                echo 'Книгата е добавена! ';
            }
        } else {
            echo 'Книгата съществува ';
        }
    } else {
        echo 'Невалидно име ';
    }
}
?>
<div class="wrapper"><input type="button" value ="Книги" onclick="redirectBookIndex()" />
    <form method ="post">
        <div><strong>Заглавие:</strong>&nbsp;<input type="text" name="title"/></div>
        <div><select multiple name="authors[]">
                <?php
                $get_authors = mysqli_query($connection, "SELECT * from authors");
                while ($author = $get_authors->fetch_assoc()) {
                    echo '<option>' . $author['author_name'] . '</option>';
                }
                ?>
            </select>
        </div>
        <div><input type="submit" value="Добави"/></div>
    </form>
</div>
<?php
include 'includes/footer.php';
?>