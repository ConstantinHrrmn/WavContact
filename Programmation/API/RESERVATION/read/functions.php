<?php

include_once "../../pdo.php";


function GetReservationById($id){
  $req = "SELECT `RESERVATION_ID` as id, `TOURNAGE_FK` as tournageId, `PROJET_FK` as projetId, `MATERIEL_ID` as materielId, `RESERVATION_QUANTITE` as quantite FROM `RESERVATION` WHERE `RESERVATION_ID` :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetch(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}

function GetAllReservationForTournage($id){
  $req = "SELECT `RESERVATION_ID` as id, `TOURNAGE_FK` as tournageId, `PROJET_FK` as projetId, `MATERIEL_ID` as materielId, `RESERVATION_QUANTITE` as quantite FROM `RESERVATION` WHERE `TOURNAGE_FK` :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}

function GetAllMaterielInTournage($id){
  $req = "SELECT DISTINCT MATERIEL.MATERIEL_ID as Id, MATERIEL.FK_CATEGORIE_ID as IdCat, MATERIEL.MATERIEL_NOM as Nom, MATERIEL.MATERIEL_DESCRIPTION as Description, MATERIEL.MATERIEL_PRIX as Prix, RESERVATION.RESERVATION_QUANTITE as Quantite FROM `MATERIEL` LEFT JOIN RESERVATION ON RESERVATION.MATERIEL_ID = MATERIEL.MATERIEL_ID WHERE MATERIEL.MATERIEL_ID IN (SELECT RESERVATION.MATERIEL_ID FROM RESERVATION WHERE RESERVATION.TOURNAGE_FK = :id);";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}

function GetMaterielAvaible($start, $end){
  $req = "SELECT DISTINCT MATERIEL.MATERIEL_ID as Id,
MATERIEL.FK_CATEGORIE_ID as IdCat,
MATERIEL.MATERIEL_NOM as Nom,
MATERIEL.MATERIEL_DESCRIPTION as Description,
MATERIEL.MATERIEL_PRIX as Prix,
CASE MATERIEL.MATERIEL_QUANTITE WHEN (MATERIEL.MATERIEL_QUANTITE - IFNULL(RESERVATION.RESERVATION_QUANTITE, 0) = 0) THEN (MATERIEL.MATERIEL_QUANTITE) ELSE (MATERIEL.MATERIEL_QUANTITE - IFNULL(RESERVATION.RESERVATION_QUANTITE, 0)) END AS Quantite
FROM `MATERIEL`
LEFT JOIN RESERVATION ON RESERVATION.MATERIEL_ID = MATERIEL.MATERIEL_ID
WHERE MATERIEL.MATERIEL_ID NOT IN (
    SELECT RESERVATION.MATERIEL_ID
    FROM RESERVATION
    WHERE RESERVATION.TOURNAGE_FK IN(
        SELECT TOURNAGE.TOURNAGE_ID
        FROM TOURNAGE
        WHERE TOURNAGE.TOURNAGE_DEBUT < :e
        AND TOURNAGE.TOURNAGE_FIN > :s
    )
    AND RESERVATION.RESERVATION_QUANTITE = MATERIEL.MATERIEL_QUANTITE
)

ORDER BY MATERIEL.MATERIEL_ID ASC;";
  $query = database()->prepare($req);
  $query->bindParam(':s', $start, PDO::PARAM_STR);
  $query->bindParam(':e', $end, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}

function GetAllReservatipn(){
  $req = "SELECT `RESERVATION_ID` as id, `TOURNAGE_FK` as tournageId, `PROJET_FK` as projetId, `MATERIEL_ID` as materielId,`RESERVATION_QUANTITE` as quantite FROM `RESERVATION`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
