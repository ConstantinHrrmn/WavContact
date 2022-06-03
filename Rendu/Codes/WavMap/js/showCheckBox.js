// Permet l'affichage des checkboxes dans le formulaire d'ajout de lieu par le collaborateur et de proposition de lieu par le client

var expanded = false;

// Affichage des checkboxes dans le formulaire d'ajout de lieu pour le collaborateur
function showCheckboxesCollab() {
  var checkboxes = document.getElementById("divCheckboxesTagAddPlaceForm");
  if (!expanded) {
    checkboxes.style.display = "block";
    expanded = true;
  } else {
    checkboxes.style.display = "none";
    expanded = false;
  }
}

// Affichage des checkboxes dans le formulaire de proposition de lieu par le client
function showCheckboxesClient() {
  var checkboxes = document.getElementById("divCheckboxesTagAddPlaceFormClient");
  if (!expanded) {
    checkboxes.style.display = "block";
    expanded = true;
  } else {
    checkboxes.style.display = "none";
    expanded = false;
  }
}
