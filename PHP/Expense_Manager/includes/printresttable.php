<?php

echo '<tr>
                            <td class="center" class="table_font">' . $columns[0] . '</td>
                        <td class="table_font"><span class="font">' . $columns[1] . '</span></td>
                        <td class="table_font"><span class="font">' . $columns[2] . '</span></td>
                        <td class="center" class="table_font">' . $types[trim($columns[3])] . '</td>
                        </tr>';
                            $totalCosts+=$columns[2];
?>
