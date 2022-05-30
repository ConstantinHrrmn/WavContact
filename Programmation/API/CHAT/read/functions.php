<?php

function GetMessages($personne_id, $group_id){
  $req ="";
  if (IsAdmin($personne_id)) {
    $req = "SELECT `CHAT_MESSAGE_ID` as id, `MESSAGE_SENDER_ID` as senderId, PERSONNE.PERSONNE_PRENOM as prenom, `MESSAGE_GROUP_ID` as groupId, `MESSAGE_CONTENT` as content, `MESSAGE_TIME` as deliveryTime
    FROM `CHAT_MESSAGE` INNER JOIN PERSONNE ON PERSONNE.PERSONNE_ID = CHAT_MESSAGE.MESSAGE_SENDER_ID
    WHERE `MESSAGE_GROUP_ID` = :id
    ORDER BY `MESSAGE_TIME` ASC;";
  }else{
    $req = "SELECT `CHAT_MESSAGE_ID` as id, `MESSAGE_SENDER_ID` as senderId, PERSONNE.PERSONNE_PRENOM as prenom, `MESSAGE_GROUP_ID` as groupId, `MESSAGE_CONTENT` as content, `MESSAGE_TIME` as deliveryTime
    FROM `CHAT_MESSAGE` INNER JOIN PERSONNE ON PERSONNE.PERSONNE_ID = CHAT_MESSAGE.MESSAGE_SENDER_ID
    WHERE `MESSAGE_GROUP_ID` = :id
    AND `MESSAGE_HIDDEN` = 0
    ORDER BY `MESSAGE_TIME` ASC;";
  }

  $query = database()->prepare($req);
  $query->bindParam(':id', $group_id, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}

function GetMessage($id){
  $req = "SELECT `CHAT_MESSAGE_ID` as id, `MESSAGE_SENDER_ID` as senderId, PERSONNE.PERSONNE_PRENOM as prenom, `MESSAGE_GROUP_ID` as groupId, `MESSAGE_CONTENT` as content, `MESSAGE_TIME` as deliveryTime
  FROM `CHAT_MESSAGE`
  INNER JOIN PERSONNE ON PERSONNE.PERSONNE_ID = CHAT_MESSAGE.MESSAGE_SENDER_ID
  WHERE `CHAT_MESSAGE_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetch(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}

function GetNewMessages($personne_id, $group_id){
  $req = "SELECT `CHAT_MESSAGE_ID` as id, `MESSAGE_SENDER_ID` as senderId, PERSONNE.PERSONNE_PRENOM as prenom, `MESSAGE_GROUP_ID` as groupId, `MESSAGE_CONTENT` as content, `MESSAGE_TIME` as deliveryTime
  FROM `CHAT_MESSAGE` INNER JOIN PERSONNE ON PERSONNE.PERSONNE_ID = CHAT_MESSAGE.MESSAGE_SENDER_ID
  WHERE `CHAT_MESSAGE_ID` IN ( SELECT CHAT_SENDING_MESSAGE.MESSAGE_ID FROM CHAT_SENDING_MESSAGE WHERE CHAT_SENDING_MESSAGE.PERSONNE_ID = :p AND CHAT_SENDING_MESSAGE.GROUP_ID = :g );";
  $query = database()->prepare($req);
  $query->bindParam(':g', $group_id, PDO::PARAM_STR);
  $query->bindParam(':p', $personne_id, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}

function GetTotalUnreadCount($personne_id){
  $req = "SELECT COUNT(`OPENED`) as total FROM `CHAT_SENDING_MESSAGE` WHERE `PERSONNE_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $personne_id, PDO::PARAM_STR);
  $query->execute();

  $matches = $query->fetch(PDO::FETCH_ASSOC);
  if ($matches == null) {
    return null;
  }else{
    return $matches['total'];
  }
}

function GetUnreadCountForEachClient($personne_id){
  $req = "SELECT CHAT_GROUP.CLIENT_ID as client_id, COUNT(`MESSAGE_ID`) as total FROM `CHAT_SENDING_MESSAGE` INNER JOIN CHAT_GROUP ON CHAT_GROUP.GROUP_ID = CHAT_SENDING_MESSAGE.GROUP_ID WHERE `PERSONNE_ID` = :id GROUP BY CHAT_SENDING_MESSAGE.`GROUP_ID`;";
  $query = database()->prepare($req);
  $query->bindParam(':id', $personne_id, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}

function OpenMessages($personne_id, $group_id){
  $req = "DELETE FROM `CHAT_SENDING_MESSAGE` WHERE `PERSONNE_ID` = :p AND `GROUP_ID` = :g";
  $query = database()->prepare($req);

  $query->bindParam(':p', $personne_id, PDO::PARAM_STR);
  $query->bindParam(':g', $group_id, PDO::PARAM_STR);

  $query->execute();
}
