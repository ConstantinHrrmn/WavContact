<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Idprojet']) && isset($headers['Idlieu'])) {
  $Idprojet = $headers['Idprojet'];
  $Idlieu = $headers['Idlieu'];

  echo json_encode(GetConcerneById($Idprojet, $Idlieu));

}elseif (isset($headers['Idprojet'])) {
  $Idprojet = $headers['Idprojet'];

  echo json_encode(GetConcerneByIdprojet($Idprojet));

}elseif (isset($headers['Idlieu'])) {
  $Idlieu = $headers['Idlieu'];

  echo json_encode(GetConcerneByIdlieu($Idlieu));

}elseif (isset($headers['All'])) {
  echo json_encode(GetAllConcerne());

}else{
  echo json_encode("wrong headers");
}
