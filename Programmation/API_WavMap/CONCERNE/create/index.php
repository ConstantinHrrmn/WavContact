<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Idprojet']) && isset($headers['Idlieu'])) {
  $idProjet = $headers['Idprojet'];
  $idLieu = $headers['Idlieu'];

  CreateConcerne($idProjet, $idLieu);
}else{
  echo json_encode("wrong headers");
}
