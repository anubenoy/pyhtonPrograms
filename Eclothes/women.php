<?php
session_start();

$products = ["H&M blue gown","Levis purple dress","Gucci Red"];
$productsPrice = [43.0,40.0,37.0];
$productImages = ["women1.png","women2.png","women3.png"];

if(isset($_SESSION["name"]) && isset($_SESSION["address"]) && isset($_SESSION["phone"])){

    if(!isset($_SESSION["products"])){
        $_SESSION["products"] = [];
        $_SESSION["productsPrice"] = [];
        $_SESSION["productQty"] = [];
    }
    if(isset($_GET["id"]) && isset($_GET["qty"])){
        $flag = true;
        if(count($_SESSION["products"]) > 0){
            for($x = 0; $x < count($_SESSION["products"]); $x++)
            {
                if($_SESSION["products"][$x] == $products[$_GET["id"]]){
                    $_SESSION["productQty"][$x] += $_GET["qty"];
                    $flag = false;
                }
            }
        }
        if($flag){
            array_push($_SESSION["products"],$products[$_GET["id"]]);
            array_push($_SESSION["productQty"],$_GET["qty"]);
            array_push($_SESSION["productsPrice"],$productsPrice[$_GET["id"]]);
        }
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
    <title>Womens collection</title>
    <link rel="stylesheet" href="Style.css">
    <script>
        function addCounter(node, mode){
            countQty = parseInt(document.getElementById(node).innerHTML.trim());
            if(mode=="+"){
                countQty = countQty + 1;
            }
            else{
                if (countQty > 1 ){
                    countQty = countQty - 1;
                }
                else{
                    alert("quantity should atleast be 1");
                }
            }
            document.getElementById(node).innerHTML = countQty;
        }
        function addToCart(node, id){
            qty = parseInt(document.getElementById(node).innerHTML.trim());
            window.location.href = "women.php?id="+id+"&qty="+qty;
        }
    </script>
</head>
<body>
    <nav>
        <div class="navigation_top_user">
            <div class="leftBar">
                <a href="home.php">Men</a>
                <a href="women.php" class="active">Women</a>
                <a href="kids.php">Kids</a>
            </div>
            <div class="rightBar">
                <a href="order.php">Orders</a>
                <a href="women.php?logout=true">Logout</a>
            </div>
        </div>
    </nav>

        
    <div class="body-user">
        <?php
            for($x = 0; $x < count($products); $x++)
            {
                $pname = $products[$x];
                ?>
                    <div class="content_box" onclick="">
                        <center><img src="images/<?php echo $productImages[$x];?>" alt=""></center>
                        <div class="NM">
                            <?php echo $pname;?> <br> <p> Price $ <?php echo $productsPrice[$x];?> </p>
                            <div class="qualityContainer">
                                <input type="button" class="additionbutton" value="-" onclick="addCounter('<?php echo $pname ?>','-')">
                                <p class="qty" id ="<?php echo $pname ?>">1</p>
                                <input type="button" class="additionbutton" value="+" onclick="addCounter('<?php echo $pname ?>','+')">
                            </div>
                        </div>     
                        <button class="addtocart" onclick="addToCart('<?php echo $pname; ?>','<?php echo $x; ?>')"> Add to card</button>
                    </div>
                <?php
            }
        ?>
    </div>
    
</body>
</html>
<?php
}
else{
    header("Location:index.php");
}
?>