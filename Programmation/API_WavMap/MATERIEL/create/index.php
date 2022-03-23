<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Nom']) && isset($headers['Description']) && isset($headers['Prix']) && isset($headers['Quantite']) && isset($headers['Categorie'])) {
  $nom = $headers['Nom'];
  $description = $headers['Description'];
  $prix = $headers['Prix'];
  $quantite = $headers['Quantite'];
  $categorie = $headers['Categorie'];

  CreateMateriel($nom, $categorie, $description, $prix, $quantite);
}else{
  echo json_encode("wrong headers");
}
