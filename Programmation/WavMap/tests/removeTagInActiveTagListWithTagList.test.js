"use strict";

const { test, l, Locator, go, resize, click, type, waitForText } = require('testim');

Locator.set(require('./locators/locators.js'));

test("enlever les tags depuis la liste des tags", async () => {
  await go("https://waview.ch/wavcontact/map/");
  await resize({width: 1024, height: 680});
  await click(l("Deconnexion"));
  await click(l("username"));
  await type(l("username"), 'constantin@waview.ch');
  await click(l("password"));
  await type(l("password"), 'motdepasse');
  await click(l("[type='submit']"));
  await click(l("vnement"));
  await click(l("Fte"));
  await click(l("Nature"));
  await click(l("Fleuve"));
  await click(l("Urban"));
  await click(l("Monument"));
  await click(l("[id='divNomTagActif']_[data-nom='Ft"));
  await click(l("[id='divNomTagActif']_[data-nom='Fl"));
  await click(l("[id='divNomTagActif']_[data-nom='Mo"));
  await waitForText(l("[id='divTagUniqueActif']"), '');
});
