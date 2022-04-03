using Microsoft.VisualStudio.TestTools.UnitTesting;

using WavContact;
using WavContact.DB;
using WavContact.Controllers;
using WavContact.Models;
using WavContact.Views.Member;
using WavContact.Views.Client;
using System.Collections.Generic;

using WavContact.Metier;

namespace Tests
{
    [TestClass]
    public class WavContactTests
    {
        [TestMethod]
        public void TestLogin()
        {
            LoginController loginController = new LoginController(new FrmLogin());

            Assert.IsNotNull(loginController.PerformLogin("constantin@waview.ch", "motdepasse"));
        }

        [TestMethod]
        public void GenerateCode()
        {
            int len = 10;

            Assert.IsTrue(WavContactPDO.GenerateCode(len).Length == len);
        }
        

        [TestMethod]
        public void SendEmail()
        {
            int len = 10;

            string pass = WavContactPDO.GenerateCode(len);

            Mailing.SendMail("waviewrecovery@gmail.com", pass);

            Assert.IsTrue(true);
        }

        
    }
}
