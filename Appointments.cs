using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;



namespace C969_Software_2
{

    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            DataRowView drv = TypeCombo.SelectedItem as DataRowView;
            try
            {
                string item = TypeCombo.SelectedItem.ToString();
                IDictionary<string, object> dictionary = SqlUpdater.ReportAppoint(item);
                janResult.Text = dictionary["Jan"].ToString();
                febResult.Text = dictionary["Feb"].ToString();
                marResult.Text = dictionary["Mar"].ToString();
                aprResult.Text = dictionary["Apr"].ToString();
                mayResult.Text = dictionary["May"].ToString();
                junResult.Text = dictionary["Jun"].ToString();
                julResult.Text = dictionary["Jul"].ToString();
                augResult.Text = dictionary["Aug"].ToString();
                sepResult.Text = dictionary["Sep"].ToString();
                octResult.Text = dictionary["Oct"].ToString();
                novResult.Text = dictionary["Nov"].ToString();
                decResult.Text = dictionary["Dec"].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void AllButton_Click(object sender, EventArgs e)
        {
            try
            {
                IDictionary<string, object> dictionary = SqlUpdater.ReportAll();
                janResult.Text = dictionary["Jan"].ToString();
                febResult.Text = dictionary["Feb"].ToString();
                marResult.Text = dictionary["Mar"].ToString();
                aprResult.Text = dictionary["Apr"].ToString();
                mayResult.Text = dictionary["May"].ToString();
                junResult.Text = dictionary["Jun"].ToString();
                julResult.Text = dictionary["Jul"].ToString();
                augResult.Text = dictionary["Aug"].ToString();
                sepResult.Text = dictionary["Sep"].ToString();
                octResult.Text = dictionary["Oct"].ToString();
                novResult.Text = dictionary["Nov"].ToString();
                decResult.Text = dictionary["Dec"].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

