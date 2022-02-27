<?php

include_once "../../pdo.php";


function GetComprendById($idReservation, $idMateriel){
  $req = "SELECT `FK_RESERVATION_ID`, `FK_MATERIEL_ID` FROM `COMPREND` WHERE `FK_RESERVATION_ID`= :idReservation AND `FK_MATERIEL_ID`= :idMateriel";
  $query = database()->prepare($req);
  $query->bindParam(':idReservation', $idReservation, PDO::PARAM_STR);
  $query->bindParam(':idMateriel', $idMateriel, PDO::PARAM_STR);

  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}


function GetComprendByIdReservation($idReservation){
  $req = "SELECT `FK_RESERVATION_ID`, `FK_MATERIEL_ID` FROM `COMPREND` WHERE `FK_RESERVATION_ID`= :idReservation";
  $query = database()->prepare($req);
  $query->bindParam(':idReservation', $idReservation, PDO::PARAM_STR);

  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}


function GetComprendByIdMateriel($idMateriel){
  $req = "SELECT `FK_RESERVATION_ID`, `FK_MATERIEL_ID` FROM `COMPREND` WHERE `FK_MATERIEL_ID`= :idMateriel";
  $query = database()->prepare($req);
  $query->bindParam(':idMateriel', $idMateriel, PDO::PARAM_STR);

  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}


function GetAllComprend(){
  $req = "SELECT * FROM `COMPREND`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
