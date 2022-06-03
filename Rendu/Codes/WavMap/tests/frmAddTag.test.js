"use strict";

const { test, l, Locator, go, resize, click, type, selectOption, waitForText } = require('testim');

Locator.set(require('./locators/locators.js'));

test("Ajouter un tag", async () => {
  await go("https://waview.ch/wavcontact/map/");
  await resize({width: 1280, height: 556});
  await click(l("username"));
  await type(l("username"), 'constantin@waview.ch');
  await click(l("password"));
  await type(l("password"), 'motdepasse');
  await click(l("[type='submit']"));
  await click(l("Ajouter_un_tag"));
  await click(l("selectCatAddTagFormCollab"));
  await selectOption(l("[id='Testcat']"));
  await click(l("selectCatAddTagFormCollab"), {button: undefined});
  await click(l("inputNomAddTagFormCollab"));
  await type(l("inputNomAddTagFormCollab"), 'testTag');
  await click(l("Ajouter"));
  await click(l("Testcat"));
  await waitForText(l("Testtag"), 'Testtag');
});
