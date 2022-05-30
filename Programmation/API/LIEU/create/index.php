<?php


include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['IdLieu']) && isset($headers['IdProjet']) && isset($headers['IdTournage'])) {
  $idL = $headers['IdLieu'];
  $idP = $headers['IdPRojet'];
  $idT = $headers['IdTournage'];
  CreateLieuForProject($idL, $idP, $idT);
}
else{
  echo json_encode("wrong headers");
}
