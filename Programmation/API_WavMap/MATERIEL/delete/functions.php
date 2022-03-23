<?php

function DeleteMateriel($id){

  $req = "DELETE FROM `MATERIEL` WHERE `MATERIEL_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
}
