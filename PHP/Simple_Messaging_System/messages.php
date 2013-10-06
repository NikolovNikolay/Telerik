<?php
$pageTitle = 'Съобщения';
include 'includes/header.php';

if(!isset($_SESSION['isLogged']))
{
    header('Location: index.php');
    exit;
}
?>
<script type="text/javascript">
<!--
function redirect_out() {
	window.location = "includes/destroy.php";
}
//-->
</script>
<div>
    <?php
        echo '<div style="background-color:yellow"><strong>You are logged as <span style="color: red">'.$_SESSION['loggedUser'].'</strong></span>&nbsp;&nbsp;<input type="button" onclick="redirect_out()" value="Log Out">';  
    ?>
    <input type="button" value="Ново съобщение" 
           onclick="window.open('new_message.php', 'windowname1', 'width=500, height=200'); return false;"/></div>
    <hr>
</div>

<?php
$query = mysqli_query($connection,"SELECT * FROM messages ORDER by date DESC");
if (!$query)
{
    echo mysqli_error($connection);
}
$rows = mysqli_num_rows($query);
if($rows == 0)
{
    echo '<h2>В момента няма съобщения</h2>';
}
else
{
    echo ' ';
    while ($row = $query->fetch_assoc()) {
        $postfix= 'каза';
        if($row['user'] == $_SESSION['loggedUser'])
        {
            $row['user'] = 'Вие';
            $postfix= 'казахте';
        }
        echo '<div><strong><i>На <span style="color: blue">' . $row['date'] . '</span></i> <span style="color: red"><strong>' . $row['user'] . '</strong></span> <i>'.$postfix.':</i></strong></div>';
        echo '<div><strong>&nbsp;&nbsp;<i>Заглавие:</strong> ' . $row['caption'] . '</i></div>';
        echo '<div><strong>&nbsp;&nbsp;&nbsp;Съобщение:</strong> ' . $row['message'] . '</div>';
        echo '<hr width="100%">' . "<br>";
    }
}
?>
<?php
include 'includes/footer.php';
?>
