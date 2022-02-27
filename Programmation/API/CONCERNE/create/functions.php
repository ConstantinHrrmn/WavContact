<?php

// Faire une vérification avec les FK

function CreateConcerne($idProjet, $idLieu){
  $req = "INSERT INTO `CONCERNE`(`FK_PROJET_ID`, `FK_LIEU_ID`) VALUES (:idProjet, :idLieu)";
  $query = database()->prepare($req);
  $query->bindParam(':idProjet', $idProjet, PDO::PARAM_STR);
  $query->bindParam(':idLieu', $idLieu, PDO::PARAM_STR);

  $query->execute();
}
