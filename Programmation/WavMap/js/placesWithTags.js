// placesWithTags utilise tous les lieux avec leurs tags
fetch("https://waview.ch/wavcontact/map/php/placesWithTags.php")  // Lien qui contient les données
  .then(res=>res.json())  // réponse en format json
  .then(res=>{
    console.log(res);
  });
