using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leave_management_system
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Login obj = new Employee_Login();
            obj.Show();
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login obj = new Admin_Login();
            obj.Show();
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "Do you really want to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Login obj = new Employee_Login();
            obj.Show();
        }
        private void btnAdmin_Click_1(object sender, EventArgs e)
        {   
            this.Hide();
            Admin_Login obj = new Admin_Login();
            obj.Show();
        }
    }
}
