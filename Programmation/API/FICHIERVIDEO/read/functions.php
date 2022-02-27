<?php

include_once "../../pdo.php";


function GetFichierVideoById($id){
  $req = "SELECT `FICHIERVIDEO_ID`, `FK_LIEU_ID` FROM `FICHIERVIDEO` WHERE `FICHIERVIDEO_ID` = :id";
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

function GetAllFichierVideo(){
  $req = "SELECT * FROM `FICHIERVIDEO`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
