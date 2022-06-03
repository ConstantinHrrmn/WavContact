// Cette fonction permet de gérer l'affichage du formulaire pour son ouverture et sa fermeture
// Il contient également notre id du lieu qui provient de map.js (voir ligne...)
var opacity = localStorage.getItem("opacity");

// Ouverture du formulaire
function ouvertureFrmAddPlaceInProject(id) {
  // Permet de récupérer l'id du lieu pour la requête que nous ferons dans frmAddPlaceInProject.php
  // Il ne sera pas visible dans notre formulaire -> type="hidden"
  inputId = `<input name="idLieu" id="idLieu" type="hidden" value='${id}'>`;
  document.getElementById("divInputHiddenIdProjet").innerHTML = inputId;

  // Condition pour savoir si d'autres formulaires sont ouverts. Si tel est le cas, on les ferme
  if(document.getElementById("divFormAddTagCollab").style.display == "block"){
    fermetureAddTagForm();
  }
  else if (document.getElementById("divFormAddPlaceCollab").style.display == "block") {
    fermetureAddPlaceForm();
  }
  else if (document.getElementById("divFormAddCategorieCollab").style.display == "block") {
    fermetureAddCategorieForm();
  }
  else if (document.getElementById("divFormsNewLieuClient").style.display == "block") {
    fermetureLocationProposalForm();
  }


  document.getElementById("divFormAddPlaceInProjectCollab").style.display = "block";

  document.getElementById("header").style.opacity = opacity;
  document.getElementById("divNomTagActif").style.opacity = opacity;
  document.getElementById("imgSeparator").style.opacity = opacity;
  document.getElementById("divTagContainer").style.opacity = opacity;
  document.getElementById("map").style.opacity = opacity;
}
// Fermeture du formulaire
function fermetureFrmAddPlaceInProject() {
  document.getElementById("divFormAddPlaceInProjectCollab").style.display = "none";

  document.getElementById("header").style.opacity = "1";
  document.getElementById("divNomTagActif").style.opacity = "1";
  document.getElementById("imgSeparator").style.opacity = "1";
  document.getElementById("divTagContainer").style.opacity = "1";
  document.getElementById("map").style.opacity = "1";
}
