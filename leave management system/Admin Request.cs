using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace leave_management_system
{
    public partial class Admin_Request : Form
    {
        public Admin_Request()
        {
            InitializeComponent();
        }
        public void DataGrid()
        {
            string connectionstring = "Server = localhost; Port = 3306; Database = leavemanagement; Uid = root; Pwd =; ";
            string sql = "SELECT * FROM Request";
            MySqlConnection con = new MySqlConnection(connectionstring);
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            con.Open();
            dataadapter.Fill(ds);
            con.Close();

            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Admin_Request_Load(object sender, EventArgs e)
        {
            DataGrid();
        }
        public void SearchemployeeID()
        {
            // Check Employee ID is entered
            if (!int.TryParse(txtEmployeeID.Text.Trim(), out int employeeID))
            {
                MessageBox.Show(
                    "Please enter a valid Employee ID.",
                    "Invalid Employee ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string Leave = cmbLeave.Text.Trim();

            // Check leave type is selected
            if (string.IsNullOrEmpty(Leave))
            {
                MessageBox.Show(
                    "Please select a leave type.",
                    "Leave Type Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            
            string connectionstring =
                "Server=localhost;Port=3306;Database=leavemanagement;Uid=root;Pwd=;";

            string sql = "SELECT * FROM Request " + "WHERE EmployeeID = " + employeeID + " AND `Leave` = '" + Leave + "'";

            MySqlConnection con = new MySqlConnection(connectionstring);

            try
            {
                // Search and display request
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, con);
                DataSet ds = new DataSet();

                con.Open();
                dataadapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                // Check for request 
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No leave request found for Employee ID " + employeeID + " and Leave Type " + Leave + ".", "No Request Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    txtLeaveDate.Clear();
                    txtCurrentDate.Clear();

                    return;
                }

                // Get the first matching request
                DataRow row = ds.Tables[0].Rows[0];

                txtLeaveDate.Text =
                    Convert.ToDateTime(row[5]).ToString("yyyy-MM-dd HH:mm:ss");

                txtCurrentDate.Text =
                    Convert.ToDateTime(row[6]).ToString("yyyy-MM-dd HH:mm:ss");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error while searching:\n\n" + ex.Message,
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchemployeeID();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataGrid();
        }
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            string connectionstring = "Server=localhost;Port=3306;Database=leavemanagement;Uid=root;Pwd=;";
            MySqlConnection con = new MySqlConnection(connectionstring);
            try
            {
                int EmployeeID = int.Parse(txtEmployeeID.Text);
                string Leave = cmbLeave.Text;
                string CurrentDate = txtCurrentDate.Text;
                string LeaveDate = txtLeaveDate.Text;
                string State = cmbState.Text;

                string query_insert = "INSERT INTO State VALUES('" + EmployeeID + "','"+ Leave + "','"+ CurrentDate + "','"+ LeaveDate + "','"+ State + "')";
                MySqlCommand cnmd = new MySqlCommand(query_insert, con);
                con.Open();
                cnmd.ExecuteNonQuery();
                MessageBox.Show("Request Submitted Successfully...!", "Employee Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "Do you really want to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin obj = new Admin();
            obj.Show();
        }
        private void btnhistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leave_History obj = new Leave_History();
            obj.Show();
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Homepage obj = new Homepage();
            obj.Show();
        }
    }
}
