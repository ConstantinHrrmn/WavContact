<?php

function IsInClientGroup($personne_id, $client_id){
  $req = "SELECT CMO.GROUP_ID as group_id FROM `CHAT_MEMBER_OF` as CMO WHERE CMO.GROUP_ID IN (SELECT CHAT_GROUP.GROUP_ID FROM CHAT_GROUP WHERE CHAT_GROUP.CLIENT_ID = :c) AND CMO.PERSONNE_ID = :p;";
  $query = database()->prepare($req);

  $query->bindParam(':c', $client_id, PDO::PARAM_STR);
  $query->bindParam(':p', $personne_id, PDO::PARAM_STR);

  $query->execute();

  $matches = $query->fetch(PDO::FETCH_ASSOC);
  if ($matches == null) {
    return null;
  }else{
    return $matches['group_id'];
  }
}

function IsInGroup($personne_id, $group_id){
  $req = "SELECT CMO.GROUP_ID as group_id FROM `CHAT_MEMBER_OF` as CMO WHERE CMO.GROUP_ID = :p;";
  $query = database()->prepare($req);

  $query->bindParam(':p', $group_id, PDO::PARAM_STR);

  $query->execute();

  $matches = $query->fetch(PDO::FETCH_ASSOC);
  if ($matches == null) {
    return null;
  }else{
    return $matches['group_id'];
  }
}

function IsAdmin($personne_id){
  $req = "SELECT `PERSONNE_ID` FROM `PERSONNE` WHERE `FK_ROLE_ID` = 1 AND `PERSONNE_ID` = :id LIMIT 1;";
  $query = database()->prepare($req);

  $query->bindParam(':id', $personne_id, PDO::PARAM_STR);

  $query->execute();

  $matches = $query->fetch(PDO::FETCH_ASSOC);
  if ($matches == null) {
    return false;
  }else{
    return true;
  }
}

function GetDateTime(){
  $date = new DateTime("now", new DateTimeZone('Europe/Zurich') );
  return $date->format('Y-m-d H:i:s.ms');
}
