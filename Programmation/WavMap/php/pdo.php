<?php
//error_reporting(E_ALL);
session_start();

//Constantes
define("DB_HOST", "waview.ch.mysql");
define("DB_NAME", "waview_chwavemap");
define("DB_USER", "waview_chwavemap");
define("DB_PASSWORD", "Wavemap2021");

// PDO
function database(){
    static $dbc = null;

    if ($dbc == null) {
        try{
            $dbc = new PDO('mysql:host=' . DB_HOST . ';dbname=' . DB_NAME, DB_USER, DB_PASSWORD,
                    array(PDO::MYSQL_ATTR_INIT_COMMAND => "SET NAMES utf8", PDO::ATTR_PERSISTENT => TRUE));
        } catch (Exception $e) {
            echo 'Erreur : ' . $e->getMessage() . '<br/>';
            echo 'N° : ' . $e->getCode();
            die('Could not connect to MySQL');
        }
    }
    return $dbc;
}
