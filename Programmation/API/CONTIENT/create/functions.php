<?php

// Faire une vérification avec les FK

function CreateContient($idEvenement, $idProjet){
  $req = "INSERT INTO `CONTIENT`(`FK_EVENEMENT_ID`, `FK_PROJET_ID`) VALUES (:idEvenement, :idProjet)";
  $query = database()->prepare($req);
  $query->bindParam(':idEvenement', $idEvenement, PDO::PARAM_STR);
  $query->bindParam(':idProjet', $idProjet, PDO::PARAM_STR);

  $query->execute();
}
