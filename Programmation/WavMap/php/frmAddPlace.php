<?php
include_once "pdo.php";

$photo = UploadImage($_FILES['photo']); // initialisation du path de la photo
CreateLieu($_POST, $photo);

header('Location: https://waview.ch/wavcontact/map'); // retour sur la page principale
exit;

function CreateLieu($data_post, $idImage){
  // ============================== INSERT INTO LIEU ==============================
  // initialisation des éléments
  $nom = $_POST['inputNomAddPlaceForm'];
  $numStatut = $_POST['actif'];
  $longitude = str_replace(',', '.', $_POST['inputLongitudeAddPlaceForm']);
  $latitude = str_replace(',', '.', $_POST['inputLatitudeAddPlaceForm']);
  $description = $_POST['inputDescriptionAddPlaceForm'];

  // Permet de mettre tout les mots en minuscule et la 1er lettre du 1er mot en majuscule (initcap)
  $nom = ucfirst(strtolower($nom));
  $description = ucfirst(strtolower($description));

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
