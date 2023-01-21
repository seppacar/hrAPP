using hrAPP.Forms;
using hrAPP.Helpers;
using System;
using System.Windows.Forms;


namespace hrAPP
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
            toolStripUsername.Text = UserSession.GetUser()[0];
            LoadForm(new DashboardForm());
        }

        public void LoadForm(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        public void ReloadForm()
        {
            LoadForm(new DashboardForm());
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            LoadForm(new DashboardForm());
        }


        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Login = new LoginForm();
            Login.Show();
        }

        private void EmployeePanelButton_Click(object sender, EventArgs e)
        {
            LoadForm(new EmployeeManagementForm());
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            var ChangePass = new ChangePasswordForm();
            ChangePass.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var DatabaseSetting = new DatabaseSettingForm(this);
            DatabaseSetting.ShowDialog();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UserManagementFormButton_Click(object sender, EventArgs e)
        {
            LoadForm(new UserManagement());
        }

        private void TalentManagementFormButton_Click(object sender, EventArgs e)
        {
            LoadForm(new TalentManagementForm());
        }
    }
}
