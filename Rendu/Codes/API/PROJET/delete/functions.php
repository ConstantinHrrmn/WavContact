<?php

function DeleteProjet($id){

  $req = "DELETE FROM `PROJET` WHERE `PROJET_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
}
