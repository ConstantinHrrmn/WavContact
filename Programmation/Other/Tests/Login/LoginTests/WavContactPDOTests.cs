using Microsoft.VisualStudio.TestTools.UnitTesting;
using WavContactLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContactLogin.Tests
{
    [TestClass()]
    public class WavContactPDOTests
    {
        string email = "constantin@waview.ch";
        string password = "motdepasse";

        [TestMethod()]
        public void LoginGood()
        {
            User actual = WavContactPDO.Login(email, password);
            User expected = new User("Constantin", "Herrmann");
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod()]
        public void LoginWrongPassword()
        {
            User actual = WavContactPDO.Login(email, "motdepassefaux");
            Assert.AreEqual(null, actual);
        }

        [TestMethod()]
        public void LoginWrongEmail()
        {
            User actual = WavContactPDO.Login("test@waview.ch", password);
            Assert.AreEqual(null, actual);
        }
    }
}