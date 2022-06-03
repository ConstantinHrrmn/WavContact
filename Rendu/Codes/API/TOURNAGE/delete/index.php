<?php

include "../../pdo.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Id'])) {

  $id = $headers['Id'];

  $req = "DELETE FROM `TOURNAGE` WHERE `TOURNAGE_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
}
