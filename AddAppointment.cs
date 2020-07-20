using System;
using System.Windows.Forms;


namespace C969_Software_2
{
    public partial class AddAppointment : Form
    {

        public AddAppointment()
        {
            InitializeComponent();

        }
        public MainForm mainFormObject;


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

        private void AddButton_Click(object sender, EventArgs e)
        {
            string timestamp = SqlUpdater.CreateTimestamp();
            int userId = SqlUpdater.GetCurrentUserID();
            string username = SqlUpdater.GetCurrentUserName();
            DateTime startTime = DateTime.Parse(StartTimeBox.Text).ToUniversalTime();
            DateTime endTime = DateTime.Parse(EndTimeBox.Text).ToUniversalTime();

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
                                SqlUpdater.CreateRecord(timestamp, username, "appointment", $"'{CustomerIDBox.Text}', '{DateTime.Parse(StartTimeBox.Text).ToUniversalTime():u}', '{DateTime.Parse(EndTimeBox.Text).ToUniversalTime():u}', '{TypeBox.Text}'", userId);
                                mainFormObject.UpdateCalendar();


                                Close();

                            }
                        }
                        catch (AppointmentException ex) { ex.BusinessHours(); }

                    }
                }
                catch (AppointmentException ex) { ex.AppOverlap(); }

                finally
                {
                    MessageBox.Show("Appointment created");
                }
        }
        private bool Validator()
        {

            if (EmptyCheck() == false)
            {
                MessageBox.Show("Please complete all Appointment Information fields.");
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(CustomerIDBox.Text, "[^0-9]+$"))
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Lambda Expression assigned to Action Delegate in C#. Used to efficiently clear various control types.
            Action<Control.ControlCollection> clearIT = null;

            clearIT = (controls) =>
            {
                foreach (Control option in controls)
                    if (option is TextBox)
                        (option as TextBox).Clear();
                    else if (option is RadioButton)
                        (option as RadioButton).Checked = false;
                    else if (option is DateTimePicker)
                        (option as DateTimePicker).Value = DateTime.Now;
                    else if (option is ComboBox)
                        (option as ComboBox).SelectedIndex = -1;
                    else
                        clearIT(option.Controls);
            };

            clearIT(Controls);

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CustomerIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TypeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartTimeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EndTimeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {

        }

    }
}