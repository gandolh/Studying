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
 # echo "Connected successfully";

  

  $sql = "SELECT * FROM `product` where (id IN (select Produs FROM oferte)) ";
  $result = $conn->query($sql);
  
  if ($result->num_rows > 0) {
    // output data of each row
    echo "<main class=\"wrapper\">
    <section class=\"breweries\" id=\"breweries\">
    <h3>Oferte</h3>
    <ul>
    ";
    while($row = $result->fetch_assoc()) {
      echo "
      <li>
      <div>
        <img src=\"" .$row["LinkImagine"]."\" alt=\"\">
        <div><h3>" .$row["Nume"]."</h3></div>
      </div>
      <p>
      " .$row["Descriere"]."
      </p>
      <form action=\"/magazin_online/components/image.php\" method=\"post\" class=\"formCard\" >
      <input name=\"id\" id=\"id\" type=\"hidden\" style=\"display:none;\" value=\"".$row["Id"]."\">
      <button type=\"submit\" class=\"buttonCard\">Vezi detalii</button>".
      "<span class=\"cuponPret\">".$row["Valoare"]." lei</span>
      </form>
    </li>
      ";
    }
    
    echo "
    </ul>
    </section>
    </main>";

  } else {
    echo "0 results";
  }

  $sql = "SELECT * FROM product";
  $result = $conn->query($sql);

  if ($result->num_rows > 0) {
    // output data of each row
    echo "<main class=\"wrapper\">
    <section class=\"breweries\" id=\"breweries\">
    <h3>Toate</h3>
    <ul>
    ";
    while($row = $result->fetch_assoc()) {
      echo "
      <li>
      <div>
        <img src=\"" .$row["LinkImagine"]."\" alt=\"\">
        <div><h3>" .$row["Nume"]."</h3></div>
      </div>
      <p>
      " .$row["Descriere"]."
      </p>
      <form action=\"/magazin_online/components/image.php\" method=\"post\" class=\"formCard\" >
      <input name=\"id\" type=\"hidden\" style=\"display:none;\" value=\"".$row["Id"]."\">
      <button type=\"submit\" class=\"buttonCard\">Vezi detalii</button>".
      "<span class=\"cuponPret\">".$row["Valoare"]." lei</span>
      </form>
    </li>
      ";
    }
    
    echo "
    </ul>
    </section>
    </main>";

  } else {
    echo "0 results";
  }




  $conn->close();



?> 