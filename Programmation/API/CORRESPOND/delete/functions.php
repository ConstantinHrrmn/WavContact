<?php

function DeleteCorrespond($idLieu, $idCritere){

  $req = "DELETE FROM `CORRESPOND` WHERE `FK_LIEU_ID` = :idLieu AND `FK_CRITERE_ID` = :idCritere";
  $query = database()->prepare($req);
  $query->bindParam(':idLieu', $idLieu, PDO::PARAM_STR);
  $query->bindParam(':idCritere', $idCritere, PDO::PARAM_STR);
  $query->execute();
}
