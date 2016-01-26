namespace DecimusN7.Sandbox.ApplicationUser.Tests
{
    using System.Linq;
    using System.Reflection;
    using ApplicationUser;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UserUnitTests
    {
        private Assembly applicationUserAssembly = Assembly.Load("DecimusN7.Sandbox.ApplicationUser");

        private PropertyInfo[] Properties
        {
            get
            {
                return this.applicationUserAssembly.GetTypes()
                    .Where(x => x.Name == "IApplicationUser")
                    .SingleOrDefault().GetProperties();
            }
        }

        [TestMethod]
        public void ApplicationUserInterfaceExists()
        {
            Assert.IsTrue(this.applicationUserAssembly.GetTypes()
                .Any(x => x.FullName == "DecimusN7.Sandbox.ApplicationUser.IApplicationUser"));
        }

        [TestMethod]
        public void ApplicationUserInterfacePropertiesExist()
        {
            Assert.IsTrue(this.Properties
                .Any(x => x.Name == "Id"));

            Assert.IsTrue(this.Properties
                .Any(x => x.Name == "FirstName"));

            Assert.IsTrue(this.Properties
                .Any(x => x.Name == "LastName"));
        }

        [TestMethod]
        public void ApplicationUserInterfacePropertiesHaveCorrectType()
        {
            Assert.IsTrue(this.Properties
                .Where(x => x.Name == "Id")
                .Single().PropertyType == typeof(int));

            Assert.IsTrue(this.Properties
                .Where(x => x.Name == "FirstName")
                .Single().PropertyType == typeof(string));

            Assert.IsTrue(this.Properties
                .Where(x => x.Name == "LastName")
                .Single().PropertyType == typeof(string));
        }

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
    }
}
