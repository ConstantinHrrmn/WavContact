<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Idevenement']) && isset($headers['Idprojet'])) {
  $idEvenement = $headers['Idevenement'];
  $idProjet = $headers['Idprojet'];

  DeleteContient($idEvenement, $idProjet);

}else{
  echo json_encode("wrong headers");
}
