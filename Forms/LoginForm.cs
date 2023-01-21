using hrAPP.Forms;
using hrAPP.Helpers;
using System;
using System.Data.OleDb;
using System.Windows.Forms;


namespace hrAPP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Validate username and password using hrapp_users table
        public bool ValidateUser()
        {
            String CommandString = "SELECT Count(*) FROM hrapp_users WHERE Username=@username and [Password]=@password";
            OleDbCommand Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            Command.Parameters.AddWithValue("@username", LoginUsernameTextbox.Text);
            Command.Parameters.AddWithValue("@password", LoginPasswordTextbox.Text);
            // Open database connection
            DatabaseHelper.Open();
            if ((int)DatabaseHelper.ExecuteScalar(Command) > 0)
            {
                // Close database connection
                DatabaseHelper.Close();
                return true;
            }
            else
            {
                // Close database connection
                DatabaseHelper.Close();
                return false;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (ValidateUser())
            {
                MessageBox.Show("Login Successful");
                UserSession.SetUser(LoginUsernameTextbox.Text, LoginPasswordTextbox.Text);
                // Hide login form
                this.Hide();
                // Display Home
                var HomeDisplay = new Home();
                HomeDisplay.Show();
            }
            else
                MessageBox.Show("Invalid Credentials, Please Re-Enter");
        }

        private void DatabaseSettingButton_Click(object sender, EventArgs e)
        {
            var DatabaseSetting = new DatabaseSettingForm();
            DatabaseSetting.ShowDialog();
        }

    }
}
