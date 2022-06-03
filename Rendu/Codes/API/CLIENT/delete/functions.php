<?php

function DeleteCategorie($id){

  $req = "DELETE FROM `CATEGORIE` WHERE `CATEGORIE_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
}
