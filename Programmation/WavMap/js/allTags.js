//allTags.js détient l'ensemble des tags de la BDD à travers allTags.php
fetch("https://waview.ch/wavcontact/map/php/allTags.php")  // Lien qui contient les données
  .then(res=>res.json())  // réponse en format json
  .then(res=>{
    //console.log(res);
    let cboTag = ``;

    // Boucle sur l'ensemble des tags
    for (var i = 0; i < res.length; i++) {
      cboTag += `<option>${res[i]['TAG_NOM']}</option>`; // Tag
    }
    //si on veut testé mettre "test" et appelé URL https://waview.ch/wavcontact/map/test.html
    document.getElementById("cboTag").innerHTML = cboTag;
  });
