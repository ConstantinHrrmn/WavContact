"use strict";

const { test, l, Locator, go, resize, click, type, sendCharacter, waitForText } = require('testim');

Locator.set(require('./locators/locators.js'));

test("ajouter une catégorie", async () => {
  await go("https://waview.ch/wavcontact/map/");
  await resize({width: 1280, height: 601});
  await click(l("username"));
  await type(l("username"), 'constantin@waview.ch');
  await sendCharacter(l("username"), '\t');
  await type(l("password"), 'motdepasse');
  await click(l("[type='submit']"));
  await click(l("Ajouter_une_catgorie"));
  await click(l("inputNomFormAddCategorieCollab"));
  await type(l("inputNomFormAddCategorieCollab"), 'testCat');
  await click(l("Ajouter"));
  await waitForText(l("Testcat"), 'Testcat');
});
