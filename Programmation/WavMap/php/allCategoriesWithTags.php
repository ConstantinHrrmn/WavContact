<?php

include_once "pdo.php";

GetAllCategoriesWithTag(); //appeler

function GetAllCategoriesWithTag(){
  $req = "SELECT * FROM `CATEGORIE` JOIN `TAG` ON `CATEGORIE_ID` = `FK_CATEGORIE_ID` ORDER BY `CATEGORIE_ID`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    echo json_encode("Une erreur s'est produite lors du chargement des tags par catégorie.", JSON_INVALID_UTF8_IGNORE);
  }
  else{
    echo json_encode($matches, JSON_INVALID_UTF8_IGNORE);
  }
}
 ?>
