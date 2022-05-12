<?php
include_once "../apiv2/pdo.php";
// Si la session est inconnu, on redemande une connexion sur le formulaire
if (!isset($_SESSION['user'])) {
  header('Location: https://waview.ch/wavcontact/map/register.php');
  exit;
}
else{
  echo json_encode("");
  // echo json_encode($_SESSION['user']);
}
?>
