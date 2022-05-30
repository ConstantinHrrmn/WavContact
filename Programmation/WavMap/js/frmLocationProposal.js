// Fonctions pour l'affichage du formulaire de proposition de lieux
var opacity = localStorage.getItem("opacity");
// Ouverture du formulaire
function ouvertrureLocationProposalForm() {
  // Condition pour savoir si un autre formulaire sont ouvert. Si tel est le cas, on le ferme
  if (document.getElementById("divFormAddPlaceInProjectCollab").style.display == "block") {
    fermetureFrmAddPlaceInProject();
  }
  document.getElementById("divFormsNewLieuClient").style.display = "block";

  document.getElementById("header").style.opacity = opacity;
  document.getElementById("divNomTagActif").style.opacity = opacity;
  document.getElementById("imgSeparator").style.opacity = opacity;
  document.getElementById("divTagContainer").style.opacity = opacity;
  document.getElementById("map").style.opacity = opacity;
}
// Fermeture du formulaire
function fermetureLocationProposalForm() {
  document.getElementById("divFormsNewLieuClient").style.display = "none";

  document.getElementById("header").style.opacity = "1";
  document.getElementById("divNomTagActif").style.opacity = "1";
  document.getElementById("imgSeparator").style.opacity = "1";
  document.getElementById("divTagContainer").style.opacity = "1";
  document.getElementById("map").style.opacity = "1";
}
