using hrAPP.Helpers;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace hrAPP.Forms
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
            LoadUsersData();
        }

        private void LoadUsersData()
        {
            EmployeeIdComboBox.Items.Clear();
            UsersListView.Items.Clear();
            String CommandString = "SELECT * FROM hrapp_users LEFT JOIN Employees ON hrapp_users.employee_id = Employees.employee_id;";
            OleDbCommand Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            // Start database connection
            DatabaseHelper.Open();
            OleDbDataReader read = DatabaseHelper.ExecuteReader(Command);
            while (read != null && read.Read())
            {
                var fullname = read["first_name"].ToString() + " " + read["last_name"].ToString();
                ListViewItem addNew = new ListViewItem();
                addNew.Text = read["user_id"].ToString();
                addNew.SubItems.Add(fullname);
                addNew.SubItems.Add(read["username"].ToString());
                addNew.SubItems.Add(read["position_name"].ToString());
                UsersListView.Items.Add(addNew);
            }
            CommandString = "SELECT employee_id FROM Employees";
            Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            read = DatabaseHelper.ExecuteReader(Command);
            while (read != null && read.Read())
            {
                EmployeeIdComboBox.Items.Add(read["employee_id"]);
            }

            // End database connection
            DatabaseHelper.Close();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void RemoveUserButton_Click(object sender, EventArgs e)
        {
            if (UsersListView.FocusedItem == null) return;
            String selectedIndex = UsersListView.FocusedItem.SubItems[0].Text;
            String CommandString = ("DELETE from hrapp_users Where user_id = " + selectedIndex);
            OleDbCommand Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            DatabaseHelper.Open();
            DatabaseHelper.ExecuteNonQuery(Command);
            DatabaseHelper.Close();
            MessageBox.Show("Employee Removed");
            LoadUsersData();
        }

        private void UsersListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            if ((PasswordConfirmTextbox.Text != PasswordTextbox.Text) || PasswordConfirmTextbox.Text == "" || PasswordTextbox.Text == "" || UsernameTextbox.Text == "")
            {
                MessageBox.Show("Please check all fields!");
                return;
            }
            else
            {
                String CommandString = String.Format("INSERT INTO hrapp_users (username, [password], employee_id) VALUES (@usern, @passwd, @empid)");
                OleDbCommand Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
                Command.Parameters.AddWithValue("@usern", UsernameTextbox.Text);
                Command.Parameters.AddWithValue("@passwd", PasswordTextbox.Text);
                Command.Parameters.AddWithValue("@empid", EmployeeIdComboBox.Text);

                DatabaseHelper.Open();
                DatabaseHelper.ExecuteNonQuery(Command);
                MessageBox.Show("User added successfully!");
                DatabaseHelper.Close();
            }
            LoadUsersData();
        }
    }
}
