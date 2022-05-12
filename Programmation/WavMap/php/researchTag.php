<?php

include_once "pdo.php";


if (isset($_POST['inputRecherche'])) {
  ResearchTag($_POST['inputRecherche']);
}
else{
  echo json_encode("Pas de tag sélectionné");
}


function ResearchTag($tagRecherche){
    $req = "SELECT `TAG_ID` FROM `TAG` WHERE LOWER(`TAG_NOM`) LIKE LOWER(\"%$tagRecherche[0]%\")";
    $query = database()->prepare($req);
    $query->execute();
    $matches = $query->fetchAll(PDO::FETCH_ASSOC);
    if($matches == null){
      echo json_encode("Aucun tag existant trouvé", JSON_INVALID_UTF8_IGNORE);
    }
    else{
      echo json_encode($matches, JSON_INVALID_UTF8_IGNORE);
    }
}
