using hrAPP.Helpers;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace hrAPP.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            // Open database connection
            DatabaseHelper.Open();
            OleDbCommand Command = new OleDbCommand();
            OleDbDataReader read;

            // Fill BirthdaysListView with detail of the employees whose birthdays are in current month
            String CommandString = "SELECT * FROM Employees WHERE MONTH(birth_date) = " + DateTime.Today.Month.ToString();
            Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            read = DatabaseHelper.ExecuteReader(Command);
            while (read != null && read.Read())
            {
                ListViewItem addNew = new ListViewItem();
                addNew.Text = read["employee_id"].ToString();
                addNew.SubItems.Add(read["first_name"].ToString() + " " + read["last_name"].ToString());
                addNew.SubItems.Add(Convert.ToDateTime(read["birth_date"]).ToString("MM/dd"));
                addNew.SubItems.Add((Convert.ToInt16(Convert.ToDateTime(read["birth_date"]).Day.ToString()) - Convert.ToInt16(DateTime.Today.Day.ToString())).ToString());
                addNew.SubItems.Add((Convert.ToInt16(DateTime.Today.Year.ToString()) - Convert.ToInt16(Convert.ToDateTime(read["birth_date"]).Year.ToString())).ToString());
                BirthdaysListView.Items.Add(addNew);
            }
            // Fill OnLeaveListView with details of the employees who are on leave
            CommandString = "SELECT * FROM Employees WHERE is_on_leave = True";
            Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            read = DatabaseHelper.ExecuteReader(Command);
            while (read != null && read.Read())
            {
                ListViewItem addNew = new ListViewItem();
                addNew.Text = read["employee_id"].ToString();
                addNew.SubItems.Add(read["first_name"].ToString() + " " + read["last_name"].ToString());
                addNew.SubItems.Add(Convert.ToDateTime(read["leave_start_date"]).ToString("MM/dd/yy"));
                addNew.SubItems.Add(Convert.ToDateTime(read["on_leave_until"]).ToString("MM/dd/yy"));
                addNew.SubItems.Add(((int)(Convert.ToDateTime(read["on_leave_until"]) - DateTime.Now).TotalDays).ToString());
                OnLeaveListView.Items.Add(addNew);
            }
            // Fill pie chart with count of employees for each department
            CommandString = "SELECT Count(employee_id) as cnt, department FROM Employees GROUP BY department";
            Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            read = DatabaseHelper.ExecuteReader(Command);
            EmpByDeptChart.Titles.Add("Employees by Department");
            EmpByDeptChart.Series["s1"].IsValueShownAsLabel = true;
            while (read != null && read.Read())
            {
                EmpByDeptChart.Series["s1"].Points.AddXY(read["department"].ToString(), read["cnt"].ToString());
            }
            // Fill pie chart with count of employees for each position
            CommandString = "SELECT Count(employee_id) as cnt, position_name FROM Employees GROUP BY position_name";
            Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            read = DatabaseHelper.ExecuteReader(Command);
            EmpByPosChart.Titles.Add("Employees by Position");
            EmpByPosChart.Series["s1"].IsValueShownAsLabel = true;
            while (read != null && read.Read())
            {
                EmpByPosChart.Series["s1"].Points.AddXY(read["position_name"].ToString(), read["cnt"].ToString());
            }
            // Set TotalEmployeesCountTextBox
            CommandString = "SELECT Count(employee_id) as cnt FROM Employees";
            Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            int TotalEmployees = DatabaseHelper.ExecuteScalar(Command);
            TotalEmployeesTextBox.Text = TotalEmployees.ToString();
            // Set ActiveEmployeesCountTextBox
            CommandString = "SELECT Count(employee_id) as cnt FROM Employees WHERE is_on_leave=False";
            Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            int ActiveEmployees = DatabaseHelper.ExecuteScalar(Command);
            ActiveEmployeesTextBox.Text = ActiveEmployees.ToString();
            // Update DateTimeLabel on dashboard
            String Dt = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
            DateTimeLabel.Text = Dt;
            //Close database connection
            DatabaseHelper.Close();
        }
    }
}
