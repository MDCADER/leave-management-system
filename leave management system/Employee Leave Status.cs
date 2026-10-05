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
    public partial class Employee_Leave_Status : Form
    {
        private int employeeID; // Specifying for a particular Employee
        public Employee_Leave_Status(int employeeID)    // Specifying for a particular Employee
        {
            InitializeComponent();
            this.employeeID = employeeID;   // Specifying for a particular Employee
        }
        private void Employee_Leave_Status_Load(object sender, EventArgs e)
        { // code to display details from Table Request in Dat view Grid 
            string connectionstring = "Server=localhost;Port=3306;Database=leavemanagement;Uid=root;Pwd=;";
            string sql = "Select * from Request Where EmployeeID ='" + employeeID + "'";
            MySqlConnection con = new MySqlConnection(connectionstring);
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            con.Open();
            dataadapter.Fill(ds);
            con.Close();

            dataGridView1.DataSource = ds.Tables[0];
        }
        private void btnSearch_Click(object sender, EventArgs e)
        { // Code fro serch  using a combox 
            string Leave = cmbLeave.Text;

            string connectionstring = "Server=localhost;Port=3306;Database=leavemanagement;Uid=root;Pwd=;";
            string sql = "SELECT * FROM Request where `Leave` = '" + Leave + "'";
            MySqlConnection con = new MySqlConnection(connectionstring);
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            con.Open();
            dataadapter.Fill(ds);
            con.Close();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {   // code to display details from Table Status in Data view Grid  where Admin rely for Leave request is saved 
            string connectionstring = "Server=localhost;Port=3306;Database=leavemanagement;Uid=root;Pwd=;";
            string sql = "Select * from State Where EmployeeID ='" + employeeID + "'";
            MySqlConnection con = new MySqlConnection(connectionstring);
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            con.Open();
            dataadapter.Fill(ds);
            con.Close();

            dataGridView2.DataSource = ds.Tables[0];
        }
        private void btnemployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Leave obj = new Employee_Leave(this.employeeID);
            obj.Show();
        }
        private void btnapply_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Request obj = new Employee_Request(this.employeeID);
            obj.Show();
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Homepage obj = new Homepage();
            obj.Show();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "Do you really want to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
