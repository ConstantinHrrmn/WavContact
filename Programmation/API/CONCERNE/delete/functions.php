<?php

function DeleteConcerne($idProjet, $idLieu){

  $req = "DELETE FROM `CONCERNE` WHERE `FK_PROJET_ID` = :idProjet AND `FK_LIEU_ID` = :idLieu";
  $query = database()->prepare($req);
  $query->bindParam(':idProjet', $idProjet, PDO::PARAM_STR);
  $query->bindParam(':idLieu', $idLieu, PDO::PARAM_STR);
  $query->execute();
}
