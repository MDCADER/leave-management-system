namespace leave_management_system
{
    partial class Leave_History
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leave_History));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnhistory = new System.Windows.Forms.Button();
            this.btnrequest = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLeave = new System.Windows.Forms.ComboBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnhistory);
            this.panel1.Controls.Add(this.btnrequest);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 702);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnhistory
            // 
            this.btnhistory.BackColor = System.Drawing.Color.Chartreuse;
            this.btnhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhistory.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhistory.Location = new System.Drawing.Point(0, 290);
            this.btnhistory.Name = "btnhistory";
            this.btnhistory.Size = new System.Drawing.Size(149, 72);
            this.btnhistory.TabIndex = 3;
            this.btnhistory.Text = "History";
            this.btnhistory.UseVisualStyleBackColor = false;
            // 
            // btnrequest
            // 
            this.btnrequest.BackColor = System.Drawing.Color.Aquamarine;
            this.btnrequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrequest.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrequest.Location = new System.Drawing.Point(0, 198);
            this.btnrequest.Name = "btnrequest";
            this.btnrequest.Size = new System.Drawing.Size(138, 72);
            this.btnrequest.TabIndex = 2;
            this.btnrequest.Text = "Request";
            this.btnrequest.UseVisualStyleBackColor = false;
            this.btnrequest.Click += new System.EventHandler(this.btnrequest_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Aquamarine;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(0, 107);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(138, 72);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(158, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 416);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(727, 563);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 38);
            this.btnRefresh.TabIndex = 47;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(566, 563);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 38);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(384, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Leave Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "EmployeeID";
            // 
            // cmbLeave
            // 
            this.cmbLeave.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLeave.FormattingEnabled = true;
            this.cmbLeave.Items.AddRange(new object[] {
            "Annual",
            "Casual ",
            "Short"});
            this.cmbLeave.Location = new System.Drawing.Point(373, 570);
            this.cmbLeave.Name = "cmbLeave";
            this.cmbLeave.Size = new System.Drawing.Size(160, 28);
            this.cmbLeave.TabIndex = 43;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(161, 567);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(181, 27);
            this.txtEmployeeID.TabIndex = 42;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(799, 648);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(139, 40);
            this.btnexit.TabIndex = 54;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Aquamarine;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(174, 645);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(190, 42);
            this.btnback.TabIndex = 55;
            this.btnback.Text = "Back to Home";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Leave_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLeave);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Leave_History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave_History";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnhistory;
        private System.Windows.Forms.Button btnrequest;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLeave;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnback;
    }
}