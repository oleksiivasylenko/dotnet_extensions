using System.Collections.Generic;
using ExtensionMethods.Extensions;
using ExtensionTests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionTests
{
    [TestClass]
    public class CollectionExtensionTests
    {
        [TestMethod]
        public void ReplaceTest()
        {
            var userList = new List<User> { new User(1, "John"), new User(2, "Lisa"), new User(3, "Ann") };
            var userArray = new List<User> { new User(1, "John"), new User(2, "Lisa"), new User(3, "Ann") };

            var stringList = new List<string> {"test1", "test2", "test3", "teset4"};
            var stringArray = new [] {"test1", "test2", "test3", "teset4"};

            var newStr = "test1000";
            var newUser = new User(77, "Johnatan");

            userList.Replace(u => u.Id == 2, newUser);
            userArray.Replace(u => u.Id == 2, newUser);
            stringList.Replace("test2", newStr);
            stringArray.Replace("test2", newStr);

            Assert.IsTrue(userList[1].Id == newUser.Id);
            Assert.IsTrue(userArray[1].Id == newUser.Id);
            Assert.IsTrue(stringList[1] == newStr);
            Assert.IsTrue(stringArray[1] == newStr);
        }

        [TestMethod]
        public void DoTest()
        {
            var users = new List<User> { new User(1, "John"), new User(2, "Lisa"), new User(3, "Ann") };

            foreach (var user in users)
                Assert.IsFalse(user.Name.Contains($"{user.Id}"));

            users.Do(u => u.Name += u.Id);

            foreach (var user in users)
                Assert.IsTrue(user.Name.Contains($"{user.Id}"));
        }
    }
}
