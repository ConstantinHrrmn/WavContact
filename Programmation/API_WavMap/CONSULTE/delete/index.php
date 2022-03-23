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

  DeleteConsulte($idPhotographe, $idLieu);

}else{
  echo json_encode("wrong headers");
}
