<?php

include_once "pdo.php";
  // Préparation de la requête
  $query = database()->prepare("SELECT * FROM `CATEGORIE` LEFT JOIN `TAG` ON `CATEGORIE_ID` = `FK_CATEGORIE_ID` ORDER BY `CATEGORIE_NOM`, `TAG_NOM`");
  // Exécution de la requête
  $query->execute();
  // Stockage des données
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  // Condition pour l'envoi des données ou dans le cas contraire une erreur
  if($matches == null){
    echo json_encode("Une erreur s'est produite lors du chargement des tags par catégorie.", JSON_INVALID_UTF8_IGNORE);
  }
  else{
    echo json_encode($matches, JSON_INVALID_UTF8_IGNORE);
  }
 ?>
