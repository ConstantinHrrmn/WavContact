<?php

// PDO de Wavmap
// wavmap()
include_once "../pdoWavMap.php";

// PDO de WavCom
// database()
include_once "../../pdo.php";

function GetLieuForProject($idPrject){
  $req = "SELECT LIEU.LIEU_ID as id, LIEU.LIEU_NOM as nom, LIEU.LIEU_DESCRIPTION as description, LIEU.LIEU_LAT as lat, LIEU.LIEU_LON as lon, PROJECT_HAS_LIEU.PK_FK_TOURNAGE_ID as idTournage, PHOTO.PHOTO_PATH as pathImage FROM LIEU INNER JOIN PROJECT_HAS_LIEU ON PROJECT_HAS_LIEU.PK_FK_LIEU_ID = LIEU.LIEU_ID LEFT JOIN PHOTO ON PHOTO.PHOTO_ID = (SELECT LIEU_HAS_PHOTO.PK_FK_PHOTO_ID FROM LIEU_HAS_PHOTO WHERE LIEU_HAS_PHOTO.PK_FK_LIEU_ID = LIEU.LIEU_ID LIMIT 1) WHERE LIEU.LIEU_ID IN ( SELECT PROJECT_HAS_LIEU.PK_FK_LIEU_ID FROM PROJECT_HAS_LIEU WHERE PROJECT_HAS_LIEU.PK_FK_PROJECT_ID =:id);";
  $query = database()->prepare($req);
  $query->bindParam(':id', $idPrject, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
