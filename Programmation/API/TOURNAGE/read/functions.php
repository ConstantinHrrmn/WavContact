<?php

function GetDatesForProject($id){
  $req = "SELECT `TOURNAGE_ID` as id, `TOURNAGE_PROJET_ID` as projet, `TOURNAGE_DEBUT` as debut, `TOURNAGE_FIN` as fin FROM `TOURNAGE` WHERE `TOURNAGE_PROJET_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    for($i = 0; $i < count($matches); $i++){

      $d = explode(" ", $matches[$i]['debut']);
      $matches[$i]['debut'] = $d[0]."T".$d[1];

      $d = explode(" ", $matches[$i]['fin']);
      $matches[$i]['fin'] = $d[0]."T".$d[1];
    }
    return $matches;
  }
}

function GetDatesForDays($baseDate, $nbDays){
  $data = array();
  $req = "";
  $date = date('Y-m-d', strtotime($baseDate));
  $req = $req."SELECT 0 as Day, TOURNAGE_ID as id, TOURNAGE_PROJET_ID as projet, PROJET.PROJET_NOM as nom, TOURNAGE_DEBUT as debut, TOURNAGE_FIN as fin FROM TOURNAGE LEFT JOIN PROJET ON PROJET.PROJET_ID = TOURNAGE.TOURNAGE_PROJET_ID WHERE TOURNAGE_DEBUT <= '$date 23:59:59' AND TOURNAGE_FIN >= '$date 00:00:00';";

  for ($i=1; $i < $nbDays; $i++) {
    $date = date('Y-m-d', strtotime($baseDate."+ $i Days"));
    $req = $req."SELECT $i as Day, TOURNAGE_ID as id, TOURNAGE_PROJET_ID as projet, PROJET.PROJET_NOM as nom, TOURNAGE_DEBUT as debut, TOURNAGE_FIN as fin FROM TOURNAGE LEFT JOIN PROJET ON PROJET.PROJET_ID = TOURNAGE.TOURNAGE_PROJET_ID WHERE TOURNAGE_DEBUT <= '$date 23:59:59' AND TOURNAGE_FIN >= '$date 00:00:00';";
  }
  $query = database()->prepare($req);
  $query->execute();


  while ($query->columnCount()) {
     $rowset = $query->fetchAll(PDO::FETCH_ASSOC);
     $query->nextRowset();
     $day = array();

     for($i = 0; $i < count($rowset); $i++){

       $d = explode(" ", $rowset[$i]['debut']);
       $rowset[$i]['debut'] = $d[0]."T".$d[1];

       $d = explode(" ", $rowset[$i]['fin']);
       $rowset[$i]['fin'] = $d[0]."T".$d[1];

       $rdv = array("jour" => $rowset[$i]['Day'], "projet" => $rowset[$i]['nom'], "debut" => $rowset[$i]['debut'], "fin" => $rowset[$i]['fin']);
       array_push($day, $rdv);
     }

     array_push($data, $day);
   }

   return $data;
}

function GetDatesForDaysClient($baseDate, $nbDays, $id){
  $data = array();
  $req = "";
  $date = date('Y-m-d', strtotime($baseDate));
  $req = $req."SELECT 0 as Day, TOURNAGE_ID as id, TOURNAGE_PROJET_ID as projet, PROJET.PROJET_NOM as nom, TOURNAGE_DEBUT as debut, TOURNAGE_FIN as fin FROM TOURNAGE LEFT JOIN PROJET ON PROJET.PROJET_ID = TOURNAGE.TOURNAGE_PROJET_ID WHERE TOURNAGE_DEBUT <= '$date 23:59:59' AND TOURNAGE_FIN >= '$date 00:00:00'  AND PROJET.FK_PERSONNE_ID = $id;";

  for ($i=1; $i < $nbDays; $i++) {
    $date = date('Y-m-d', strtotime($baseDate."+ $i Days"));
    $req = $req."SELECT $i as Day, TOURNAGE_ID as id, TOURNAGE_PROJET_ID as projet, PROJET.PROJET_NOM as nom, TOURNAGE_DEBUT as debut, TOURNAGE_FIN as fin FROM TOURNAGE LEFT JOIN PROJET ON PROJET.PROJET_ID = TOURNAGE.TOURNAGE_PROJET_ID WHERE TOURNAGE_DEBUT <= '$date 23:59:59' AND TOURNAGE_FIN >= '$date 00:00:00'  AND PROJET.FK_PERSONNE_ID = $id;";
  }
  $query = database()->prepare($req);
  $query->execute();


  while ($query->columnCount()) {
     $rowset = $query->fetchAll(PDO::FETCH_ASSOC);
     $query->nextRowset();
     $day = array();

     for($i = 0; $i < count($rowset); $i++){

       $d = explode(" ", $rowset[$i]['debut']);
       $rowset[$i]['debut'] = $d[0]."T".$d[1];

       $d = explode(" ", $rowset[$i]['fin']);
       $rowset[$i]['fin'] = $d[0]."T".$d[1];

       $rdv = array("jour" => $rowset[$i]['Day'], "projet" => $rowset[$i]['nom'], "debut" => $rowset[$i]['debut'], "fin" => $rowset[$i]['fin']);
       array_push($day, $rdv);
     }

     array_push($data, $day);
   }

   return $data;
}
