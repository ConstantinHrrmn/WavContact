<?php
include_once "../apiv2/pdo.php";
include_once "../apiv2/PERSONNE/read/functions.php";
include_once "../apiv2/ROLE/read/functions.php";

// Vérification du login
if (isset($_POST['username']) && isset($_POST['password'])) {
    $password = $_POST['password'];
    $username = $_POST['username'];

    $hashed_pass = hash("sha256", $password.$username);

    $password = hash("sha256", $hashed_pass);
    $email = $username;

    $id = GetUserIdByEmail($email);

    if ($id['id'] != null) {

      $idHash = hash("sha256", $id['id']);
      $pass = hash("sha512", $idHash.$password);

      $login = Login($email, $pass);

      //var_dump($login);

      if ($login != null) {
          // LE LOGIN EST OK
          $logged_user = GetUserById($id['id']);
          $_SESSION['user'] = $logged_user;



          header('Location: https://waview.ch/wavcontact/map');
      }
      else {
          // Login pas OK
      }
    }
  }
?>
