<?php
include_once "session.php";
?>

<!DOCTYPE html>
<html lang="fr" dir="ltr"> <!-- ltr pour lecture de gauche à droite (left to right)-->
  <head>
    <!-- Responsive html-->
    <link rel="stylesheet" href="css/index.css" />
    <meta charset="utf-8" name="viewport" content="width=device-width, initial-scale=1.0">
    <title>WavMaps</title>
    <script src="js/allPlaces.js"></script>
    <script src="js/allTags.js"></script>
    <script src="js/placesWithTags.js"></script>
    <script src="js/allCategoriesWithTags.js"></script>
    <script src="js/map.js"></script>
    <script src="js/locationProposalForm.js"></script>
    <script src="js/researchTag.js"></script>
  </head>
  <body id="body">
    <header>
      <div id="logo">
        <!-- logo waview a demander en PNG -->
        <img src="image/wav2.png" id="imgLogo" alt="">
      </div>

      <div id="titre">
        <p id="pTitle">WAVMAP</p>
      </div>

      <div id="buttonLogout">
        <a id="btnLogout" onclick="window.location.href='https://waview.ch/wavcontact/map/logout.php'">Deconnexion</a>
      </div>
    </header>

    <div id="containerNomTagActif">
      <div id="divNom">
        <h2 id="textBonjour">Bonjour <?php echo $_SESSION['user']['first_name'] ?> (<?php echo $_SESSION['user']['roleName'] ?>)</h2>
        <button type="button" onclick="ouvertureForms()">Proposer un nouveau lieu</button>
      </div>

      <div id="divTagActif">
        <div id="divTitleTagActif">
          <p id="titleTagActif">Tag actuellement actif :
        </div>
        <div id="tagUniqueActif">
          <ul id="ulTagActif">

            <!-- <li>montagne</li>
            <li>montagne</li>
            <li>montagne</li>
            <li>montagne</li>
            <li>montagne</li>
            <li>montagne</li>
            <li>montagne</li>
            <li>montagne</li>
            <li>montagne</li>
            <li>montagne</li>
            <li>montagne</li> -->
          </ul>
        </div>
      </div>
    </div>

    <img id="barreSep" src="image/barreSeparator2.png" alt="" />

    <div id="divTagContainer">
      <div id="divRecherche">
        <p id="titleTagRecherche"> Rechercher tag </p>
        <input id="inputRecherche" type="text" name="inputRecherche" placeholder="ex : montagne" />
        <!-- TODO : savoir  si on fait a chaque lettre ecrite on fait apparaitre les tags, ou seulement quand c'est valider -->
        <button id="buttonRecherche"> Rechercher </button>
        <div id="divListeTagsRecherches"></div>
      </div>

      <div id="divTagFavoris">
        <p id="titleTagFavoris"> Tag favoris </p>
        <ul id="ulTagFavoris">
          <li>Plage</li>
          <li>Montagne</li>
          <li>Lac</li>
          <li>Tag 4</li>
          <li>Tag 5</li>
          <li>Tag 6</li>
          <li>Tag 7</li>
          <li>Tag 8</li>
          <li>Tag 9</li>
          <li>Tag 10</li>
        </ul>
      </div>

      <div id="divTagListe">
        <p id="titleTagListe"> Tag liste </p>
        <div id="divScroll">

          <!-- <script type="text/javascript">
            ulNature.addListener("click", function(e){
              document.getElementById("ulTagActif").innerHTML = `<li>${e}</li>`;
            });
          </script> -->
        </div>
      </div>
    </div>


    <div id="map">
      <!-- adresse API + clé + region : CH + langue : français + callback : initMap + libraries-->
      <script
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCREy29Y020Q0EBK69pN4bb32jc72BmpFY&region=CH&language=fr&callback=initMap"
        async
      ></script>
    </div>


    <div id="formsNew" style="display: none;">
      <form action="" class="">
        <h1>Proposition nouveau lieu</h1>
        <div id="divGeneralForm">

          <div id="divNomLieuForm">
            <label id="nomLieuLabel" for="nomLieuLabel"><b>Nom du lieu</b></label>
            <input type="text" id="nomLieu" required>
          </div>

          <div id="divLongituteLieuForm">
            <label id="longitudeLabel" for="longitudeLabel"><b>Longitude</b></label>
            <input type="number" placeholder="Ex: 6.1431577" id="longitude" step="0.000001" required>
          </div>

          <div id="divLatitudeLieuForm">
            <label id="latitudeLabel" for="latitudeLabel"><b>Latitude</b></label>
            <input type="number" placeholder="Ex: 46.2043907" id="latitude" step="0.000001" required>
          </div>

          <div id="divDescriptionLieuForm">
            <label id="descriptionLabel" for="descriptionLabel"><b>Description</b></label>
            <textarea type="text" id="description" rows="4" required>
            </textarea>
          </div>

          <div id="divTagCorrespLieuForm">
            <label id="tagCorrsepondantLabel" for="tagCorrsepondantLabel"><b>Séléctionner tag correspondant :</b></label>
            <select id="cboTag">
            </select>
            <button id="btnValiderTagForm" type="button">Valider tag</button>
            <textarea type="text" id="tagCorrsepondant" rows="8"
            placeholder="Sélectionner les tags qui correspond à votre lieu! Si vous voulez crée un nouveau tag écriver le directement séparer par des virgules (ex : Nature, Ocean, ...)" required></textarea>
          </div>

          <div id="divBtnLieuForm">
            <button id="btnEnvoyer" type="submit" class="btn">Envoyer</button>
            <button id="btnClose" type="button" class="btn cancel" onclick="fermetureForms()">Annuler</button>
          </div>

        </div>

      </form>
    </div>
  </body>
</html>
