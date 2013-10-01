<?php
session_start();
$pageTitle = 'Upload file';
include 'includes/header.php';
mb_internal_encoding('UTF-8');
setlocale(LC_CTYPE, 'bg_BG.UTF-8');
if($_SESSION['isLogged'] != true)
{
    header('Location: index.php');
}
?>
<form enctype="multipart/form-data" method="POST">
<input type="hidden" name="MAX_FILE_SIZE" value="10485760" />
Choose a file to upload: <input name="uploadedfile" type="file" /><br />
<input type="submit" value="Upload File" />
</form>
<ul>
    <li>Maximum file size is limited to 10Mb</li>
    <li>*.rar and *.exe files are not supported</li>
    <li>Cyrillic fonts are not supported</li>
</ul>
<br>
<div>Logged as <strong><?= $_SESSION['loggedUser']?></strong>&nbsp;&nbsp;<a href="myfiles.php">Files</a>&nbsp;&nbsp;<a href="includes/destroy.php">Log Out</a></div>
<div>
<?php
if($_POST)
{
    if(count($_FILES) > 0) {
        if((stripos($_FILES['uploadedfile']['name'], './') !== false || stripos($_FILES['uploadedfile']['name'], '../') !== false ))
        {
            echo 'error';
            exit;
        }
        $postfix = explode('.', $_FILES['uploadedfile']['name']);
        $extension = end($postfix);
        $forbiddenTypes = array('exe','rar','bat','php','html');
        if(in_array($extension, $forbiddenTypes))
        {
            //echo 'Unsupported file type!';
            echo "<script type=\"text/javascript\">
            { alert('Unsupported file type!'); };
            </script>";
            exit;
        }
        if(($_FILES['uploadedfile']['size'] > 10485760 ))
        {
            //echo 'File is too big!';
            echo "<script type=\"text/javascript\">
            { alert('File is too big!'); };
            </script>";
            exit;
        }
        
        if(move_uploaded_file($_FILES['uploadedfile']['tmp_name'], 'users'.DIRECTORY_SEPARATOR.$_SESSION['loggedUser'].DIRECTORY_SEPARATOR.rand(1, 101).$_FILES['uploadedfile']['name'])) {
            
            //echo 'File uploaded successfully!';
            echo "<script type=\"text/javascript\">
            { alert('File uploaded successfully!'); };
            </script>"; 
        }
    }
}
?>
</div>
<?php
include 'includes/footer.php';
?>