<!-- adding and listing authors view -->
<a href="index.php">Списък</a>
<a href="index.php?page=add_book">Нова книга</a>
<form method="post" action="index.php?page=authors">
    Име: <input type="text" name="author_name" />
    <input type="submit" value="Добави" />    
</form>
<table border='1'>
    <tr><th>Автор</th></tr>
    <?php
    foreach ($result['authors'] as $row) {
        echo '<tr><td>' . $row['author_name'] . '</td></tr>';
    }
    ?>
</table>