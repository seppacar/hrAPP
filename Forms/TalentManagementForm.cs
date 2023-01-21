using hrAPP.Helpers;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace hrAPP.Forms
{
    public partial class TalentManagementForm : Form
    {
        public TalentManagementForm()
        {
            InitializeComponent();
            LoadFormData();
        }

        private void LoadFormData()
        {
            ApplicantsListView.Items.Clear();
            PositionFilterComboBox.Items.Clear();
            DatabaseHelper.Open();
            String CommandString = "SELECT DISTINCT position_name from job_applications";
            OleDbCommand Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            OleDbDataReader read = DatabaseHelper.ExecuteReader(Command);
            while (read != null && read.Read())
            {
                PositionFilterComboBox.Items.Add(read["position_name"]);
            }

            CommandString = "SELECT * FROM job_applications";
            Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            read = DatabaseHelper.ExecuteReader(Command);
            while (read != null && read.Read())
            {
                ListViewItem addNew = new ListViewItem();
                addNew.Text = read["applicant_id"].ToString();
                addNew.SubItems.Add(read["first_name"].ToString());
                addNew.SubItems.Add(read["last_name"].ToString());
                addNew.SubItems.Add(read["position_name"].ToString());
                ApplicantsListView.Items.Add(addNew);
            }
            DatabaseHelper.Close();
        }
        private void LoadFormData(String position)
        {
            ApplicantsListView.Items.Clear();
            DatabaseHelper.Open();
            String CommandString = "SELECT * FROM job_applications WHERE position_name = @positionname";
            OleDbCommand Command = new OleDbCommand(CommandString, DatabaseHelper.AccessDbConnection);
            Command.Parameters.AddWithValue("@positionname", position);
            OleDbDataReader read = DatabaseHelper.ExecuteReader(Command);
            while (read != null && read.Read())
            {
                ListViewItem addNew = new ListViewItem();
                addNew.Text = read["applicant_id"].ToString();
                addNew.SubItems.Add(read["first_name"].ToString());
                addNew.SubItems.Add(read["last_name"].ToString());
                addNew.SubItems.Add(read["position_name"].ToString());
                ApplicantsListView.Items.Add(addNew);
            }
            DatabaseHelper.Close();
        }

        private void TalentManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void ApplicantsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ApplicantsListView.FocusedItem == null) return;
            String selectedIndex = ApplicantsListView.FocusedItem.SubItems[0].Text;
            String QueryString = "Select * from job_applications Where applicant_id = " + selectedIndex;
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
                DateTime application_date = Convert.ToDateTime(read["application_date"]);
                dateTimePicker2.Value = application_date;
                textBox2.Text = (read["position_name"].ToString());
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

        private void PositionFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFormData(PositionFilterComboBox.Text);
        }
    }
}
