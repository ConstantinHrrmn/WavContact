<?php

// Faire une vérification avec la FK_PROJET_ID

function CreateReservation($FK_PROJET_ID, $RESERVATION_QUANTITE, $RESERVATION_DATE_DEBUT, $RESERVATION_DATE_FIN){
  $req = "INSERT INTO `RESERVATION`(`FK_PROJET_ID`, `RESERVATION_QUANTITE`, `RESERVATION_DATE_DEBUT`, `RESERVATION_DATE_FIN`) VALUES (:projet, :quantite, :debut, :fin)";
  $query = database()->prepare($req);
  $query->bindParam(':projet', $FK_PROJET_ID, PDO::PARAM_STR);
  $query->bindParam(':quantite', $RESERVATION_QUANTITE, PDO::PARAM_STR);
  $query->bindParam(':debut', $RESERVATION_DATE_DEBUT, PDO::PARAM_STR);
  $query->bindParam(':fin', $RESERVATION_DATE_FIN, PDO::PARAM_STR);
  $query->execute();
}
