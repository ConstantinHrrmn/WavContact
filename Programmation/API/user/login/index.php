<?php

include "../../pdo.php";
include "../functions.php";

//var_dump(hash("sha512", hash("sha256", "1").hash("sha256", "motdepasse"."constantin@waview.ch")));
//$pass = hash("sha256", "84865fdc3031f38086d0319225b8d5e8a782361b71fceaefd6dded4ed217d6ff");
//echo $pass;

$headers = array();
foreach (getallheaders() as $name => $value) {
    $headers[$name] = $value;
}

//var_dump($headers);

if (isset($headers['Email']) && isset($headers['Password'])) {

  $password = hash("sha256", $headers['Password']);
  $email = $headers['Email'];

  //var_dump(getallheaders());

  $id = GetUserIdByEmail($email);

  if ($id['id'] != null) {

    $idHash = hash("sha256", $id['id']);
    $pass = hash("sha512", $idHash.$password);

    //var_dump($pass);

    $login = Login($id['id'], $pass);
    if ($login != "null") {
      echo json_encode($login);
    }else{
      echo json_encode("login fail");
    }
  }else{
    echo json_encode("no user");
  }

}else{
  echo json_encode("wrong headers");
}
