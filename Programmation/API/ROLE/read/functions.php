<?php

include_once "../../pdo.php";

// Collaborateur 0
// Client 1
// Photographe 2

$r_Collaborateur = "SELECT * FROM `COLLABORATEUR` WHERE `FK_PERSONNE_ID` = ";
$r_Client = "SELECT * FROM `CLIENT` WHERE `CLIENT_VALIDER` = 1 AND `FK_PERSONNE_ID` = ";
$r_Photographe = "SELECT * FROM `PHOTOGRAPHE` WHERE `FK_PERSONNE_ID` = ";

$requetes = array(
  $r_Collaborateur,
  $r_Client,
  $r_Photographe
);

function WhatIsMyRole($id){

  global $requetes;

  $r = array();

  for ($i=0; $i < count($requetes); $i++) {
    $str = $requetes[$i]."$id";
    array_push($r, $str);
  }

  $response = false;
  $index = 0;

  while ($response == false && $index < count($r)) {
    $response = CheckIfInTable($r[$index]);
    if ($response) {
      return array($index, GetNameForRole($index));
    }
    $index += 1;
  }
}

function GetNameForRole($index){
  switch ($index) {
    case 0:
      return "Collaborateur";
    case 1:
      return "Client";
    case 2:
      return "Photographe";

    default:
      return "Unknown";
  }
}

function CheckIfInTable($req){
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetch(PDO::FETCH_ASSOC);
  if($matches == null){
    return false;
  }else{
    return true;
  }
}

function GetAllRoles(){

}
