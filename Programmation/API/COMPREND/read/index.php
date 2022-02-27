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

  echo json_encode(GetComprendById($idReservation, $idMateriel));

}elseif (isset($headers['All'])) {
  echo json_encode(GetAllComprend());

}elseif (isset($headers['Idreservation'])) {
  $idReservation = $headers['Idreservation'];

  echo json_encode(GetComprendByIdReservation($idReservation));

}elseif (isset($headers['Idmateriel'])) {
  $idMateriel = $headers['Idmateriel'];

  echo json_encode(GetComprendByIdMateriel($idMateriel));

}else{
  echo json_encode("wrong headers");
}
