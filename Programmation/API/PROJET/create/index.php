<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Nom']) && isset($headers['Description']) && isset($headers['Client']) && isset($headers['Valider'])) {

  $nom = $headers['Nom'];
  $description = $headers['Description'];
  $client = $headers['Client'];
  $valider = $headers['Valider'];

  CreateProjet($client, $nom, $description, $valider);
}else{
  echo json_encode("wrong headers");
}
