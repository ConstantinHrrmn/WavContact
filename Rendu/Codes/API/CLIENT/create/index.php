<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Nom'])) {
  $nom = $headers['Nom'];

  CreateCategorie($nom);
}else{
  echo json_encode("wrong headers");
}
