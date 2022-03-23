<?php

function DeleteCritere($id){

  $req = "DELETE FROM `CRITERE` WHERE `CRITERE_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
}
