using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeQuality.BusinessObjects.Tests
{
    [TestClass]
    public class ObjectTests
    {
        [TestMethod]
        public void CreateObject()
        {
            // arrange
            var mgr = ObjectFactory.GetObject("mgr", "Bill", "Lumberg");
            var usCustomer = ObjectFactory.GetObject("1_USD", "Bill", "Lumberg");
            var ukCustomer = ObjectFactory.GetObject("1_GBP", "Bill", "Lumberg");
            var genericCustomer = ObjectFactory.GetObject("CUST", "Bill", "Lumberg");
#pragma warning disable S125 // Sections of code should not be commented out
                            // var person = ObjectFactory.GetObject("", "Bill", "Lumberg");

            // assert
            Assert.IsInstanceOfType(mgr, typeof(Manager));
#pragma warning restore S125 // Sections of code should not be commented out
            Assert.IsInstanceOfType(usCustomer, typeof(USCustomer));
            Assert.IsInstanceOfType(ukCustomer, typeof(UKCustomer));
            Assert.IsInstanceOfType(genericCustomer, typeof(Customer));
            // Assert.IsInstanceOfType(person, typeof(Person));
        }

        [TestMethod]
        void ManagerLogin()
        {
            var mgr = ObjectFactory.GetObject("mgr", "Bill", "Lumberg");

            mgr.Login();
        }
    }
}
