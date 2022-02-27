<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Lieu'])) {
  $lieu = $headers['Lieu'];

  CreateFichierVideo($lieu);
}else{
  echo json_encode("wrong headers");
}
