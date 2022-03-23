<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Idcollaborateur']) && isset($headers['Idprojet'])) {
  $idCollaborateur = $headers['Idcollaborateur'];
  $idProjet = $headers['Idprojet'];

  CreateGere($idCollaborateur, $idProjet);
}else{
  echo json_encode("wrong headers");
}
