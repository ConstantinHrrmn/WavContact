<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Projet']) && isset($headers['Quantite']) && isset($headers['Debut']) && isset($headers['Fin'])) {
  $projet = $headers['Projet'];
  $quantite = $headers['Quantite'];
  $debut = $headers['Debut'];
  $fin = $headers['Fin'];

  CreateReservation($projet, $quantite, $debut, $fin);
}else{
  echo json_encode("wrong headers");
}
