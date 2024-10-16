using System.Drawing.Text;
using TH.AutoRepair.BL;

namespace TH.AutoRepair.UI
{
    public partial class Form1 : Form
    {
        // field (private class variable)
        private CustomerCollection customers = new CustomerCollection();

        public Form1()
        {
            InitializeComponent();

            customers.PopulateTestData();
            RebindCustomers();

        }

        private void RebindCustomers()
        {
            lstCustomers.DataSource = null;
            lstCustomers.DataSource = customers;
        }
        private void RebindVehicles(Customer customer)
        {
            lstVehicles.DataSource = null;
            lstVehicles.DataSource = customer.Vehicles;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();
                customer.FirstName = txtFirstName.Text.Trim();
                customer.LastName = txtLastName.Text.Trim();
                customer.PhoneNumber = txtPhoneNumber.Text.Trim();
                customers.Add(customer);

                RebindCustomers();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Year");
            }
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer? selectedCustomer = lstCustomers.SelectedItem as Customer;
            if (selectedCustomer != null)
            {
                txtFirstName.Text = selectedCustomer.FirstName;
                txtLastName.Text = selectedCustomer.LastName;
                txtPhoneNumber.Text = selectedCustomer.PhoneNumber;

                RebindVehicles(selectedCustomer);
            }

        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            Customer? selectedCustomer = lstCustomers.SelectedItem as Customer;
            if (selectedCustomer != null)
            {
                try
                {
                    Vehicle vehicle = new Vehicle();
                    vehicle.Make = txtMake.Text;
                    vehicle.Model = txtModel.Text;
                    vehicle.Year = int.Parse(txtYear.Text);

                    selectedCustomer.Vehicles.Add(vehicle);
                    RebindVehicles(selectedCustomer);
                }
                catch (InvalidYearException iyex)
                {
                    MessageBox.Show(iyex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lstVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}