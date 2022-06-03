//allTags.js va prendre l'ensemble des lieux de la BDD à travers allTags.php et créer des marqueurs
fetch("https://waview.ch/wavcontact/map/php/allTagFavoris.php")  // Boucle sur l'URL qui contient les données
    .then(res=>res.json())  // réponse en format json
    .then(res=>{
      let allTagFavoris = ``;
      // Boucle sur l'ensemble des résultats pour la création des checkboxs
      for(var i = 0; i < res.length; i++){
        allTagFavoris += `<li data-nom="${res[i]['TAG_NOM']}" class="liTagFavoris" style="list-style: none;cursor: pointer;
">${res[i]['TAG_NOM']}</li>`;
      }
      // Ajout dans les divs des formulaires
      document.getElementById("ulTagFavoris").innerHTML = allTagFavoris;
    });
