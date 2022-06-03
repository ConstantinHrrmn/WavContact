<?php

include_once "pdo.php";

GetAllPlaces(); //appeler

function GetAllPlaces(){
  // Préparation de la requête
  $query = database()->prepare("SELECT * FROM `LIEU` LEFT JOIN PHOTO ON PHOTO.PHOTO_ID IN (SELECT LIEU_HAS_PHOTO.PK_FK_PHOTO_ID FROM LIEU_HAS_PHOTO WHERE LIEU_HAS_PHOTO.PK_FK_LIEU_ID = LIEU.LIEU_ID) JOIN `LIEU_HAS_TAG` ON `PK_FK_LIEU_ID` = `LIEU_ID` JOIN `TAG` ON `PK_FK_TAG_ID` = `TAG_ID` WHERE `FK_LIEU_STATUT` = 2");
  // Exécution de la requête
  $query->execute();
  // Stockage des données
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  // Condition pour l'envoi des données ou dans le cas contraire une erreur
  if($matches == null){
    echo json_encode("Une erreur s'est produite lors du chargement des lieux.", JSON_INVALID_UTF8_IGNORE);
  }
  else{
    echo json_encode($matches, JSON_INVALID_UTF8_IGNORE);
  }
}
?>
