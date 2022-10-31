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
            <li><a class ="leftone active" href="shave.php">Shave</a></li>
            <li><a class ="leftone" href="shower.php">Shower</a></li>
            
            <li><a class ="rightOne" name="logout" href="blade.php?logout=yes">Logout</a></li>
            <li><a class ="rightOne" href=""><?php echo $_SESSION["name"]; ?></a></li>
        </ul>
    </nav>
    <main>
        <div class="defaultCard">
            <img src="images/sh1.jpg" alt="shave1">
            <h1>Cooper hat kit</h1>
            <h2>$102.00</h2>
            <div class="qtyContainer">
                <button onclick="setCookie('shave1','-')">-</button>
                <p id="shave1">
                    <?php
                        if (isset($_COOKIE["shave1"])){
                            echo $_COOKIE["shave1"];
                        }
                        else{
                            echo 1;
                        }
                    ?>
                </p>
                <button onclick="setCookie('shave1','+')">+</button>
            </div>
        </div>
        <div class="defaultCard">
            <img src="images/sh2.jpg" alt="shave2">
            <h1>Harry's Truman Set</h1>
            <h2>$28.00</h2>
            <div class="qtyContainer">
                <button onclick="setCookie('shave2','-')">-</button>
                <p id="shave2">
                    <?php
                        if (isset($_COOKIE["shave2"])){
                            echo $_COOKIE["shave2"];
                        }
                        else{
                            echo 1;
                        }
                    ?>
                </p>
                <button onclick="setCookie('shave2','+')">+</button>
            </div>
        </div>
        <div class="defaultCard">
            <img src="images/sh3.jpeg" alt="shave3">
            <h1>Harry's Essentials Travel Kit</h1>
            <h2>$32.00</h2>
            <div class="qtyContainer">
                <button onclick="setCookie('shave3','-')">-</button>
                <p id="shave3">
                    <?php
                        if (isset($_COOKIE["shave3"])){
                            echo $_COOKIE["shave3"];
                        }
                        else{
                            echo 1;
                        }
                    ?>
                </p>
                <button onclick="setCookie('shave3','+')">+</button>
            </div>
        </div>
        <div class="defaultCard">
            <img src="images/sh4.jpg" alt="shave4">
            <h1>Harry's 6 Razor Blades AND Shaving Gel</h1>
            <h2>$42.00</h2>
            <div class="qtyContainer">
                <button onclick="setCookie('shave4','-')">-</button>
                <p id="shave4">
                    <?php
                        if (isset($_COOKIE["shave4"])){
                            echo $_COOKIE["shave4"];
                        }
                        else{
                            echo 1;
                        }
                    ?>
                </p>
                <button onclick="setCookie('shave4','+')">+</button>
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