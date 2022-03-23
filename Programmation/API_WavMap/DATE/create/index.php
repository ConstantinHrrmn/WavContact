<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Date']) && isset($headers['Heure'])) {
  $date = $headers['Date'];
  $heure = $headers['Heure'];

  CreateDate($date, $heure);
}else{
  echo json_encode("wrong headers");
}
