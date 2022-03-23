<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Idprojet']) && isset($headers['Iddate'])) {
  $idProjet = $headers['Idprojet'];
  $idDate = $headers['Iddate'];

  CreateA_Lieu($idProjet, $idDate);
}else{
  echo json_encode("wrong headers");
}
