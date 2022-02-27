<?php

function DeleteReservation($id){

  $req = "DELETE FROM `RESERVATION` WHERE `RESERVATION_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $id, PDO::PARAM_STR);
  $query->execute();
}
