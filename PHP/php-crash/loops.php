<?php

//for loop
for($i = 0; $i < 10; $i++){
    echo 'Number ' . $i . '<br/>';
}
echo '<br/>';

// while loop
$i = 0;
while($i < 10){
    echo 'Number ' . $i . '<br/>';
    $i++;
}
echo '<br/>';

// do while loop
$i = 0;
do{
    echo 'Number ' . $i . '<br/>';
    $i++;
} while($i < 10);
echo '<br/>';


//foreach loop
$people = ['Brad', 'Jose', 'William'];
foreach($people as $person){
    echo $person . '<br/>';
}
echo '<br/>';

//foreach loop with echo index and value
foreach($people as $index => $person){
    echo $index . ' - ' . $person . '<br/>';
}

?>


