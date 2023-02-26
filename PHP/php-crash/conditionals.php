<?php

$age = 20;
//if structure
if($age >= 18){
    echo 'You are old enough to vote';
} else {
    echo 'You are not old enough to vote';
}
echo "<br/>";

//else if structure
$currentHour = date('H');
if($currentHour  >= 17){
    echo 'Good Evening';
} else if($currentHour >= 12){
    echo 'Good Afternoon';
} else {
    echo 'Good Morning';
}
echo "<br/>";

//not empty array
$posts = ['First Post', 'Second Post', 'Third Post'];
if(!empty($posts)){
    echo $posts[0];
} else {
    echo 'There are no posts';
}
echo "<br/>";

//ternary operator
echo $age >= 18 ? 'You are old enough to vote' : 'You are not old enough to vote';
echo "<br/>";

// get first post if array of posts is not empty
$post = !empty($posts) ? $posts[0] : 'There are no posts';
echo $post;
echo "<br/>";

//coalescence operator
$post = $posts[0] ?? 'no posts';
echo $post;
echo "<br/>";


//switch structure
$color = 'red';
switch($color){
    case 'red':
        echo 'Your favorite color is red';
        break;
    case 'blue':
        echo 'Your favorite color is blue';
        break;
    default:
        echo 'Your favorite color is something else';
        break;
}
?>