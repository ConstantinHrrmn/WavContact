<?php

include "functions.php";

$users = GetAllUsers();

echo json_encode($users);
