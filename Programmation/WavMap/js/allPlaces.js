//allPlaces.js va prendre l'ensemble des lieux de la BDD à travers allPlaces.php et créer des markers
fetch("https://waview.ch/wavcontact/map/php/allPlaces.php")  // Lien qui contient les données
  .then(res=>res.json())  // réponse en format json
  .then(res=>{
    //addMarker(46.2201647, 6.0771042, "Waview");
    // Boucle pour ajouter les marker
    for (var i = 0; i < res.length; i++) {
       addMarker(res[i]['LIEU_LAT'], res[i]['LIEU_LON'], res[i]['LIEU_NOM'], res[i]['LIEU_DESCRIPTION']);
    }
  });
