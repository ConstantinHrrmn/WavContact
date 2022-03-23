<?php

function DeleteComprend($idReservation, $idMateriel){

  $req = "DELETE FROM `COMPREND` WHERE `FK_RESERVATION_ID` = :idReservation AND `FK_MATERIEL_ID` = :idMateriel";
  $query = database()->prepare($req);
  $query->bindParam(':idReservation', $idReservation, PDO::PARAM_STR);
  $query->bindParam(':idMateriel', $idMateriel, PDO::PARAM_STR);
  $query->execute();
}
