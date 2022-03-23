<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Idprojet']) && isset($headers['Iddate'])) {
  $idProjet = $headers['Idprojet'];
  $idDate = $headers['Iddate'];

  echo json_encode(GetA_LieuById($idProjet, $idDate));

}elseif (isset($headers['Idprojet'])) {
  $idProjet = $headers['Idprojet'];

  echo json_encode(GetA_LieuByIdProjet($idProjet));

}elseif (isset($headers['Iddate'])) {
  $idDate = $headers['Iddate'];

  echo json_encode(GetA_LieuByIdDate($idDate));

}elseif (isset($headers['All'])) {
  echo json_encode(GetAllA_Lieu());

}else{
  echo json_encode("wrong headers");
}
