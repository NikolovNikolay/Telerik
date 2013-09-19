<?php
mb_internal_encoding('UTF-8');
$pageTitle = 'Форма';
include 'includes/header.php';
?>

<div align="center">
    <div align ="center" width ="400px"><a href="index.php">Към списък</a></div>
    <table>
        <tr align="left">
            <td>
                <form method="POST" name="expense_form">
                    <div>
                        <label for ="date_selected">Дата:</label>
                        <input TYPE="text" name="date" value="" id="date_selected">
                        <a href="#" onClick="cal.select(document.forms['expense_form'].date, 'anchor', 'MM/dd/yyyy');
                                return false;"
                           NAME="anchor" ID="anchor">избери</a>
                    </div>
                    <div>
                        <label for ="chosen_name">&nbspИме:</label>
                        <input type="text" name ="name" id="chosen_name"/>
                    </div>
                    <div>
                        <label for ="sum_inputed">Сума:</label>
                        <input type="text" name ="sum" id="sum_inputed"/>
                    </div>
                    <div>
                        <label for ="what_kind">&nbspВид:</label>
                        <select id="what_kind" name="kind">
                            <option value ="blank" selected>
                                <?php
                                for ($i = 0; $i < 25; $i++) {
                                    echo '-';
                                }
                                ?>
                            </option>
                            <?php
                            foreach ($types as $key => $value) {
                                echo '<option value="' . $key . '">' . $value .
                                '</option>';
                            }
                            ?>
                        </select>
                    </div>
                    <div align="center"><input type="submit" value="Добави" /></div>
                </form>
            </td>
        </tr>
    </table>
    <div>
        <?php
        include 'includes/formresult.php';
        ?>
    </div>
</div>