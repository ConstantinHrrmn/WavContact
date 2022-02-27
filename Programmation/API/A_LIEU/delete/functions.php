<?php

function DeleteA_LIEU($idProjet, $idDate){

  $req = "DELETE FROM `A_LIEU` WHERE `FK_PROJET_ID` = :idProjet AND `FK_DATE_ID` = :idDate";
  $query = database()->prepare($req);
  $query->bindParam(':idProjet', $idProjet, PDO::PARAM_STR);
  $query->bindParam(':idDate', $idDate, PDO::PARAM_STR);
  $query->execute();
}
