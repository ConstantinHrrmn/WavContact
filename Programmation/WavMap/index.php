<?php
// Permet d'appeler session.php qui gérera la session de l'utilisateur
include_once "session.php";
?>

<!DOCTYPE html>
<html lang="fr" dir="ltr"> <!-- ltr pour lecture de gauche à droite (left to right)-->
  <head>
    <!-- Lien sur la stylisation du code en langage CSS -->
    <link rel="stylesheet" href="css/index.css" />
    <!-- Responsive html-->
    <meta charset="utf-8" name="viewport" content="width=device-width, initial-scale=1.0">

    <title>WavMaps</title>

    <!-- Appel du fichier jquery.js qui contient la librairie JQuery pour l'utilisation d'AJAX -->
    <script src="JQuery/jquery.js"></script>

    <!-- Appel des fichiers .js qui retourne le résultat du PDO voulu en utilisant AJAX -->
    <!-- Les noms des PDO portent les mêmes noms que les fichiers .js, mais avec l'extension .php -->
    <script src="js/allCategoriesWithTags.js"></script>
    <script src="js/allPlacesWithTags.js"></script>
    <script src="js/allTags.js"></script>
    <script src="js/allProject.js"></script>
    <script src="js/allProject.js"></script>
    <script src="js/allShootsByProject.js"></script>

    <script src="js/testAjax.js"></script>

    <!-- Appel des affichages des formulaires -->
    <script src="js/frmLocationProposal.js"></script>
    <script src="js/frmAddPlace.js"></script>
    <script src="js/frmAddTag.js"></script>
    <script src="js/frmAddCategorie.js"></script>
    <script src="js/frmAddPlaceInProject.js"></script>

    <!-- Décision pour savoir à combien on floute le fond lors de l'ouverture des formulaires -->
    <script type="text/javascript">
      var opacity = "0.1";
      localStorage.setItem("opacity", opacity);
    </script>

    <!-- Appel du fichier showCheckBox.js qui sert à l'affichage des CheckBox -->
    <script src="js/showCheckBox.js"></script>

    <!-- Notre map -->
    <script src="js/map.js"></script>

    <!-- Barre de recherche -->
    <script src="js/searchBar.js"></script>


    <!-- Appel des tests -->
    <!-- <script src="js/map.test.js"></script> -->
  </head>


  <body id="body">
    <!-- Partie du haut avec image de fond + logo Waview + Nom de l'application : WAVMAP + bouton Déconnexion -->
    <header id="header">
      <div id="divLogo">
        <img src="image/wav2.png" id="imgLogo" alt="">
      </div>

      <div id="divTitreHeader">
        <p id="pTitleHeader">WAVMAP</p>
      </div>

      <div id="btnLogout">
        <a id="aLogout" onclick="window.location.href='https://waview.ch/wavcontact/map/logout.php'">Deconnexion</a>
      </div>
    </header>

    <!-- Partie du haut avec message de bienvenue : "Bonjour UTILISATEUR" + boutons formulaires + Liste des tags actuellement actifs -->
    <div id="divNomTagActif">
      <!-- Message de bienvenue + boutons formulaires -->
      <div id="divNom">
        <h2 id="txtBonjour">Bonjour <?php echo $_SESSION['user']['first_name'] ?></h2>
        <?php
          // Condition servant à afficher les boutons des formulaires adéquats selon si l'utilisateur est un collaborateur ou non
          if($_SESSION['user']['roleName'] == "Collaborateur"){
            echo '
            <button type="button" id="btnAjouterCategorie" onclick="ouvertureFrmAddCategorie()">Ajouter une catégorie</button>
            <button type="button" id="btnAjouterTag" onclick="ouvertureAddTagForm()">Ajouter un tag</button>
            <button type="button" id="btnAjouterLieu" onclick="ouvertureAddPlaceForm()">Ajouter un lieu</button>
            ';
          }
          else{
            echo '<button type="button" onclick="ouvertrureLocationProposalForm()">Proposer un nouveau lieu</button>';
          }
         ?>
      </div>
       <!-- Liste des tags actuellement actifs -->
      <div id="divTagActif">
        <div id="divTitleTagActif">
          <p id="txtTitleTagActif">Tags actuellement actifs</p>
        </div>
        <div id="divTagUniqueActif">
          <ul id="ulTagActif"></ul>
        </div>
      </div>
    </div>

    <img id="imgSeparator" src="image/barreSeparator2.png" alt="" />

    <!-- Barre de recherche -->
    <div id="divTagContainer">
      <div id="divRecherche">
        <p id="txtTitleTagRecherche">Recherche de tag</p>
          <input id="inputRecherche" type="text" name="inputRecherche" placeholder="ex : Paradis" onkeyup="search()"/>
        <div id="divListeTagsRecherches" style="display : block;">
          <ul id="ulLstTagTrouve" style="display : none;"></ul>
        </div>
      </div>

      <!-- Tag favoris -->
      <div id="divTagFavoris" style="display : block;">
        <p id="txtTitleTagFavoris"> Tag favoris </p>
        <ul id="ulTagFavoris">
          <li id="Plage" class="liTagFavoris" data-nom='Plage' style="list-style: none;">Plage</li>
          <li class="liTagFavoris" data-nom='Montagne' style="list-style: none;">Montagne</li>
          <li class="liTagFavoris" data-nom='Lac' style="list-style: none;">Lac</li>
          <li class="liTagFavoris" data-nom='Forêt' style="list-style: none;">Forêt</li>
          <li class="liTagFavoris" data-nom='Champ' style="list-style: none;" >Champ</li>
          <li class="liTagFavoris" data-nom='Ecole' style="list-style: none;" >Ecole</li>
          <li class="liTagFavoris" data-nom='Monument' style="list-style: none;">Monument</li>
          <li class="liTagFavoris" data-nom='Piscine' style="list-style: none;">Piscine</li>
          <li class="liTagFavoris" data-nom='Maison' style="list-style: none;">Maison</li>
          <li class="liTagFavoris" data-nom='Villa' style="list-style: none;">Villa</li>
        </ul>
      </div>

      <!-- Liste des tags -->
      <div id="divTagListe" style="display : block;">
        <p id="txtTitleTagListe"> Liste des tags </p>
        <div id="divScroll"></div>
      </div>
    </div>

    <!-- La carte avec API Google Maps -->
    <div id="map">
      <!-- adresse API + clé + region : CH + langue : français + callback : initMap + libraries-->
      <script
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCREy29Y020Q0EBK69pN4bb32jc72BmpFY&region=CH&language=fr&callback=initMap"
        async
      ></script>
    </div>

    <!-- Formulaire Proposition nouveau lieu / Client -->
    <div id="divFormsNewLieuClient" class="formCSS" style="display: none;">
      <form action="php/proposePlace.php" class="" method="post" enctype="multipart/form-data">
        <h1 class="formTitre">Proposition nouveau lieu</h1>
        <div id="divGeneralFormLieuClient">
          <div id="divNomLieuFormClient">
            <label id="lblNomLieuClient" class="formLabel" for="nomLieuLabel"><b>Nom du lieu</b></label>
            <input type="text" id="inputNomLieuClient" name="lieu" required>
          </div>

          <div id="divLatitudeLieuFormClient">
            <label id="lblLatitudeLieuFormClient" class="formLabel" for="latitudeLabel"><b>Latitude</b></label>
            <input type="number" placeholder="Ex: 46.2050242" id="inputLatitudeLieuFormClient" step="0.000001" name="latitude" required>
          </div>

          <div id="divLongituteLieuFormClient">
            <label id="lblLongitudeLieuFormClient" class="formLabel" for="longitudeLabel"><b>Longitude</b></label>
            <input type="number" placeholder="Ex: 6.1090692" id="inputLongitudeLieuFormClient" step="0.000001" name="logitude" required>
          </div>

          <div id="divDescriptionLieuFormClient">
            <label id="lblDescriptionLieuFormClient" class="formLabel" for="descriptionLabel"><b>Description</b></label>
            <textarea type="text" id="txtareaDescriptionLieuFormClient" rows="4" name="description" required></textarea>
          </div>

          <div id="divTagCorrespLieuFormClient">
            <label id="lblTagCorrespLieuFormClient" class="formLabel" for="tagCorrsepondantLabel"><b>Sélectionner tag correspondant</b></label>
            <button id="btnBoxMultiSelectTagAddPlaceFormClient" type="button" onclick="showCheckboxesClient()">Sélectionner vos tags</button>
            <div id="divCheckboxesTagAddPlaceFormClient" style="display: none"></div>
          </div>

          <div id="divImgAddPlaceForm">
            <label id="lblImgAddPlaceForm" class="formLabel" for="lblImgAddPlaceForm"><b>Ajouter une image</b></label>
            <input type="file" class="form-control-file" id="inputImgAddPlaceForm" name="photo" accept="image/jpeg, image/x-png">
          </div>

          <input type="hidden" name="actif" value="3">

          <div id="divBtn">
            <button id="btnAjouter" type="submit" class="btn">Envoyer</button>
            <button id="btnFermer" type="button" class="btn cancel" onclick="fermetureLocationProposalForm()">Annuler</button>
          </div>
        </div>
      </form>
    </div>

    <!-- Formulaire d'ajout d'une catégorie / Collaborateur -->
    <div id="divFormAddCategorieCollab" class="formCSS" style="display: none;">
      <form class="" method="post" action="php/frmAddCategorie.php">
        <h1 class="formTitre">Ajout d'une catégorie</h1>
        <div id="divGeneralFormAddCategorieCollab">
          <div id="divNomFormAddCategorieCollab">
            <label id="lblNomFormAddCategorieCollab" class="formLabel" for="lblNomCategorie"><b>Nom de la catégorie </b></label>
            <input type="text" id="inputNomFormAddCategorieCollab" name="inputNomFormAddCategorieCollab" required>
          </div>

          <div id="divBtn">
            <button id="btnAjouter" type="submit" class="btn">Ajouter</button>
            <button id="btnFermer" type="button" class="btn cancel" onclick="fermetureFrmAddCategorie()">Annuler</button>
          </div>
        </div>
      </form>
    </div>


    <!-- Formulaire d'ajout d'un tag / Collaborateur -->
    <div id="divFormAddTagCollab" class="formCSS" style="display: none;">
      <form class="" method="post" action="php/frmAddTag.php">
        <h1 class="formTitre">Ajout de tag</h1>
        <div id="divGeneralAddTagFormCollab">
          <div id="divSelectCatAddTagFormCollab">
            <label id="lblSelectCatAddTagFormCollab" class="formLabel" for="lblSelectCatAddTagFormCollab"><b>Sélectionner la catégorie </b></label>
            <select id="selectCatAddTagFormCollab" name="selectCatAddTagFormCollab"></select>
          </div>

          <div id="divNomAddTagFormCollab">
            <label id="lblNomAddTagFormCollab" class="formLabel" for="lblNomAddTagFormCollab"><b>Nom tag </b></label>
            <input type="text" id="inputNomAddTagFormCollab" name="inputNomAddTagFormCollab" required>
          </div>

          <div id="divBtn">
            <button id="btnAjouter" type="submit" class="btn">Ajouter</button>
            <button id="btnFermer" type="button" class="btn cancel" onclick="fermetureAddTagForm()">Annuler</button>
          </div>
        </div>
      </form>
    </div>

    <!-- Formulaire d'ajout d'un lieu / Collaborateur -->
    <div id="divFormAddPlaceCollab" class="formCSS" style="display: none;">
      <form class="" action="php/frmAddPlace.php" method="post" enctype="multipart/form-data">
        <h1 class="formTitre">Ajout de lieu</h1>
        <div id="divGeneralAddPlaceForm">
          <div id="divNomAddPlaceForm">
            <label id="lblNomAddPlaceForm" class="formLabel" for="lblNomAddPlaceForm"><b>Nom du lieu</b></label>
            <input type="text" id="inputNomAddPlaceForm" name="inputNomAddPlaceForm" required>
          </div>

          <div id="divDescriptionAddPlaceForm">
            <label id="lblDescriptionAddPlaceForm" class="formLabel" for="lblDescriptionAddPlaceForm"><b>Description du lieu </b></label>
            <textarea type="text" id="inputDescriptionAddPlaceForm" name="inputDescriptionAddPlaceForm" rows="4" required></textarea>
          </div>

          <div id="divLatitudeAddPlaceForm">
            <label id="lblLatitudeAddPlaceForm" class="formLabel" for="lblLatitudeAddPlaceForm"><b>Latitude</b></label>
            <input type="number" placeholder="Ex: 46.2050242" id="inputLatitudeAddPlaceForm" name="inputLatitudeAddPlaceForm" step="0.0000001" required>
          </div>

          <div id="divLongitudeAddPlaceForm">
            <label id="lblLongitudeAddPlaceForm" class="formLabel" for="lblLongitudeAddPlaceForm"><b>Longitude</b></label>
            <input type="number" placeholder="Ex: 6.1090692" id="inputLongitudeAddPlaceForm" name="inputLongitudeAddPlaceForm" step="0.0000001" required>
          </div>

          <div id="divMultiSelectTagAddPlaceForm">
            <label id="lblMultiSelectTagAddPlaceForm" class="formLabel" for="lblMultiSelectTagAddPlaceForm"><b>Tags</b></label>
            <button id="btnBoxMultiSelectTagAddPlaceForm" type="button" onclick="showCheckboxesCollab()">Sélectionner vos tags</button>
            <div id="divCheckboxesTagAddPlaceForm"></div>
          </div>

          <div id="divImgAddPlaceForm">
            <label id="lblImgAddPlaceForm" class="formLabel" for="lblImgAddPlaceForm"><b>Ajouter une image</b></label>
            <input type="file" class="form-control-file" id="inputImgAddPlaceForm" name="photo" accept="image/jpeg, image/x-png">
          </div>

          <input type="hidden" name="actif" value="2">

          <div id="divBtn">
            <button id="btnAjouter" type="submit" class="btn">Ajouter</button>
            <button id="btnFermer" type="button" class="btn cancel" onclick="fermetureAddPlaceForm()">Annuler</button>
          </div>
        </div>
      </form>
    </div>

    <!-- Formulaire d'ajout d'un lieu dans un projet avec les dates et heures du tournage -->
    <div id="divFormAddPlaceInProjectCollab" class="formCSS" style="display: none;">
      <form class="" method="post" action="php/frmAddPlaceInProject.php">
        <div id="divTitre">
          <h1 name="titleProject" id="titleProject" class="formTitre">Ajouter un lieu au projet</h1>
        </div>
        <div id="divInputHiddenIdProjet"></div>

        <div id="divGeneralFormAddPlaceInProject">
          <div id="selectProjet" class="formSelectProject">
            <select name="cboProjet" id="cboProjet">
              <option value="">Sélectionner un projet</option>
            </select>
          </div>

          <div id="selectTournage" class="formSelectTournage"></div>

          <div id="divBtn">
            <button id="btnAjouter" type="submit" class="btn">Ajouter</button>
            <button id="btnFermer" type="button" class="btn cancel" onclick="fermetureFrmAddPlaceInProject()">Annuler</button>
          </div>
        </div>
      </form>
    </div>

  </body>
</html>
