<?php

function UpdateCategorie($CATEGORIE_ID, $CATEGORIE_NOM){
  $req = "UPDATE `CATEGORIE` SET `CATEGORIE_NOM` = :nom WHERE `CATEGORIE_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $CATEGORIE_ID, PDO::PARAM_STR);
  $query->bindParam(':nom', $CATEGORIE_NOM, PDO::PARAM_STR);

  $query->execute();
}
