<?php

include_once "pdo.php";

GetAllTags(); //appeler

function GetAllTags(){
  $req = "SELECT * FROM `TAG`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    echo json_encode("Une erreur s'est produite lors du chargement des tags.", JSON_INVALID_UTF8_IGNORE);
  }
  else{
    echo json_encode($matches, JSON_INVALID_UTF8_IGNORE);
  }
}
 ?>
