<?php

include_once "../../pdo.php";


function GetMaterielById($id){
  $req = "SELECT `MATERIEL_ID` as Id, `FK_CATEGORIE_ID` as IdCat, `MATERIEL_NOM` as Nom, `MATERIEL_DESCRIPTION` as Description, `MATERIEL_PRIX` as Prix, `MATERIEL_QUANTITE` as Quantite FROM `MATERIEL` WHERE `MATERIEL_ID` = :id";
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

function GetAllMateriel(){
  $req = "SELECT `MATERIEL_ID` as Id, `FK_CATEGORIE_ID` as IdCat, `MATERIEL_NOM` as Nom, `MATERIEL_DESCRIPTION` as Description, `MATERIEL_PRIX` as Prix, `MATERIEL_QUANTITE` as Quantite FROM `MATERIEL`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
