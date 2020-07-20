using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace C969_Software_2
{
    public partial class LogInReports : Form
    {

        public LogInReports()
        {
            InitializeComponent();

        }
        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void ReportButton_Click(object sender, System.EventArgs e)
        {

            try
            {
                string line;

                //string path = Application.StartupPath + "log.txt";

                //string[] readText = File.ReadAllLines(path);
                //IList<String> dataStrings = new List<String>();
                //foreach (string s in readText)
                //{
                //    dataStrings.Add(s);
                //}
                //if (readText.Length == 0)
                //{
                //    dataStrings.Add("No Login information to show.");
                //}
                //dataGridView.DataSource = dataStrings.Select(x => new { Value = x }).ToList();
                //dataGridView.Show();

                using (StreamReader sr = new StreamReader("log.txt"))
                {
                    
                    while ((line = sr.ReadLine()) != null)
                    {
                        RichTextBox1.AppendText(line);
                        RichTextBox1.AppendText("\r\n");
                        line = sr.ReadLine();

                    }
                    sr.Close();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("The file could not be read or there is no data.");

            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
