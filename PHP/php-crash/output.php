<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php 
    // output everything
    echo 123, 'hello', 10.5, '<br/>';
    //prints only one value 
    print 123;
    print '<br/>';
    // prints arrays
    print_r([1,2,3,4,5]);
    echo '<br/>';
    // returns more info 
    var_dump([1,2,3,4,5]);
    echo '<br/>';

    // returns string representation of variable
    var_export([1,2,3,4,5]);
    echo '<br/>';

    ?>
</body>
</html>