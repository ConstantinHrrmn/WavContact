function search() {
  // Declare variables
  var input, filter, ul, li, a, i, txtValue;
  input = document.getElementById('inputRecherche');
  filter = input.value.toUpperCase();
  ul = document.getElementById("ulLstTagTrouve");
  li = ul.getElementsByTagName('li');

  // Permet l'affichage de la liste des tags recherchés et de cacher les autres listes (favoris et ensemble des tags)
  if (filter == ""){
    ul.style.display = "none";
    if(window.innerWidth > 1100){
      document.getElementById("divTagListe").style.display = "block";
      document.getElementById("divTagFavoris").style.display = "block";
      document.getElementById("divRecherche").style.height = "15%";
      document.getElementById("divListeTagsRecherches").style.height = "auto";
    }
    else if(window.innerWidth < 620){
      document.getElementById("divRecherche").style.height = "auto";
    }
    else{
      document.getElementById("divRecherche").style.height = "75%";
      document.getElementById("divListeTagsRecherches").style.height = "-webkit-fill-available";
    }
  }
  else{
    ul.style.display = "block";
    if(window.innerWidth > 1100){
      document.getElementById("divTagListe").style.display = "none";
      document.getElementById("divTagFavoris").style.display = "none";
      document.getElementById("divRecherche").style.height = "80%";
      document.getElementById("divListeTagsRecherches").style.height = "-webkit-fill-available";
    }
    else if(window.innerWidth < 620){
      document.getElementById("divRecherche").style.height = "auto";
    }
    else{
      document.getElementById("divRecherche").style.height = "75%";
      document.getElementById("divListeTagsRecherches").style.height = "-webkit-fill-available";
    }
  }

  // Tri des tags
  Array.from(ul.getElementsByTagName("LI"))
    .sort((a, b) => a.textContent.localeCompare(b.textContent, undefined))
    .forEach(li => ul.appendChild(li));

  // Boucle tous les éléments de la liste et masque ceux qui ne correspondent pas à la requête de recherche
  for (i = 0; i < li.length; i++) {
    txtValue = li[i].textContent || li[i].innerText;
    if (toNormalForm(txtValue).toUpperCase().indexOf(toNormalForm(filter)) > -1) {
      li[i].style.display = "block";
    } else {
      li[i].style.display = "none";
    }
  }
}

// Fonction de normaliser les accents lors de la recherche -> ne marche pas à savoir pourquoi
function toNormalForm(str) {
    return str.normalize("NFD").replace(/[\u0300-\u036f]/g, '');
}
