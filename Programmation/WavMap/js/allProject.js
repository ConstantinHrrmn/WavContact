//allProject.js va prendre l'ensemble des lieux de la BDD à travers getProjectForUser.php et créer des markers

fetch("https://waview.ch/wavcontact/apiv2/PROJET/read/getProjectForUser.php")  // Boucle sur l'URL qui contient les données
  .then(res=>res.json())  // réponse en format json
  .then(res=>{
    readAllProject = `<option value="Empty">Sélectionner un projet</option>`;
    // Boucle sur les résultats pour ajouter les options dans le select
    for(var i = 0; i < res.length; i++){
      readAllProject += `<option name="${res[i]['id']}" value="${res[i]['id']}" data-name='${res[i]['name']}' id='${res[i]['name']}'>${res[i]['name']}</option>`;
    }
    // Ajout dans le select
    document.getElementById("cboProjet").innerHTML = readAllProject;

    // Événement lorsque un projet est sélectionné
    document.getElementById("cboProjet").addEventListener("change", evenement=>{
      // Condition servant à savoir si c'est l'option qui propose de la sélection de projet
      if(evenement.target.value === "Empty"){
        document.getElementById("selectTournage").innerHTML = ""; // retourne rien
      }
      else{
        searchShootsByProject(evenement.target.value); // appel de la fonction se trouvant dans allShootsByProject.js
      }
    });

  });
