<?php
// Set a cookie
setcookie('name', 'gandolh', time() + 60 * 60 * 24 * 30); 

// echo time();

// Get a cookie
if (isset($_COOKIE['name'])) {
  echo $_COOKIE['name'];
}

// Delete a cookie
setcookie('name', '', time() - 86400);
