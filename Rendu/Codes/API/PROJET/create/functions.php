<?php

// Faire une vérification avec la FK_CATEGORIE_ID

function CreateProjet($PROJET_CLIENT_ID, $PROJET_NOM, $PROJET_DESCRIPTION, $PROJET_VALIDER){
  $req = "INSERT INTO `PROJET`(`FK_PERSONNE_ID`, `PROJET_NOM`, `PROJET_DESCRIPTION`, `PROJET_VALIDER`) VALUES (:client, :nom, :description, :valid)";
  $query = database()->prepare($req);
  $query->bindParam(':nom', $PROJET_NOM, PDO::PARAM_STR);
  $query->bindParam(':client', $PROJET_CLIENT_ID, PDO::PARAM_STR);
  $query->bindParam(':description', $PROJET_DESCRIPTION, PDO::PARAM_STR);
  $query->bindParam(':valid', $PROJET_VALIDER, PDO::PARAM_STR);
  $query->execute();
}
