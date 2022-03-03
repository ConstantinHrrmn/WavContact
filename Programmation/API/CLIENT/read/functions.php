<?php

include_once "../../pdo.php";
include_once "../../PROJET/read/functions.php";


function GetCategorieById($id){
  $req = "SELECT `CATEGORIE_ID`, `CATEGORIE_NOM` FROM `CATEGORIE` WHERE `CATEGORIE_ID` = :id";
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

function GetAllClients(){
  $req = "SELECT PERSONNE.PERSONNE_ID as id, PERSONNE.PERSONNE_NOM as last_name, PERSONNE.PERSONNE_PRENOM as first_name, PERSONNE.PERSONNE_MAIL as email, PERSONNE.PERSONNE_TEL as phone FROM PERSONNE WHERE PERSONNE.PERSONNE_ID IN (SELECT CLIENT.FK_PERSONNE_ID FROM CLIENT);";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    $final = array();
    for ($i=0; $i < count($matches); $i++) {
      $projets = GetProjetcsForUser($matches[$i]['id']);
      $data = array(
        "id" => $matches[$i]['id'],
        "last_name" => $matches[$i]['last_name'],
        "first_name" => $matches[$i]['first_name'],
        "email" => $matches[$i]['email'],
        "password" => $matches[$i]['password'],
        "phone" => $matches[$i]['phone'],
        "projets" => $projets
      );

      array_push($final, $data);
    }

    return $final;
  }
}

function GetClientId($idPerson){
  $req = "SELECT `CLIENT_ID` as id FROM `CLIENT` WHERE `FK_PERSONNE_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $idPerson, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetch(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches['id'];
  }
}
