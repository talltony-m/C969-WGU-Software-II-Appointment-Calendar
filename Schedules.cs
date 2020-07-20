using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;




namespace C969_Software_2
{
    public partial class Schedules : Form
    {
        public static List<KeyValuePair<string, object>> userList;

        public Schedules()
        {
            InitializeComponent();
            FillConsol();
        }
        public void SetUserList(List<KeyValuePair<string, object>> list)
        {

            userList = list;

        }

        public static List<KeyValuePair<string, object>> GetUserList()
        {

            return userList;
        }


        public void FillConsol()
        {
            MySqlConnection conn = new MySqlConnection(SqlUpdater.conString);

            try
            {
                string query = "select  userId, userName as 'Display' from user;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "User");
                comboBox1.DisplayMember = "Display";
                comboBox1.ValueMember = "userId";
                comboBox1.DataSource = ds.Tables["User"];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured! " + ex);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            DataRowView drv = comboBox1.SelectedItem as DataRowView;
            int id = Convert.ToInt32(comboBox1.SelectedValue);

            DataTable dtRecord = SqlUpdater.Schedule(id.ToString());
            userReportView.DataSource = dtRecord;
        }
    }
}
