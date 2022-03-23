<?php

function DeleteLieu($id){

  $req = "DELETE FROM `LIEU` WHERE `LIEU_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
}
