<?php

include_once "pdo.php";

GetAllTags(); //appeler

function GetAllTags(){
  // Préparation de la requête
  $query = database()->prepare("SELECT TAG_NOM FROM `TAG` ORDER BY NB_SELECTION DESC LIMIT 10");
  // Exécution de la requête
  $query->execute();
  // Stockage des données
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  // Condition pour l'envoi des données ou dans le cas contraire une erreur
  if($matches == null){
    echo json_encode("Une erreur s'est produite lors du chargement des tags.", JSON_INVALID_UTF8_IGNORE);
  }
  else{
    echo json_encode($matches, JSON_INVALID_UTF8_IGNORE);
  }
}
?>
