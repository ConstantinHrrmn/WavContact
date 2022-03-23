<?php

include_once "../../pdo.php";


function GetCritereById($id){
  $req = "SELECT `CRITERE_ID`, `CRITERE_NOM` FROM `CRITERE` WHERE `CRITERE_ID` = :id";
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

function GetAllCritere(){
  $req = "SELECT * FROM `CRITERE`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
