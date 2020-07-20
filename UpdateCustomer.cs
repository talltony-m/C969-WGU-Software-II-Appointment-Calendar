using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace C969_Software_2
{
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        public static Dictionary<string, string> cForm = new Dictionary<string, string>();

        public bool UpdateCust(Dictionary<string, string> updatedForm)
        {
            MySqlConnection c = new MySqlConnection(SqlUpdater.conString);
            c.Open();

            string recUpdate = $"UPDATE customer" +
                $" SET customerName = '{updatedForm["customerName"]}', lastUpdate = '{SqlUpdater.CreateTimestamp()}', lastUpdateBy = '{SqlUpdater.GetCurrentUserName()}'" +
                $" WHERE customerName = '{cForm["customerName"]}'";
            MySqlCommand cmd = new MySqlCommand(recUpdate, c);
            int customerUpdated = cmd.ExecuteNonQuery();

            recUpdate = $"UPDATE address" +
                $" SET address = '{updatedForm["address"]}', postalCode = '{updatedForm["zip"]}', phone = '{updatedForm["phone"]}', lastUpdate = '{SqlUpdater.CreateTimestamp()}', lastUpdateBy = '{SqlUpdater.GetCurrentUserName()}'" +
                $" WHERE address = '{cForm["address"]}'";
            cmd = new MySqlCommand(recUpdate, c);
            int addressUpdated = cmd.ExecuteNonQuery();

            recUpdate = $"UPDATE city" +
                $" SET city = '{updatedForm["city"]}', lastUpdate = '{SqlUpdater.CreateTimestamp()}', lastUpdateBy = '{SqlUpdater.GetCurrentUserName()}'" +
                $" WHERE city = '{cForm["city"]}'";
            cmd = new MySqlCommand(recUpdate, c);
            int cityUpdated = cmd.ExecuteNonQuery();

            recUpdate = $"UPDATE country" +
                $" SET country = '{updatedForm["country"]}', lastUpdate = '{SqlUpdater.CreateTimestamp()}', lastUpdateBy = '{SqlUpdater.GetCurrentUserName()}'" +
                $" WHERE country = '{cForm["country"]}'";
            cmd = new MySqlCommand(recUpdate, c);
            int countryUpdated = cmd.ExecuteNonQuery();

            c.Close();

            if (customerUpdated != 0 && addressUpdated != 0 && cityUpdated != 0 && countryUpdated != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            {
                int customerId = SqlUpdater.FindCustomer(SearchBar.Text);
                if (customerId != 0)
                {
                    cForm = SqlUpdater.GetCustomerDetails(customerId);
                    CustomerNameBox.Text = cForm["customerName"];
                    CustomerPhoneBox.Text = cForm["phone"];
                    CustomerCityBox.Text = cForm["city"];
                    CustomerAddressBox.Text = cForm["address"];
                    CustomerZipBox.Text = cForm["zip"];
                    CustomerCountryBox.Text = cForm["country"];
                }
                else
                {
                    MessageBox.Show("Unable to find customer");
                }
            }
        }

        private void UpdateButton_Click_1(object sender, EventArgs e)
        {
            Dictionary<string, string> updatedForm = new Dictionary<string, string>
            {
                { "customerName", CustomerNameBox.Text },
                { "phone", CustomerPhoneBox.Text },
                { "address", CustomerAddressBox.Text },
                { "city", CustomerCityBox.Text },
                { "country", CustomerCountryBox.Text },
                { "zip", CustomerZipBox.Text },
            };

            if (UpdateCust(updatedForm))
            {
                MessageBox.Show("Updated succesfull");
            }
            else
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
