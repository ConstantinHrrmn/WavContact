<?php

function DeleteContient($idEvenement, $idProjet){

  $req = "DELETE FROM `CONTIENT` WHERE `FK_EVENEMENT_ID` = :idEvenement AND `FK_PROJET_ID` = :idProjet";
  $query = database()->prepare($req);
  $query->bindParam(':idEvenement', $idEvenement, PDO::PARAM_STR);
  $query->bindParam(':idProjet', $idProjet, PDO::PARAM_STR);
  $query->execute();
}
