<?php

include_once "functions.php";
include_once "../read/functions.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
    $headers[$name] = $value;
}

if (isset($headers['Email']) && isset($headers['Nom']) && isset($headers['Prenom']) && isset($headers['Tel']) && isset($headers['Password']) && isset($headers['Role']) && isset($headers['Active'])) {
    CreateNewPerson($headers['Nom'], $headers['Prenom'], $headers['Email'], $headers['Tel'], $headers['Role'], $headers['Active']);

    $password = hash("sha256", $headers['Password']);
    $email = $headers['Email'];

    $id = database()->lastInsertId();

    $idHash = hash("sha256", $id);
    $pass = hash("sha512", $idHash.$password);

    AddPasswordToPerson($id, $pass);


    //AddPersonToRole($id, $headers['Role']);
    if ($headers['Role'] == 2) {
      CreateChatForClient($id);
    }
    else if($headers['Role'] == 1){
      AddUserToAllChannels($id);
    }

    echo json_encode("");
}
else{
    echo json_encode("Missing headers to continue");
}
