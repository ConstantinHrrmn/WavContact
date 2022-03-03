<?php

include_once "../../pdo.php";
include_once "functions.php";

include_once "../../CLIENT/read/functions.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Nom']) && isset($headers['Description']) && isset($headers['Client']) && isset($headers['Valider'])) {

  $nom = $headers['Nom'];
  $description = $headers['Description'];
  $client = $headers['Client'];
  $valider = $headers['Valider'];

  $c = GetClientId($client);

  if ($c == null) {
    echo json_encode("The user is not a client");
  }else{
    CreateProjet($c, $nom, $description, $valider);
    echo json_encode("Project created");
  }


}else{
  echo json_encode("wrong headers");
}
