<?php

include "../../pdo.php";
include "functions.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Id']) && isset($headers['Projet']) && isset($headers['Quantite']) && isset($headers['Debut']) && isset($headers['Fin'])) {
  $id = $headers['Id'];
  $projet = $headers['Projet'];
  $debut = $headers['Debut'];
  $fin = $headers['Fin'];
  $quantite = $headers['Quantite'];

  UpdateReservation($id, $projet, $quantite, $debut, $fin);

}else{
  echo json_encode("wrong headers");
}
