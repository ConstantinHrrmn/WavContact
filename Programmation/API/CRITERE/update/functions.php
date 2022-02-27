<?php

function UpdateCritere($CRITERE_ID, $CRITERE_NOM){
  $req = "UPDATE `CRITERE` SET `CRITERE_NOM` = :nom WHERE `CRITERE_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $CRITERE_ID, PDO::PARAM_STR);
  $query->bindParam(':nom', $CRITERE_NOM, PDO::PARAM_STR);

  $query->execute();
}
