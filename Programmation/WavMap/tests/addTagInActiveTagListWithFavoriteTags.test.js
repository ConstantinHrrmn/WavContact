"use strict";

const { test, l, Locator, go, resize, click, type, waitForText } = require('testim');

Locator.set(require('./locators/locators.js'));

test("Ajout de tag depuis liste des favoris", async () => {
  await go("https://waview.ch/wavcontact/map/");
  await resize({width: 1024, height: 680});
  await click(l("username"));
  await type(l("username"), 'constantin@waview.ch');
  await click(l("password"));
  await type(l("password"), 'motdepasse');
  await click(l("[type='submit']"));
  await click(l("Plage"));
  await waitForText(l("[id='divNomTagActif']_[data-nom='Pl"), 'Plage');
  await click(l("Fte"));
  await waitForText(l("[id='divNomTagActif']_[data-nom='Ft"), 'Fête');
  await click(l("Mariage"));
  await waitForText(l("[id='divNomTagActif']_[data-nom='Ma"), 'Mariage');
});
