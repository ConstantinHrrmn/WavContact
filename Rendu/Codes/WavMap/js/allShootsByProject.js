// Fonction permettant de retourner dans les tournages correspondants au projet sélectionné
function searchShootsByProject(id){

  // Boucle tous les éléments de la liste et masque ceux qui ne correspondent pas à la requête de recherche
    fetch("https://waview.ch/wavcontact/apiv2/TOURNAGE/read/getTournagesForUser.php")  // Boucle sur l'URL qui contient les données
      .then(res=>res.json())  // réponse en format json
      .then(res=>{
        let readAllTournage = `<select name="selectATournage" id="selectATournage">`;
        // Boucle pour ajouter les options dans le select
        for (var i = 0; i < res.length; i++) {
          if(id == res[i]['idProjet']){
            readAllTournage += `<option value=${res[i]['idTournage']}>${res[i]['debut']} au ${res[i]['fin']}</option>`;
          }
        }
        // Condition pour savoir s'il faut annoncé qu'il n'y a pas de tournage pour ce projet
        if(readAllTournage == `<select name="selectATournage" id="selectATournage">`){
          readAllTournage = "Aucune date de tournage prévue avec ce projet";
        }else{
          readAllTournage += "</select>"
        }

        // Ajout dans la div du formulaire d'ajout de lieu pour un projet
        document.getElementById("selectTournage").innerHTML = readAllTournage;

      });
}
