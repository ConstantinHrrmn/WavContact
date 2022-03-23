<?php

include_once "../../pdo.php";


function GetGereById($idCollaborateur, $idProjet){
  $req = "SELECT `FK_PROJET_ID`, `FK_COLLABORATEUR_ID` FROM `GERE` WHERE `FK_PROJET_ID`= :idProjet AND `FK_COLLABORATEUR_ID`= :idCollaborateur";
  $query = database()->prepare($req);
  $query->bindParam(':idCollaborateur', $idCollaborateur, PDO::PARAM_STR);
  $query->bindParam(':idProjet', $idProjet, PDO::PARAM_STR);

  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}


function GetGereByIdCollaborateur($idCollaborateur){
  $req = "SELECT `FK_PROJET_ID`, `FK_COLLABORATEUR_ID` FROM `GERE` WHERE `FK_COLLABORATEUR_ID`= :idCollaborateur";
  $query = database()->prepare($req);
  $query->bindParam(':idCollaborateur', $idCollaborateur, PDO::PARAM_STR);

  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}


function GetGereByIdProjet($idProjet){
  $req = "SELECT `FK_PROJET_ID`, `FK_COLLABORATEUR_ID` FROM `GERE` WHERE `FK_PROJET_ID`= :idProjet";
  $query = database()->prepare($req);
  $query->bindParam(':idProjet', $idProjet, PDO::PARAM_STR);

  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}


function GetAllGere(){
  $req = "SELECT * FROM `GERE`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
