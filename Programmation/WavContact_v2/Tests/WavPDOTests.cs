using Microsoft.VisualStudio.TestTools.UnitTesting;

using WavContact;
using WavContact.DB;
using WavContact.Models;
using WavContact.Views.Member;
using WavContact.Views.Client;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class WavPDOTests
    {

        #region USER
        /// <summary>
        /// Ce connecter avec le bon email et mot de passe permet de récupérer l'utilisateur connecté
        /// </summary>
        [TestMethod]
        public void LoginUserCorrect()
        {
            string email = "constantin@waview.ch";
            string password = "motdepasse";
            User u = WavContactPDO.Login(email, password);

            Assert.IsNotNull(u);
        }

        #endregion

        [TestMethod]
        public void GetAllClients()
        {
            List<User> clients = WavContactPDO.Clients();

            Assert.IsNotNull(clients);
        }

        [TestMethod]
        public void UserExists()
        {
            bool yes = WavContactPDO.UserExists("constantin@waview.ch");

            Assert.IsTrue(yes);
        }

        [TestMethod]
        public void ResetUserPassword()
        {
            bool yes = WavContactPDO.ResetUserPassword("luna@waview.ch", "yesyes");

            Assert.IsTrue(yes);
        }
    } 
}