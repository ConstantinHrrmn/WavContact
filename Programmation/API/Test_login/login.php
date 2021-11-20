<?php

include "functions.php";

//var_dump(hash("sha512", hash("sha256", "1").hash("sha256", "motdepasse"."constantin@waview.ch")));


$headers = array();
foreach (getallheaders() as $name => $value) {
    $headers[$name] = $value;
}

$password = $headers['password'];
$email = $headers['email'];

$id = GetUserIdByEmail($email);

if ($id['id'] != null) {
  $pass = hash("sha256", $password.$email);
  $idHash = hash("sha256", $id['id']);
  $pass = hash("sha512", $idHash.$pass);

  $login = Login($id['id'], $pass);
  if ($login != "null") {
    echo json_encode($login);
  }else{
    echo json_encode("null");
  }
}else{
  echo json_encode("null");
}
