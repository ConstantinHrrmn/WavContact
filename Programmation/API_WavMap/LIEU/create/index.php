<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Nom']) && isset($headers['Longitude']) && isset($headers['Latitude']) && isset($headers['Description'])) {
  $nom = $headers['Nom'];
  $description = $headers['Description'];
  $longitude = $headers['Longitude'];
  $latitude = $headers['Latitude'];

  CreateLieu($nom, $longitude, $latitude, $description);
}else{
  echo json_encode("wrong headers");
}
