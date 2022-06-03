"use strict";

const { test, l, Locator, go, resize, click, type, sendCharacter, inputFile } = require('testim');

Locator.set(require('./locators/locators.js'));

test("ajouter un lieu", async () => {
  await go("https://waview.ch/wavcontact/map/");
  await resize({width: 1280, height: 601});
  await click(l("username"));
  await type(l("username"), 'constantin@waview.ch');
  await sendCharacter(l("username"), '\t');
  await type(l("password"), 'motdepasse');
  await click(l("[type='submit']"));
  await click(l("Ajouter_un_lieu"));
  await click(l("Description_du_lieu"));
  await click(l("inputNomAddPlaceForm"));
  await type(l("inputNomAddPlaceForm"), 'lieuTest');
  await click(l("inputDescriptionAddPlaceForm"));
  await type(l("inputDescriptionAddPlaceForm"), 'Ceci est un test de lieu');
  await click(l("Ex:_46.2050242"));
  await type(l("Ex:_46.2050242"), '46.2050');
  await click(l("Ex:_6.1090692"));
  await type(l("Ex:_6.1090692"), '6.1090');
  await click(l("Slectionner_vos_tags"));
  await click(l("check_list[]"));
  await click(l("photo"));
  await inputFile(l("photo"), [ '/test-projects-artifacts/U95ndV9AhLsSeVnkbDnC/upload-file/oM0ezGi198K2jRKG_imageTest.png']);
  await click(l("Ajouter"));
});
