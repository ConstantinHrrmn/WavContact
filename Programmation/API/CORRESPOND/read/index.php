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

  echo json_encode(GetCorrespondById($idLieu, $idCritere));

}elseif (isset($headers['Idlieu'])) {
  $idLieu = $headers['Idlieu'];

  echo json_encode(GetCorrespondByIdLieu($idLieu));

}elseif (isset($headers['Idcritere'])) {
  $idCritere = $headers['Idcritere'];

  echo json_encode(GetCorrespondByIdCritere($idCritere));

}elseif (isset($headers['All'])) {
  echo json_encode(GetAllCorrespond());

}else{
  echo json_encode("wrong headers");
}
