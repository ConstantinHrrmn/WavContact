<?php

include_once "../../pdo.php";
include_once "../update/functions.php";

function CreateChatForClient($id){
  $collaborateurs = GetAllCollaborateurs();

  $req = "INSERT INTO `CHAT_GROUP`(`CLIENT_ID`) VALUES ($id)";
  $query = database()->prepare($req);
  $query->execute();

  $group_id = database()->lastInsertId();

  $req = "INSERT INTO `CHAT_MEMBER_OF`(`PERSONNE_ID`, `GROUP_ID`) VALUES ($id,$group_id);";
  for ($i=0; $i < count($collaborateurs); $i++) {
    $req = $req."INSERT INTO CHAT_MEMBER_OF(PERSONNE_ID, GROUP_ID) VALUES (".$collaborateurs[$i]['PERSONNE_ID'].",$group_id);";
  }

  $query = database()->prepare($req);
  $query->execute();

}

function GetAllCollaborateurs(){
  $req = "SELECT `PERSONNE_ID` FROM `PERSONNE` WHERE `FK_ROLE_ID` = 1;";
  $query = database()->prepare($req);
  $query->execute();

  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if ($matches == null) {
    return null;
  }else{
    return $matches;
  }
}

function CreateNewPerson($nom, $prenom, $email, $tel, $role, $active){
  $req = "INSERT INTO `PERSONNE`(`PERSONNE_NOM`, `PERSONNE_PRENOM`, `PERSONNE_MAIL`, `PERSONNE_MDP`, `PERSONNE_TEL`, `FK_ROLE_ID`, `PERSONNE_ACTIVE`) VALUES (:n,:p,:m,null,:t, :r, :a)";
  $query = database()->prepare($req);
  $query->bindParam(':n', $nom, PDO::PARAM_STR);
  $query->bindParam(':p', $prenom, PDO::PARAM_STR);
  $query->bindParam(':m', $email, PDO::PARAM_STR);
  $query->bindParam(':t', $tel, PDO::PARAM_STR);
  $query->bindParam(':r', $role, PDO::PARAM_STR);
  $query->bindParam(':a', $active, PDO::PARAM_STR);
  $query->execute();
}

function AddUserToAllChannels($id){
  $groups = GetAllGroups();

  $req = "";
  for ($i=0; $i < count($groups); $i++) {
    $group = $groups[$i]['group_id'];
    $req = $req."INSERT INTO `CHAT_MEMBER_OF`(`PERSONNE_ID`, `GROUP_ID`) VALUES ($id, $group);";
  }

  $query = database()->prepare($req);
  $query->execute();
}

function GetAllGroups(){
  $req = "SELECT `GROUP_ID` as group_id FROM `CHAT_GROUP`";
  $query = database()->prepare($req);
  $query->execute();

  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if ($matches == null) {
    return null;
  }else{
    return $matches;
  }
}

/*
// 0 : Collaborateur
// 1 : Client
// 2 : Photographe
function AddPersonToRole($idUser, $idRole){
  switch ($idRole) {
    case '0':
      InsertPersonInRole($idUser, "COLLABORATEUR");
      break;
    case '1':
      InsertPersonInRole($idUser, "CLIENT");
      break;
    case '2':
      InsertPersonInRole($idUser, "PHOTOGRAPHE");
      break;
    default:
      // code...
      break;
  }
}
*/


function AddPtRTable($idUser){
  $req = "INSERT INTO `PERSONNE`(`PERSONNE_NOM`, `PERSONNE_PRENOM`, `PERSONNE_MAIL`, `PERSONNE_MDP`, `PERSONNE_TEL`) VALUES (:n,:p,:m,null,:t)";
  $query = database()->prepare($req);
  $query->bindParam(':n', $nom, PDO::PARAM_STR);
  $query->bindParam(':p', $prenom, PDO::PARAM_STR);
  $query->bindParam(':m', $email, PDO::PARAM_STR);
  $query->bindParam(':t', $tel, PDO::PARAM_STR);
  $query->execute();
}

function AddPasswordToPerson($id, $pass){
  UpdatePassword($id, $pass);
}
