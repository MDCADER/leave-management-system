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
    public partial class Employee_Request : Form
    {
        private int employeeID; // Specifying for a particular Employee
        public Employee_Request(int employeeID) // Specifying for a particular Employee
        {
            InitializeComponent();
            this.employeeID = employeeID; // Specifying for a particular Employee
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=leavemanagement;Uid=root;Pwd=;");
        private void Employee_Request_Load(object sender, EventArgs e)
        {   // Code for showing Emplyee details to be displayed in labels
            string query_Select = "Select * from Employee Where EmployeeID ='" + employeeID + "'";
            MySqlCommand cmd = new MySqlCommand(query_Select, con);
            con.Open();
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                lblEmployeeID.Text = r[0].ToString();
                lblEmployeeName.Text = r[1].ToString();
                lblJobTitle.Text = r[4].ToString();
                lblMemberState.Text = r[5].ToString();
                lblAnnual.Text = r[10].ToString();
                lblCausal.Text = r[11].ToString();
                lblShort.Text = r[12].ToString();

            }
            con.Close();
        }
        private void btnRequest_Click(object sender, EventArgs e)
        { // Code is divied into 2 variable to show case the Leave Funtion   
            if (AuthenticityRequest())
            {
                InsertRequest();
                ShowRequest();
            }
        }
        private bool AuthenticityRequest()
        {   // checking the Leave validity 
            string Leave = cmbLeave.Text;
            DateTime LeaveDate = dateTimePicker2.Value;
            DateTime CurrentDate = dateTimePicker1.Value;

            if (Leave == "Annual")
            {   // Annual leave can only be applied after checking between the dates for a 7 day Gap
                if (LeaveDate < CurrentDate.AddDays(7) || LeaveDate.Year != CurrentDate.Year)
                {
                    MessageBox.Show("Invalid annual leave request.");
                    return false;
                }
            }
            else if (Leave == "Casual")
            {
                // Casual leave can only be applied before starts time from morning 8 a.m. till evening 5 p.m.
                if (LeaveDate.Hour < 8 || LeaveDate.Hour > 17)
                {
                    MessageBox.Show("Invalid casual leave request.");
                    return false;
                }
            } 
            else if (Leave == "Short")
            {   
                // Short leave only for 1 hour and 30 minutes
                TimeSpan difference = LeaveDate - CurrentDate;

                if (difference.TotalMinutes != 90)
                {
                    MessageBox.Show("Short leave must be exactly 1 hour and 30 minutes.");
                    return false;
                }
            }
            return true;
        }
        private void InsertRequest() 
        { // Code is seprated due to different Table named Request
            int EmployeeID = int.Parse(lblEmployeeID.Text);
            string EmployeeName = lblEmployeeName.Text;
            string JobTitle = lblJobTitle.Text;
            string MemberState = lblMemberState.Text;
            string Leave = cmbLeave.Text;
            DateTime LeaveDate = dateTimePicker2.Value;
            string leaveDateValue = LeaveDate.ToString("yyyy-MM-dd HH:mm:ss");
            DateTime CurrentDate = dateTimePicker1.Value;
            string currentDateValue = CurrentDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Reason = txtReason.Text;

            string query_check = "SELECT COUNT(*) FROM Request WHERE EmployeeID = '" + EmployeeID + "' AND `Leave` = '" + Leave + "'";
            MySqlCommand cmd_check = new MySqlCommand(query_check, con);
            con.Open();
            int count = Convert.ToInt32(cmd_check.ExecuteScalar());
            con.Close();

            if (count == 0)
            { //Code insert into Table Request aaprt fromEmployee Table 
                string query_insert = "INSERT INTO Request VALUES('" + EmployeeID + "','" + EmployeeName + "','" + JobTitle + "'," +
                    "'" + MemberState + "','" + Leave + "','" + leaveDateValue + "','" + currentDateValue + "','" + Reason + "')";
                MySqlCommand cmd = new MySqlCommand(query_insert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Request", "Request Submiited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }  
        }
        private void ShowRequest()
        {
            string leave = cmbLeave.Text;

            if (leave == "Annual")
            {
                int annual = int.Parse(lblAnnual.Text) - 1;
                lblAnnual.Text = annual.ToString();
                // Update Annual leave in database
                string query_update = "UPDATE Employee SET Annual = '" + annual + "' WHERE EmployeeID = '" + employeeID + "'";
                MySqlCommand cmd = new MySqlCommand(query_update, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else if (leave == "Casual")
            {
                int casual = int.Parse(lblCausal.Text) - 1;
                lblCausal.Text = casual.ToString();
                // Update Casual leave in database
                string query_update = "UPDATE Employee SET Causal = '" + casual + "' WHERE EmployeeID = '" + employeeID + "'";
                MySqlCommand cmd = new MySqlCommand(query_update, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else if (leave == "Short")
            {
                int Short = int.Parse(lblShort.Text) - 1;
                lblShort.Text = Short.ToString();
                // Update Short leave in database
                string query_update = "UPDATE Employee SET Short = '" + Short + "' WHERE EmployeeID = '" + employeeID + "'";
                MySqlCommand cmd = new MySqlCommand(query_update, con);
                con.Open();
                cmd.ExecuteNonQuery();
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
        private void btnapply_Click(object sender, EventArgs e)
        {
        }
        private void btnstatus_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Leave_Status obj = new Employee_Leave_Status(this.employeeID);
            obj.Show();
        }
        private void btnemployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Leave obj = new Employee_Leave(this.employeeID);
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
