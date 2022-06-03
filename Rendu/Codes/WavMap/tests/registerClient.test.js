"use strict";

const { test, l, Locator, go, resize, click, type, sendCharacter, waitForText } = require('testim');

Locator.set(require('./locators/locators.js'));

test("register client", async () => {
  await go("https://waview.ch/wavcontact/map/register.php");
  await resize({width: 1024, height: 680});
  await click(l("username"));
  await type(l("username"), 'coralie.chevalley@gmail.com');
  await sendCharacter(l("username"), '\t');
  await type(l("password"), 'cyc3d4');
  await click(l("[type='submit']"));
  await waitForText(l("Bonjour_Coralie"), 'Bonjour Coralie');
});
