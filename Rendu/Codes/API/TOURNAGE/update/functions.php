<?php

function UpdateTournage($id, $start, $end){
  $req = "UPDATE `TOURNAGE` SET `TOURNAGE_DEBUT`= '$start',`TOURNAGE_FIN`= '$end' WHERE `TOURNAGE_ID` = $id";

  var_dump($req);

  $query = database()->prepare($req);
  $query->execute();
}
