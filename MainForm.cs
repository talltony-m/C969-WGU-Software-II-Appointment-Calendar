using System;
using System.Data;
using System.Windows.Forms;


namespace C969_Software_2
{
    public partial class MainForm : Form
    {
        public Login loginForm;

        public static string conString = SqlUpdater.GetconString();

        public MainForm()
        {
            InitializeComponent();
            MainForm_Load(WeekRadioButton.Checked = true);
            ReminderCheck(AppointmentCalendar);
        }


        public static string SetApptId = "";

        public static string SetCustName = "";


        public void MainForm_Load(bool week)
        {
            DateTime filter = week ? CalcDateFilter("week") : CalcDateFilter("month");
            DataTable dtRecord = SqlUpdater.FirstCal(SqlUpdater.DateSQLFormat(filter), week);
            AppointmentCalendar.DataSource = dtRecord;
        }


        public static DateTime CalcDateFilter(string type)
        {
            if (type == "week")
            {
                DateTime week = DateTime.Now.AddDays(7);
                return week;
            }
            else
            {
                DateTime month = DateTime.Now.AddMonths(1);
                return month;
            }
        }

        public static void ReminderCheck(DataGridView AppointmentCalendar)
        {
            foreach (DataGridViewRow row in AppointmentCalendar.Rows)
            {
                DateTime now = DateTime.UtcNow;
                DateTime start = DateTime.Parse(row.Cells[4].Value.ToString()).ToUniversalTime();
                TimeSpan nowUntilStartOfApp = now - start;
                if (nowUntilStartOfApp.TotalMinutes >= -15 && nowUntilStartOfApp.TotalMinutes < 1)
                {
                    MessageBox.Show($"Reminder: you have a meeting within 15 minutes. ");
                }
            }


        }

        private void CreateCustomerButton_Click(object sender, EventArgs e)
        {
            CreateCustomer createCustomer = new CreateCustomer();
            createCustomer.Show();
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.Show();
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            DeleteCustomer deleteCustomer = new DeleteCustomer();
            deleteCustomer.Show();
        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment
            {
                mainFormObject = this
            };
            addAppointment.Show();
        }

        private void UpdateAppointmentButton_Click(object sender, EventArgs e)
        {
            UpdateAppointment updateAppointment = new UpdateAppointment
            {
                mainFormObject = this
            };
            updateAppointment.Show();
        }

        private void DeleteAppointmentButton_Click(object sender, EventArgs e)
        {
            DeleteAppointment deleteAppointment = new DeleteAppointment
            {
                mainFormObject = this
            };
            deleteAppointment.Show();
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            Appointments appointments = new Appointments();
            appointments.Show();
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            Schedules schedules = new Schedules();
            schedules.Show();
        }

        private void WeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm_Load(WeekRadioButton.Checked);
        }


        public void UpdateCalendar()
        {
            MainForm_Load(WeekRadioButton.Checked);
        }

        private void LogInReportButton_Click(object sender, EventArgs e)
        {
            LogInReports loginreports = new LogInReports();
            loginreports.Show();
        }

        private void AppointmentCalendar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
