<?php

include_once "../../pdo.php";
include_once "../update/functions.php";
include_once "../../ROLE/create/functions.php";

function CreateNewPerson($nom, $prenom, $email, $tel){
  $req = "INSERT INTO `PERSONNE`(`PERSONNE_NOM`, `PERSONNE_PRENOM`, `PERSONNE_MAIL`, `PERSONNE_MDP`, `PERSONNE_TEL`) VALUES (:n,:p,:m,null,:t)";
  $query = database()->prepare($req);
  $query->bindParam(':n', $nom, PDO::PARAM_STR);
  $query->bindParam(':p', $prenom, PDO::PARAM_STR);
  $query->bindParam(':m', $email, PDO::PARAM_STR);
  $query->bindParam(':t', $tel, PDO::PARAM_STR);
  $query->execute();
}

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
