<?php


include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}


if (isset($headers['Idlieu']) && isset($headers['Idprojet']) && isset($headers['Idtournage'])) {
  $idL = $headers['Idlieu'];
  $idP = $headers['Idprojet'];
  $idT = $headers['Idtournage'];
  DeleteLieuForProject($idL, $idP, $idT);
}
else{
  echo json_encode("wrong headers");
}
