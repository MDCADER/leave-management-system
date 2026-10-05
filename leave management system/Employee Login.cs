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
    public partial class Employee_Login : Form
    {
        public Employee_Login()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=leavemanagement;Uid=root;Pwd=;");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string employeeID = txtEmployeeID.Text;
            string password = txtPassword.Text;

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Employee WHERE EmployeeID = '" + employeeID + "' AND Password = '" + password + "'", con);
            MySqlDataAdapter da = new  MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                MessageBox.Show("Employee Login", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Employee_Leave Obj = new Employee_Leave(int.Parse(employeeID));
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Logins credentials", "please check employee ID and Password and try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void chkShowpassword_CheckedChanged(object sender, EventArgs e)
        {

            if (chkShowpassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Clear();
            txtPassword.Clear();
        }
        private void btnExit_Click(object sender, EventArgs e)
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
    }
}
