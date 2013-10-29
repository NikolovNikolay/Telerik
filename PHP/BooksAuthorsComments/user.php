<?php

ob_start();
$userName = $_GET['user'];
$pageTitle = $userName;
include 'includes/header.php';

$getComments = mysqli_query($connection, "SELECT * FROM messages WHERE user = '$userName' Order by date DESC");
$rows = mysqli_num_rows($getComments);

echo '<div><h2>Коментари от <span style="color: blue">' . $userName . '</span> (' . $rows . ')</h2></div>';
while ($row = $getComments->fetch_assoc()) {
    echo '> <i>' . $row['message'] . '</i> | <b> относно</b> ' . '\'<i><a href="book_details.php?book_name=' . $row['about_book'] . '">' . $row['about_book'] . '</a></i>\' <b>от</b> <i><span style="color: red">' . $row['date'] . '</span></i>' . "</br>";
}
?>

<?php

include 'includes/footer.php';
?>
