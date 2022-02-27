<?php

include_once "../../pdo.php";

// On inclu les fonctions de Role afin de récupérer les roles
include_once "../../ROLE/read/functions.php";

// Return data :
// id
// last_name
// first_name
// email
// password
// phone
function GetAllPersons(){
  $req = "SELECT `PERSONNE_ID` as id, `PERSONNE_NOM` as last_name, `PERSONNE_PRENOM` as first_name, `PERSONNE_MAIL` as email, `PERSONNE_MDP` as password, `PERSONNE_TEL` as phone FROM `PERSONNE`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}

function GetAllPersonsWithRole(){
  $req = "SELECT `PERSONNE_ID` as id, `PERSONNE_NOM` as last_name, `PERSONNE_PRENOM` as first_name, `PERSONNE_MAIL` as email, `PERSONNE_MDP` as password, `PERSONNE_TEL` as phone FROM `PERSONNE`";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    $final = array();
    for ($i=0; $i < count($matches); $i++) {
      $role = GetRoleForPerson($matches[$i]['id']);
      $data = array(
        "id" => $matches[$i]['id'],
        "last_name" => $matches[$i]['last_name'],
        "first_name" => $matches[$i]['first_name'],
        "email" => $matches[$i]['email'],
        "password" => $matches[$i]['password'],
        "phone" => $matches[$i]['phone'],
        "roleNumber" => $role[0],
        "roleName" => $role[1]
      );

      array_push($final, $data);
    }

    return $final;
  }
}

function GetUserById($id){
  $req = "SELECT `PERSONNE_ID` as id, `PERSONNE_NOM` as last_name, `PERSONNE_PRENOM` as first_name, `PERSONNE_MAIL` as email, `PERSONNE_TEL` as phone FROM `PERSONNE` WHERE `PERSONNE_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetch(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    $role = GetRoleForPerson($matches['id']);
    $data = array(
      "id" => $matches['id'],
      "last_name" => $matches['last_name'],
      "first_name" => $matches['first_name'],
      "email" => $matches['email'],
      "phone" => $matches['phone'],
      "roleNumber" => $role[0],
      "roleName" => $role[1]
    );
    return $data;
  }
}

function Login($email, $password){
  $req = "SELECT `PERSONNE_ID` as id FROM `PERSONNE` WHERE `PERSONNE_MAIL` =  :m AND `PERSONNE_MDP` = :p";
  $query = database()->prepare($req);
  $query->bindParam(':m', $email, PDO::PARAM_STR);
  $query->bindParam(':p', $password, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetch(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}

function GetRoleForPerson($id){
  return WhatIsMyRole($id);
}

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
