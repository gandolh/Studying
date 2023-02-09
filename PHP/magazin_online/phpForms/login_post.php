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

            $email = $_POST["email"];
            $parola = $_POST["parola"];
            $sql = "SELECT * FROM `user` where Email = '".$email."' and Parola = '".$parola."'";
            $result = $conn->query($sql);
            if ($result->num_rows > 0){
                $row= $result->fetch_assoc();
                echo 'Bun venit, '.$row["Nume"].' '.$row["Prenume"].
                '.<br/>Parola ta este '.$row["Parola"];
            }
            else{
               echo "nu am gasit contul";
            }
            ?>
        </div>
        </div>
    </div>
<?php
include("../components/footer.php");
?> 
</body>
</html>