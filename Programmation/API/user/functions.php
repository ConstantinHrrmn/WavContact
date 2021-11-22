<?php

include_once "../pdo.php";

function GetUserIdByEmail($email){
  $req = "SELECT `id` FROM `Person` WHERE `email` = :m";
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

function Login($id, $password){
  $req = "SELECT `first_name`, `last_name` FROM `Person` WHERE `id` = :i AND `password` = :p";
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

function GetAllUsers(){
  $req = "SELECT * FROM `Person`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}
