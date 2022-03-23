<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Idphotographe']) && isset($headers['Idlieu'])) {
  $idPhotographe = $headers['Idphotographe'];
  $idLieu = $headers['Idlieu'];

  echo json_encode(GetConsulteById($idPhotographe, $idLieu));

}elseif (isset($headers['Idphotographe'])) {
  $idPhotographe = $headers['Idphotographe'];

  echo json_encode(GetConsulteByIdPhotographe($idPhotographe));

}elseif (isset($headers['Idlieu'])) {
  $idLieu = $headers['Idlieu'];

  echo json_encode(GetConsulteByIdLieu($idLieu));

}elseif (isset($headers['All'])) {
  echo json_encode(GetAllConsulte());

}else{
  echo json_encode("wrong headers");
}
