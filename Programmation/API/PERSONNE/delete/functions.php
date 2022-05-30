<?php

// Delete unser
function DeletePersonne($id){
  $req = "DELETE FROM `PERSONNE` WHERE `PERSONNE_ID` = $id";
  $query = database()->prepare($req);
  $query->execute();
}
