<?php

$usedpost = false;
if ($_POST) {
    $usedpost = true;
    $filter = $_POST['expense_type'];
    $month = $_POST['month'];
    $year = $_POST['year'];
    $totalCosts = 0.0;
    if (file_exists('infodata.txt')) {
        $res = file('infodata.txt');
       
        foreach ($res as $value) {
            $columns = explode('!', $value);

            if ((array_key_exists($filter, $types)) && $month != 'избери' && $year != 'избери') { // month, year and kind selected from filter
                $dateComps = explode('.', $columns[0]);
                if (($types[$filter] == $types[trim(($columns[3]))]) && ($month == $dateComps[0] && $year == $dateComps[2])) {
                    include 'includes/printresttable.php';
                }
            } elseif ((array_key_exists($filter, $types)) && $month != 'избери') { //kind and month selected from filter
                $dateComps = explode('.', $columns[0]);
                if (($types[$filter] == $types[trim(($columns[3]))]) && ($month == $dateComps[0])) {
                    include 'includes/printresttable.php';
                }
            } elseif ((array_key_exists($filter, $types)) && $year != 'избери') { // kind and year selected from filter
                $dateComps = explode('.', $columns[0]);
                if (($types[$filter] == $types[trim(($columns[3]))]) && ($year == $dateComps[2])) {
                    include 'includes/printresttable.php';
                }
            } elseif ((array_key_exists($filter, $types))) { //kind selected from filter
                if ($types[$filter] == $types[trim(($columns[3]))]) {
                    include 'includes/printresttable.php';
                }
            } elseif ($month != 'избери' && $year != 'избери') { //month and year selected only
                $dateComps = explode('.', $columns[0]);
                if (($month == $dateComps[0] && $year == $dateComps[2])) {
                    include 'includes/printresttable.php';
                }
            } elseif ($month != 'избери') { // month selected
                $dateComps = explode('.', $columns[0]);
                if (($month == $dateComps[0])) {
                    include 'includes/printresttable.php';
                }
            } elseif ($year != 'избери') { // year selected
                $dateComps = explode('.', $columns[0]);
                if (($year == $dateComps[2])) {
                    include 'includes/printresttable.php';
                }
            } else { //nothing selected from filter
                include 'includes/filldatatable.php';
                break;
            }
        }
        include 'includes/printtotalcosts.php';
    }
}
if (!$usedpost) {
    include 'includes/filldatatable.php';
    include 'includes/printtotalcosts.php';
}
?>