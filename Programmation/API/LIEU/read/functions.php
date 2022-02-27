<?php

include_once "../../pdo.php";


function GetLieuById($id){
  $req = "SELECT `LIEU_ID`, `LIEU_NOM`, `LIEU_LONGITUDE`, `LIEU_LATITUDE`, `LIEU_CRITERE`, `LIEU_DESCRIPTION` FROM `LIEU` WHERE `LIEU_ID` = :id";
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

function GetAllLieu(){
  $req = "SELECT * FROM `LIEU`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
