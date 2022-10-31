<?php
session_start();
if(isset($_POST["name"])){
    $_SESSION["name"] = $_POST["name"];
    header("Location:blade.php");
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
        function validate(){
            var name = document.getElementById("name");
            // console.log(temp.length);
            if(name.value.trim().length == 0){
                name.style.cssText = "border : 1px solid red;";
                return false
            }
            else{
                name.style.cssText = "border : none";
                return true
            }
        }
    </script>
</head>
<body>
    <form action="index.php" method="POST">
        <div class="logincard">
            <p>User Information</p>
            <input type="text" name="name" id="name" placeholder="Full Name"/>
            <button onclick="return validate()">Next</button>
        </div>
    </form>
</body>
</html>