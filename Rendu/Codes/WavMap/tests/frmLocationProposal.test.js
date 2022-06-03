"use strict";

const { test, l, Locator, go, resize, click, type, inputFile, waitForText } = require('testim');

Locator.set(require('./locators/locators.js'));

test("proposition de lieu", async () => {
  await go("https://waview.ch/wavcontact/map/");
  await resize({width: 1024, height: 680});
  await click(l("username"));
  await type(l("username"), 'coralie.chevalley@gmail.com');
  await click(l("password"));
  await type(l("password"), 'cyc3d4');
  await click(l("[type='submit']"));
  await click(l("Proposer_un_nouveau_lieu"));
  await click(l("lieu"));
  await type(l("lieu"), 'TestPropositionLieu');
  await click(l("Ex:_46.2050242"));
  await type(l("Ex:_46.2050242"), '46.2050');
  await click(l("Description"));
  await click(l("Ex:_6.1090692"));
  await type(l("Ex:_6.1090692"), '6.1090');
  await click(l("description"));
  await type(l("description"), 'Ceci est un test de proposition de lieu');
  await click(l("Slectionner_vos_tags"));
  await click(l("Anniversaire"));
  await click(l("check_list[]"));
  await click(l("[id='divFormsNewLieuClient']_[id='B"));
  await click(l("photo"));
  await inputFile(l("photo"), [ '/test-projects-artifacts/U95ndV9AhLsSeVnkbDnC/upload-file/aiSYSUMRlZaM4ZNy_imageTest.png']);
  await click(l("Envoyer"));
  await click(l("Retour_sur_WavMap"));
  await click(l("Testpropositionlieu"));
  await waitForText(l("[id='map']_h1"), 'Testpropositionlieu');
});
