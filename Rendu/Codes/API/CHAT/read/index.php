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

    if (isset($headers['New'])) {
      echo json_encode(GetNewMessages($personne_id, $group_id));
    }else{
      echo json_encode(GetMessages($personne_id, $group_id));
    }

    OpenMessages($personne_id, $group_id);
  }
}

else if(isset($headers['Personne']) && isset($headers['Total'])){
  $personne_id = $headers['Personne'];
  echo json_encode(GetTotalUnreadCount($personne_id));
}

else if(isset($headers['Personne'])){
  $personne_id = $headers['Personne'];
  echo json_encode(GetUnreadCountForEachClient($personne_id));
}

else if(isset($headers['Id'])){
  echo json_encode(GetMessage($headers['Id']));
}
