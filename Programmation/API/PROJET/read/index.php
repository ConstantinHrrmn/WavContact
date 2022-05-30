<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

//var_dump($headers);

if (isset($headers['Id'])) {
  $id = $headers['Id'];
  echo json_encode(GetProjetById($id));
}
elseif (isset($headers['All'])) {
  echo json_encode(GetAllProjet());

}
else if (isset($headers['Clientid'])) {
  $id = $headers['Clientid'];
  echo json_encode(GetProjetcsForClient($id));
}
else if (isset($headers['Userid'])) {
  $id = $headers['Userid'];
  echo json_encode(GetProjetcsForUser($id));
}
else{
  echo json_encode("wrong headers");
}
