<?php

function GetDateTime(){
  $date = new DateTime("now", new DateTimeZone('Europe/Zurich') );
  return $date->format('Y-m-d H:i:s.ms');
}

function NewActivity($user, $project, $text, $time){
  $req = "INSERT INTO `ACTIVITE`(`ACTIVITE_PERSONNE_FK`, `ACTIVITE_PROJET_FK`, `ACTIVITY_CONTENT`, `ACTIVITE_MAJ`) VALUES ('$user', '$project', '$text', '$time')";
  $query = database()->prepare($req);
  $query->execute();
}

function GetLogsForProject($id){
  $req = "SELECT `ACTIVITE_ID` AS Id, PERSONNE.PERSONNE_PRENOM AS prenom, `ACTIVITY_CONTENT` AS Content, `ACTIVITE_MAJ` AS MaJ FROM `ACTIVITE` INNER JOIN PERSONNE ON PERSONNE.PERSONNE_ID = ACTIVITE_PERSONNE_FK WHERE `ACTIVITE_PROJET_FK` = :id ORDER BY ACTIVITE_MAJ DESC;";
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

function GetLastActivities($amount){
  $req = "SELECT PROJET.PROJET_NOM as projet,PERSONNE.PERSONNE_PRENOM AS prenom, `ACTIVITY_CONTENT` AS Content, `ACTIVITE_MAJ` AS MaJ FROM `ACTIVITE` INNER JOIN PERSONNE ON PERSONNE.PERSONNE_ID = ACTIVITE_PERSONNE_FK INNER JOIN PROJET ON PROJET.PROJET_ID = ACTIVITE_PROJET_FK ORDER BY ACTIVITE_MAJ DESC LIMIT $amount";
  $query = database()->prepare($req);
  $query->bindParam(':amount', $amount, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
