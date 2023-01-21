using hrAPP.Forms;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace hrAPP.Helpers
{
    internal class DatabaseHelper
    {
        public static OleDbConnection AccessDbConnection;
        public static bool SetAccessDbPath(String AccessDbPath)
        {
            String ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AccessDbPath;
            // Check database connection
            try
            {
                AccessDbConnection = new OleDbConnection(ConnString);
                AccessDbConnection.Open();
                AccessDbConnection.Close();
                // Save AccessDbPath property
                Properties.Settings.Default.AccessDbPath = AccessDbPath;
                Properties.Settings.Default.Save();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error");
                return false;
            }
        }

        public static void Open()
        {
            try
            {
                AccessDbConnection.Open();
            }
            catch
            {
                MessageBox.Show("Database error!");
            }
        }
        public static void Close()
        {
            try
            {
                AccessDbConnection.Close();
            }
            catch
            {
                MessageBox.Show("Database error!");
            }
        }
        public static void InitalizeAccessDb()
        {
            String AccessDbPath = Properties.Settings.Default.AccessDbPath;
            // Create connection string
            String ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AccessDbPath;

            // Check system settings if AccessDbPath property has a value and set "DatabaseConnectionString" variable if not propmt user to set a value
            if (AccessDbPath == "")
            {
                MessageBox.Show("Database connection path not set yet, please enter path of the AccessDB file path.");
                DatabaseSettingForm Form = new DatabaseSettingForm();
                Form.ShowDialog();

            }
            else
            {
                SetAccessDbPath(ConnString);
            }
            // Initalize connection and check connectivity to the local database
            try
            {
                AccessDbConnection = new OleDbConnection(ConnString);
                AccessDbConnection.Open();
                AccessDbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error");
            }
        }

        public static OleDbDataReader ExecuteReader(OleDbCommand Command)
        {
            try
            {
                OleDbDataReader Reader = Command.ExecuteReader();
                return Reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static void ExecuteNonQuery(OleDbCommand Command)
        {
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int ExecuteScalar(OleDbCommand Command)
        {
            try
            {
                int result = (int)Command.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check database path and tables\n" + "Error Message:" + ex.Message);
                return -1;
            }
        }

        public static bool CheckConnection()
        {
            try
            {
                AccessDbConnection.Open();
                AccessDbConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
