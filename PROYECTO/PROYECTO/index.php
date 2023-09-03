<?php

  session_start();

  require 'db.php';

  if (isset($_SESSION['Nombre'])) {
    $records = $conn->prepare("SELECT Nombre, email, Contraseña FROM usuario WHERE Nombre = :Nombre");
    $records->bindParam('Nombre', $_SESSION['Nombre']);
    $records->execute();
    $results = $records->fetch(PDO::FETCH_ASSOC);

    $user = null;

    if (count($results) > 0) {
      $Nombre = $results;
    }
  }
?>
fkp-vdfy-szs