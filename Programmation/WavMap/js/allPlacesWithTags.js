//allPlaces.js va prendre l'ensemble des lieux de la BDD à travers allPlaces.php et créer des markers

var path = "https://waview.ch/wavcontact/map/imagelieu/";

fetch("https://waview.ch/wavcontact/map/php/allPlacesWithTags.php")  // Boucle sur l'URL qui contient les données
  .then(res=>res.json())  // réponse en format json
  .then(res=>{
    // Boucle pour ajouter les marker
    for (var i = 0; i < res.length; i++) {
       let marker = addMarker(res[i]['LIEU_LAT'], res[i]['LIEU_LON'], res[i]['LIEU_NOM'], res[i]['LIEU_DESCRIPTION'], res[i]['TAG_NOM'], res[i]['PHOTO_PATH'], res[i]['LIEU_ID']);
    }
  });
