<?php

include_once "../../pdo.php";


function GetContientById($idEvenement, $idProjet){
  $req = "SELECT `FK_EVENEMENT_ID`, `FK_PROJET_ID` FROM `CONTIENT` WHERE `FK_EVENEMENT_ID`= :idEvenement AND `FK_PROJET_ID`= :idProjet";
  $query = database()->prepare($req);
  $query->bindParam(':idEvenement', $idEvenement, PDO::PARAM_STR);
  $query->bindParam(':idProjet', $idProjet, PDO::PARAM_STR);

  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}


function GetContientByIdEvenement($idEvenement){
  $req = "SELECT `FK_EVENEMENT_ID`, `FK_PROJET_ID` FROM `CONTIENT` WHERE `FK_EVENEMENT_ID`= :idEvenement";
  $query = database()->prepare($req);
  $query->bindParam(':idEvenement', $idEvenement, PDO::PARAM_STR);

  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}


function GetContientByIdProjet($idProjet){
  $req = "SELECT `FK_EVENEMENT_ID`, `FK_PROJET_ID` FROM `CONTIENT` WHERE `FK_PROJET_ID`= :idProjet";
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


function GetAllContient(){
  $req = "SELECT * FROM `CONTIENT`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
