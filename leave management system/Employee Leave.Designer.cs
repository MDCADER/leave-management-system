namespace leave_management_system
{
    partial class Employee_Leave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Leave));
            this.btnstatus = new System.Windows.Forms.Button();
            this.btnapply = new System.Windows.Forms.Button();
            this.btnemployee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMemberState = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAnnual = new System.Windows.Forms.Label();
            this.lblCausal = new System.Windows.Forms.Label();
            this.lblShort = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstatus
            // 
            this.btnstatus.BackColor = System.Drawing.Color.Chartreuse;
            this.btnstatus.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstatus.Location = new System.Drawing.Point(0, 339);
            this.btnstatus.Name = "btnstatus";
            this.btnstatus.Size = new System.Drawing.Size(155, 84);
            this.btnstatus.TabIndex = 2;
            this.btnstatus.Text = "Status";
            this.btnstatus.UseVisualStyleBackColor = false;
            this.btnstatus.Click += new System.EventHandler(this.btnstatus_Click);
            // 
            // btnapply
            // 
            this.btnapply.BackColor = System.Drawing.Color.Chartreuse;
            this.btnapply.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapply.Location = new System.Drawing.Point(0, 236);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(155, 84);
            this.btnapply.TabIndex = 1;
            this.btnapply.Text = "Apply Leave ";
            this.btnapply.UseVisualStyleBackColor = false;
            this.btnapply.Click += new System.EventHandler(this.btnapply_Click);
            // 
            // btnemployee
            // 
            this.btnemployee.BackColor = System.Drawing.Color.GreenYellow;
            this.btnemployee.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemployee.Location = new System.Drawing.Point(0, 136);
            this.btnemployee.Name = "btnemployee";
            this.btnemployee.Size = new System.Drawing.Size(165, 84);
            this.btnemployee.TabIndex = 0;
            this.btnemployee.Text = "Employee";
            this.btnemployee.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnstatus);
            this.panel1.Controls.Add(this.btnapply);
            this.panel1.Controls.Add(this.btnemployee);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 651);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(723, 41);
            this.label5.TabIndex = 11;
            this.label5.Text = "Welcome to Employee Leave Management ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(182, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Leaves Given ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(182, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Member State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(182, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Job Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(182, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "EmployeeID";
            // 
            // lblMemberState
            // 
            this.lblMemberState.AutoSize = true;
            this.lblMemberState.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMemberState.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMemberState.Location = new System.Drawing.Point(425, 349);
            this.lblMemberState.Name = "lblMemberState";
            this.lblMemberState.Size = new System.Drawing.Size(356, 24);
            this.lblMemberState.TabIndex = 16;
            this.lblMemberState.Text = "Pending,Permanent,Trainee";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblJobTitle.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblJobTitle.Location = new System.Drawing.Point(425, 296);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(109, 24);
            this.lblJobTitle.TabIndex = 15;
            this.lblJobTitle.Text = "Job Title";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblEmployeeName.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmployeeName.Location = new System.Drawing.Point(426, 182);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(204, 24);
            this.lblEmployeeName.TabIndex = 14;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblEmployeeID.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmployeeID.Location = new System.Drawing.Point(425, 125);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(145, 24);
            this.lblEmployeeID.TabIndex = 13;
            this.lblEmployeeID.Text = " ID Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(182, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Annual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(414, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Causal ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(651, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Short";
            // 
            // lblAnnual
            // 
            this.lblAnnual.AutoSize = true;
            this.lblAnnual.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAnnual.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAnnual.Location = new System.Drawing.Point(284, 476);
            this.lblAnnual.Name = "lblAnnual";
            this.lblAnnual.Size = new System.Drawing.Size(96, 24);
            this.lblAnnual.TabIndex = 25;
            this.lblAnnual.Text = "Annual";
            // 
            // lblCausal
            // 
            this.lblCausal.AutoSize = true;
            this.lblCausal.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCausal.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCausal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCausal.Location = new System.Drawing.Point(509, 476);
            this.lblCausal.Name = "lblCausal";
            this.lblCausal.Size = new System.Drawing.Size(97, 24);
            this.lblCausal.TabIndex = 26;
            this.lblCausal.Text = "Causal ";
            // 
            // lblShort
            // 
            this.lblShort.AutoSize = true;
            this.lblShort.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblShort.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShort.Location = new System.Drawing.Point(731, 476);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(74, 24);
            this.lblShort.TabIndex = 27;
            this.lblShort.Text = "Short";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(182, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 24);
            this.label10.TabIndex = 28;
            this.label10.Text = "Gender";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblGender.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGender.Location = new System.Drawing.Point(425, 236);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(98, 24);
            this.lblGender.TabIndex = 29;
            this.lblGender.Text = "Gender";
            this.lblGender.Click += new System.EventHandler(this.lblGender_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(735, 587);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(139, 40);
            this.btnexit.TabIndex = 55;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Aquamarine;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(168, 587);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(190, 42);
            this.btnback.TabIndex = 59;
            this.btnback.Text = "Back to Home";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Employee_Leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblShort);
            this.Controls.Add(this.lblCausal);
            this.Controls.Add(this.lblAnnual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMemberState);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee_Leave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Leave";
            this.Load += new System.EventHandler(this.Employee_Leave_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstatus;
        private System.Windows.Forms.Button btnapply;
        private System.Windows.Forms.Button btnemployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMemberState;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAnnual;
        private System.Windows.Forms.Label lblCausal;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnback;
    }
}