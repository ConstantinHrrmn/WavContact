"use strict";

const { test, l, Locator, go, resize, click, type, waitForText } = require('testim');

Locator.set(require('./locators/locators.js'));

test("register", async () => {
  await go("https://waview.ch/wavcontact/map/register.php");
  await resize({width: 1024, height: 680});
  await click(l("username"));
  await type(l("username"), 'constantin@waview.ch');
  await click(l("password"));
  await type(l("password"), 'motdepasse');
  await click(l("[type='submit']"));
  await waitForText(l("Bonjour_Constantin"), 'Bonjour Constantin');
});
