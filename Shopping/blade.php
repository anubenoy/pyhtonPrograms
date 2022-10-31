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
            <li><a class ="leftone active" href="blade.php">Blades and Handles</a></li>
            <li><a class ="leftone" href="shave.php">Shave</a></li>
            <li><a class ="leftone" href="shower.php">Shower</a></li>
            
            <li><a class ="rightOne" name="logout" href="blade.php?logout=yes">Logout</a></li>
            <li><a class ="rightOne" href=""><?php echo $_SESSION["name"]; ?></a></li>
        </ul>
    </nav>
    <main>
        <div class="defaultCard">
            <img src="images/b1.png" alt="blade1">
            <h1>Club Series Handle</h1>
            <h2>$20.00</h2>
            <div class="qtyContainer">
                <button onclick="setCookie('blade1','-')">-</button>
                <p id="blade1">
                    <?php
                        if (isset($_COOKIE["blade1"])){
                            echo $_COOKIE["blade1"];
                        }
                        else{
                            echo 1;
                        }
                    ?>
                </p>
                <button onclick="setCookie('blade1','+')">+</button>
            </div>
        </div>
        <div class="defaultCard">
            <img src="images/b2.jpeg" alt="blade2">
            <h1>Merkur Safety razor</h1>
            <h2>$21.00</h2>
            <div class="qtyContainer">
                <button onclick="setCookie('blade2','-')">-</button>
                <p id="blade2">
                    <?php
                        if (isset($_COOKIE["blade2"])){
                            echo $_COOKIE["blade2"];
                        }
                        else{
                            echo 1;
                        }
                    ?>
                </p>
                <button onclick="setCookie('blade2','+')">+</button>
            </div>
        </div>
        <div class="defaultCard">
            <img src="images/b3.png" alt="blade3">
            <h1>Cross Knurl Safety Razor</h1>
            <h2>$22.00</h2>
            <div class="qtyContainer">
                <button onclick="setCookie('blade3','-')">-</button>
                <p id="blade3">
                    <?php
                        if (isset($_COOKIE["blade3"])){
                            echo $_COOKIE["blade3"];
                        }
                        else{
                            echo 1;
                        }
                    ?>
                </p>
                <button onclick="setCookie('blade3','+')">+</button>
            </div>
        </div>
        <div class="defaultCard">
            <img src="images/b4.png" alt="blade4">
            <h1>DOVO Solingen Straight razor</h1>
            <h2>$23.00</h2>
            <div class="qtyContainer">
                <button onclick="setCookie('blade4','-')">-</button>
                <p id="blade4">
                    <?php
                        if (isset($_COOKIE["blade4"])){
                            echo $_COOKIE["blade4"];
                        }
                        else{
                            echo 1;
                        }
                    ?>
                </p>
                <button onclick="setCookie('blade4','+')">+</button>
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