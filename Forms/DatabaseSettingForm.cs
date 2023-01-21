using hrAPP.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace hrAPP.Forms
{
    public partial class DatabaseSettingForm : Form
    {
        private Home HomeDisplay;
        public DatabaseSettingForm()
        {
            InitializeComponent();
            if (DatabaseHelper.CheckConnection())
            {
                DatabaseSettingConnectionPictureBox.BackColor = Color.Green;
            }
            else
            {
                DatabaseSettingConnectionPictureBox.BackColor = Color.Red;
            }
        }
        public DatabaseSettingForm(Home form)
        {
            HomeDisplay = form;
            InitializeComponent();
            if (DatabaseHelper.CheckConnection())
            {
                DatabaseSettingConnectionPictureBox.BackColor = Color.Green;
            }
            else
            {
                DatabaseSettingConnectionPictureBox.BackColor = Color.Red;
            }
        }

        private void DatabaseSettingBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Please select your local Access Database file";
            file.Filter = "AccessDB File (.accdb)|*.accdb";
            if (file.ShowDialog() == DialogResult.OK)
            {
                DatabaseSettingPathTextBox.Text = file.FileName;
            }
        }

        private void DatabaseSettingSubmitButton_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.SetAccessDbPath(DatabaseSettingPathTextBox.Text))
            {
                DatabaseSettingConnectionPictureBox.BackColor = Color.Green;
                if (HomeDisplay != null)
                {
                    HomeDisplay.ReloadForm();
                }
            }
            else
            {
                DatabaseSettingConnectionPictureBox.BackColor = Color.Red;
                if (HomeDisplay != null)
                {
                    HomeDisplay.ReloadForm();
                }
            }
        }
    }
}
