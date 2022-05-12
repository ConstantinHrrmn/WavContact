// map contient notre map initial
// infoWindow contient les informations de notre fenêtre positionné pour un marker
let map;

function initMap() {
  // Position de départ souhaité. Ici, Genève
  ourMap(46.2043907, 6.1431577);

  // Icone de fleche et localisation de l'utilisateur
  userLocation();
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
  locationButton.src = "image/marker-multiauto.png";
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

function addMarker(latitude, longitude, name, description){
  //Créer et ouvrir l'infoWindow
  var infoWindow = new google.maps.InfoWindow();

  //Ajouter un nouveau marker
  var marker = new google.maps.Marker({
    position: {lat: Number(latitude), lng: Number(longitude)},
    map: map,
    title: name,
 });

 //Affilier un événement sur le marker qui ouvrira l'info
 (function (marker) {
     google.maps.event.addListener(marker, "click", function (e) {
         // Contenu de l'infoWindow
         infoWindow.setContent("<h1>" + name + "</h1>" + "<p>" + description + "</p>");
         // Ouverture de l'infoWindow sur la map avec le marker en question
         infoWindow.open(map, marker);
     });
 })(marker);
}
