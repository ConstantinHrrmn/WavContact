<?php
include_once "../apiv2/pdo.php";
include "/php/functions.php";

$user = null;

// Si la session est inconnu, on redemande une connexion sur le formulaire
if (!isset($_SESSION['user'])) {
  header('Location: https://waview.ch/wavcontact/map/register.php');
}
else{

  $user = $_SESSION['user'];

  $headers = array();
  foreach (getallheaders() as $name => $value) {
     $headers[$name] = $value;
  }

  if (isset($headers['Tags'])) {
    var_dump(GetPlacesWithTags($headers['Tags']));
  }
  else{
    echo json_encode("No Tags");
  }

}
?>


<!DOCTYPE html>
<html lang="en" dir="ltr"> <!-- ltr pour lecture de gauche à droite (left to right)-->
  <head>
    <!-- Responsive html-->
    <link rel="stylesheet" href="css/index.css" />
    <meta charset="utf-8" name="viewport" content="width=device-width, initial-scale=1.0">
    <title>WavMaps</title>


    <script>
      // map contient notre map initial
      // infoWindow contient les informations de notre fenêtre positionné pour un marker
      let map, infoWindow, marker;

      function initMap() {
        // Position de départ souhaité. Ici, Genève
        ourMap(46.2043907, 6.1431577);

        // Icone de fleche et localisation de l'utilisateur
        userLocation();

        // Ajouter un marker. Ici, Waview
        addMarker(46.2201647, 6.0771042, "Waview");

      }



      function ourMap(latitude, longitude){
        // Simple ouverture de la maps selon la longitude et latitude de startPlace
        map = new google.maps.Map(document.getElementById("map"), {
          center: {lat: latitude, lng: longitude}, // centrer sur startPlace
          zoom: 11, // le zoom que l'on veux appliquer sur la carte au début (1 loin, +++ plus près)
          mapTypeId: 'hybrid'  // Type de la carte de base au choix : roadmap, satellite, hybrid, terrain
        });
        map.setTilt(45); // angle de 45° si on zoom (marche en mode satellite et hybrid)
      }



      // Fonction pour la création de la flèche de la géolocalisation et géolocalisation de l'utilisateur
      function userLocation(){
        const locationButton = document.createElement("img");
        locationButton.src = "icon_geoloca.png";
        locationButton.classList.add("custom-map-control-button");
        locationButton.style.height = "8%";
        locationButton.style.marginRight = 6;
        locationButton.style.marginTop = 8;
        map.controls[google.maps.ControlPosition.TOP_RIGHT].push(locationButton);
        // Si on clique sur la flèche noir, une infoWindow va s'afficher sur la position actuelle de l'utilisateur
        locationButton.addEventListener("click", () => {
          if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(
              (position) => {
                const pos = {
                  lat: position.coords.latitude,
                  lng: position.coords.longitude,
                };
                infowindow = new google.maps.InfoWindow({
                  position: pos,
                  content: "Vous êtes ici !",
                  map: map,
                  center: pos
                });
              },
              () => {
                handleLocationError(true, infoWindow, map.getCenter());
              }
            );
          }
          else {
            handleLocationError(false, infoWindow, map.getCenter());
          }
        });
      }



      // Fonction utiliser pour la geolocalisation
      function handleLocationError(browserHasGeolocation, infoWindow, pos) {
        infowindow = new google.maps.InfoWindow({
          position: pos,
          content: browserHasGeolocation
            ? "Erreur: La géolocalisation a échoué."
            : "Erreur: Votre moteur de recherche ne peut pas vous géolocaliser.",
          map: map,
          center: pos
        });
      }



      // Fonction pour créer un marker et son infoWindow
      function addMarker(latitude, longitude, name){
        marker = new google.maps.Marker({
          position: {lat: latitude, lng: longitude},
          map: map,
          title: name,
        });

        infowindow = new google.maps.InfoWindow({
          content: name,
        });

        // Permet de mettre un affichage sur le marker lorsqu'on y clique
        marker.addListener("click", () => {
          infowindow.open({
            anchor: marker,
            map,
          });
        });
      }
    </script>

  </head>
  <body>
    <h1>Voici notre application</h1>
    <h2>Bonjour <?php echo $user['first_name'] ?> (<?php echo $user['roleName'] ?>)</h2>
    <button type="button" name="btnLogout" onclick="window.location.href='https://waview.ch/wavcontact/map/php/logout.php'">Logout</button>

    <div id="tagRecherche">
      <p> Ca marche cette merde
        c'est ici qu'il faut mettre les différents tag
      </p>
    </div>


    <div id="map">
      <!-- adresse API + clé + region : CH + langue : français + callback : initMap + libraries-->
      <script
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCREy29Y020Q0EBK69pN4bb32jc72BmpFY&region=CH&language=fr&callback=initMap&libraries=&v=weekly"
        async
      ></script>
    </div>

  </body>
</html>
