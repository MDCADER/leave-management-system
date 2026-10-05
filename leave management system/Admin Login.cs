using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;


namespace leave_management_system
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();

            

        }
        

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text;

            string connectionString =
                "Server=localhost;Port=3306;Database=leavemanagement;Uid=root;Pwd=;";


            string query = @"
SELECT Password 
FROM Admin 
WHERE Username = @Username";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Username", username);

                try
                {
                    con.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string storedPassword = result.ToString();

                        if (password == storedPassword)
                        {
                            MessageBox.Show("Login successful!");

                            Admin adminForm = new Admin();
                            adminForm.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Database error: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }
        private void chkshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpassword.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
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
