<?php

// Faire une vérification avec les FK

function CreateComprend($idReservation, $idMateriel){
  $req = "INSERT INTO `COMPREND`(`FK_RESERVATION_ID`, `FK_MATERIEL_ID`) VALUES (:idReservation, :idMateriel)";
  $query = database()->prepare($req);
  $query->bindParam(':idReservation', $idReservation, PDO::PARAM_STR);
  $query->bindParam(':idMateriel', $idMateriel, PDO::PARAM_STR);

  $query->execute();
}
