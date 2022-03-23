<?php

function DeleteDate($id){

  $req = "DELETE FROM `DATE` WHERE `DATE_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
}
