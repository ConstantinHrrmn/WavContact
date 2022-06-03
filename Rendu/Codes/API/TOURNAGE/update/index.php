<?php

include "../../pdo.php";
include "functions.php";

$headers = array();
foreach (getallheaders() as $name => $value) {
   $headers[$name] = $value;
}

if (isset($headers['Id']) && isset($headers['Start']) && isset($headers['End'])) {
    $startTime = date('Y-m-d H:i:s.ms', strtotime($headers['Start']));
    $endTime = date('Y-m-d H:i:s.ms', strtotime($headers['End']));
    $id = $headers['Id'];

    UpdateTournage($id, $startTime, $endTime);
    //var_dump($startTime, $endTime);
}
