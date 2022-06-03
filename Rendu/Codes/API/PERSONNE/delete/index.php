<?php

include_once "../../pdo.php";
include "functions.php";

$headers = array();

foreach (getallheaders() as $name => $value) {
    $headers[$name] = $value;
}

if (isset($headers['Id'])) {
  DeletePersonne($headers['Id']);
  echo json_encode(true);
}else{
  echo json_encode("No headers");
}
