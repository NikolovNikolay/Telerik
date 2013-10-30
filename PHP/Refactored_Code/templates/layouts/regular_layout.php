<!-- project structure -->
<!DOCTYPE html>
<html>
    <head>
        <title><?= $result['title']; ?></title>
        <meta charset="UTF-8">       
    </head>
    <body>
        <div>
            <?php
            include $result['content'];
            ?>
        </div>
    </body>
</html>
