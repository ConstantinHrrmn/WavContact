<?php

function DeleteGere($idCollaborateur, $idProjet){

  $req = "DELETE FROM `GERE` WHERE `FK_COLLABORATEUR_ID` = :idCollaborateur AND `FK_PROJET_ID` = :idProjet";
  $query = database()->prepare($req);
  $query->bindParam(':idCollaborateur', $idCollaborateur, PDO::PARAM_STR);
  $query->bindParam(':idProjet', $idProjet, PDO::PARAM_STR);
  $query->execute();
}
