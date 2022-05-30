<?php

// Faire une vérification avec la FK_CATEGORIE_ID

function CreateMateriel($MATERIEL_NOM, $MATERIEL_CATEGORIE, $MATERIEL_DESCRIPTION, $MATERIEL_PRIX, $MATERIEL_QUANTITE){
  $req = "INSERT INTO `MATERIEL`(`MATERIEL_NOM`, `FK_CATEGORIE_ID`, `MATERIEL_DESCRIPTION`, `MATERIEL_PRIX`, `MATERIEL_QUANTITE`) VALUES (:nom, :categorie, :description, :prix, :quantite)";
  $query = database()->prepare($req);
  $query->bindParam(':nom', $MATERIEL_NOM, PDO::PARAM_STR);
  $query->bindParam(':categorie', $MATERIEL_CATEGORIE, PDO::PARAM_STR);
  $query->bindParam(':description', $MATERIEL_DESCRIPTION, PDO::PARAM_STR);
  $query->bindParam(':prix', $MATERIEL_PRIX, PDO::PARAM_STR);
  $query->bindParam(':quantite', $MATERIEL_QUANTITE, PDO::PARAM_STR);
  $query->execute();
}
