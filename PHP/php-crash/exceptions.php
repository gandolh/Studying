<?php
function inverse($x) {
  if (!$x) {
    throw new Exception('Division by zero.');
  }
  return 1/$x;
}

// echo inverse(0); // Causes an exception to be thrown and stops script execution

// Handles the exception
// try {
//   echo inverse(5) . ' ';
//   echo inverse(0) . ' '";
// } catch (Exception $e) {
//   echo 'Caught exception: ',  $e->getMessage(), ' ';
// }

// Finally block is executed regardless of whether an exception is thrown or not

try {
  echo inverse(5) . ' ';
} catch (Exception $e) {
  echo 'Caught exception: ',  $e->getMessage(), ' ';
} finally {
  echo 'First finally ';
}

try {
  echo inverse(0) . ' ';
} catch (Exception $e) {
  echo 'Caught exception: ',  $e->getMessage(), ' ';
} finally {
  echo "Second finally ";
}


echo 'Hello World';