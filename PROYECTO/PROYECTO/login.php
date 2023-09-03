<?php

  session_start();

  if (isset($_SESSION["Nombre"])) {
    header('Location: /php-login');
  }
  require 'db.php';

  if (!empty($_POST['email']) && !empty($_POST['Contraseña'])) {
    $records = $conn->prepare('SELECT Nombre, email, Contraseña FROM users WHERE email = :email');
    $records->bindParam(':email', $_POST['email']);
    $records->execute();
    $results = $records->fetch(PDO::FETCH_ASSOC);

    $message = '';

    if (count($results) > 0 && password_verify($_POST['Contraseña'], $results['Contraseña'])) {
      $_SESSION["Nombre"] = $results["Nombre"];
      header("Location: /php-login");
    } else {
      $message = '¡Credenciales incorrectas!';
    }
  }

?>


<!DOCTYPE html>
<html lang="es" ></html>
<html>
<head>
  <title>Login</title>
  <link rel="stylesheet" type="text/css" href="css/style.css">
  <link href="https://fonts.googleapis.com/css?family=Poppins:600&display=swap" rel="stylesheet">
  <script src="https://kit.fontawesome.com/a81368914c.js"></script>
  <meta name="viewport" content="width=device-width, initial-scale=1">
</head>
<body>

  <form action="validar.php" method="post"></form>
  
  <img class="wave" src="img/wave.png">
  <div class="container">
    <div class="img">
      <img src="img/Maestro.svg">
    </div>

        <div class="login-content">
            <form action="index.html">
           <img src="img/Usuario.svg">
           <h2 class="title">Bienvenido</h2>
                      <div class="input-div one">
                       <div class="i">
                    <i class="fas fa-user"></i>
                 </div>


                 <div class="div">
                    <h5>Usuario</h5>
                    <input type="text" class="input">
                 </div>
              </div>
              <div class="input-div pass">
                 <div class="i"> 
                    <i class="fas fa-lock"></i>
                 </div>
                 <div class="div">
                    <h5>Contraseña</h5>
                    <input type="password" class="input">
                 </div>
              </div>
              
              <input type="submit" class="btn" value="Ingresar">
            </form>
        </div>
    </div>
    <script type="text/javascript" src="js/main.js"></script>
</body>
</html>