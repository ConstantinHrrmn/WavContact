<?php

function UpdateEvenement($EVENEMENT_ID, $EVENEMENT_NOM){
  $req = "UPDATE `EVENEMENT` SET `EVENEMENT_NOM` = :nom WHERE `EVENEMENT_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $EVENEMENT_ID, PDO::PARAM_STR);
  $query->bindParam(':nom', $EVENEMENT_NOM, PDO::PARAM_STR);

  $query->execute();
}
