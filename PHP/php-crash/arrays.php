<?php

$numbers = [1, 2, 3, 4, 5];
$fruits = ['apple', 'orange', 'banana', 'grapes'];
print_r($numbers);
echo '<br/>';
var_dump($numbers);
echo '<br/>';
echo $fruits[1];
echo '<br/>';

//asociative array
$colors = ['red' => '#f00', 'green' => '#0f0', 'blue' => '#00f'];
echo $colors['red'];
echo '<br/>';


//multi dimensional array
$people = [
    ['name' => 'Brad', 'age' => 30, 'email' => 'sda@yahoo.sx'],
    ['name' => 'John', 'age' => 25, 'email' => 'sad'],
    ['name' => 'Sara', 'age' => 22, 'email' => '']
];
echo $people[0]['email'];
echo '<br/>';

var_dump(json_encode($people));
?>
