<?php

include_once "../../pdo.php";
include_once "functions.php";
include_once "../../ROLE/read/functions.php";

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

else if (isset($headers['Unactive'])){
  echo json_encode(GetUnactivePersons());
}

else if (isset($headers['Email'])){
    if(isset($headers['Login'])){
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
    elseif (isset($headers['Infos'])) {
      echo json_encode(GetUserByEmail($headers['Email']));
    }
    else{
      echo json_encode(GetUserIdByEmail($headers['Email']));
    }
}

else{
    echo json_encode("No params ...");
}
