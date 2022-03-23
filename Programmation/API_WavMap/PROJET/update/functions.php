<?php

function UpdateProjet($PROJET_ID, $PROJET_CLIENT, $PROJET_NOM, $PROJET_DESCRIPTION, $PROJET_VALIDER){
  $req = "UPDATE `PROJET` SET `FK_CLIENT_ID` = :client, `PROJET_NOM` = :nom, `PROJET_DESCRIPTION` = :description, `PROJET_VALIDER` = :valid WHERE `PROJET_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $PROJET_ID, PDO::PARAM_STR);
  $query->bindParam(':nom', $PROJET_NOM, PDO::PARAM_STR);
  $query->bindParam(':description', $PROJET_DESCRIPTION, PDO::PARAM_STR);
  $query->bindParam(':client', $PROJET_CLIENT, PDO::PARAM_STR);
  $query->bindParam(':valid', $PROJET_VALIDER, PDO::PARAM_STR);
  $query->execute();
}
