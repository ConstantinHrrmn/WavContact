<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Idlieu']) && isset($headers['Idcritere'])) {
  $idLieu = $headers['Idlieu'];
  $idCritere = $headers['Idcritere'];

  CreateCorrespond($idLieu, $idCritere);
}else{
  echo json_encode("wrong headers");
}
