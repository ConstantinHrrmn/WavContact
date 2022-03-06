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

        /// <summary>
        /// Le fait de ce connecter avec le mauvais mot de passe ou email retourne "NULL"
        /// </summary>
        [TestMethod]
        public void LoginUserIncorrectReturnNull()
        {
            string email = "constantin@waview.ch";
            string password = "thisisawrongpassword";
            User u = WavContactPDO.Login(email, password);

            Assert.IsNull(u);
        }
        #endregion

        [TestMethod]
        public void GetAllClients()
        {
            List<User> clients = WavContactPDO.Clients();

            Assert.IsNotNull(clients);
        }
    }
}