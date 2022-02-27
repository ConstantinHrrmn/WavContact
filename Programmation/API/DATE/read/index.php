<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Id'])) {
  $id = $headers['Id'];

  echo json_encode(GetDateById($id));

}elseif (isset($headers['All'])) {
  echo json_encode(GetAllDate());

}else{
  echo json_encode("wrong headers");
}
