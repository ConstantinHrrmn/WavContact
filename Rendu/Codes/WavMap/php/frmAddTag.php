<?php
include_once "pdo.php";
CreateTag();
header('Location: https://waview.ch/wavcontact/map'); // retour à la page principale
exit;

function CreateTag(){
  // Elements
  $data_categorie = $_POST['selectCatAddTagFormCollab'];
  $nom = $_POST['inputNomAddTagFormCollab'];
  $nbSelection = 0;

  // Permet de mettre tout les mots en minuscule et la 1er lettre du 1er mot en majuscule (initcap)
  $nom = ucfirst(strtolower($nom));

  $pdo=database(); // initialisation de la base de donnée

  // ============== Select pour obtenir l'id de la categorie ==============
  $stmt = $pdo->prepare("SELECT CATEGORIE_ID FROM CATEGORIE WHERE CATEGORIE_NOM = ?"); // préparation de la requête
  $stmt->execute([$data_categorie]); // exécution de la requête
  $categorie = $stmt->fetch(); // stockage des donnéethis


  // ============== Insertion dans la base de donnée du tag et de sa catégorie ==============
  $data = [$nom, $categorie[0], $nbSelection]; // tableau des éléments
  $query = $pdo->prepare("INSERT INTO TAG(TAG_NOM, FK_CATEGORIE_ID, NB_SELECTION) VALUES (?,?,?)"); // préparation de la requête
  $query->execute($data); // exécution de la requête
}
?>
