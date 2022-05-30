<?php
include_once "pdo.php";


addCountFavoris();

function AddCountFavoris(){
  //print_r("test");
  // if( !isset($_POST['nameTag']) ) {print_r("a");}
  // else if( !isset($_POST['number']) ) {print_r("b");}
  // else {
  //   $data = ['name' => $_POST['nameTag'], 'number => '$_POST['number']];
  //   print_r($data);
  //   $pdo = database();
  //   $req = "UPDATE TAG SET NB_SELECTION =:number WHERE TAG_NOM =: name";
  //
  //   $query = $pdo->prepare($req);
  //   $query->execute($data);
  // }
  print_r($_POST);
  return json_encode("test");
}
?>
