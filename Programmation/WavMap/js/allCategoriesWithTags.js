// allCategoriesWithTags est utilisé pour la liste des tags par catégorie
fetch("https://waview.ch/wavcontact/map/php/allCategoriesWithTags.php")  // Lien qui contient les données
  .then(res=>res.json())  // réponse en format json
  .then(res=>{
    //console.log(res); // Voir les données dans la console
    let categorie = res[0]['CATEGORIE_NOM']; // Stock la catégorie en cours
    let lstCategorie = new Array(categorie); // Stock les catégories
    let divScroll = `<details close><summary id='summary${categorie}'>${categorie}</summary><ul id='ul${categorie}'>`;
    let tagsActifs = new Array();
    // Boucle sur l'ensemble des tags
    for (var i = 1; i < res.length; i++) {
      divScroll += `<li data-nom='${res[i]['TAG_NOM']}'>${res[i]['TAG_NOM']}</li>`; // Tag
      categorie = res[i]['CATEGORIE_NOM'];

      // Condition pour savoir si on a déjà afficher la catégorie
      if(!lstCategorie.includes(categorie)){
        //console.log("Categorie ajoute : " + categorie);
        lstCategorie.push(categorie);
        divScroll += `</ul></details><details><summary id='summary${categorie}'>${categorie}</summary><ul id='ul${categorie}'>`;  // Categorie
      }
    }
    divScroll += `</ul></details>`;

    //si on veut testé mettre "test" et appelé URL https://waview.ch/wavcontact/map/testAJAX.html
    document.getElementById("divScroll").innerHTML = divScroll;
    // Boucle sur liste pour ajouter dans liste des tags actifs
    lstCategorie.forEach((categorie) => {
      //console.log(`ul${categorie}`, document.getElementById(`ul${categorie}`));
      document.getElementById(`ul${categorie}`).addEventListener("click", e=>{
         //console.log(e.target.dataset.nom);
         document.getElementById('ulTagActif').innerHTML += `<li>${e.target.dataset.nom}</li>`;
         //if(!tagsActifs.includes(e.target.dataset.nom)){
         //  tagsActifs.push(e.target.dataset.nom);
         //}

       });
    });
    //tagsActifs.sort();
    //let stringTagsActifs = null;
    //tagsActifs.forEach((item) => {
    //  stringTagsActifs += `<li>${tagsActifs[i]}</li>`;
    //});
    //document.getElementById('ulTagActif').innerHTML = stringTagsActifs;

  });
