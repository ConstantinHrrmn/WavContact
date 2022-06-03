"use strict";

const { test, l, Locator, go, resize, click, type, waitForText } = require('testim');

Locator.set(require('./locators/locators.js'));

test("ajout de tag depuis barre de recherche", async () => {
  await go("https://waview.ch/wavcontact/map/");
  await resize({width: 1024, height: 680});
  await click(l("username"));
  await type(l("username"), 'constantin@waview.ch');
  await click(l("password"));
  await type(l("password"), 'motdepasse');
  await click(l("[type='submit']"));
  await click(l("ex_:_Paradis"));
  await type(l("ex_:_Paradis"), 'monta');
  await click(l("Montagne"));
  await waitForText(l("[id='divNomTagActif']_[data-nom='Mo"), 'Montagne');
  await click(l("[id='inputRecherche']"));
  await type(l("[id='inputRecherche']"), 'para');
  await click(l("Paradis"));
  await waitForText(l("[id='divNomTagActif']_[data-nom='Pa"), 'Paradis');
  await click(l("[id='inputRecherche']"));
  await type(l("[id='inputRecherche']"), 'ba');
  await click(l("Btiment"));
  await waitForText(l("[id='divNomTagActif']_[data-nom='Bt"), 'Bâtiment');
});
