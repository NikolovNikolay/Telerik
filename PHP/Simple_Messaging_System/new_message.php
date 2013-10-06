<?php
ob_start();
$pageTitle = 'Ново съобщение';
include 'includes/header.php';
date_default_timezone_set('Europe/Sofia');

if(!isset($_SESSION['isLogged']))
{
    header('Location: index.php');
    exit;
}

if($_POST)
{
    $captionRaw = str_replace('<','',trim($_POST['caption']));
    $caption = str_replace('>', '', $captionRaw);
    $textRaw = str_replace('<','',trim($_POST['text']));
    $text = str_replace('>', '', $textRaw);
    
    $caption = mysqli_real_escape_string($connection,$caption);
    $text = mysqli_real_escape_string($connection,$text);

    if(strlen($caption) == 0 || strlen($text) == 0)
    {
        echo "<h1><script type='text/javascript'>
                    {
                        window.alert('Двете полета са задължителни');
                    }
                    </script></h1>";
    }
    else
    {
        $user = $_SESSION['loggedUser'];
        $today = date("Y-m-d H:i:s");
        $query = mysqli_query($connection,"INSERT INTO messages(user,caption,message,date) VALUES('$user','$caption','$text','$today')");
        
        if (!$query) {
        echo mysqli_error($connection);
        }
        else
        {
            header('Location: includes/result.php');
        }
    }
    
}
?>

<script type="text/javascript">
function closeSelf(){
    self.close();
    return true;
}
function clearTextArea(){
            document.getElementById("text").value='';
          
     }
function refreshParent(){
    window.opener.location.reload();
}
</script>
<form method="POST">
    <div><b><label for="caption">Заглавие:</label></b></div>
    <div><input type ="text" maxlength="70" size="50" name="caption" id="caption"/></div>
    <div><b><label for="text">Съобщение:</label></b></div>
    <div><textarea rows="4" cols ="50" maxlength="250" name="text" id="text"></textarea></div>
    <div><input type="submit" value="Добави"/><input type="button" value="Изчисти" onclick ="clearTextArea()"/>
    <input type="button" value="Затвори" onclick ="closeSelf()"/>
    </div>
</form>

<?php
include 'includes/footer.php';
?>