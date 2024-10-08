namespace TH.AutoRepair.BL
{
    public class Customer
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string PhoneNumber { get; set; } = "";

        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

    }
}