<?php

//Constantes
define("DB_HOST2", "waview.ch.mysql");
define("DB_NAME2", "waview_chcontact");
define("DB_USER2", "waview_chcontact");
define("DB_PASSWORD2", "Waview2021_!");

// PDO
function wavcontact(){
    static $dbc = null;

    if ($dbc == null) {
        try{
            $dbc = new PDO('mysql:host=' . DB_HOST2 . ';dbname=' . DB_NAME2, DB_USER2, DB_PASSWORD2,
                    array(PDO::MYSQL_ATTR_INIT_COMMAND => "SET NAMES utf8", PDO::ATTR_PERSISTENT => TRUE));
        } catch (Exception $e) {
            echo 'Erreur : ' . $e->getMessage() . '<br/>';
            echo 'N° : ' . $e->getCode();
            die('Could not connect to MySQL');
        }
    }
    return $dbc;
}
