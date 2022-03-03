<?php

include_once "../../pdo.php";

function InsertPersonInRole($idPerson, $table){
  $req = "INSERT INTO `$table`(`FK_PERSONNE_ID`) VALUES (:id)";
  $query = database()->prepare($req);
  $query->bindParam(':id', $idPerson, PDO::PARAM_STR);
  $query->execute();
}
