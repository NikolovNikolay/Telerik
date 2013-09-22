<?php
if ($_POST) {
    $date = trim($_POST['date']);
    $name = trim($_POST['name']);
	
    // we check if the string, which represents the name of the expense contains '!'
    // if it does, we replace it with ''
    if (strpos($name, '!')) {
        $name = str_replace('!', '', $name);
    }

    $sum = str_replace(',','.',trim(($_POST['sum'])));
    $selectedType = (int) $_POST['kind'];
    $error = false;

    // we check the name's length
    if (mb_strlen($name) > 50) {
        $error = true;
        echo '<p>Името е прекалено дълго!</p>';
    }

    // splitting the date to '/' char, formig the components, representing the month/date/year
    // if the components are less than tree, or more we throw an exception
    $dateComponents = explode('/', $date);
    $nums = count(($dateComponents));

    if (($nums == 3)) {
        if (($dateComponents[0] < 1 || $dateComponents[0] > 12) || ($dateComponents[1] < 1 || $dateComponents[1] > 31)) {
            $error = true;
            echo '<p>Въведете коректна дата!</p>';
        }
    } else {
        $error = true;
        echo '<p>Въведете коректна дата!</p>';
    }

    //using a for loop, we check every char in the given sum
    //if the char is a letter, we break and throw an exception, also when more than 1 '.' are available

    if (!preg_match('/^[-+]?[0-9]*\.?[0-9]+$||[-+]?[0-9]*\.?[0-9]+$/', $sum) || $sum<=0) {
        $error = true;
        echo '<p>Въведете правилна сума!</p>';
    }
    // checking if the key of the group exists in $types
    if (!array_key_exists($selectedType, $types)) {
        $error = true;
        echo '<p>Избрана е невалидна група!</p>';
    }

    if (!$error) {
        $result = $dateComponents[0] . '.' . $dateComponents[1] . '.' . $dateComponents[2] . '!' .
                $name . '!' . $sum . '!' . $selectedType . "\n";
        if (file_put_contents('infodata.txt', $result, FILE_APPEND)) {
            echo 'Записът е успешен';
        }
    }
}
?>
