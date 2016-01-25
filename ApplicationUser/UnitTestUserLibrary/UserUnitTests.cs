namespace DecimusN7.Sandbox.ApplicationUser.Tests
{
    using ApplicationUser;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Reflection;
    using System.Linq;

    [TestClass]
    public class UserUnitTests
    {
        private Assembly applicationUserAssembly = Assembly.Load("DecimusN7.Sandbox.ApplicationUser");

        [TestMethod]
        public void UserPropertiesExist()
        {
            User user = new User();
            user.Id = 1;
            user.LastName = "Simpson";
            user.FirstName = "Homer";

            Assert.AreEqual(1, user.Id);
            Assert.AreEqual("Simpson", user.LastName);
            Assert.AreEqual("Homer", user.FirstName);
        }

        [TestMethod]
        public void ApplicationUserInterfaceExists()
        {
            Assert.IsTrue(applicationUserAssembly.GetTypes().Contains(typeof(IApplicationUser)));
        }
    }
}
