<?php

function CreateCritere($CRITERE_NOM){
  $req = "INSERT INTO `CRITERE`(`CRITERE_NOM`) VALUES (:nom)";
  $query = database()->prepare($req);
  $query->bindParam(':nom', $CRITERE_NOM, PDO::PARAM_STR);

  $query->execute();
}
