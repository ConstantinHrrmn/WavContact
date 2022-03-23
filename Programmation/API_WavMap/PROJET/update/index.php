<?php

include "../../pdo.php";
include "functions.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Id']) && isset($headers['Nom']) && isset($headers['Description']) && isset($headers['Client']) && isset($headers['Valider'])) {
  $id = $headers['Id'];
  $nom = $headers['Nom'];
  $description = $headers['Description'];
  $client = $headers['Client'];
  $valid = $headers['Valider'];

  UpdateProjet($id, $client, $nom, $description, $valid);

}else{
  echo json_encode("wrong headers");
}
