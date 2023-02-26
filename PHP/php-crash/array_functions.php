<?php

$fruits = ['apple', 'orange', 'banana', 'grapes'];

//get length
echo count($fruits);

//search in array
echo '<br/>';
echo array_search('banana', $fruits);

//check if apple is in array
echo '<br/>';
echo var_dump(in_array('apple', $fruits));

//Add to array
echo '<br/>';
$fruits[] = 'pears';
print_r($fruits);
echo '<br/>';

array_push($fruits, 'pears');
print_r($fruits);
echo '<br/>';

array_unshift($fruits, 'mango');
print_r($fruits);

//remove from array
echo '<br/>';
array_pop($fruits);
print_r($fruits);
echo '<br/>';
array_shift($fruits);
print_r($fruits);
echo '<br/>';

unset($fruits[2]);
print_r($fruits);
echo '<br/>';

//split into 2 chunks
echo '<br/>';
$people = ['Brad', 'Jose', 'William', 'John', 'Sara', 'Katie'];
$chunked = array_chunk($people, 3);
print_r($chunked);
echo '<br/>';
//MERGE ARRAYS
$arr1 = [1,2,3];
$arr2 = [4,5,6];
$arr3 = array_merge($arr1, $arr2);
$arr4 = [ ...$arr1, ...$arr2];
print_r($arr3);
echo '<br/>';
print_r($arr4);
echo '<br/>';

$colors = ['red', 'green', 'blue'];
$fruits = ['apple', 'orange', 'banana'];
$c = array_combine($colors, $fruits);
print_r($c);
echo '<br/>';

//other functions
$keys =  array_keys($c);
print_r($keys);
echo '<br/>';


$flipped = array_flip($c);
print_r($flipped);
echo '<br/>';


$numbers = range(1,20);
print_r($numbers);
$new_numbers = array_map(function($n){
    return $n * 2;
}, $numbers);
print_r($new_numbers);
echo '<br/>';


$filtered = array_filter($numbers, function($n){
    return $n % 2 == 0;
});
print_r($filtered);
echo '<br/>';

$sum = array_reduce( $numbers, fn($carry, $n) => $carry + $n, 0);
echo $sum;
echo '<br/>';

?>
