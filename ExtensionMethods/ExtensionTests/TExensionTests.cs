﻿using ExtensionMethods;
using ExtensionTests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace ExtensionTests
{
    [TestClass]
    public class TExensionTests
    {
        [TestMethod]
        public void DeepCloneTest()
        {
            var user1 = new User(1, "John");
            var user2 = user1.DeepClone();

            Assert.AreEqual(JsonConvert.SerializeObject(user1), JsonConvert.SerializeObject(user2));
            Assert.IsFalse(ReferenceEquals(user1, user2));
        }
    }
}
