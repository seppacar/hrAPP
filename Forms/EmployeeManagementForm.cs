using hrAPP.Helpers;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace hrAPP.Forms
{
    public partial class EmployeeManagementForm : Form
    {
        // OpenFileDialog variable
        OpenFileDialog opnfd = new OpenFileDialog();
        public EmployeeManagementForm()
        {
            InitializeComponent();
            LoadEmployeeData();
        }
        public void LoadEmployeeData()
        {
            EmployeesListView.Items.Clear();
            comboBox1.Items.Clear();
            DepartmentsComboBox.Items.Clear();
            String CommandString = "SELECT * FROM Employees";
            OleDbCommand Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            DatabaseHelper.Open();
            OleDbDataReader read = DatabaseHelper.ExecuteReader(Command);
            while (read != null && read.Read())
            {
                ListViewItem addNew = new ListViewItem();
                addNew.Text = read["employee_id"].ToString();
                addNew.SubItems.Add(read["first_name"].ToString());
                addNew.SubItems.Add(read["last_name"].ToString());
                addNew.SubItems.Add(read["position_name"].ToString());
                addNew.SubItems.Add(read["department"].ToString());
                EmployeesListView.Items.Add(addNew);
            }
            CommandString = "SELECT * FROM Positions";
            Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            read = DatabaseHelper.ExecuteReader(Command);
            while (read != null && read.Read())
            {
                comboBox1.Items.Add(read["position_name"]);
            }
            CommandString = "SELECT * FROM Departments";
            Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            read = DatabaseHelper.ExecuteReader(Command);
            while (read != null && read.Read())
            {
                DepartmentsComboBox.Items.Add(read["department_name"]);
            }
            DatabaseHelper.Close();
        }

        public void ClearFields()
        {
            fNameTbox.Text = "";
            MailTbox.Text = "";
            PhoneTbox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            SalaryTbox.Text = "";
        }


        // If selected index changed update Employee Detail Textboxes
        private void EmployeesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (EmployeesListView.FocusedItem == null) return;
            String selectedIndex = EmployeesListView.FocusedItem.SubItems[0].Text;
            String QueryString = "Select * from Employees Where employee_id = " + selectedIndex;
            OleDbCommand AccessCommand = new OleDbCommand(QueryString, DatabaseHelper.AccessDbConnection);
            DatabaseHelper.Open();
            OleDbDataReader read = AccessCommand.ExecuteReader();
            while (read.Read())
            {
                fNameTbox.Text = read["first_name"].ToString() + " " + read["last_name"].ToString();
                MailTbox.Text = read["mail"].ToString();
                PhoneTbox.Text = read["phone_number"].ToString();
                DateTime birthdate = Convert.ToDateTime(read["birth_date"]);
                dateTimePicker1.Value = birthdate;
                DateTime hiredate = Convert.ToDateTime(read["hire_date"]);
                dateTimePicker2.Value = hiredate;
                SalaryTbox.Text = read["salary"].ToString();
                DepartmentsComboBox.SelectedIndex = DepartmentsComboBox.FindString(read["department"].ToString());
                comboBox1.SelectedIndex = comboBox1.FindString(read["position_name"].ToString());
                try
                {
                    byte[] bytes = (byte[])read["profile_photo"];
                    MemoryStream memStream = new MemoryStream(bytes);
                    Image myImage = new Bitmap(memStream);
                    pictureBox1.Image = myImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    pictureBox1.Image = null;
                }

            }
            DatabaseHelper.Close();
        }
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            // Get profile image file path
            string fileName = opnfd.FileName;
            if (fileName == null || fileName == "")
            {
                MessageBox.Show("Please select a photo");
                return;
            }
            var pic = File.ReadAllBytes(fileName);
            // Setup Command String
            String CommandString = String.Format("INSERT INTO Employees (first_name, last_name, mail, phone_number, hire_date, birth_date, salary, department, position_name, profile_photo) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', @image)", fNameTbox.Text.Split(' ')[0], fNameTbox.Text.Split(' ')[fNameTbox.Text.Split(' ').Length - 1], MailTbox.Text, PhoneTbox.Text, dateTimePicker2.Value.ToString(), dateTimePicker1.Value.ToString(), SalaryTbox.Text, DepartmentsComboBox.Text, comboBox1.Text);
            OleDbCommand Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            Command.Parameters.AddWithValue("@image", pic);
            DatabaseHelper.Open();
            DatabaseHelper.ExecuteNonQuery(Command);
            MessageBox.Show("Employee added successfully!");
            DatabaseHelper.Close();
            LoadEmployeeData();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();

        }


        private void RemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            if (EmployeesListView.FocusedItem == null)
            {
                MessageBox.Show("No item selected");
                return;
            }

            String selectedIndex = EmployeesListView.FocusedItem.SubItems[0].Text;
            String CommandString = ("DELETE from Employees Where employee_id = " + selectedIndex);
            OleDbCommand Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            DatabaseHelper.Open();
            DatabaseHelper.ExecuteNonQuery(Command);
            DatabaseHelper.Close();
            MessageBox.Show("Employee Removed");
            LoadEmployeeData();
            ClearFields();
        }

        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            if (EmployeesListView.FocusedItem == null)
            {
                MessageBox.Show("No item selected");
                return;
            }

            String selectedIndex = EmployeesListView.FocusedItem.SubItems[0].Text;
            OleDbCommand Command = new OleDbCommand();
            Command.Connection = DatabaseHelper.AccessDbConnection;
            //Store profile image data
            string fileName = opnfd.FileName;
            byte[] pic;
            String CommandString;
            if (fileName != null && fileName != "")
            {
                pic = File.ReadAllBytes(fileName);
                CommandString = String.Format("UPDATE Employees SET first_name = '{0}', last_name = '{1}', mail = '{2}', phone_number = '{3}', hire_date = '{4}', birth_date = '{5}', salary = '{6}', department = '{7}', position_name = '{8}', profile_photo = @image WHERE employee_id = {9}", fNameTbox.Text.Split(' ')[0], fNameTbox.Text.Split(' ')[fNameTbox.Text.Split(' ').Length - 1], MailTbox.Text, PhoneTbox.Text, dateTimePicker2.Value.ToString(), dateTimePicker1.Value.ToString(), SalaryTbox.Text, DepartmentsComboBox.Text, comboBox1.Text, selectedIndex);
                Command.CommandText = (CommandString);
                Command.Parameters.AddWithValue("@image", pic);
            }
            else
            {
                CommandString = String.Format("UPDATE Employees SET first_name = '{0}', last_name = '{1}', mail = '{2}', phone_number = '{3}', hire_date = '{4}', birth_date = '{5}', salary = '{6}', department = '{7}', position_name = '{8}' WHERE employee_id = {9}", fNameTbox.Text.Split(' ')[0], fNameTbox.Text.Split(' ')[fNameTbox.Text.Split(' ').Length - 1], MailTbox.Text, PhoneTbox.Text, dateTimePicker2.Value.ToString(), dateTimePicker1.Value.ToString(), SalaryTbox.Text, DepartmentsComboBox.Text, comboBox1.Text, selectedIndex);
                Command.CommandText = (CommandString);
            }
            //Create update string
            DatabaseHelper.Open();
            DatabaseHelper.ExecuteNonQuery(Command);
            MessageBox.Show("Employee updated");
            DatabaseHelper.Close();
            LoadEmployeeData();
        }

        private void ImageSelectButton_Click(object sender, EventArgs e)
        {
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void EmployeeDataPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DepartmentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void SalaryTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PhoneTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MailTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void fNameTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
