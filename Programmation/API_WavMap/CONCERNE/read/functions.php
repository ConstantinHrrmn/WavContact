<?php

include_once "../../pdo.php";


function GetConcerneById($idProjet, $idLieu){
  $req = "SELECT `FK_PROJET_ID`, `FK_LIEU_ID` FROM `CONCERNE` WHERE `FK_PROJET_ID`= :idProjet AND `FK_LIEU_ID`= :idLieu";
  $query = database()->prepare($req);
  $query->bindParam(':idProjet', $idProjet, PDO::PARAM_STR);
  $query->bindParam(':idLieu', $idLieu, PDO::PARAM_STR);

  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}


function GetConcerneByIdProjet($idProjet){
  $req = "SELECT `FK_PROJET_ID`, `FK_LIEU_ID` FROM `CONCERNE` WHERE `FK_PROJET_ID`= :idProjet";
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


function GetConcerneByIdLieu($idLieu){
  $req = "SELECT `FK_PROJET_ID`, `FK_LIEU_ID` FROM `CONCERNE` WHERE `FK_LIEU_ID`= :idLieu";
  $query = database()->prepare($req);
  $query->bindParam(':idLieu', $idLieu, PDO::PARAM_STR);

  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}


function GetAllConcerne(){
  $req = "SELECT * FROM `CONCERNE`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
