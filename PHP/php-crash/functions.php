<?php

function registerUser($email){
    echo "{$email} Registered";

}
registerUser('SDA');

/////////////////////////////
function sum($num1 = 4, $num2 = 5){
    return $num1 + $num2;
}
echo '<br/>';
echo sum(1, 2);
echo '<br/>';
$number = sum(5, 2);
echo $number;
echo '<br/>';
$number2 = sum();
echo $number2;

/////////////////////////////
$substract = function($num1, $num2){
    return $num1 - $num2;
};
echo '<br/>';
echo $substract(5, 2);

$multiply = fn($n1, $n2) => $n1 * $n2;
echo '<br/>';
echo $multiply(9, 3);


?>
