"use strict";

const { test, l, Locator, go, resize, click, type, sendCharacter, waitForText } = require('testim');

Locator.set(require('./locators/locators.js'));

test("enlever les tags depuis barre de recherche", async () => {
  await go("https://waview.ch/wavcontact/map/");
  await resize({width: 1024, height: 650});
  await click(l("username"));
  await type(l("username"), 'constantin@waview.ch');
  await click(l("password"));
  await type(l("password"), 'motdepasse');
  await sendCharacter(l("[type='password']"), '\r');
  await click(l("ex_:_Paradis"));
  await type(l("ex_:_Paradis"), 'mon');
  await click(l("Monument"));
  await click(l("Montagne"));
  await click(l("[id='inputRecherche']"));
  await type(l("[id='inputRecherche']"), 'ba');
  await click(l("Btiment"));
  await type(l("\"\"_WAVMAP_Deconnexion_Bonjour_Con"), '');
  await click(l("[id='inputRecherche']"));
  await type(l("[id='inputRecherche']"), 'f');
  await click(l("Fte"));
  await click(l("[id='divNomTagActif']_[data-nom='Ft"));
  await click(l("[id='divNomTagActif']_[data-nom='Mo"));
  await click(l("[id='inputRecherche']"));
  await type(l("[id='inputRecherche']"), 'pla');
  await click(l("Plage"));
  await click(l("[id='divNomTagActif']_[data-nom='Bt"));
  await click(l("[id='divNomTagActif']_[data-nom='Pl"));
  await click(l("[id='divNomTagActif']_[data-nom='Mo"));
  await waitForText(l("[id='divTagUniqueActif']"), '');
});
