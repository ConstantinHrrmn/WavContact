<?php

include "../../pdo.php";
include "functions.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if(isset($headers['Project'])){
  echo json_encode(GetDatesForProject($headers['Project']));
}

else if(isset($headers['Da'])){
  echo json_encode(GetDatesForDays($headers['Da'], 7));
}

else if(isset($headers['Do']) && isset($headers['Id'])){
  echo json_encode(GetDatesForDaysClient($headers['Do'], 7, $headers['Id']));
}
