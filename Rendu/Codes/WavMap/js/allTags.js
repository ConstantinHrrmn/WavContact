//allTags.js va prendre l'ensemble des lieux de la BDD à travers allTags.php et créer des marqueurs
fetch("https://waview.ch/wavcontact/map/php/allTags.php")  // Boucle sur l'URL qui contient les données
    .then(res=>res.json())  // réponse en format json
    .then(res=>{
      let frmAddPlace = ``;
      let frmProposalPlace = ``;
      // Boucle sur l'ensemble des résultats pour la création des checkboxs
      for(var i = 0; i < res.length; i++){
        frmAddPlace += `<label name="lblTagNom" for="${res[i]['TAG_NOM']}"><input type="checkbox" id="${res[i]['TAG_NOM']}" class="divCheckboxesTagAddPlaceForm" name="check_list[]" value="${res[i]['TAG_NOM']}"/>${res[i]['TAG_NOM']}</label>`;
        frmProposalPlace += `<label name="lblTagNom" for="${res[i]['TAG_NOM']}"><input type="checkbox" id="${res[i]['TAG_NOM']}" class="divCheckboxesTagAddPlaceFormClient" name="check_list[]" value="${res[i]['TAG_NOM']}"/>${res[i]['TAG_NOM']}</label>`;
      }
      // Ajout dans les divs des formulaires
      document.getElementById("divCheckboxesTagAddPlaceForm").innerHTML = frmAddPlace;
      document.getElementById("divCheckboxesTagAddPlaceFormClient").innerHTML = frmProposalPlace;
    });
