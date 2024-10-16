using NuGet.Frameworks;

namespace TH.AutoRepair.BL.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void ToSringTest()
        {
            Customer customer = new Customer();
            customer.FirstName = "Tyler";
            customer.LastName = "Hanson";

            string expected = "Hanson, Tyler";
            string actual = customer.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] 
        public void AddVehicleTest()
        {
            Customer customer = new Customer();
            int previousCount = customer.Vehicles.Count;
            customer.Vehicles.Add(new Vehicle());
            int currentCount = customer.Vehicles.Count;

            Assert.AreEqual(previousCount + 1, currentCount);
        }
    }
}