using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace C969_Software_2
{
    public partial class UpdateAppointment : Form
    {


        public UpdateAppointment()
        {
            InitializeComponent();

        }
        public MainForm mainFormObject;

        public static Dictionary<string, string> form = new Dictionary<string, string>();

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            string appointmentId = SearchBar.Text;
            form = SqlUpdater.GetAppointmentDetails(appointmentId);
            CustomerIdBox.Text = form["customerId"];
            TypeBox.Text = form["type"];
            StartTimeBox.Text = SqlUpdater.ConvertToTimezone(form["start"]);
            EndTimeBox.Text = (SqlUpdater.ConvertToTimezone(form["end"]));
        }

        public static bool AppHasConflict(DateTime startTime, DateTime endTime)
        {

            foreach (var app in SqlUpdater.GetAppointments().Values)
            {

                if (startTime < DateTime.Parse(app["end"].ToString()) && DateTime.Parse(app["start"].ToString()) < endTime)
                    return true;
            }
            return false;
        }

        public static bool OutsideBusinessHours(DateTime startTime, DateTime endTime)
        {
            startTime = startTime.ToLocalTime();
            endTime = endTime.ToLocalTime();
            DateTime businessStart = DateTime.Today.AddHours(8);
            DateTime businessEnd = DateTime.Today.AddHours(17);
            if (startTime.TimeOfDay > businessStart.TimeOfDay && startTime.TimeOfDay < businessEnd.TimeOfDay &&
                endTime.TimeOfDay > businessStart.TimeOfDay && endTime.TimeOfDay < businessEnd.TimeOfDay)
                return false;
            return true;
        }

        private void UpdateButton_Click_1(object sender, EventArgs e)
        {
            string timestamp = SqlUpdater.CreateTimestamp();
            int userId = SqlUpdater.GetCurrentUserID();
            string username = SqlUpdater.GetCurrentUserName();
            int appointmentId = Convert.ToInt32(SearchBar.Text);
            int customerId = Convert.ToInt32(CustomerIdBox.Text);
            string type = TypeBox.Text;
            DateTime startTime = DateTime.Parse(StartTimeBox.Text).ToUniversalTime();
            DateTime endTime = DateTime.Parse(EndTimeBox.Text).ToUniversalTime();
            String st = DateTime.Parse(StartTimeBox.Text).ToUniversalTime().ToString("u");
            String et = DateTime.Parse(EndTimeBox.Text).ToUniversalTime().ToString("u");

            bool pass = Validator();
            if (pass)

                try
                {
                    if (AppHasConflict(startTime, endTime))
                        throw new AppointmentException();
                    else
                    {
                        try
                        {
                            if (OutsideBusinessHours(startTime, endTime))
                                throw new AppointmentException();
                            else
                            {

                                SqlUpdater.UpdateAppt(customerId, userId, st, et, type, timestamp, username, appointmentId);

                                mainFormObject.UpdateCalendar();
                                MessageBox.Show("Update Sucessfull.");
                                Close();

                            }
                        }
                        catch (AppointmentException ex) { ex.BusinessHours(); }

                    }
                }
                catch (AppointmentException ex) { ex.AppOverlap(); }

            else
            {

                MessageBox.Show("Add Appointment Error.");
            }
        }

        private bool Validator()
        {

            if (EmptyCheck() == false)
            {
                MessageBox.Show("Please complete all Appointment Information fields.");
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(CustomerIdBox.Text, "[^0-9]+$"))
            {
                ShowError(CustomerIdLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(TypeBox.Text, "[^a-zA-Z]+$"))
            {
                ShowError(TypeLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(StartTimeBox.Text, "[^0-9:/]+$"))
            {
                ShowError(StartLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(EndTimeBox.Text, "[^0-9:/]+$"))
            {
                ShowError(EndLabel.Text);
                return false;
            }
            return true;
        }

        private void ShowError(string item)
        {
            MessageBox.Show("Please enter a valid information for " + item);
        }

        private bool EmptyCheck()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        return false;
                    }
                }
                if (c is ComboBox)
                {
                    ComboBox combo = c as ComboBox;
                    if (combo.SelectedIndex == -1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void CustomerIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}

