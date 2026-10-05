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

namespace leave_management_system
{
    public partial class Leave_History : Form
    {
        public Leave_History()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Validate Employee ID
            if (!int.TryParse(txtEmployeeID.Text.Trim(), out int employeeID))
            {
                MessageBox.Show(
                    "Please enter a valid Employee ID.",
                    "Invalid Employee ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Get selected leave type
            string Leave = cmbLeave.Text.Trim();

            // Check whether leave type is selected
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

            string sql =
                "SELECT * FROM State " + "WHERE EmployeeID = " + employeeID + " AND `Leave` = '" + Leave + "'";

            MySqlConnection con = new MySqlConnection(connectionstring);

            try
            {
                MySqlDataAdapter dataadapter =
                    new MySqlDataAdapter(sql, con);

                DataSet ds = new DataSet();

                con.Open();
                dataadapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                // Check whether any records were found
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No leave history found for Employee ID " + employeeID + " and Leave Type " + Leave + ".", "No Records Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
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
        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "Do you really want to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnrequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Request obj = new Admin_Request();
            obj.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin obj = new Admin();
            obj.Show();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string connectionstring = "Server=localhost;Port=3306;Database=leavemanagement;Uid=root;Pwd=;";
            string sql = "SELECT * FROM Request";
            MySqlConnection con = new MySqlConnection(connectionstring);
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            con.Open();
            dataadapter.Fill(ds);
            con.Close();

            dataGridView1.DataSource = ds.Tables[0];
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Homepage obj = new Homepage();
            obj.Show();
        }
    }
}
