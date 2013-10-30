<!-- adding book view -->
<a href="index.php">Списък</a>
<form method="post" action="index.php?page=add_book">
    Име: <input type="text" name="book_name" />        
    <div>Автори:<select name="authors[]" multiple style="width: 200px">
            <?php
            foreach ($result['authors'] as $row) {
                echo '<option value="' . $row['author_id'] . '">
                    ' . $row['author_name'] . '</option>';
            }
            ?>
        </select></div>
    <input type="submit" value="Добави" />    
</form>
