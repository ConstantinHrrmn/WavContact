<?php

function CreateDate($DATE_DATE, $DATE_HEURE){
  $req = "INSERT INTO `DATE`(`DATE_DATE`, `DATE_HEURE`) VALUES (:date, :heure)";
  $query = database()->prepare($req);
  $query->bindParam(':date', $DATE_DATE, PDO::PARAM_STR);
  $query->bindParam(':heure', $DATE_HEURE, PDO::PARAM_STR);

  $query->execute();
}
