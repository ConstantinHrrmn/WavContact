<?php

function CreateCategorie($CATEGORIE_NOM){
  $req = "INSERT INTO `CATEGORIE`(`CATEGORIE_NOM`) VALUES (:nom)";
  $query = database()->prepare($req);
  $query->bindParam(':nom', $CATEGORIE_NOM, PDO::PARAM_STR);

  $query->execute();
}
