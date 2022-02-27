<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Idevenement']) && isset($headers['Idprojet'])) {
  $idEvenement = $headers['Idevenement'];
  $idProjet = $headers['Idprojet'];

  echo json_encode(GetContientById($idEvenement, $idProjet));

}elseif (isset($headers['Idevenement'])) {
  $idEvenement = $headers['Idevenement'];

  echo json_encode(GetContientByIdEvenement($idEvenement));

}elseif (isset($headers['Idprojet'])) {
  $idProjet = $headers['Idprojet'];

  echo json_encode(GetContientByIdProjet($idProjet));

} elseif (isset($headers['All'])) {
  echo json_encode(GetAllContient());

}else{
  echo json_encode("wrong headers");
}
