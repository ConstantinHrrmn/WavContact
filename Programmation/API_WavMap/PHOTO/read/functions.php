<?php

include_once "../../pdo.php";


function GetPhotoById($id){
  $req = "SELECT `PHOTO_ID`, `FK_LIEU_ID`, `PHOTO_DATE`, `PHOTO_CHEMIN` FROM `PHOTO` WHERE `PHOTO_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetch(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}

function GetAllPhoto(){
  $req = "SELECT * FROM `PHOTO`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
