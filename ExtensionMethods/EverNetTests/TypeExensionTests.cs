using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EverNetExtensionTests
{
    [TestClass]
    public class TypeExensionTests
    {
        [TestMethod]
        public void DeepCloneTest()
        {
            var user1 = new User(1, "John", new Role(1, "RoleTest", new RoleArea(1, RoleAreaType.Portal)));
            var user2 = user1.DeepClone();

            Assert.AreEqual(JsonConvert.SerializeObject(user1), JsonConvert.SerializeObject(user2));
            Assert.IsFalse(ReferenceEquals(user1, user2));
        }
    }
}
