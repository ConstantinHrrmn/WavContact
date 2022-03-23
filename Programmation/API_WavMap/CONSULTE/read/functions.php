<?php

include_once "../../pdo.php";


function GetConsulteById($idPhotographe, $idLieu){
  $req = "SELECT `FK_PHOTOGRAPHE_ID`, `FK_LIEU_ID` FROM `CONSULTE` WHERE `FK_PHOTOGRAPHE_ID`= :idPhotographe AND `FK_LIEU_ID`= :idLieu";
  $query = database()->prepare($req);
  $query->bindParam(':idPhotographe', $idPhotographe, PDO::PARAM_STR);
  $query->bindParam(':idLieu', $idLieu, PDO::PARAM_STR);

  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}


function GetConsulteByIdPhotographe($idPhotographe){
  $req = "SELECT `FK_PHOTOGRAPHE_ID`, `FK_LIEU_ID` FROM `CONSULTE` WHERE `FK_PHOTOGRAPHE_ID`= :idPhotographe";
  $query = database()->prepare($req);
  $query->bindParam(':idPhotographe', $idPhotographe, PDO::PARAM_STR);

  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}


function GetConsulteByIdLieu($idLieu){
  $req = "SELECT `FK_PHOTOGRAPHE_ID`, `FK_LIEU_ID` FROM `CONSULTE` WHERE `FK_LIEU_ID`= :idLieu";
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


function GetAllConsulte(){
  $req = "SELECT * FROM `CONSULTE`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
