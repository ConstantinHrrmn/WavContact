<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Lieu']) && isset($headers['Date']) && isset($headers['Chemin'])) {
  $lieu = $headers['Lieu'];
  $date = $headers['Date'];
  $chemin = $headers['Chemin'];

  CreatePhoto($lieu, $date, $chemin);
}else{
  echo json_encode("wrong headers");
}
