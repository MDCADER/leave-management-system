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
    public partial class Employee_Leave : Form
    {
        private int employeeID; // Specifying for a particular Employee
        public Employee_Leave(int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID; // Specifying for a particular Employee
        }
        private void Employee_Leave_Load(object sender, EventArgs e)
        {    // Code for SQL to retrieve Employee Details to showing in Labels  
            MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=leavemanagement;Uid=root;Pwd=;");
            string query_Select = "Select * from Employee Where EmployeeID ='" + employeeID + "'";
            MySqlCommand cmd= new MySqlCommand(query_Select, con);
            con.Open();
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read()) 
            {
                lblEmployeeID.Text = r[0].ToString();
                lblEmployeeName.Text = r[1].ToString();
                lblGender.Text = r[3].ToString();
                lblJobTitle.Text = r[4].ToString();
                lblMemberState.Text = r[5].ToString();
                lblAnnual.Text = r[10].ToString();
                lblCausal.Text = r[11].ToString();
                lblShort.Text = r[12].ToString();
                
            }
            con.Close();
        }
        private void btnapply_Click(object sender, EventArgs e)
        {
            Employee_Request Obj = new Employee_Request(this.employeeID);
            Obj.Show();
            this.Hide();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "Do you really want to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Homepage obj = new Homepage();
            obj.Show();
        }
        private void btnstatus_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Leave_Status obj = new Employee_Leave_Status(this.employeeID);
            obj.Show();
        } //To show carry Specified Employee to next interface 

        private void lblGender_Click(object sender, EventArgs e)
        {

        }
    }
}
