<link href="../css/image.css" rel="stylesheet"/>
<link rel="stylesheet" href="../css/navbar.css">
<?php 
$id = $_POST["id"];

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
 # echo "Connected successfully";

  

  $sql = "SELECT * FROM `product` where (id = ".$id.") ";
  $result = $conn->query($sql);

    $row = $result->fetch_assoc();
    $nume = $row["Nume"];
    $pret = $row["Valoare"];
    $descriere = $row["Descriere"];
    $descriereLunga = $row["DescriereLunga"];
    $linkImagine = $row["LinkImagine"];



include("navbar.php");
?>
<div class="containerSingleItem">
    <div class="innerContainerSingleItem">
        <h3 style="text-align:left;"> <?php echo $nume; ?>  </h3>
        <img src=" <?php echo '/magazin_online/'.$linkImagine?> " class="imgSingleItem"/>
        <p> pret: <?php echo $pret ?> </p> 
        <p>  <?php echo $descriere ?> </p>
        <p> <?php echo $descriereLunga ?> </p>
        <a  href="/magazin_online/confirmacomanda.php" class="buyButton" >cumpara</a>
    </div>
</div>
<?php 
include("footer.php");
?>


