<?php

function DeleteConsulte($idPhotographe, $idLieu){

  $req = "DELETE FROM `CONSULTE` WHERE `FK_PHOTOGRAPHE_ID` = :idPhotographe AND `FK_LIEU_ID` = :idLieu";
  $query = database()->prepare($req);
  $query->bindParam(':idPhotographe', $idPhotographe, PDO::PARAM_STR);
  $query->bindParam(':idLieu', $idLieu, PDO::PARAM_STR);
  $query->execute();
}
