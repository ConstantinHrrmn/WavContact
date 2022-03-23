<?php
include_once "functions.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['All'])) {
  echo json_encode(GetAllClients());
}else{
  echo json_encode("wrong headers");
}
