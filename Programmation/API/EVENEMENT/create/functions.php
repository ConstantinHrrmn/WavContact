<?php

function CreateEvenement($EVENEMENT_NOM){
  $req = "INSERT INTO `EVENEMENT`(`EVENEMENT_NOM`) VALUES (:nom)";
  $query = database()->prepare($req);
  $query->bindParam(':nom', $EVENEMENT_NOM, PDO::PARAM_STR);

  $query->execute();
}
