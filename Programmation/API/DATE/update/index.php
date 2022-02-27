<?php

include "../../pdo.php";
include "functions.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Id']) && isset($headers['Date']) && isset($headers['Heure'])) {
  $id = $headers['Id'];
  $date = $headers['Date'];
  $heure = $headers['Heure'];

  UpdateDate($id, $date, $heure);

}else{
  echo json_encode("wrong headers");
}
