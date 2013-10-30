<?php
// single entry port paradigm
mb_internal_encoding('UTF-8');
include './includes/functions.php';

$dispatch = '';
if (isset($_GET['page'])) {
    switch ($_GET['page']) {
        case 'authors':
            $dispatch = 'authors';
            break;
        case 'add_book':
            $dispatch = 'add_book';
            break;
        default:
            $dispatch = 'list_all';
            break;
    }
} else {
    $dispatch = 'list_all';
}
include 'nav/' . $dispatch . '.php';
exit;