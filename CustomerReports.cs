using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace C969_Software_2
{
    public partial class CustomerReports : Form
    {

        public CustomerReports() 
        {
            InitializeComponent();
     
        }
        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void ReportButton_Click(object sender, System.EventArgs e)
        {
            string path = Application.StartupPath + "_log.txt";

            string[] readText = File.ReadAllLines(path);
            IList<String> dataStrings = new List<String>();
            foreach (string s in readText)
            {
                dataStrings.Add(s);
            }
            if (readText.Length == 0)
            {
                dataStrings.Add("No Log In information to show.");
            }
            CustomerReportView.DataSource = dataStrings.Select(x => new { Value = x }).ToList();
            CustomerReportView.Show();

        }
    }
}