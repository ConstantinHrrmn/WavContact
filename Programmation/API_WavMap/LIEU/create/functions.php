<?php

function CreateLieu($LIEU_NOM, $LIEU_LONGITUDE, $LIEU_LATITUDE, $LIEU_DESCRIPTION){
  $req = "INSERT INTO `LIEU`(`LIEU_NOM`, `LIEU_LONGITUDE`, `LIEU_LATITUDE`, `LIEU_DESCRIPTION`) VALUES (:nom, :longitude, :latitude, :description)";
  $query = database()->prepare($req);
  $query->bindParam(':nom', $LIEU_NOM, PDO::PARAM_STR);
  $query->bindParam(':longitude', $LIEU_LONGITUDE, PDO::PARAM_STR);
  $query->bindParam(':latitude', $LIEU_LATITUDE, PDO::PARAM_STR);
  $query->bindParam(':description', $LIEU_DESCRIPTION, PDO::PARAM_STR);
  $query->execute();
}
