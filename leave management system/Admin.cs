using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace leave_management_system
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
            // SQL code for connection 
        MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=leavemanagement;Uid=root;Pwd=;");
        private void btnRegister_Click(object sender, EventArgs e)
        { // Code to insert Employee Deatils 
            try
            {
                int EmployeeID = int.Parse(txtID.Text);
                string EmployeeName = txtName.Text;
                DateTime DateOfBirth = dateTimePicker1.Value;
                string DOB = DateOfBirth.ToString("yyyy-MM-dd HH:mm:ss");
                string Gender;
                if (rbnMale.Checked)
                {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Female";
                }
                string JobTitle = txtJob.Text;
                string MemberState = cmbMember.Text;
                string Address = txtAddress.Text;
                int Age = int.Parse(txtAge.Text);
                string Telephone = txtNumber.Text;
                string Password = txtPassword.Text;
                int Annual= int.Parse(cmbannual.Text);
                int Causal = int.Parse(cmbcasual.Text);
                int Short = int.Parse(cmbshort.Text);

                string query_insert = "INSERT INTO Employee VALUES('" + EmployeeID + "','" + EmployeeName + "','" + DOB + "','" + Gender + "','" + JobTitle + "'," +
                    "'" + MemberState + "','" + Address + "','" + Age + "','" + Telephone + "','" + Password + "','" + Annual + "','" + Causal + "','" + Short + "')";
                MySqlCommand cnmd = new MySqlCommand(query_insert, con);
                con.Open();
                cnmd.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully...!", "Register Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void btnrequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Request obj = new Admin_Request();
            obj.Show();

        }
        private void btnhistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leave_History obj = new Leave_History();
            obj.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "Do you really want to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {

        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Homepage obj = new Homepage();
            obj.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        { // Code to Updating Employee Deatils 
                try
                {
                    int EmployeeID = int.Parse(txtID.Text);
                    string EmployeeName = txtName.Text;
                    DateTime DateOfBirth = dateTimePicker1.Value;
                    string DOB = DateOfBirth.ToString("yyyy-MM-dd HH:mm:ss");
                    string Gender;
                    if (rbnMale.Checked)
                    {
                        Gender = "Male";
                    }
                    else
                    {
                        Gender = "Female";
                    }
                    string JobTitle = txtJob.Text;
                    string MemberState = cmbMember.Text;
                    string Address = txtAddress.Text;
                    int Age = int.Parse(txtAge.Text);
                    string Telephone = txtNumber.Text;
                    string Password = txtPassword.Text;
                    int Annual = int.Parse(cmbannual.Text);
                    int Causal = int.Parse(cmbcasual.Text);
                    int Short = int.Parse(cmbshort.Text);

                    string query_update = "UPDATE Employee SET EmployeeName='" + EmployeeName + "',DateOfBirth='" + DOB + "',Gender='" + Gender + "',JobTitle='" + JobTitle + "',MemberState='" + MemberState + "'," +
                    "Address='" + Address + "',Age='" + Age + "',Telephone='" + Telephone + "',Password='" + Password + "',Annual='" + Annual + "',Causal='" + Causal + "',Short='" + Short + "'WHERE EmployeeID='"+ EmployeeID + "'";
                    MySqlCommand cnmd = new MySqlCommand(query_update, con);
                    con.Open();
                    cnmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully...!", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Code to Deleting Employee Deatils 
            try
            {
                int EmployeeID = int.Parse(txtID.Text);
                

                string query_delete = "DELETE FROM Employee WHERE EmployeeID='" + EmployeeID + "'";
                MySqlCommand cnmd = new MySqlCommand(query_delete, con);
                con.Open();
                cnmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully...!", "Deleting Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
