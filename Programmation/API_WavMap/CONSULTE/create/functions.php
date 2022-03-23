<?php

// Faire une vérification avec les FK

function CreateConsulte($idPhotographe, $idLieu){
  $req = "INSERT INTO `CONSULTE`(`FK_PHOTOGRAPHE_ID`, `FK_LIEU_ID`) VALUES (:idPhotographe, :idLieu)";
  $query = database()->prepare($req);
  $query->bindParam(':idPhotographe', $idPhotographe, PDO::PARAM_STR);
  $query->bindParam(':idLieu', $idLieu, PDO::PARAM_STR);

  $query->execute();
}
