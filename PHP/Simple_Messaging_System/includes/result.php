<?php
ob_start();
session_start();
mb_internal_encoding('UTF-8');
$pageTitle = 'Успешно изпратено съобщение';
?>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title><?= $pageTitle ?></title>
        <SCRIPT LANGUAGE="JavaScript" SRC="JavaScript/async_alerts.js"></SCRIPT>
    </head>
    <body>
        <script type="text/javascript">
            window.onload = function() {
                window.opener.location.reload();
            };
            function redirect() {
                window.location = '../new_message.php';
            }
            function closeSelf() {
                self.close();
                return true;
            }
        </script>

        <?php
        echo '<h2>Съобщението е добавено!</h2>';
        ?>
        <div><input type="button" onclick="redirect()" value="Ново съобщение"/><input type="button" value="Затвори" onclick ="closeSelf()"/></div>

    </body>
</html>