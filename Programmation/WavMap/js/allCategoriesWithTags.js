// allCategoriesWithTags.js utilise les données envoyées par le PDO à travers le fichier allCategoriesWithTags.php
// Grâce aux informations de celui-ci, il sera possible d'afficher sur l'ensemble de notre site les endroits ayant besoin de tag.
// Les endroits sont la "liste des tags", les "tags favoris", la "recherche de tag" et la liste des "Tags actuellement actifs".
// Il permet également d'obtenir les catégories qui seront utilisées à 2 endroits : "liste des tags" et "Ajouter un tag".
fetch("https://waview.ch/wavcontact/map/php/allCategoriesWithTags.php")  // Boucle sur l'URL qui contient les données
  .then(res=>res.json())  // réponse en format json
  .then(res=>{


    let categorie = res[0]['CATEGORIE_NOM']; // Stock la catégorie en cours
    let lstCategorie = new Array(categorie); // Stock la liste des catégories
    let tagsActifs = new Array(); // Stock la liste des tags actifs



    // liste de tag dans la liste de tag avec categorie
    let divScroll = `<details close><summary id='summary${categorie}'>${categorie}</summary><ul id='ul${categorie}' data-nom='ul${categorie}'>`;
    let readCategoriesForFormAddTag = `<option class=categories id=${categorie}>${categorie}</option>`;
    // liste de tag de la recherche
    let readSearchBar = ``;


    // Boucle sur l'ensemble des tags
    for (var i = 1; i < res.sort().length; i++) {
      categorie = res[i]['CATEGORIE_NOM'];

      // Condition pour savoir si on a déjà affiché la catégorie
      if(!lstCategorie.includes(categorie)){
        lstCategorie.push(categorie);
        divScroll += `</ul></details><details><summary id='summary${categorie}'>${categorie}</summary><ul id='ul${categorie}'>`;
        readCategoriesForFormAddTag += `<option class=categories id=${categorie}>${categorie}</option>`;
      }

      // Ajout des li dans les listes
      //divScroll += `<li value='${res[i]['TAG_NOM']}' onclick="hello(${res[i]['TAG_NOM']})" data-nom='${res[i]['TAG_NOM']}' style="list-style: none; margin-left: -1em;">${res[i]['TAG_NOM']}</li>`;
      divScroll += `<li value='${res[i]['TAG_NOM']}' id='${res[i]['TAG_NOM']}' data-nom='${res[i]['TAG_NOM']}' style="list-style: none; margin-left: -1em;">${res[i]['TAG_NOM']}</li>`;

      readSearchBar += `<li data-nom='${res[i]['TAG_NOM']}' style="list-style: none; margin-left: -1em;">${res[i]['TAG_NOM']}</li>`;
    }
    divScroll += `</ul></details>`;

    // Ajout au différent endroit ayant besoin des éléments
    document.getElementById("divScroll").innerHTML = divScroll;
    document.getElementById("ulLstTagTrouve").innerHTML = readSearchBar;
    document.getElementById("selectCatAddTagFormCollab").innerHTML = readCategoriesForFormAddTag;


    // ================================= EVENEMENTS POUR AFFICHAGE DE TAG ACTIF =================================
    // Boucle sur liste des categories pour ajouter dans liste des tags actifs
    //for(var i = 0; i < lstCategorie.sort().length; i++){
    for(var i = 0; i < lstCategorie.sort().length; i++){

      // Evenement clic de la liste des tags par categorie
      document.getElementById(`ul${lstCategorie[i]}`).addEventListener("click", evenement=>{
        hideMarkers(); // cacher tous les markers sans les supprimer
        document.getElementById('ulTagActif').innerHTML = "";
         // Condition pour savoir si le tag a déjà été sélectionné
         if(!tagsActifs.includes(evenement.target.dataset.nom)){
          tagsActifs.push(evenement.target.dataset.nom);
          tagsActifs.sort();

          // Condition pour assigner le nombre de clic sur les tags dans le localStorage
          if(localStorage.getItem(evenement.target.dataset.nom) == null){

            localStorage.setItem(evenement.target.dataset.nom, 1);
          }
          else {
            localStorage.setItem(evenement.target.dataset.nom, parseInt(localStorage.getItem(evenement.target.dataset.nom)) + 1);
          }

          //console.log(localStorage);
         }
         // Affichage des tags sélectionnés
         for(var i = 0; i < tagsActifs.length; i++){
           showMarker(`${tagsActifs[i]}`);
          document.getElementById('ulTagActif').innerHTML += `<li>${tagsActifs[i]}</li>`;
         }

      });
    }


    // Evenement clic de la liste des tags pour la barre de recherche
    document.getElementById('ulLstTagTrouve').addEventListener("click", evenement=>{
      hideMarkers(); // cacher tous les markers sans les supprimer
        document.getElementById('ulTagActif').innerHTML = "";
       // Condition pour savoir si le tag a déjà été sélectionné
       if(!tagsActifs.includes(evenement.target.dataset.nom)){
        tagsActifs.push(evenement.target.dataset.nom);
        tagsActifs.sort();
        // Condition pour assigner le nombre de clic sur les tags dans le localStorage
        if(localStorage.getItem(evenement.target.dataset.nom) == null){
          localStorage.setItem(evenement.target.dataset.nom, 1);
        }
        else {
          localStorage.setItem(evenement.target.dataset.nom, parseInt(localStorage.getItem(evenement.target.dataset.nom)) + 1);
        }
        $.ajax({
            url: '../php/addCountFavoris.php',
            type: 'POST',
            //dataType: 'json',
            data: {nameTag : liActuel, number : parseInt(localStorage.getItem(evenement.target.dataset.nom)) + 1},
            //data: data,
            success: function() {
             alert('Element retourné de AJAX : ' + liActuel);
            },
           error: function() {
             alert('There was some error performing the AJAX call!');
           }
        });
      }
      // Affichage des tags sélectionnés
      for(var i = 0; i < tagsActifs.length; i++){
        showMarker(`${tagsActifs[i]}`);
       document.getElementById('ulTagActif').innerHTML += `<li>${tagsActifs[i]}</li>`;
      }
    });


    // Evenement clic de la liste des tags favoris
    document.getElementById('ulTagFavoris').addEventListener("click", evenement=>{

    //let hellov = 'hello';
    //console.log(hellov);
    // Envoi des données du localStorage dans le PDO



     // let data = {helloAttribut: 'hello'};
     // data = JSON.stringify(data);
     //console.log(data);
      // let xhr = new XMLHttpRequest();
      // let url = './php/addCountFavoris.php';
      // xhr.open('POST', url);
      // xhr.setRequestHeader('Content-type', 'application/json');
      // xhr.send(JSON.stringify(data));

      hideMarkers(); // cacher tous les markers sans les supprimer
        document.getElementById('ulTagActif').innerHTML = "";
       // Condition pour savoir si le tag a déjà été sélectionné
       if(!tagsActifs.includes(evenement.target.dataset.nom)){
        tagsActifs.push(evenement.target.dataset.nom);
        tagsActifs.sort();

        // Condition pour assigner le nombre de clic sur les tags dans le localStorage
        if(localStorage.getItem(evenement.target.dataset.nom) == null){
          localStorage.setItem(evenement.target.dataset.nom, 1);
        }
        else {
          localStorage.setItem(evenement.target.dataset.nom, parseInt(localStorage.getItem(evenement.target.dataset.nom)) + 1);
        }

      }
      // Affichage des tags sélectionnés
      for(var i = 0; i < tagsActifs.length; i++){
        showMarker(`${tagsActifs[i]}`);
       document.getElementById('ulTagActif').innerHTML += `<li>${tagsActifs[i]}</li>`;
      }

    });



    // ================================= EVENEMENT POUR SUPPRESSION DE TAG ACTIF =================================
    // Evénement clic -> suppression de la liste des tags actifs
    document.getElementById('ulTagActif').addEventListener("click", evenement=>{
      //TODO : evenement.target.dataset.nom = undefined donc indexOf = -1 donc marche pass
      if (evenement.target !=evenement.currentTarget){
        const index = tagsActifs.indexOf(evenement.target.value);
        tagsActifs.splice(index);
        document.getElementById('ulTagActif').removeChild(evenement.target); // Supprimera que le li (enfant) et pas le ul (parent)
      }
      // Si la liste est vide, alors on affiche l'ensemble des marqueurs
      if(tagsActifs.length === 0){
        showMarkers();
      }
    });


    $('.liTagFavoris').click(function(){
      liActuel = $(this).html();
      $.ajax({
          url: './php/addCountFavoris.php',
          type: 'POST',
          //dataType: 'json',
          data: {nameTag : liActuel, number : parseInt(localStorage.getItem(evenement.target.dataset.nom)) + 1},
          //data: data,
          success: function() {
           alert('Element retourné de AJAX : ' + liActuel);
          },
         error: function() {
           alert('There was some error performing the AJAX call!');
         }
      });
    });


  });
