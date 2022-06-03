<?php
// PDO de Wavmap
// wavmap()
include_once "../pdoWavMap.php";

function DeleteLieuForProject($idL, $idP, $idT){
  $req = "DELETE FROM `PROJECT_HAS_LIEU` WHERE `PK_FK_PROJECT_ID` = $idP AND `PK_FK_LIEU_ID` = $idL AND `PK_FK_TOURNAGE_ID` = $idT";
  $query = wavmap()->prepare($req);
  $query->execute();
}
