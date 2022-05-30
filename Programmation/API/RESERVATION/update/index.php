<?php

include "../../pdo.php";
include "functions.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Tournage']) && isset($headers['Projet']) && isset($headers['Materiel']) && isset($headers['Quantite'])) {
  $projet = $headers['Projet'];
  $quantite = $headers['Quantite'];
  $tournage = $headers['Tournage'];
  $materiel = $headers['Materiel'];

  UpdateReservation($tournage, $projet, $materiel, $quantite);

}else{
  echo json_encode("wrong headers !");
}
