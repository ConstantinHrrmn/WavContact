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
    public class WavContactModelTests
    {
        [TestMethod]
        public void UserEmail()
        {
            User reference = new User(1, "a@b.c", "coco", "bobo", 0, "0798828925");

            User newUser = new User();
            newUser.Email = "a@b.c";

            Assert.IsTrue(reference.Email.Equals(newUser.Email));
        }

        [TestMethod]
        public void UserToString()
        {
            User reference = new User(1, "a@b.c", "coco", "bobo", 0, "0798828925");

            Assert.IsTrue(reference.ToString().Equals("coco bobo"));
        }

        

    }
}
