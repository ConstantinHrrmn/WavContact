<?php

include "../../pdo.php";
include "functions.php";
include "../check.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if( isset($headers['Sender']) && isset($headers['Group']) && isset($headers['Content']) ){
  $sender_id = $headers['Sender'];
  $group_id = $headers['Group'];
  $content = $headers['Content'];

  $group_id = IsInClientGroup($sender_id, $group_id);

  if ($group_id != null) {
    if(isset($headers['Hidden'])){
      echo json_encode(SendHiddenMessage($sender_id, $group_id, $content));
    }else{
      echo json_encode(SendMessage($sender_id, $group_id, $content));
    }

  }else{
    echo json_encode("Not in group to get the chat");
  }
}
