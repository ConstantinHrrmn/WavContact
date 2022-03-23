<?php

function DeleteEvenement($id){

  $req = "DELETE FROM `EVENEMENT` WHERE `EVENEMENT_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
}
