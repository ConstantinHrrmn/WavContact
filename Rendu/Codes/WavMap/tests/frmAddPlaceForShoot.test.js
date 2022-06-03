"use strict";

const { test, l, Locator, go, resize, click, type, selectOption } = require('testim');

Locator.set(require('./locators/locators.js'));

test("ajouter un lieu au projet", async () => {
  await go("https://waview.ch/wavcontact/map/");
  await resize({width: 1024, height: 680});
  await click(l("username"));
  await type(l("username"), 'coralie.chevalley@gmail.com');
  await click(l("password"));
  await type(l("password"), 'cyc3d4');
  await click(l("[type='submit']"));
  await click(l("Plage_des_Eaux-Vives"));
  await click(l("Ajouter__votre_projet"));
  await click(l("cboProjet"));
  await selectOption(l("[id='Clip_Karakoe']"));
  await click(l("cboProjet"), {button: undefined});
  await click(l("selectATournage"));
  await selectOption(l("[id='selectATournage']_>_:nth-child"));
  await click(l("selectATournage"), {button: undefined});
  await click(l("Ajouter"));
});
