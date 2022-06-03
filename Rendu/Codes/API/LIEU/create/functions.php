<?php
// PDO de Wavmap
// wavmap()
include_once "../pdoWavMap.php";

// PDO de WavCom
// database()
include_once "../../pdo.php";

function CreateLieuForProject($idL, $idP, $idT){
  $req = "INSERT INTO `PROJECT_HAS_LIEU`(`PK_FK_PROJECT_ID`, `PK_FK_LIEU_ID`, `PK_FK_TOURNAGE_ID`) VALUES (:p,:l, :t)";
  $query = database()->prepare($req);
  $query->bindParam(':p', $idP, PDO::PARAM_STR);
  $query->bindParam(':l', $idL, PDO::PARAM_STR);
  $query->bindParam(':t', $idT, PDO::PARAM_STR);
  $query->execute();
}
