<?php

function GetDateTime(){
  $date = new DateTime("now", new DateTimeZone('Europe/Zurich') );
  return $date->format('Y-m-d H:i:s.ms');
}
