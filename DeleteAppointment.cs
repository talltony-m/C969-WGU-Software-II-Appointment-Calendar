using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C969_Software_2
{
    public partial class DeleteAppointment : Form
    {
        public MainForm mainFormObject;

        public DeleteAppointment()
        {
            InitializeComponent();
        }

        private void DeleteAppointment_Load(object sender, EventArgs e)
        {

        }

        public static Dictionary<string, string> appointmentDetails = new Dictionary<string, string>();

        public static bool DeleteApp()
        {
            MySqlConnection c = new MySqlConnection(SqlUpdater.conString);
            c.Open();

            string recDelete = $"DELETE FROM appointment" +
                $" WHERE appointmentId = '{appointmentDetails["appointmentId"]}'";
            MySqlCommand cmd = new MySqlCommand(recDelete, c);
            int appointmentDeleted = cmd.ExecuteNonQuery();
            c.Close();

            if (appointmentDeleted != 0)
                return true;
            else
                return false;

        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                if (DeleteApp())
                    MessageBox.Show($"Appointment: {appointmentDetails["type"]} was deleted");
                else
                    MessageBox.Show($"Appointment: {appointmentDetails["type"]} was not deleted");

            }
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string appointmentId = AppointmentIdBox.Text;
            appointmentDetails = SqlUpdater.GetAppointmentDetails(appointmentId);
            CustomerIdLabel.Text = appointmentDetails["customerId"];
            TypeLabel2.Text = appointmentDetails["type"];
            StartLabel.Text = appointmentDetails["start"];
            EndLabel.Text = appointmentDetails["end"];
        }
    }
}
