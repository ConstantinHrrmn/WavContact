<?php

include "functions.php";


if (isset($_GET['id'])) {
  $id = $_GET['id'];
  activatePlace($id);

  echo "Le lieu à bien été ajouté. Vous pouvez fermer cette page.";
}
