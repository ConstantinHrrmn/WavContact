<?php

include_once "../../pdo.php";


function GetCorrespondById($idLieu, $idCritere){
  $req = "SELECT `FK_LIEU_ID`, `FK_CRITERE_ID` FROM `CORRESPOND` WHERE `FK_LIEU_ID`= :idLieu AND `FK_CRITERE_ID`= :idCritere";
  $query = database()->prepare($req);
  $query->bindParam(':idLieu', $idLieu, PDO::PARAM_STR);
  $query->bindParam(':idCritere', $idCritere, PDO::PARAM_STR);

  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}


function GetCorrespondByIdLieu($idLieu){
  $req = "SELECT `FK_LIEU_ID`, `FK_CRITERE_ID` FROM `CORRESPOND` WHERE `FK_LIEU_ID`= :idLieu";
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


function GetCorrespondByIdCritere($idCritere){
  $req = "SELECT `FK_LIEU_ID`, `FK_CRITERE_ID` FROM `CORRESPOND` WHERE `FK_CRITERE_ID`= :idCritere";
  $query = database()->prepare($req);
  $query->bindParam(':idCritere', $idCritere, PDO::PARAM_STR);

  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}


function GetAllCorrespond(){
  $req = "SELECT * FROM `CORRESPOND`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
