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
        //Create a client in the database
        public void CreateUpdateDeleteClient()
        {
            WavContactPDO.CreateClient(clientBaseTest);
            
            List<User> clients = WavContactPDO.Clients();

            // find client by email
            User client = clients.Find(x => x.Email == clientBaseTest.Email);

            Assert.IsNotNull(client);

            client.First_name = "UNIT";
            client.Last_name = "Update";
            client.IdRole = 3;

            WavContactPDO.UpdateUser(client);

            User clientUpdated = WavContactPDO.Login(client.Email, "Bonjour");

            Assert.IsTrue(clientUpdated.First_name == "UNIT" && clientUpdated.Last_name == "Update");

            WavContactPDO.DeleteUser(clientUpdated);

            User clientDeleted = WavContactPDO.Login(client.Email, "Bonjour");

            Assert.IsNull(clientDeleted);
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
        // Find client by email
        public void FindClienbyEmaill()
        {
            // Get all clients
            List<User> clients = WavContactPDO.Clients();

            // find client by email
            User client = clients.Find(x => x.Email == "aurelie@hes.ch");

            Assert.IsNotNull(client);
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

        #endregion

        // Get Categories
        [TestMethod]
        public void GetCategories()
        {
            List<CategorieMateriel> categories = WavContactPDO.GetCategories();

            Assert.IsNotNull(categories);
        }

        // Create project for user
        [TestMethod]
        public void CreateProject()
        {
            string searchName = "TestProject";

            Project p = new Project();
            p.Name = searchName;
            p.Description = "Test";
            p.Valider = 1;

            User u = WavContactPDO.GetUserByEmail("aurelie@hes.ch");

            WavContactPDO.CreateProject(p, u);

            // break the test for 1 seconde
            System.Threading.Thread.Sleep(1000);
            
            List<Project> projects = WavContactPDO.ProjectsForUser(u);

            // find a project in list with a specific name 
            Project project = projects.Find(x => x.Name == searchName);

            Assert.IsNotNull(project);
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