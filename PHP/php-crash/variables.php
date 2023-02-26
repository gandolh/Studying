<?php

$name = 'Brad';
$age = 30;
$has_kids = true;
$cash_on_hand = 299.99;

echo $name, '<br/>', $age, '<br/>', $has_kids, '<br/>';
var_dump( $has_kids);
echo '<br/>';
var_dump( $cash_on_hand);
echo '<br/>';
//concatenate
echo $name . ' is ' . $age . ' years old';
echo '<br/>';
// string literal
echo "${name} is ${age} years old";
$x = '5'+'5';
echo '<br/>';
var_dump($x);
echo '<br/>';
echo 10 - 5, '<br/>';
echo 10 * 5, '<br/>';
echo 10 / 5, '<br/>';
echo 10 % 5, '<br/>';


define('PI', 3.14);
echo PI;
?>