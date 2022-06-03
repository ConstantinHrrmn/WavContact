<?php

// Faire une vérification avec la FK_PROJET_ID

function CreateReservation($tournage, $projet, $materiel, $quantite){
  $req = "INSERT INTO `RESERVATION`(`TOURNAGE_FK`, `PROJET_FK`, `MATERIEL_ID`, `RESERVATION_QUANTITE`) VALUES (:t, :p, :m, :q)";
  $query = database()->prepare($req);
  $query->bindParam(':t', $tournage, PDO::PARAM_STR);
  $query->bindParam(':p', $projet, PDO::PARAM_STR);
  $query->bindParam(':m', $materiel, PDO::PARAM_STR);
  $query->bindParam(':q', $quantite, PDO::PARAM_STR);
  $query->execute();
}
