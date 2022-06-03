<?php

function SendMessage($sender_id, $group_id, $content){
  $time = GetDateTime();

  $req = "INSERT INTO `CHAT_MESSAGE`(`MESSAGE_SENDER_ID`, `MESSAGE_GROUP_ID`, `MESSAGE_CONTENT`, `MESSAGE_TIME`) VALUES (:s, :i, :c, :t)";
  $query = database()->prepare($req);

  $query->bindParam(':s', $sender_id, PDO::PARAM_STR);
  $query->bindParam(':i', $group_id, PDO::PARAM_STR);
  $query->bindParam(':c', $content, PDO::PARAM_STR);
  $query->bindParam(':t', $time, PDO::PARAM_STR);

  $query->execute();

  $message_id = database()->lastInsertId();

  $members = GetAllMembersOfGroup($group_id, $sender_id);

  $req = "";
  for($i = 0; $i < count($members); $i++){
    $personne_id = $members[$i]['PERSONNE_ID'];
    $req = $req."INSERT INTO `CHAT_SENDING_MESSAGE`(`PERSONNE_ID`, `MESSAGE_ID`, `GROUP_ID`) VALUES ($personne_id, $message_id, $group_id);";
  }

  $query = database()->prepare($req);
  $query->execute();

  return $message_id;
}

function SendHiddenMessage($sender_id, $group_id, $content){
  $time = GetDateTime();

  $content = "[HIDDEN] ".$content;

  $req = "INSERT INTO `CHAT_MESSAGE`(`MESSAGE_SENDER_ID`, `MESSAGE_GROUP_ID`, `MESSAGE_CONTENT`, `MESSAGE_TIME`, `MESSAGE_HIDDEN`) VALUES (:s, :i, :c, :t, 1)";
  $query = database()->prepare($req);

  $query->bindParam(':s', $sender_id, PDO::PARAM_STR);
  $query->bindParam(':i', $group_id, PDO::PARAM_STR);
  $query->bindParam(':c', $content, PDO::PARAM_STR);
  $query->bindParam(':t', $time, PDO::PARAM_STR);

  $query->execute();

  $message_id = database()->lastInsertId();

  $members = GetAllCollaborateurs($sender_id);

  $req = "";
  for($i = 0; $i < count($members); $i++){
    $personne_id = $members[$i]['id'];
    $req = $req."INSERT INTO `CHAT_SENDING_MESSAGE`(`PERSONNE_ID`, `MESSAGE_ID`, `GROUP_ID`) VALUES ($personne_id, $message_id, $group_id);";
  }
  if($req != ""){
    $query = database()->prepare($req);
    $query->execute();
  }


  return $message_id;
}

function GetAllCollaborateurs($id){
  $req = "SELECT `PERSONNE_ID` as id FROM `PERSONNE` WHERE `FK_ROLE_ID` = 1 AND `PERSONNE_ID` != $id;";
  $query = database()->prepare($req);
  $query->execute();

  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if ($matches == null) {
    return null;
  }else{
    return $matches;
  }
}

function GetAllMembersOfGroup($group_id, $sender_id){
  $req = "SELECT `PERSONNE_ID` FROM `CHAT_MEMBER_OF` WHERE `GROUP_ID` = :g AND `PERSONNE_ID` != :s;";
  $query = database()->prepare($req);

  $query->bindParam(':g', $group_id, PDO::PARAM_STR);
  $query->bindParam(':s', $sender_id, PDO::PARAM_STR);

  $query->execute();

  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if ($matches == null) {
    return null;
  }else{
    return $matches;
  }
}
