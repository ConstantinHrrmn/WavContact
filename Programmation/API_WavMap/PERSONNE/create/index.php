<?php

include_once "functions.php";
include_once "../read/functions.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
    $headers[$name] = $value;
}

if (isset($headers['Email']) && isset($headers['Nom']) && isset($headers['Prenom']) && isset($headers['Tel']) && isset($headers['Password']) && isset($headers['Role'])) {
    CreateNewPerson($headers['Nom'], $headers['Prenom'], $headers['Email'], $headers['Tel']);

    $password = hash("sha256", $headers['Password']);
    $email = $headers['Email'];

    $id = database()->lastInsertId();

    var_dump($id);

    $idHash = hash("sha256", $id);
    $pass = hash("sha512", $idHash.$password);

    AddPasswordToPerson($id, $pass);
    AddPersonToRole($id, $headers['Role']);

    echo json_encode(GetUserById($id));
}
else{
    echo json_encode("Missing headers to continue");
}
