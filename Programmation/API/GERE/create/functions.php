<?php

// Faire une vérification avec les FK

function CreateGere($idCollaborateur, $idProjet){
  $req = "INSERT INTO `GERE`(`FK_PROJET_ID`, `FK_COLLABORATEUR_ID`) VALUES (:idProjet, :idCollaborateur)";
  $query = database()->prepare($req);
  $query->bindParam(':idCollaborateur', $idCollaborateur, PDO::PARAM_STR);
  $query->bindParam(':idProjet', $idProjet, PDO::PARAM_STR);

  $query->execute();
}
