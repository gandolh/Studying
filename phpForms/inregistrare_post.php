<link href="../css/inregistrare.css" rel="stylesheet" />
<link href="../css/navbar.css" rel="stylesheet" />
<link href="../css/inregistrare.css" rel="stylesheet" />

<html>
<body>
    <?php
    include("../components/navbar.php");
    ?> 
<div id="container_inregistrare">
    <div id="card_inregistrare">
        <div class="inner_card_inregistrare">
        <h3> Multumim ca v-ati autentificat</h3>
        <p> Atat s-a putut e de buget</p>
    </div>
    </div>
</div>
<?php
include("../components/footer.php");
?> 
<?php 
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "magazin";
// Create connection
$conn = new mysqli($servername, $username, $password,$dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
  }


$sql = "INSERT INTO user (Nume, Prenume, Email, Adresa, Varsta, Parola)".
"VALUES ('".$_POST["Nume"]."','".$_POST["prenume"]."','".$_POST["Email"]."','"
.$_POST["adresa"]."',".$_POST["varsta"].",'".$_POST["Parola"]."');";

$result = $conn->query($sql);
?>
</body>
</html>