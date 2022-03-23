<?php

// Faire une vérification avec la FK_LIEU_ID

function CreatePhoto($LIEU, $PHOTO_DATE, $PHOTO_CHEMIN){
  $req = "INSERT INTO `PHOTO`(`FK_LIEU_ID`, `PHOTO_DATE`, `PHOTO_CHEMIN`) VALUES (:lieu, :dat, :chemin)";
  $query = database()->prepare($req);
  $query->bindParam(':lieu', $LIEU, PDO::PARAM_STR);
  $query->bindParam(':dat', $PHOTO_DATE, PDO::PARAM_STR);
  $query->bindParam(':chemin', $PHOTO_CHEMIN, PDO::PARAM_STR);

  $query->execute();
}
