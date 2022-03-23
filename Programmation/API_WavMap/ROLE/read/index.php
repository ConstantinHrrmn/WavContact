<?php

include "functions.php";

// Initialisation de la liste qui contiendra les headers
$headers = array();

foreach (getallheaders() as $name => $value) {
    $headers[$name] = $value;
}

if (isset($headers['Id'])) {
    echo json_encode(WhatIsMyRole($headers['Id']));
}
