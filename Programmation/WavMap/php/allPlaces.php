<?php

include_once "pdo.php";

GetAllPlaces(); //appeler

function GetAllPlaces(){
  //$req = "SELECT * FROM `LIEU` JOIN `LIEU_HAS_PHOTO` ON `PK_FK_LIEU_ID` = `LIEU_ID`";
  $req = "SELECT * FROM `LIEU`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    echo json_encode("Une erreur s'est produite lors du chargement des lieux.", JSON_INVALID_UTF8_IGNORE);
  }
  else{

    echo json_encode($matches, JSON_INVALID_UTF8_IGNORE);
  }
}
?>
