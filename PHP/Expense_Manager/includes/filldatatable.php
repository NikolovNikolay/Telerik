<?php
$totalCosts = 0.0;
    if (file_exists('infodata.txt')) {
        $res = file('infodata.txt');
        foreach ($res as $value) {
            $columns = explode('!', $value);
            echo '<tr>
                        <td>' . $columns[0] . '</td>
                        <td>' . $columns[1] . '</td>
                        <td>' . $columns[2] . '</td>
                        <td>' . $types[trim($columns[3])] . '</td>
                        </tr>';
            $totalCosts+=$columns[2];
        }
    }
?>
