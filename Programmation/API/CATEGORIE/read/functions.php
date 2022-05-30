<?php

include_once "../../pdo.php";


function GetCategorieById($id){
  $req = "SELECT `CATEGORIE_ID` as Id, `CATEGORIE_NOM` as Nom FROM `CATEGORIE` WHERE `CATEGORIE_ID` = :id";
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

function GetAllCategorie(){
  $req = "SELECT `CATEGORIE_ID` as Id, `CATEGORIE_NOM` as Nom  FROM `CATEGORIE`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}

// Get Categorie by Catergorie_nom
function GetCategorieIdByName($nom){
  $req = "SELECT `CATEGORIE_ID` as Id FROM `CATEGORIE` WHERE `CATEGORIE_NOM` = :nom";
  $query = database()->prepare($req);
  $query->bindParam(':nom', $nom, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetch(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}