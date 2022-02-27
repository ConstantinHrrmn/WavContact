<?php

// Faire une vérification avec la FK_LIEU_ID

function CreateFichierVideo($LIEU_ID){
  $req = "INSERT INTO `FICHIERVIDEO`(`FK_LIEU_ID`) VALUES (:lieu)";
  $query = database()->prepare($req);
  $query->bindParam(':lieu', $LIEU_ID, PDO::PARAM_STR);

  $query->execute();
}
