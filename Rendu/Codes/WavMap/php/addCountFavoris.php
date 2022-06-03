<?php
include_once "pdo.php";

addCountFavoris();

function AddCountFavoris(){
  //print_r("test");
  if(isset($_POST['nameTag'])){
    $nom = $_POST['nameTag']; // élément

    $data = [$nom]; // tableau de l'élément
    //echo "UPDATE TAG SET NB_SELECTION =NB_SELECTION+1 WHERE TAG_NOM = '$nom'";
    $query = database()->prepare("UPDATE TAG SET NB_SELECTION =NB_SELECTION+1 WHERE TAG_NOM = '$nom'"); // préparation de la requête
    $query->execute(); // exécution de la requête
  }
}
?>
