<?php


include_once "functions.php";

include "../read/functions.php";

$headers = array();

foreach (getallheaders() as $name => $value) {
    $headers[$name] = $value;
}

if (isset($headers['Reset'])) {
    if ($headers['Reset'] == "password") {
        if (isset($headers['Email']) && isset($headers['Password'])) {

            $password = hash("sha256", $headers['Password']);
            $email = $headers['Email'];

            //var_dump($email);

            $id = GetUserIdByEmail($email);

            //var_dump($id);

            if ($id['id'] != null) {
                $idHash = hash("sha256", $id['id']);
                $pass = hash("sha512", $idHash.$password);

                UpdatePassword($id['id'], $pass);
                echo json_encode(true);
            }else{
                echo json_encode(false);
            }
        }else{
            echo json_encode(false);
        }
    }
}

elseif (isset($headers['Active'])) {
  if (isset($headers['Id'])) {
    $id = $headers['Id'];
    SetActive($id);
  }
}

elseif(isset($headers["Update"])){
  if (isset($headers["Id"]) && isset($headers["Firstname"]) && isset($headers["Lastname"]) && isset($headers["Phone"]) && isset($headers["Role"])) {
    $id = $headers['Id'];
    $firstname = $headers['Firstname'];
    $lastanme = $headers['Lastname'];
    $phone = $headers['Phone'];
    $role = $headers['Role'];

    UpdateClientInfos($id, $firstname, $lastanme, $phone, $role);

    echo json_encode(true);
  }else{
    echo json_encode(false);
  }
}

else{
  echo json_encode("No headers");
}
