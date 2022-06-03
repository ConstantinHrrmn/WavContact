<?php
include "../../pdo.php";

$id = $_SESSION['user']['id'];

echo json_encode(GetTournages($id));

function GetTournages($id){
  $req = "SELECT TOURNAGE.TOURNAGE_ID as idTournage, PROJET.PROJET_ID as idProjet, TOURNAGE.TOURNAGE_DEBUT as debut, TOURNAGE.TOURNAGE_FIN as fin FROM TOURNAGE INNER JOIN PROJET ON PROJET.PROJET_ID = TOURNAGE.TOURNAGE_PROJET_ID WHERE TOURNAGE.TOURNAGE_PROJET_ID IN (SELECT PROJET.PROJET_ID FROM PROJET WHERE PROJET.FK_PERSONNE_ID = :id);";
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
