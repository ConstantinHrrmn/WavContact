<?php

function DeleteFichierVideo($id){

  $req = "DELETE FROM `FICHIERVIDEO` WHERE `FICHIERVIDEO_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
}
