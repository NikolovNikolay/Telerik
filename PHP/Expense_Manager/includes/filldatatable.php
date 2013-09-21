<?php
$totalCosts = 0.0;
    if (file_exists('infodata.txt')) {
        $res = file('infodata.txt');
        foreach ($res as $value) {
            $columns = explode('!', $value);
            echo '<tr class="tab">
                        <td class="tab" class="center" class="table_font">' . $columns[0] . '</td>
                        <td class="tab" class="table_font"><span class="font">' . $columns[1] . '</span></td>
                        <td class="tab" class="table_font"><span class="font">' . $columns[2] . '</span></td>
                        <td class="tab" class="center" class="table_font">' . $types[trim($columns[3])] . '</td>
                        </tr>';
            $totalCosts+=$columns[2];
        }
    }
?>
