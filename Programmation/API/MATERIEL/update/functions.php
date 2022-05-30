<?php

function UpdateMateriel($MATERIEL_ID, $MATERIEL_NOM, $MATERIEL_CATEGORIE, $MATERIEL_DESCRIPTION, $MATERIEL_PRIX, $MATERIEL_QUANTITE){
  $req = "UPDATE `MATERIEL` SET `MATERIEL_NOM` = :nom, `FK_CATEGORIE_ID` = :categorie, `MATERIEL_DESCRIPTION` = :description, `MATERIEL_PRIX` = :prix, `MATERIEL_QUANTITE` = :quantite WHERE `MATERIEL_ID` = :id";
  $query = database()->prepare($req);
  $query->bindParam(':id', $MATERIEL_ID, PDO::PARAM_STR);
  $query->bindParam(':nom', $MATERIEL_NOM, PDO::PARAM_STR);
  $query->bindParam(':categorie', $MATERIEL_CATEGORIE, PDO::PARAM_STR);
  $query->bindParam(':description', $MATERIEL_DESCRIPTION, PDO::PARAM_STR);
  $query->bindParam(':prix', $MATERIEL_PRIX, PDO::PARAM_STR);
  $query->bindParam(':quantite', $MATERIEL_QUANTITE, PDO::PARAM_STR);
  $query->execute();
}
