<?php

include "../../pdo.php";
include "functions.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Id']) && isset($headers['Nom'])) {
  $id = $headers['Id'];
  $nom = $headers['Nom'];

  UpdateEvenement($id, $nom);

}else{
  echo json_encode("wrong headers");
}
