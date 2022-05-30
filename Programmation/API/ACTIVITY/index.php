<?php

include "../pdo.php";
include "functions.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['User']) && isset($headers['Project']) && isset($headers['Activity'])) {
  $user = $headers['User'];
  $project = $headers['Project'];
  $text = $headers['Activity'];
  $time = GetDateTime();

  NewActivity($user, $project, $text, $time);
}

elseif (isset($headers['Id'])) {
  echo json_encode(GetLogsForProject($headers['Id']));
}

elseif (isset($headers['Last'])) {
  $amount = $headers['Last'];

  echo json_encode(GetLastActivities($amount));
}
else{
  echo json_encode("wrong headers");
}
