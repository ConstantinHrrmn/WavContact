// map.js contient la carte Google Map avec ses marqueurs.
//Il est également possible de savoir notre position actuelle.
let map;  // la carte
let markers = []; // Liste des marqueurs
let dicoMarkersTag = {}; // Liste des tags avec ses marqueurs. Clé : tag & valeurs : liste de marqueurs
let tags = []; // Liste des tags
var infoopened = "undefined";  // infoWindow actuellement ouverte. Initialisation en "undefined"


// Fonction permettant d'initialiser notre carte et la position de l'utilisateur
function initMap() {
  // Position de départ souhaité. Ici, Genève
  ourMap(46.2043907, 6.1431577);

  // Localisation de l'utilisateur
  userLocation();
}

// Fonction permettant d'initialiser notre carte
function ourMap(latitude, longitude){
  // Simple ouverture de la maps selon la latitude et la longitude
  map = new google.maps.Map(document.getElementById("map"), {
    center: {lat: latitude, lng: longitude}, // centrer sur la carte sur les positions souhaitées
    zoom: 11, // le zoom que l'on veux appliquer sur la carte au début (1 loin, +++ plus près)
    mapTypeId: 'hybrid'  // Type de la carte de base au choix : roadmap, satellite, hybrid, terrain
  });
  map.setTilt(45); // angle de 45° si on zoom (marche en mode satellite et hybrid)
}

// Fonction pour la création de la balise de la géolocalisation et géolocalisation de l'utilisateur
function userLocation(){
  const locationButton = document.createElement("img");
  locationButton.src = "image/marker-multiauto.png";
  locationButton.classList.add("custom-map-control-button");
  locationButton.style.height = "8%";
  locationButton.style.marginRight = 6;
  locationButton.style.marginTop = 8;
  locationButton.style.cursor = "pointer";
  var infoWindow = new google.maps.InfoWindow();

  map.controls[google.maps.ControlPosition.TOP_RIGHT].push(locationButton);
  // Si on clique sur la balise, une infoWindow va s'afficher sur la position actuelle de l'utilisateur
  locationButton.addEventListener("click", () => {
    if(infoopened != "undefined"){ // Permet de fermer le marqueur ouvert si on veux l'affichage de le géolocalisation
      infoopened.close();
    }

    if (navigator.geolocation) {
      navigator.geolocation.getCurrentPosition(
        (position) => {
          const pos = {
            lat: position.coords.latitude,
            lng: position.coords.longitude,
          };
          infoWindow = new google.maps.InfoWindow({
            position: pos,
            content: "Vous êtes ici !",
            map: map,
            center: pos
          });
          infoopened = infoWindow;
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

// Fonction permettant d'ajouter un marker et son infoWindow
function addMarker(latitude, longitude, name, description, tag, image, id){
  //Initialisation de l'infoWindow
  // infoWindow contient les informations de notre fenêtre pour un marqueur
   var infoWindow = new google.maps.InfoWindow();
   infoWindow.setSize(50);

  //Initialisation du nouveau marqueur
  var marker = new google.maps.Marker({
    position: {lat: Number(latitude), lng: Number(longitude)},
    map: map,
    title: name,
  });


 //Fonction interne qui affilie un événement sur le marqueur qui permet d'ouvrir l'infoWindow
 (function (marker) {
     google.maps.event.addListener(marker, "click", function (e) {
         if(infoopened != 'undefined') {
           infoopened.close();
         }
         let imageString = "";

         if(image != null){
           imageString = '<img src="../map/imagelieu/' + image + '" height="40%" width="40%">';
          // Le style mieux en % mais ne marche pas sur téléphone du coup
         }
         // Contenu de l'infoWindow
         let contentString = '<div id="content" style="z-index:10;">' +
                              '<div id="siteNotice"></div>' +
                              '<h1>' +name + '</h1>' +
                              '<div id="bodyContent">' +
                              '<p>' + description + '</p>' +
                              imageString +
                              '<div id="lienContent">' +
                              `<button type="button" class="btnMarker" onclick="ouvertureFrmAddPlaceInProject(${id})"><img src="../map/image/imagePlus.png" height="2%" width="2%"><a href="#headerSession" style="text-decoration:none; color:black;">Ajouter à votre projet</a></button>` +
                              '</div>' +
                              "</div>" +
                              "</div>";
         // Ajout du contenu de l'infoWindow
         infoWindow.setContent(contentString);

         // Ouverture de l'infoWindow sur la map avec le marqueur en question
         infoWindow.open(map, marker);
         infoopened = infoWindow;
     });
 })(marker);


 markers.push(marker); // ajout dans la liste des marqueurs
 if (!tags.includes(tag)){
   tags.push(tag);  // ajout dans la liste des tags
   dicoMarkersTag[tag] = [];
 }
 dicoMarkersTag[tag].push(marker); // ajouter le marker à la liste ayant comme clé le tag
}

// Cache tous les marqueurs sans les enlever de la liste des marqueurs
function hideMarkers() {
  for(var i = 0; i < markers.length; i++){
    markers[i].setVisible(false);
  }
  if(infoopened != 'undefined') {
    infoopened.close();
  }
}

// Affiche tous les marqueurs
function showMarkers() {
  for(var i = 0; i < markers.length; i++){
    markers[i].setVisible(true);
  }
  if(infoopened != 'undefined') {
    infoopened.close();
  }
}

// Affiche les marqueurs selon le tag choisi
function showMarker(tagChoosen) {
  let arrayMarker = dicoMarkersTag[tagChoosen];
  if(arrayMarker != null){
    for(var i = 0; i < arrayMarker.length; i++){
      arrayMarker[i].setVisible(true);
    }
  }
  if(infoopened != 'undefined') {
    infoopened.close();
  }
}
