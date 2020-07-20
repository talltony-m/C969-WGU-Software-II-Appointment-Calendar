using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.Windows.Forms;



namespace C969_Software_2
{
    public partial class Login : Form
    {
        public string errorMessage = "The username and password are incorrect";
        public string exit = "Are you sure to exit this Application?";
        public Login()
        {
            InitializeComponent();

            //Supports English or Spanish (LCID=2058)
            //Language Check
            if (CultureInfo.CurrentUICulture.LCID == 2058)
            {
                titleLabel.Text = "Por favor Iniciar sesión";
                usernameLabel.Text = "nombre de usuario";
                passwordLabel.Text = "Contraseña";
                LoginButton.Text = "Iniciar sesión";
                CancelButton.Text = "Cancelar";
                errorMessage = "El nombre de usuario y la contraseña son incorrectos";
                exit = "Estás seguro de salir de esta aplicación?";
            }
        }


        static public int FindUser(string userName, string password)
        {
            MySqlConnection C = new MySqlConnection(SqlUpdater.conString);
            C.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT userId FROM user WHERE userName = '{userName}' AND password = '{password}'", C);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                SqlUpdater.SetCurrentUserID(Convert.ToInt32(rdr[0]));
                SqlUpdater.SetCurrentUserName(userName);
                rdr.Close();
                return SqlUpdater.GetCurrentUserID();
            }
            return 0;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(exit, this.Text,
                            MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {

            if (FindUser(Username.Text, Password.Text) != 0)
            {
                this.Hide();
                MainForm MainForm = new MainForm
                {
                    loginForm = this
                };
                Logger.WriteUserLoginLog(SqlUpdater.GetCurrentUserName());

                MainForm.Show();
            }
            else
            {
                MessageBox.Show(errorMessage);
                Password.Text = "";
            }
        }
    }
}


