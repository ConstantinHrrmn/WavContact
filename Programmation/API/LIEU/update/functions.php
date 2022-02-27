<?php

function UpdateLieu($LIEU_ID, $LIEU_NOM, $LIEU_LONGITUDE, $LIEU_LATITUDE, $LIEU_DESCRIPTION){
  $req = "UPDATE `LIEU` SET `LIEU_NOM` = :nom, `LIEU_LONGITUDE` = :longitude, `LIEU_LATITUDE` = :latitude, `LIEU_DESCRIPTION` = :description WHERE `LIEU_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $LIEU_ID, PDO::PARAM_STR);
  $query->bindParam(':nom', $LIEU_NOM, PDO::PARAM_STR);
  $query->bindParam(':longitude', $LIEU_LONGITUDE, PDO::PARAM_STR);
  $query->bindParam(':latitude', $LIEU_LATITUDE, PDO::PARAM_STR);
  $query->bindParam(':description', $LIEU_DESCRIPTION, PDO::PARAM_STR);
  $query->execute();
}
