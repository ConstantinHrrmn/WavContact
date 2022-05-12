<?php

include_once "pdo.php";

session_start();


if (isset($_POST['tagSelected'])) {
  PlacesWithTags($_POST['tagSelected']);
}
else{
  echo json_encode("Pas de tag sélectionné");
}



function PlacesWithTags($tags){
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
      echo json_encode("Aucun tag existant sélectionné", JSON_INVALID_UTF8_IGNORE);
    }
    else{
      echo json_encode($matches, JSON_INVALID_UTF8_IGNORE);
    }
  }

}
