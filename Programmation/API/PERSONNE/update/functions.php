<?php

include_once "../../pdo.php";

function UpdatePassword($id, $password){
  $req = "UPDATE `PERSONNE` SET `PERSONNE_MDP`= :p WHERE `PERSONNE_ID` = :i";
  $query = database()->prepare($req);
  $query->bindParam(':p', $password, PDO::PARAM_STR);
  $query->bindParam(':i', $id, PDO::PARAM_STR);
  $query->execute();
}
