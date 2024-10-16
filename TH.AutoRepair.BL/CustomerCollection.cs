using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH.AutoRepair.BL
{
    public class CustomerCollection : List<Customer>
    {
        public void PopulateTestData()
        {
            Customer customer;
            Vehicle vehicle;

            customer = new Customer();
            customer.FirstName = "Joe";
            customer.LastName = "Wetzel";
            customer.PhoneNumber = "(920) 836-1121";
            vehicle = new Vehicle();
            vehicle.Make = "Jeep";
            vehicle.Model = "Wrangler";
            vehicle.Year = 2010;
            customer.Vehicles.Add(vehicle);
            Add(customer);


            customer = new Customer();
            customer.FirstName = "Brian";
            customer.LastName = "Foote";
            customer.PhoneNumber = "(920) 830-7777";
            Add(customer);

            customer = new Customer();
            customer.FirstName = "Mark Kay";
            customer.LastName = "Hinkson";
            customer.PhoneNumber = "(920) 836-2255";
            Add(customer);

            customer = new Customer();
            customer.FirstName = "TJ";
            customer.LastName = "Spilman";
            customer.PhoneNumber = "(920) 836-6565 ";
            Add(customer);
        }
    }
}
