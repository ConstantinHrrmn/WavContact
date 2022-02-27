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

  echo json_encode(GetGereById($idCollaborateur, $idProjet));

}elseif (isset($headers['Idcollaborateur'])) {
  $idCollaborateur = $headers['Idcollaborateur'];

  echo json_encode(GetGereByIdCollaborateur($idCollaborateur));

}elseif (isset($headers['Idprojet'])) {
  $idProjet = $headers['Idprojet'];

  echo json_encode(GetGereByIdProjet($idProjet));

}elseif (isset($headers['All'])) {
  echo json_encode(GetAllGere());

}else{
  echo json_encode("wrong headers");
}
