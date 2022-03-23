<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Idreservation']) && isset($headers['Idmateriel'])) {
  $idReservation = $headers['Idreservation'];
  $idMateriel = $headers['Idmateriel'];

  CreateComprend($idReservation, $idMateriel);
}else{
  echo json_encode("wrong headers");
}
