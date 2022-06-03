<?php
include_once "pdo.php";


CreateCategorie($_POST); //appel
header('Location: https://waview.ch/wavcontact/map'); // retour sur la page principale
exit;

function CreateCategorie($data_post){
  $nom = $_POST['inputNomFormAddCategorieCollab']; // élément

  // Permet de mettre tout les mots en minuscule et la 1er lettre du 1er mot en majuscule (initcap)
  $nom = ucfirst(strtolower($nom));

  $data = [$nom]; // tableau de l'élément

  $query = database()->prepare("INSERT INTO CATEGORIE(CATEGORIE_NOM) VALUES (?)"); // préparation de la requête

  $query->execute($data); // exécution de la requête
}
?>
