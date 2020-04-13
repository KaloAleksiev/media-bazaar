namespace MediaBazaarTest
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnStocks = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbLogin.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(388, 105);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(346, 39);
            this.tbEmail.TabIndex = 0;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(388, 155);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(346, 39);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(60, 105);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 195);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Maroon;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.Location = new System.Drawing.Point(388, 238);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(348, 62);
            this.btnLogIn.TabIndex = 13;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = false;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnLogIn);
            this.gbLogin.Controls.Add(this.pictureBox1);
            this.gbLogin.Controls.Add(this.tbEmail);
            this.gbLogin.Controls.Add(this.tbPassword);
            this.gbLogin.Location = new System.Drawing.Point(18, 18);
            this.gbLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbLogin.Size = new System.Drawing.Size(814, 409);
            this.gbLogin.TabIndex = 2;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.lblRole);
            this.gbMain.Controls.Add(this.lblDate);
            this.gbMain.Controls.Add(this.btnStatistics);
            this.gbMain.Controls.Add(this.btnStocks);
            this.gbMain.Controls.Add(this.btnSchedule);
            this.gbMain.Controls.Add(this.lblWelcome);
            this.gbMain.Controls.Add(this.btnLogOut);
            this.gbMain.Controls.Add(this.btnEmployee);
            this.gbMain.Location = new System.Drawing.Point(18, 543);
            this.gbMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMain.Name = "gbMain";
            this.gbMain.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMain.Size = new System.Drawing.Size(814, 409);
            this.gbMain.TabIndex = 3;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Home Page";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(56, 123);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(149, 20);
            this.lblRole.TabIndex = 14;
            this.lblRole.Text = "Logged in as *Role*";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(50, 65);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 20);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "*Date*";
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.Maroon;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStatistics.Location = new System.Drawing.Point(378, 260);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStatistics.Size = new System.Drawing.Size(213, 69);
            this.btnStatistics.TabIndex = 12;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = false;
            // 
            // btnStocks
            // 
            this.btnStocks.BackColor = System.Drawing.Color.Maroon;
            this.btnStocks.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStocks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStocks.Location = new System.Drawing.Point(378, 172);
            this.btnStocks.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStocks.Size = new System.Drawing.Size(213, 69);
            this.btnStocks.TabIndex = 11;
            this.btnStocks.Text = "Stocks";
            this.btnStocks.UseVisualStyleBackColor = false;
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.Maroon;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSchedule.Location = new System.Drawing.Point(144, 260);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSchedule.Size = new System.Drawing.Size(213, 69);
            this.btnSchedule.TabIndex = 10;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(200, 65);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(135, 20);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "Welcome, *name*";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Maroon;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(622, 332);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Size = new System.Drawing.Size(177, 63);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Maroon;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmployee.Location = new System.Drawing.Point(144, 172);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmployee.Size = new System.Drawing.Size(213, 69);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 472);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(926, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "These 2 GroupBoxes can stay on top of each other, so that only one of them is vis" +
    "ible at a time.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 971);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.gbLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Label label1;
    }
}