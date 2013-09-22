<?php
$totalCosts = 0.0;
    if (file_exists('infodata.txt')) {
        $res = file('infodata.txt');
      
        foreach ($res as $value) {
            $columns = explode('!', $value);
            if(count($columns)<4)
                echo '<h3>Няма налична информация или е повредена!</h3>';
            else {
            echo '<tr class="tab">
                        <td >'.$counter.'</td>
                        <td class="tab" class="center" class="table_font">' . $columns[0] . '</td>
                        <td class="tab" class="table_font"><span class="font">' . $columns[1] . '</span></td>
                        <td class="tab" class="table_font"><span class="font">' . $columns[2] . '</span></td>
                        <td class="tab" class="center" class="table_font">' . $types[trim($columns[3])] . '</td>
                        <td align="center" id="'.$counter.'"><a href="option.php"0>edit</a>'.' | '.'<a href="#">delete</a></td>
                        </tr>';
            $totalCosts+=$columns[2];
            $counter++;
            }
        }
        
    }
?>
