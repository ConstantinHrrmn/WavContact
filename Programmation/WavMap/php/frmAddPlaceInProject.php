<?php
include_once "pdo.php";
include_once "pdocontact.php";

$userId = $_SESSION['user']['id'];
$projetId = $_POST['cboProjet'];
$log = "Log : Ajout lieu";
$time = GetDateTime();

NewActivity($userId, $projetId, $log, $time);

AddPlaceInProject($_POST);

header('Location: https://waview.ch/wavcontact/map'); // retour sur la page principale
exit;

function GetDateTime(){
  $date = new DateTime("now", new DateTimeZone('Europe/Zurich') );
  return $date->format('Y-m-d H:i:s.ms');
}

function NewActivity($user, $project, $text, $time){
  $req = "INSERT INTO `ACTIVITE`(`ACTIVITE_PERSONNE_FK`, `ACTIVITE_PROJET_FK`, `ACTIVITY_CONTENT`, `ACTIVITE_MAJ`) VALUES ('$user', '$project', '$text', '$time')";
  $query = wavcontact()->prepare($req);
  $query->execute();
}

function AddPlaceInProject($data_post){
  // Elements
  $idProjet = $_POST['cboProjet'];
  $idLieu = $_POST['idLieu'];
  $idTournage = $_POST['selectATournage'];

  // Tableau sur les éléments
  $data = [$idProjet, $idLieu, $idTournage];
  // Préparation de la requête
  $query = database()->prepare("INSERT INTO PROJECT_HAS_LIEU(PK_FK_PROJECT_ID, PK_FK_LIEU_ID, PK_FK_TOURNAGE_ID) VALUES (?,?,?)");
  // Exécution de la requête
  $query->execute($data);
}
?>
