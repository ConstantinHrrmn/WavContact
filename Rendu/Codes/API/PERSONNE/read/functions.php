<?php

function GetAllPersons(){
  $req = "SELECT `PERSONNE_ID` as id, `PERSONNE_NOM` as last_name, `PERSONNE_PRENOM` as first_name, `PERSONNE_MAIL` as email, `PERSONNE_MDP` as password, `PERSONNE_TEL` as phone FROM `PERSONNE` WHERE `PERSONNE_ACTIVE` = 1";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    return $matches;
  }
}

function GetUnactivePersons(){
  $req = "SELECT `PERSONNE_ID` as id, `PERSONNE_NOM` as last_name, `PERSONNE_PRENOM` as first_name, `PERSONNE_MAIL` as email, `PERSONNE_MDP` as password, `PERSONNE_TEL` as phone FROM `PERSONNE` WHERE `PERSONNE_ACTIVE` = 0";
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
  $req = "SELECT `PERSONNE_ID` as id, `PERSONNE_NOM` as last_name, `PERSONNE_PRENOM` as first_name, `PERSONNE_MAIL` as email, `PERSONNE_MDP` as password, `PERSONNE_TEL` as phone , `FK_ROLE_ID` as role FROM `PERSONNE` WHERE `PERSONNE_ACTIVE` = 1";
  $query = database()->prepare($req);
  $query->execute();
  $matches = $query->fetchAll(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    $final = array();
    for ($i=0; $i < count($matches); $i++) {
      $role = GetRoleForPerson($matches[$i]['role']);
      $data = array(
        "id" => $matches[$i]['id'],
        "last_name" => $matches[$i]['last_name'],
        "first_name" => $matches[$i]['first_name'],
        "email" => $matches[$i]['email'],
        "password" => $matches[$i]['password'],
        "phone" => $matches[$i]['phone'],
        "roleNumber" => $role["ROLE_ID"],
        "roleName" => $role["ROLE_NAME"]
      );

      array_push($final, $data);
    }

    return $final;
  }
}

function GetUserById($id){
  $req = "SELECT `PERSONNE_ID` as id, `PERSONNE_NOM` as last_name, `PERSONNE_PRENOM` as first_name, `PERSONNE_MAIL` as email, `PERSONNE_TEL` as phone, `FK_ROLE_ID` as role FROM `PERSONNE` WHERE `PERSONNE_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetch(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    $role = GetRoleForPerson($matches['role']);
    $data = array(
      "id" => $matches['id'],
      "last_name" => $matches['last_name'],
      "first_name" => $matches['first_name'],
      "email" => $matches['email'],
      "phone" => $matches['phone'],
      "roleNumber" => $role["ROLE_ID"],
      "roleName" => $role["ROLE_NAME"]
    );
    return $data;
  }
}

function Login($email, $password){
  $req = "SELECT `PERSONNE_ID` as id FROM `PERSONNE` WHERE `PERSONNE_MAIL` =  :m AND `PERSONNE_MDP` = :p AND `PERSONNE_ACTIVE` = 1";
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

function GetUserByEmail($email){
  $req = "SELECT `PERSONNE_ID` as id, `PERSONNE_NOM` as last_name, `PERSONNE_PRENOM` as first_name, `PERSONNE_MAIL` as email, `PERSONNE_TEL` as phone, `FK_ROLE_ID` as role FROM `PERSONNE` WHERE `PERSONNE_MAIL` = :email";
  $query = database()->prepare($req);
  $query->bindParam(':email', $email, PDO::PARAM_STR);
  $query->execute();
  $matches = $query->fetch(PDO::FETCH_ASSOC);
  if($matches == null){
    return null;
  }else{
    $role = GetRoleForPerson($matches['role']);
    $data = array(
      "id" => $matches['id'],
      "last_name" => $matches['last_name'],
      "first_name" => $matches['first_name'],
      "email" => $matches['email'],
      "phone" => $matches['phone'],
      "roleNumber" => $role["ROLE_ID"],
      "roleName" => $role["ROLE_NAME"]
    );
    return $data;
  }
}



// Update User password by id
function UpdateUserPassword($id, $password){
  $req = "UPDATE `PERSONNE` SET `PERSONNE_MDP` = :p WHERE `PERSONNE_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':p', $password, PDO::PARAM_STR);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
}
