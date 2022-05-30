<?php
include_once "pdo.php";

$photo = UploadImage($_FILES['photo']); // initialisation du path de la photo
$idLieu = CreateLieu($_POST, $photo);

$target_file = "https://waview.ch/wavcontact/map/imagelieu/" . basename($_FILES['photo']["name"]);

$url = "https://waview.ch/wavcontact/apiv2/LIEU/activate?id=".$idLieu;
$subject = "Nouveau lieu proposé";
$mail = "Bonjour, \r\n ".$_SESSION['user']['first_name']. " vous propose un nouveau lieu. Afin de l'accepter, veuillez cliquer sur le lien suivant : \r\n".$url;
$mail = $mail." \r\n Voici les informations du lieu : ";
$mail = $mail." \r\n Identifiant : ". $idLieu;
$mail = $mail." \r\n Nom : ". $_POST['lieu'];
$mail = $mail." \r\n Longitude : ". str_replace(',', '.', $_POST['logitude']);
$mail = $mail." \r\n Latitude : ". str_replace(',', '.', $_POST['latitude']);
$mail = $mail." \r\n Description : ". $_POST['description'];
$mail = $mail." \r\n Photo : ". $target_file;

$headers = 'From: wavmap@waview.ch' . "\r\n" .
     'Reply-To: info@waview.ch' . "\r\n" .
     'X-Mailer: PHP/' . phpversion();

mail("info@waview.ch", $subject, $mail, $headers);

header('Location: https://waview.ch/wavcontact/map/validation.php'); // retour sur la page principale
exit;

function CreateLieu($data_post, $idImage){
  // ============================== INSERT INTO LIEU ==============================
  // initialisation des éléments
  $nom = $_POST['lieu'];
  $numStatut = $_POST['actif'];
  $longitude = str_replace(',', '.', $_POST['logitude']);
  $latitude = str_replace(',', '.', $_POST['latitude']);
  $description = $_POST['description'];

  // Tableau des éléments
  $data = [$nom, $numStatut, $longitude, $latitude, $description];
  // Préparation de la requête
  $query = database()->prepare("INSERT INTO LIEU(LIEU_NOM, FK_LIEU_STATUT, LIEU_LON, LIEU_LAT, LIEU_DESCRIPTION) VALUES (?,?,?,?,?)");
  // Exécution de la requête
  $query->execute($data);

  // Stockage de l'id du lieu
  $id = database()->lastInsertId();

  //============================== INSERT INTO LIEU_HAS_TAG ==============================
  $data = array();
  if(!empty($_POST['check_list'])){
    $stmt = database()->query("SELECT * FROM TAG");
    while ($row = $stmt->fetch()) {
      for($i = 0; $i < count($_POST['check_list']); $i++){
        if ($row['TAG_NOM'] == $_POST['check_list'][$i]){
          array_push($data, [$id, $row['TAG_ID']]);
        }
      }
    }
  }

  $req = "";
  // Boucle pour la requête d'insertions dans la table LIEU_HAS_TAG
  foreach ($data as $row)
  {
    $req = $req . "INSERT INTO LIEU_HAS_TAG(PK_FK_LIEU_ID, PK_FK_TAG_ID) VALUES ($row[0], $row[1]);";
  }
  // Préparation de la requête
  $query = database()->prepare($req);
  // Exécution de la requête
  $query->execute();


  // ============================== INSERT INTO LIEU_HAS_PHOTO ==============================
  $data = [$id, $idImage]; // Tableau des éléments
  // Préparation de la requête
  $query = database()->prepare("INSERT INTO `LIEU_HAS_PHOTO`(`PK_FK_LIEU_ID`, `PK_FK_PHOTO_ID`) VALUES (?,?)");
  // Exécution de la requête
  $query->execute($data);

  return $id;
}

// ============================== INSERT INTO PHOTO ==============================
function UploadImage($sourceFile){
  $target_dir = "../imagelieu/";
  $target_file = $target_dir . basename($sourceFile["name"]);

  move_uploaded_file($sourceFile["tmp_name"], $target_file); // ajout dans le dossier imagelieu sur le serveur

  // Elément
  $path = basename($sourceFile["name"]);
  // Tableau des éléments
  $data = [$path];
  // Préparation de la requête
  $query = database()->prepare("INSERT INTO `PHOTO`(`PHOTO_PATH`) VALUES (?)");
  // Exécution de la requête
  $query->execute($data);

  return database()->lastInsertId();
}

?>
