<?php

include_once "../../pdo.php";

function GetProjetById($id){
  $req = "SELECT `PROJET_ID`, `FK_CLIENT_ID`, `PROJET_NOM`, `PROJET_DESCRIPTION`, `PROJET_VALIDER` FROM `PROJET` WHERE `PROJET_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}

function GetProjetcsForClient($id){
  $req = "SELECT `PROJET_ID`, `PROJET_NOM`, `PROJET_DESCRIPTION`, `PROJET_VALIDER` FROM `PROJET` WHERE `FK_CLIENT_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}

function GetProjetcsForUser($id){
  $req = "SELECT `PROJET_ID` as id, `PROJET_NOM` as name, `PROJET_DESCRIPTION` as description, `PROJET_VALIDER` as valider FROM `PROJET` WHERE `FK_CLIENT_ID` IN (SELECT CLIENT.CLIENT_ID FROM CLIENT WHERE CLIENT.FK_PERSONNE_ID = :id);";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}

function GetAllProjet(){
  $req = "SELECT * FROM `PROJET`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
