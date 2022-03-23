<?php

include "../../pdo.php";
include "functions.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Id']) && isset($headers['Nom']) && isset($headers['Longitude']) && isset($headers['Latitude']) && isset($headers['Description'])) {
  $id = $headers['Id'];
  $nom = $headers['Nom'];
  $longitude = $headers['Longitude'];
  $latitude = $headers['Latitude'];
  $description = $headers['Description'];

  UpdateLieu($id, $nom, $longitude, $latitude, $description);

}else{
  echo json_encode("wrong headers");
}
