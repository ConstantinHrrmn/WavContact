<?php

include_once "../../pdo.php";

function GetUserIdByEmail($email){
  $req = "SELECT `PERSONNE_ID` as id FROM `PERSONNE` WHERE `PERSONNE_MAIL` =  :m";
  $query = database()->prepare($req);
  $query->bindParam(':m', $email, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetch(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}


function GetUserById($id){
  //$req = "SELECT `id`, `idRole`, `last_name`, `first_name`, `email`, `phone`, `password` FROM `Person` WHERE `id` = :i";
  $req = "SELECT `id`, `idROLE` as idRole, `last_name`, `first_name`, `email`, `phone`, `password` FROM `Person` WHERE `id` = :i";
  $query = database()->prepare($req);
  $query->bindParam(':i', $id, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetch(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}

function Login($id, $password){
  $req = "SELECT `first_name`, `last_name`, `idRole` FROM `Person` WHERE `id` = :i AND `password` = :p";
  $query = database()->prepare($req);
  $query->bindParam(':i', $id, PDO::PARAM_STR);
  $query->bindParam(':p', $password, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetch(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
