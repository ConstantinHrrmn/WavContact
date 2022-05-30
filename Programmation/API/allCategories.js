//allCategories.js va prendre l'ensemble des lieux de la BDD à travers allCategories.php et créer des markers
fetch("https://waview.ch/wavcontact/map/php/allCategories.php")  // Lien qui contient les données
  .then(res=>res.json())  // réponse en format json
  .then(res=>{
    optionsCategorie = `<option value=""> Choisir une categorie </option>`;
    for (var i = 0; i < res.length; i++) {
       optionsCategorie += `<option value="${res['CATEGORIE_NOM']}">${res['CATEGORIE_NOM']}</option>`;
    }
    document.getElementById("selectCategorie").innerHTML = optionsCategorie;
  });
