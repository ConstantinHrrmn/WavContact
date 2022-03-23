<?php

include_once "../../pdo.php";


function GetReservationById($id){
  $req = "SELECT `RESERVATION_ID`, `FK_PROJET_ID`, `RESERVATION_QUANTITE`, `RESERVATION_DATE_DEBUT`, `RESERVATION_DATE_FIN` FROM `RESERVATION` WHERE `RESERVATION_ID` = :id";
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

function GetAllReservatipn(){
  $req = "SELECT * FROM `RESERVATION`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
