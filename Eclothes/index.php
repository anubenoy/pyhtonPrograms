<?php
session_start();
if(isset($_SESSION["name"]) && isset($_SESSION["address"]) && isset($_SESSION["phone"])){
    header("Location:home.php");
}
if(isset($_POST["name"])){
    $_SESSION["name"] = $_POST["name"];
    $_SESSION["phone"] = $_POST["phone"];
    $_SESSION["address"] = $_POST["address"];
    header("Location:home.php");
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>eCloths</title>
    <link rel="stylesheet" href="Style.css">

    <script>
        function validate(){
            var name = document.getElementById("name");
            var phone = document.getElementById("ph");
            var adress = document.getElementById("address");
            patt=/^\d{3}\-\d{3}\-\d{4}$/;
            var nameFlag = false;
            var phoneFlag = false;
            var adressFlag = false;
            if(name.value.trim().length == 0){
                name.style.cssText = "border : 1px solid red;";
                nameFlag = false;
            }
            else{
                name.style.cssText = "border : none";
                nameFlag = true;
            }
            if(phone.value.trim()=="" || !phone.value.match(patt)){
                phone.style.cssText = "border : 1px solid red;";
                phoneFlag = false;
                phone.value = "";
                phone.placeholder="XXX-XXX-XXXX";
            }
            else{
                phone.style.cssText = "border : none";
                phoneFlag = true;
            }
            if(adress.value.trim().length == 0){
                adress.style.cssText = "border : 1px solid red;";
                adressFlag = false;
            }
            else{
                adress.style.cssText = "border : none";
                adressFlag = true;
            }
            if(nameFlag && phoneFlag && adressFlag){
                return true;
            }
            else{
                return false;
            }
            
        }
    </script>
</head>
<body>
    <form action="index.php" method="POST">
        <div class="logincard">
            <p>Login</p>
            <input type="text" name="name" id="name" placeholder="Full Name"/>
            <input type="text" name="phone" id="ph" placeholder="Phone Number"/>
            <input type="text" name="address" id="address" placeholder="Address"/>
            <button onclick="return validate()">Login</button>
        </div>
    </form>
</body>
</html>