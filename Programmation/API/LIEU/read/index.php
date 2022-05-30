<?php

include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Id'])) {
  $id = $headers['Id'];
  echo json_encode(GetLieuForProject($id));
}
else{
  echo json_encode("wrong headers");
}
