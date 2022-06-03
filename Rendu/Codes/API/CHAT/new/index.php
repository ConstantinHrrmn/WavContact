<?php

include "../../pdo.php";
include "functions.php";
include "../check.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if( isset($headers['Personne']) && isset($headers['Client']) ){
  $personne_id = $headers['Personne'];
  $client_id = $headers['Client'];

  $group_id = IsInClientGroup($personne_id, $client_id);

  if ($group_id != null) {
    OpenMessages($personne_id, $group_id);
  }
}
