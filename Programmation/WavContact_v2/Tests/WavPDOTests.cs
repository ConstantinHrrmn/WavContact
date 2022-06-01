using Microsoft.VisualStudio.TestTools.UnitTesting;

using WavContact;
using WavContact.DB;
using WavContact.Models;
using WavContact.Views.Member;
using WavContact.Views.Client;
using System.Collections.Generic;
using System.Diagnostics;

namespace Tests
{
    [TestClass]
    public class WavPDOTests
    {

        User clientBaseTest = new User(-1, "unit@test.ch", "Unit", "Test", 2, "0797654321");

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

        [TestMethod]
        public void LoginUserIncorrectPassword()
        {
            string email = "constantin@waview.ch";
            string password = "MauvaisMDP";
            User u = WavContactPDO.Login(email, password);

            Assert.IsNull(u);
        }

        [TestMethod]
        public void GetAllClients()
        {
            List<User> clients = WavContactPDO.Clients();

            Assert.IsNotNull(clients);
        }

        [TestMethod]
        // Find client by email
        public void FindClienbyEmaillFail()
        {
            // Get all clients
            List<User> clients = WavContactPDO.Clients();

            // find client by email
            User client = clients.Find(x => x.Email == "constantin@waview.ch");

            // Return Null because Constantin@waview.ch is not a client.
            Assert.IsNull(client);
        }


        [TestMethod]
        public void UserExists()
        {
            bool yes = WavContactPDO.UserExists("constantin@waview.ch");

            Assert.IsTrue(yes);
        }


        #endregion

        // Get Categories
        [TestMethod]
        public void GetCategories()
        {
            List<CategorieMateriel> categories = WavContactPDO.GetCategories();

            Assert.IsNotNull(categories);
        }

        #region MATERIEL
        // Get All materiel
        [TestMethod]
        public void GetAllMateriel()
        {
            List<Materiel> materiels = WavContactPDO.GetMateriel();

            Assert.IsNotNull(materiels);
        }

        [TestMethod]
        public void FindAMaterialInList()
        {
            List<Materiel> materiels = WavContactPDO.GetMateriel();

            Materiel m = materiels.Find(x => x.Nom.Contains("Tesla"));

            Assert.IsNotNull(m);
        }

        [TestMethod]
        // Update Material
        public void UpdateMaterial()
        {
            List<Materiel> materiels = WavContactPDO.GetMateriel();

            Materiel m = materiels.Find(x => x.Nom.Contains("Tesla"));

            m.Nom = "Tesla Model S";

            WavContactPDO.UpdateMaterial(m);

            Materiel mUpdated = WavContactPDO.GetMateriel().Find(x => x.Nom.Contains("Tesla Model S"));

            Assert.IsNotNull(mUpdated);
        }

        [TestMethod]
        // Create a material
        public void CreateMaterial()
        {
            Materiel m = new Materiel(-1, 11, "AutoTest", "This is a test", 1234.56, 1);

            WavContactPDO.CreateMaterial(m);

            // break the test for 1 seconde
            System.Threading.Thread.Sleep(1000);

            List<Materiel> materiels = WavContactPDO.GetMateriel();

            // find a material in list with a specific name 
            Materiel material = materiels.Find(x => x.Nom == "AutoTest");

            Assert.IsNotNull(material);
        }

        [TestMethod]
        // Delete a meterial 
        public void DeleteMaterial()
        {
            List<Materiel> materiels = WavContactPDO.GetMateriel();

            // find a material in list with a specific name 
            Materiel material = materiels.Find(x => x.Nom == "AutoTest");

            WavContactPDO.DeleteMaterial(material);

            // break the test for 1 seconde
            System.Threading.Thread.Sleep(1000);

            materiels = WavContactPDO.GetMateriel();

            // find a material in list with a specific name 
            material = materiels.Find(x => x.Nom == "AutoTest");

            Assert.IsNull(material);
        }

        #endregion
    }
}