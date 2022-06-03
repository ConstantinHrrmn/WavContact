<?php

include "../../pdo.php";
include "functions.php";


$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Id'])) {
  $id = $headers['Id'];

  echo json_encode(GetReservationById($id));

}elseif (isset($headers['All'])) {
  echo json_encode(GetAllReservatipn());

}

elseif (isset($headers['Tournage']) && isset($headers['What'])) {
  // Get All réservations for a shoot
  $what = $headers['What'];
  if ($what == "Taken") {
    echo json_encode(GetAllMaterielInTournage($headers['Tournage']));
  }else{
    if (isset($headers['Start']) && isset($headers['End'])) {
      $start = $headers['Start'];
      $end = $headers['End'];

      echo json_encode(GetMaterielAvaible($start, $end));
    }else{
      echo json_encode("No dates");
    }
  }

}

else{
  echo json_encode("wrong headers");
}
