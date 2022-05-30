<?php

function OpenMessages($personne_id, $group_id){
  $req = "DELETE FROM `CHAT_SENDING_MESSAGE` WHERE `PERSONNE_ID` = :p AND `GROUP_ID` = :g";
  $query = database()->prepare($req);

  $query->bindParam(':p', $personne_id, PDO::PARAM_STR);
  $query->bindParam(':g', $group_id, PDO::PARAM_STR);

  $query->execute();
}
