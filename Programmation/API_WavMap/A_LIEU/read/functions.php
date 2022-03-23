<?php

include_once "../../pdo.php";


function GetA_LieuById($idProjet, $idDate){
  $req = "SELECT `FK_PROJET_ID`, `FK_DATE_ID` FROM `A_LIEU` WHERE `FK_PROJET_ID`= :idProjet AND `FK_DATE_ID`= :idDate";
  $query = database()->prepare($req);
  $query->bindParam(':idProjet', $idProjet, PDO::PARAM_STR);
  $query->bindParam(':idDate', $idDate, PDO::PARAM_STR);

  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}


function GetA_LieuByIdProjet($idProjet){
  $req = "SELECT `FK_PROJET_ID`, `FK_DATE_ID` FROM `A_LIEU` WHERE `FK_PROJET_ID`= :idProjet";
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


function GetA_LieuByIdDate($idDate){
  $req = "SELECT `FK_PROJET_ID`, `FK_DATE_ID` FROM `A_LIEU` WHERE `FK_DATE_ID`= :idDate";
  $query = database()->prepare($req);
  $query->bindParam(':idDate', $idDate, PDO::PARAM_STR);

  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}


function GetAllA_Lieu(){
  $req = "SELECT * FROM `A_LIEU`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
