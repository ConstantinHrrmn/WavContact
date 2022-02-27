<?php

function UpdateDate($DATE_ID, $DATE_DATE, $DATE_HEURE){
  $req = "UPDATE `DATE` SET `DATE_DATE` = :date, `DATE_HEURE` = :heure WHERE `DATE_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $DATE_ID, PDO::PARAM_STR);
  $query->bindParam(':date', $DATE_DATE, PDO::PARAM_STR);
  $query->bindParam(':heure', $DATE_HEURE, PDO::PARAM_STR);

  $query->execute();
}
