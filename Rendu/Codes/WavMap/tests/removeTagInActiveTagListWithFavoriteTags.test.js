"use strict";

const { test, l, Locator, go, resize, click, type, waitForText } = require('testim');

Locator.set(require('./locators/locators.js'));

test("enlever les tags de la liste", async () => {
  await go("https://waview.ch/wavcontact/map/");
  await resize({width: 1024, height: 680});
  await click(l("username"));
  await type(l("username"), 'constantin@waview.ch');
  await click(l("password"));
  await type(l("password"), 'motdepasse');
  await click(l("[type='submit']"));
  await click(l("Paradis"));
  await click(l("Mariage"));
  await click(l("Fte"));
  await click(l("[id='divNomTagActif']_[data-nom='Ft"));
  await click(l("Montagne"));
  await click(l("[id='divNomTagActif']_[data-nom='Ma"));
  await click(l("[id='divNomTagActif']_[data-nom='Mo"));
  await click(l("[id='divNomTagActif']_[data-nom='Pa"));
  await waitForText(l("[id='divTagUniqueActif']"), '');
});
