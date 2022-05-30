<?php

function UpdateReservation($tournage, $projet, $materiel, $quantite){
  $req = "UPDATE `RESERVATION` SET `RESERVATION_QUANTITE`= :q WHERE `TOURNAGE_FK`= :t AND `PROJET_FK`= :p AND`MATERIEL_ID`=:m";
  $query = database()->prepare($req);
  $query->bindParam(':t', $tournage, PDO::PARAM_STR);
  $query->bindParam(':p', $projet, PDO::PARAM_STR);
  $query->bindParam(':m', $materiel, PDO::PARAM_STR);
  $query->bindParam(':q', $quantite, PDO::PARAM_STR);
  $query->execute();
}
