<?php

include "../../pdo.php";
include "functions.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Id']) && isset($headers['Lieu'])) {
  $id = $headers['Id'];
  $lieu = $headers['Lieu'];

  UpdateFichierVideo($id, $lieu);

}else{
  echo json_encode("wrong headers");
}
