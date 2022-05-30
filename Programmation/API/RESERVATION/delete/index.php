<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Tournage']) && isset($headers['Projet']) && isset($headers['Materiel'])) {
  $projet = $headers['Projet'];
  $tournage = $headers['Tournage'];
  $materiel = $headers['Materiel'];

  DeleteReservation($tournage, $projet, $materiel);

}else{
  echo json_encode("wrong headers !");
}
