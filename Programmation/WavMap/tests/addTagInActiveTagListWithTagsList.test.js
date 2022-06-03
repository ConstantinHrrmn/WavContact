"use strict";

const { test, l, Locator, go, resize, click, type } = require('testim');

Locator.set(require('./locators/locators.js'));

test("ajout de tag depuis la liste des tags", async () => {
  await go("https://waview.ch/wavcontact/map/");
  await resize({width: 1280, height: 601});
  await click(l("username"));
  await type(l("username"), 'constantin@waview.ch');
  await click(l("password"));
  await type(l("password"), 'motdepasse');
  await click(l("[type='submit']"));
  await click(l("vnement"));
  await click(l("Fte"));
  await click(l("Mariage"));
  await click(l("Paradis"));
  await click(l("[id='divNomTagActif']_[data-nom='Ma"));
  await click(l("Mariage"));
  await click(l("[id='divNomTagActif']_[data-nom='Ma"));
});
