<?php

$pageTitle = 'Налични книги';
include 'includes/header.php';
?>
<?php

$mix = mysqli_query($connection, "SELECT * FROM books LEFT JOIN books_authors ON books.book_id = books_authors.book_id LEFT JOIN authors ON authors.author_id = books_authors.author_id");
$result = array();
while ($row = mysqli_fetch_assoc($mix)) {
    $result[$row['book_id']]['book_title'] = $row['book_title'];
    $result[$row['book_id']]['authors'][] = $row['author_name'];
}
echo '<div class = "wrapper"><div><input type="button" onclick="redirectAddBooks()" value = "Добави книга" />&nbsp;&nbsp;<input type="button" value="Добави автор" onclick="redirectAddAuthor()" /></div>';
echo '<div><table border = "1"><tr class="first_row"><td><b>Книга</b></td><td><b>Автори</b></td></tr>';
foreach ($result as $value) {
    echo '<tr><td>&nbsp;<i>\'' . $value['book_title'] . '\'</i>&nbsp;</td><td>&nbsp;';
    $data = array();
    foreach ($value['authors'] as $inner_value) {
        $data[] = '<a href = "books_from_author.php?authorname=' . $inner_value . '">' . $inner_value . '</a>';
    }
    echo implode(' | ', $data);
    echo '&nbsp;</td></tr>';
}
echo '</table></div></div>';
include 'includes/footer.php';
?>