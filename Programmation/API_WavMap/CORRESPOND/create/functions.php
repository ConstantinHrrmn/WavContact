<?php

// Faire une vérification avec les FK

function CreateCorrespond($idLieu, $idCritere){
  $req = "INSERT INTO `CORRESPOND`(`FK_LIEU_ID`, `FK_CRITERE_ID`) VALUES (:idLieu, :idCritere)";
  $query = database()->prepare($req);
  $query->bindParam(':idLieu', $idLieu, PDO::PARAM_STR);
  $query->bindParam(':idCritere', $idCritere, PDO::PARAM_STR);

  $query->execute();
}
