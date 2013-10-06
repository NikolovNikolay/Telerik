<?php
$pageTitle ='Регистрация';
include 'includes/header.php';

if($_POST)
{
    $chosenName = trim($_POST['namechoose']);
    $chosenName = mysqli_real_escape_string($connection,$chosenName);
    $chosenPassword = trim($_POST['choosepass']);
    $chosenPassword = mysqli_real_escape_string($connection,$chosenPassword);
    $repeatPass = trim($_POST['choosepassrep']);
    $repeatPass = mysqli_real_escape_string($connection,$repeatPass);
    $nonfilled = false;
    $takenUsername = false;
    $tooShort = false;
    
    if($chosenName == null || $chosenPassword == null || $repeatPass== null)
    {
        echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Всички полета са задължителни');
                    }
                    </script></h1>";
        $nonfilled = true;
    }
    
    if(strlen($chosenName) < 5 || strlen($chosenPassword) < 5)
    {
        $tooShort = true;
        echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Името или паролата са по-къси от 5 символа');
                    }
                    </script></h1>";
    }
    else
    {
        if($chosenPassword != $repeatPass)
        {
            echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Паролите не съответстват');
                    }
                    </script></h1>";
        }
    }
    
    $query = mysqli_query($connection, "SELECT * FROM userdata WHERE username ='$chosenName'");
    if (!$query) {
        echo mysqli_error($connection);
    }
    $rows = mysqli_num_rows($query);
    if($rows >= 1)
    {
        echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Потребителското име е заето');
                    }
                    </script></h1>";
        $takenUsername = true;
    }
    
    if(!$takenUsername && !$tooShort && !$nonfilled)
    {
        $query = mysqli_query($connection, "INSERT INTO userdata(username,password) VALUES('$chosenName','$chosenPassword')");
        if (!$query) {
        echo mysqli_error($connection);
        }   
        
        echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Успешна регистрация. Може да се логнете');
                    }
                    </script></h1>";
    }
}
?>
<script type="text/javascript">
    function redirect(){
        window.location = 'index.php';
    }
</script>
<div id="main">
    <div id="wrapper" align="center">
        <form id="regform" method="POST">
            <div><input type="text" name="namechoose" placeholder=" Изберете име"/></iv>
            <div><input type="password" name="choosepass" placeholder=" Изберете парола"/></iv>
            <div><input type="password" name="choosepassrep" placeholder=" Повторете паролата"/></iv>
            <div><input type="submit" value="Регистрирай ме"/></div>
            <div><input type="button" onclick="redirect()" value="Влез в системата"/></div>
        </form>
    </div>
</div>

<?php
include 'includes/footer.php';
?>
