using hrAPP.Helpers;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace hrAPP.Forms
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        private void PassChangeSubmitButton_Click(object sender, EventArgs e)
        {
            String[] userdata = UserSession.GetUser();
            if ((NewPasswordConfirmTextBox.Text != NewPasswordTextBox.Text))
            {
                MessageBox.Show("Passwords do not match!");
            }
            else if (OldpasswordTextBox.Text != userdata[1])
            {
                MessageBox.Show("Please check old password!");

            }
            else
            {
                String CommandString = "UPDATE hrapp_users SET [password]=@password WHERE username =@username";
                OleDbCommand Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
                Command.Parameters.AddWithValue("@username", userdata[0]);
                Command.Parameters.AddWithValue("@password", NewPasswordTextBox.Text);
                DatabaseHelper.Open();
                DatabaseHelper.ExecuteNonQuery(Command);
                DatabaseHelper.Close();
                MessageBox.Show("Password updated for user " + userdata[0]);
                this.Hide();
            }
        }
    }
}
