<?php

include_once "pdo.php";

function GetPlacesWithTags($tags){
  $tagsArr = explode(",", $tags);

  $len = count($tagsArr);



  if (count($len) > 0) {

    $reqTag = "SELECT `TAG_ID` FROM `TAG` WHERE `TAG_NOM` LIKE \"$tagsArr[0]\"";
    //`TAG_NOM` LIKE "Paradis" OR `TAG_NOM` LIKE "Ecole";";

    if ($len > 1) {
      for ($i=1; $i < $len; $i++) {
        $reqTag = $reqTag." OR `TAG_NOM` LIKE \"$tagsArr[$i]\"";
      }
    }

    $req = "SELECT * FROM `LIEU` WHERE `LIEU_ID` IN (SELECT LIEU_HAS_TAG.PK_FK_LIEU_ID FROM LIEU_HAS_TAG WHERE LIEU_HAS_TAG.PK_FK_TAG_ID IN($reqTag))";
    $query = database()->prepare($req);
    $query->execute();
    $matches = $query->fetchAll(PDO::FETCH_ASSOC);
    if($matches == null){
      return null;
    }else{
      return $matches;
    }
  }

  return "null";

}

function GetAllPlaces(){
  $req = "SELECT * FROM `LIEU`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
