namespace leave_management_system
{
    partial class Admin_Login
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
            this.Loginpage = new System.Windows.Forms.GroupBox();
            this.chkshowpassword = new System.Windows.Forms.CheckBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.Loginpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Loginpage
            // 
            this.Loginpage.BackColor = System.Drawing.Color.Transparent;
            this.Loginpage.Controls.Add(this.chkshowpassword);
            this.Loginpage.Controls.Add(this.btnclear);
            this.Loginpage.Controls.Add(this.btnlogin);
            this.Loginpage.Controls.Add(this.txtpassword);
            this.Loginpage.Controls.Add(this.txtusername);
            this.Loginpage.Controls.Add(this.lblpassword);
            this.Loginpage.Controls.Add(this.lblusername);
            this.Loginpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginpage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Loginpage.Location = new System.Drawing.Point(97, 43);
            this.Loginpage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Loginpage.Name = "Loginpage";
            this.Loginpage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Loginpage.Size = new System.Drawing.Size(541, 341);
            this.Loginpage.TabIndex = 1;
            this.Loginpage.TabStop = false;
            this.Loginpage.Text = "Admin Login ";
            // 
            // chkshowpassword
            // 
            this.chkshowpassword.AutoSize = true;
            this.chkshowpassword.Font = new System.Drawing.Font("ROG Fonts", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkshowpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkshowpassword.Location = new System.Drawing.Point(146, 198);
            this.chkshowpassword.Name = "chkshowpassword";
            this.chkshowpassword.Size = new System.Drawing.Size(235, 26);
            this.chkshowpassword.TabIndex = 6;
            this.chkshowpassword.Text = "Show Password";
            this.chkshowpassword.UseVisualStyleBackColor = true;
            this.chkshowpassword.CheckedChanged += new System.EventHandler(this.chkshowpassword_CheckedChanged);
            // 
            // btnclear
            // 
            this.btnclear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnclear.Location = new System.Drawing.Point(330, 272);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(117, 44);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnlogin.Location = new System.Drawing.Point(70, 272);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(117, 44);
            this.btnlogin.TabIndex = 1;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(191, 143);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(294, 31);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(191, 93);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(294, 31);
            this.txtusername.TabIndex = 3;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("ROG Fonts", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpassword.Location = new System.Drawing.Point(30, 150);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(137, 22);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("ROG Fonts", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblusername.Location = new System.Drawing.Point(31, 102);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(137, 22);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "Username";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Firebrick;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Location = new System.Drawing.Point(671, 394);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(117, 44);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Admin_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.Loginpage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Login";
            this.Loginpage.ResumeLayout(false);
            this.Loginpage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Loginpage;
        private System.Windows.Forms.CheckBox chkshowpassword;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button btnexit;
    }
}