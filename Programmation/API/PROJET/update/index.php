<?php

include "../../pdo.php";
include "functions.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Id']) && isset($headers['Nom']) && isset($headers['Description']) && isset($headers['Client']) && isset($headers['Valider']) && isset($headers['Commentaire'])) {
  $id = $headers['Id'];
  $nom = $headers['Nom'];
  $description = $headers['Description'];
  $client = $headers['Client'];
  $valid = $headers['Valider'];
  $commentaire = $headers['Commentaire'];

  UpdateProjet($id, $client, $nom, $description, $valid, $commentaire);

}else{
  echo json_encode("wrong headers");
}
