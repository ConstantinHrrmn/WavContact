<?php

function DeletePhoto($id){

  $req = "DELETE FROM `PHOTO` WHERE `PHOTO_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
}
