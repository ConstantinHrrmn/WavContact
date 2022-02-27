<?php

function UpdateReservation($RESERVATION_ID, $FK_PROJET_ID, $RESERVATION_QUANTITE, $RESERVATION_DATE_DEBUT, $RESERVATION_DATE_FIN){
  $req = "UPDATE `RESERVATION` SET `FK_PROJET_ID` = :projet, `RESERVATION_QUANTITE` = :quantite, `RESERVATION_DATE_DEBUT` = :debut, `RESERVATION_DATE_FIN` = :fin WHERE `RESERVATION_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $RESERVATION_ID, PDO::PARAM_STR);
  $query->bindParam(':projet', $FK_PROJET_ID, PDO::PARAM_STR);
  $query->bindParam(':quantite', $RESERVATION_QUANTITE, PDO::PARAM_STR);
  $query->bindParam(':debut', $RESERVATION_DATE_DEBUT, PDO::PARAM_STR);
  $query->bindParam(':fin', $RESERVATION_DATE_FIN, PDO::PARAM_STR);
  $query->execute();
}
