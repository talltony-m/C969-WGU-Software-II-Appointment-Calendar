using System;
using System.Windows.Forms;

namespace C969_Software_2
{
    public partial class CreateCustomer : Form
    {


        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void CustomerCreateButton_Click(object sender, EventArgs e)
        {
            string timestamp = SqlUpdater.CreateTimestamp();
            string userName = SqlUpdater.GetCurrentUserName();

            if (string.IsNullOrEmpty(CustomerNameText.Text) ||
                string.IsNullOrEmpty(CustomerPhoneText.Text) ||
                string.IsNullOrEmpty(CustomerCityText.Text) ||
                string.IsNullOrEmpty(CustomerCountryText.Text) ||
                string.IsNullOrEmpty(CustomerZipText.Text) ||
                string.IsNullOrEmpty(CustomerAddressText.Text)) //||
                                                                //(activeYes.Checked == false && activeNo.Checked == false))
            {
                MessageBox.Show("Please complete all fields");
            }
            else
            {
                int countryId = SqlUpdater.CreateRecord(timestamp, userName, "country", $"'{CustomerCountryText.Text}'");
                int cityId = SqlUpdater.CreateRecord(timestamp, userName, "city", $"'{CustomerCityText.Text}', '{countryId}'");
                int addressId = SqlUpdater.CreateRecord(timestamp, userName, "address", $"'{CustomerAddressText.Text}', '', '{cityId}', '{CustomerZipText.Text}', '{CustomerPhoneText.Text}'");
                SqlUpdater.CreateRecord(timestamp, userName, "customer", $"'{ CustomerNameText.Text}', '{addressId}', '{(ActiveYes.Checked ? 1 : 0)}'");

                MessageBox.Show("Customer created.");
                Close();


                //   string timestamp = SqlUpdater.CreateTimestamp();
                //   string userName = SqlUpdater.GetCurrentUserName();

                //if (string.IsNullOrEmpty(CustomerNameText.Text) ||
                //    string.IsNullOrEmpty(CustomerPhoneText.Text) ||
                //    string.IsNullOrEmpty(CustomerCityText.Text) ||
                //    string.IsNullOrEmpty(CustomerCountryText.Text) ||
                //    string.IsNullOrEmpty(CustomerZipText.Text) ||
                //    string.IsNullOrEmpty(CustomerAddressText.Text))
                //{
                //    MessageBox.Show("Please complete all fields");
                //}
                //else
                //{
                //    int countryId = SqlUpdater.CreateRecord(timestamp, userName, "country", $"'{CustomerCountryText.Text}'");
                //    int cityId = SqlUpdater.CreateRecord(timestamp, userName, "city", $"'{CustomerCityText.Text}', {countryId}");
                //    int addressId = SqlUpdater.CreateRecord(timestamp, userName, "address", $"'{CustomerAddressText.Text}', {cityId}, '{CustomerZipText.Text}', '{CustomerPhoneText.Text}'");
                //    SqlUpdater.CreateRecord(timestamp, userName, "customer", $"'{ CustomerNameText.Text}', {addressId}");

                //    MessageBox.Show("Customer created.");
                //    Close();
            }
        }
        private void CustomerCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ActiveYes_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
