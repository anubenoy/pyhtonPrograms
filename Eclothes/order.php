<?php
session_start();

if(isset($_SESSION["name"]) && isset($_SESSION["address"]) && isset($_SESSION["phone"])){

    if(!isset($_SESSION["products"])){
        $_SESSION["products"] = [];
    }

    if(isset($_GET["logout"])){
        session_destroy();
        header("Location:index.php");
    }
?> 

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Orders</title>
    <link rel="stylesheet" href="Style.css">
</head>
<body>
    <nav>
        <div class="navigation_top_user">
            <div class="leftBar">
                <a href="home.php">Men</a>
                <a href="women.php" >Women</a>
                <a href="kids.php" >Kids</a>
            </div>
            <div class="rightBar">
                <a href="order.php" class="active">Orders</a>
                <a href="home.php?logout=true">Logout</a>
            </div>
        </div>
    </nav>

    <button class="placeorder" onclick="location.href='order.php?place=true';">Place order</button>
    <?php
        if(isset($_GET["place"])){
            if(count($_SESSION["products"])>0){
           ?>
            <table class="tableView">
                <tr>
                    <th colspan="2">Order Details</th>
                </tr>
                <tr>
                    <td>Name</td>
                    <td><?php echo $_SESSION["name"];?></td>
                </tr>
                <tr>
                    <td>Contact</td>
                    <td><?php echo $_SESSION["phone"];?></td>
                </tr>
                <tr>
                    <td>Shopping address</td>
                    <td><?php echo $_SESSION["address"];?></td>
                </tr>
                <?php
                    $totalPrice = 0.0;
                    for($x = 0; $x < count($_SESSION["products"]); $x++){
                        $tempQty = $_SESSION["productQty"][$x];
                        $price = $_SESSION["productsPrice"][$x]*$tempQty;
                        $totalPrice += $price;
                        echo "<tr> 
                                <td>".$_SESSION["products"][$x]." x".$tempQty."</td>
                                <td> $ ".$price."</td>
                            </tr>";
                    }
                    $totalPrice = $totalPrice * 1.15;
                    echo "<tr>
                            <td>Total (15% tax)</td>
                            <td> $ ".$totalPrice."</td>
                        </tr>"
                ?>
            </table>
            <?php
            } 
            else{
                echo "<script>alert('no orders found, please add some orders to see the bill !')</script>";
            }
        }
    ?>
    
</body>
</html>
<?php
}
else{
    header("Location:index.php");
}
?>
