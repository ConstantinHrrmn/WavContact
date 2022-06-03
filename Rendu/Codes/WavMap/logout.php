<?php

include_once "pdo.php";

session_destroy(); // détruit la session

header("Location: https://waview.ch/wavcontact/map/register.php"); // retourn sur la page de connexion
?>
