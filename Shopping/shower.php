<?php
session_start();
if(isset($_SESSION["name"])){
    if(isset($_GET["logout"])){
        session_destroy();
        $cookie = array_keys($_COOKIE);
        for($x = 0; $x < count($cookie)-1 ; $x++)
        {
            setcookie($cookie[$x], null, -1);
        }
        header("Location:index.php");
    }
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Shopping</title>
    <link rel="stylesheet" href="style.css">
    <script>
        function setCookie(node, mode){
            const d = new Date();
            d.setTime(d.getTime() + (1*24*60*60*1000));
            countQty = parseInt(document.getElementById(node).innerHTML.trim());
            if(mode=="+"){
                countQty = countQty + 1;
            }
            else{
                if (countQty > 1 ){
                    countQty = countQty - 1;
                }
            }
            document.getElementById(node).innerHTML = countQty;
            document.cookie = node+"="+countQty+";expires="+d.toUTCString();
            console.log(document.cookie);
        }
    </script>
</head>
<body>
    <nav>
        <ul>
            <li><a class ="leftone" href="blade.php">Blades and Handles</a></li>
            <li><a class ="leftone" href="shave.php">Shave</a></li>
            <li><a class ="leftone active" href="shower.php">Shower</a></li>
            
            <li><a class ="rightOne" name="logout" href="blade.php?logout=yes">Logout</a></li>
            <li><a class ="rightOne" href=""><?php echo $_SESSION["name"]; ?></a></li>
        </ul>
    </nav>
    <main>
        <div class="defaultCard">
            <img src="images/shw1.jpg" alt="shw1">
            <h1>David Beckham Instinct</h1>
            <h2>$50.00</h2>
            <div class="qtyContainer">
                <button onclick="setCookie('shw1','-')">-</button>
                <p id="shw1">
                    <?php
                        if (isset($_COOKIE["shw1"])){
                            echo $_COOKIE["shw1"];
                        }
                        else{
                            echo 1;
                        }
                    ?>
                </p>
                <button onclick="setCookie('shw1','+')">+</button>
            </div>
        </div>
        <div class="defaultCard">
            <img src="images/shw2.jpeg" alt="shw2">
            <h1>Bergamot & Sandalwood Shower Gel | M&S</h1>
            <h2>$61.00</h2>
            <div class="qtyContainer">
                <button onclick="setCookie('shw2','-')">-</button>
                <p id="shw2">
                    <?php
                        if (isset($_COOKIE["shw2"])){
                            echo $_COOKIE["shw2"];
                        }
                        else{
                            echo 1;
                        }
                    ?>
                </p>
                <button onclick="setCookie('shw2','+')">+</button>
            </div>
        </div>
        <div class="defaultCard">
            <img src="images/shw3.jpg" alt="shw3">
            <h1>Sauvage Shower Gel</h1>
            <h2>$42.00</h2>
            <div class="qtyContainer">
                <button onclick="setCookie('shw3','-')">-</button>
                <p id="shw3">
                    <?php
                        if (isset($_COOKIE["shw3"])){
                            echo $_COOKIE["shw3"];
                        }
                        else{
                            echo 1;
                        }
                    ?>
                </p>
                <button onclick="setCookie('shw3','+')">+</button>
            </div>
        </div>
        <div class="defaultCard">
            <img src="images/shw4.jpg" alt="shw4">
            <h1>Dior Homme</h1>
            <h2>$43.00</h2>
            <div class="qtyContainer">
                <button onclick="setCookie('shw4','-')">-</button>
                <p id="shw4">
                    <?php
                        if (isset($_COOKIE["shw4"])){
                            echo $_COOKIE["shw4"];
                        }
                        else{
                            echo 1;
                        }
                    ?>
                </p>
                <button onclick="setCookie('shw4','+')">+</button>
            </div>
        </div>
    </main>
</body>
</html>
<?php
}
else{
    header("Location:index.php");
}
?>