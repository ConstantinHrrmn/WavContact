<?php

function UpdateFichierVideo($FICHIERVIDEO_ID, $FK_LIEU_ID){
  $req = "UPDATE `FICHIERVIDEO` SET `FK_LIEU_ID` = :lieu WHERE `FICHIERVIDEO_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $FICHIERVIDEO_ID, PDO::PARAM_STR);
  $query->bindParam(':lieu', $FK_LIEU_ID, PDO::PARAM_STR);

  $query->execute();
}
