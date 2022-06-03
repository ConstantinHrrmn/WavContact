// Fonctions pour l'affichage du formulaire d'ajout de tag
var opacity = localStorage.getItem("opacity");
// Ouverture du formulaire
function ouvertureAddTagForm() {
  // Condition pour savoir si d'autres formulaires sont ouverts. Si tel est le cas, on les ferme
  if(document.getElementById("divFormAddPlaceCollab").style.display == "block"){
    fermetureAddPlaceForm();
  }
  else if (document.getElementById("divFormAddCategorieCollab").style.display == "block"){
    fermetureFrmAddCategorie();
  }
  else if (document.getElementById("divFormAddPlaceInProjectCollab").style.display == "block") {
    fermetureFrmAddPlaceInProject();
  }
  document.getElementById("divFormAddTagCollab").style.display = "block";

  document.getElementById("header").style.opacity = opacity;
  document.getElementById("divNomTagActif").style.opacity = opacity;
  document.getElementById("imgSeparator").style.opacity = opacity;
  document.getElementById("divTagContainer").style.opacity = opacity;
  document.getElementById("map").style.opacity = opacity;
}

// Fermeture du formulaire
function fermetureAddTagForm() {
  document.getElementById("divFormAddTagCollab").style.display = "none";

  document.getElementById("header").style.opacity = "1";
  document.getElementById("divNomTagActif").style.opacity = "1";
  document.getElementById("imgSeparator").style.opacity = "1";
  document.getElementById("divTagContainer").style.opacity = "1";
  document.getElementById("map").style.opacity = "1";
}
