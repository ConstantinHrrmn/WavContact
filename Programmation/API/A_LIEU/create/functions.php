<?php

// Faire une vérification avec les FK

function CreateA_Lieu($idProjet, $idDate){
  $req = "INSERT INTO `A_LIEU`(`FK_PROJET_ID`, `FK_DATE_ID`) VALUES (:idProjet, :idDate)";
  $query = database()->prepare($req);
  $query->bindParam(':idProjet', $idProjet, PDO::PARAM_STR);
  $query->bindParam(':idDate', $idDate, PDO::PARAM_STR);

  $query->execute();
}
