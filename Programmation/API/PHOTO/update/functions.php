<?php

function UpdatePhoto($PHOTO_ID, $LIEU, $PHOTO_DATE, $PHOTO_CHEMIN){

  $req = "UPDATE `PHOTO` SET `FK_LIEU_ID` = :lieu, `PHOTO_DATE` = :dat, `PHOTO_CHEMIN` = :chemin WHERE `PHOTO_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $PHOTO_ID, PDO::PARAM_STR);
  $query->bindParam(':lieu', $LIEU, PDO::PARAM_STR);
  $query->bindParam(':dat', $PHOTO_DATE, PDO::PARAM_STR);
  $query->bindParam(':chemin', $PHOTO_CHEMIN, PDO::PARAM_STR);

  $query->execute();
}
