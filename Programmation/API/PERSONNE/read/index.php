<?php

include "functions.php";

$headers = array();

foreach (getallheaders() as $name => $value) {
    $headers[$name] = $value;
}

if (isset($headers['All'])) {
    echo json_encode(GetAllPersons());
}

else if (isset($headers['Allandroles'])) {
    echo json_encode(GetAllPersonsWithRole());
}

else if (isset($headers['Id'])){
  echo json_encode(GetUserById($headers['Id']));
}

else if(isset($headers['Login'])){
    $emailOk = false;
    $passOk = false;

    if (isset($headers['Email'])) {
        $emailOk = true;
    }else{
        echo json_encode("Missing email");
    }

    if (isset($headers['Password'])) {
        $passOk = true;
    }else{
        echo json_encode("Missing password");
    }

    if ($emailOk && $passOk) {
        //echo json_encode("ALL OK");
        $password = hash("sha256", $headers['Password']);
        $email = $headers['Email'];

        //var_dump($password);
        //var_dump($email);

        $id = GetUserIdByEmail($email);

        if ($id['id'] != null) {

            $idHash = hash("sha256", $id['id']);
            $pass = hash("sha512", $idHash.$password);

            //var_dump($pass);

            $login = Login($email, $pass);

            //var_dump($login);

            if ($login != null) {
              echo json_encode(GetUserById($id['id']));
            }else{
              echo json_encode("login fail");
            }
         }else{
            echo json_encode("no user");
         }
    }
}

else{
    echo json_encode("No params ...");
}
