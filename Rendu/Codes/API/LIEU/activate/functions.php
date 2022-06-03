<?php
// PDO de Wavmap
// wavmap()
include_once "../pdoWavMap.php";

function activatePlace($id){
  $req = "UPDATE LIEU SET LIEU.FK_LIEU_STATUT = 2 WHERE LIEU.LIEU_ID = :id";
  $query = wavmap()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
}
