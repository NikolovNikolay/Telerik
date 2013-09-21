<?php
$pageTitle = 'Списък';
include 'includes/header.php'
?>

<div align="center">
<div align ="center"><a href="form.php">Добави нов разход</a>
    <form method="POST">
        <label for="month" >Месец:</label>
        <select id="month" name="month">
            <option>избери</option>
            <?php
            for($i=1;$i<=12;$i++)
            {
                if($i<10)
                    echo '<option value='.$i.'>'.'0'.$i.'</option>';
                else
                    echo '<option value='.$i.'>'.$i.'</option>';
            }
            ?>
        </select>
        <label for="year" >Година:</label>
        <select id="year" name="year">
            <option>избери</option>
            <?php
            for($i=2008;$i<=2014;$i++)
            {
                 echo '<option value='.$i.'>'.$i.'</option>';
            }
            ?>
        </select>
        <label for="expense_type" >Вид:</label>
    <select id="expense_type" name="expense_type">
        <option value="all">Всички</option>
        <?php
        foreach ($types as $key => $value)
        {
            echo '<option value='.$key.'>'.$value.'</option>';
        }
        ?>
    </select>
        <input id="submitbutton" type="submit" value="Филтър">
    </form>
</div>
<table id="main_table" border ="1">
    <tr id="main_row">
        <td width="100" align="center">Дата</td>
        <td width ="350" align="center">Име</td>
        <td width="80" align="center">Сума</td>
        <td width="120" align="center">Вид</td>
    </tr>
    <?php
    include 'includes/filldatathroughfilter.php'
    ?>
    
</table>
</div>
<?php
include 'includes/footer.php';
?>
   
