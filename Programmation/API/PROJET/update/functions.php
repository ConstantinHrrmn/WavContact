<?php

function UpdateProjet($PROJET_ID, $PROJET_CLIENT, $PROJET_NOM, $PROJET_DESCRIPTION, $PROJET_VALIDER, $PROJET_COMMENTAIRE){
  $req = "UPDATE `PROJET` SET `FK_PERSONNE_ID` = $PROJET_CLIENT, `PROJET_NOM` = '$PROJET_NOM', `PROJET_DESCRIPTION` = '$PROJET_DESCRIPTION', `PROJET_VALIDER` = $PROJET_VALIDER, `PROJET_COMMENTAIRE` = '$PROJET_COMMENTAIRE' WHERE `PROJET_ID` = $PROJET_ID";

  $query = database()->prepare($req);
  /*$query->bindParam(':id', $PROJET_ID, PDO::PARAM_STR);
  $query->bindParam(':nom', $PROJET_NOM, PDO::PARAM_STR);
  $query->bindParam(':description', $PROJET_DESCRIPTION, PDO::PARAM_STR);
  $query->bindParam(':client', $PROJET_CLIENT, PDO::PARAM_STR);
  $query->bindParam(':valid', $PROJET_VALIDER, PDO::PARAM_STR);*/
  $query->execute();
}
