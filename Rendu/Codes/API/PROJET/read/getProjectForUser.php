<?php

include_once "../../pdo.php";

$id = $_SESSION['user']['id'];

echo json_encode(GetProjetcsForUser($id));

function GetProjetcsForUser($id){
  $req = "SELECT `PROJET_ID` as id, `PROJET_NOM` as name, `PROJET_DESCRIPTION` as description, `PROJET_VALIDER` as valider, `PROJET_COMMENTAIRE` as commentaire FROM `PROJET` WHERE `FK_PERSONNE_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
