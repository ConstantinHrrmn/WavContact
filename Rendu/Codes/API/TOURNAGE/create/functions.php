<?php



function CreateTournage($project_id, $start, $end){
  $req = "INSERT INTO `TOURNAGE`(`TOURNAGE_PROJET_ID`, `TOURNAGE_DEBUT`, `TOURNAGE_FIN`) VALUES (:p, :s, :e)";
  $query = database()->prepare($req);
  $query->bindParam(':p', $project_id, PDO::PARAM_STR);
  $query->bindParam(':s', $start, PDO::PARAM_STR);
  $query->bindParam(':e', $end, PDO::PARAM_STR);

  $query->execute();
}
