<?php

include_once "../../pdo.php";


function UpdatePassword($id, $password){
  $req = "UPDATE `PERSONNE` SET `PERSONNE_MDP`= :p WHERE `PERSONNE_ID` = :i";
  $query = database()->prepare($req);
  $query->bindParam(':p', $password, PDO::PARAM_STR);
  $query->bindParam(':i', $id, PDO::PARAM_STR);
  $query->execute();
}

function UpdateClientInfos($id, $fn, $ln, $phone, $role){
  $req = "UPDATE `PERSONNE` SET `PERSONNE_NOM`= \"$ln\" ,`PERSONNE_PRENOM`= \"$fn\" , `PERSONNE_TEL`= \"$phone\" ,`FK_ROLE_ID`= \"$role\" WHERE `PERSONNE_ID` = $id";
  $query = database()->prepare($req);
  $query->execute();
}

function SetActive($id){
  $req = "UPDATE `PERSONNE` SET `PERSONNE_ACTIVE`= 1 WHERE `PERSONNE_ID` = :i";
  $query = database()->prepare($req);
  $query->bindParam(':i', $id, PDO::PARAM_STR);
  $query->execute();
}
