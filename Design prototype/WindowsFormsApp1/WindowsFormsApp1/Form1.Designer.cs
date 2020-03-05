namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pLogin = new System.Windows.Forms.Panel();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btlogout = new System.Windows.Forms.Button();
            this.btStock = new System.Windows.Forms.Button();
            this.btStatistics = new System.Windows.Forms.Button();
            this.btEmployee = new System.Windows.Forms.Button();
            this.pEmplyee = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btAddToSchedule = new System.Windows.Forms.Button();
            this.dtpShiftDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbSupervisor = new System.Windows.Forms.TextBox();
            this.tbWorkLocation = new System.Windows.Forms.TextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.btSearchEmployee = new System.Windows.Forms.Button();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.tbStartDay = new System.Windows.Forms.TextBox();
            this.btAddEmployee = new System.Windows.Forms.Button();
            this.tbFunction = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pStatistics = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btViewStatsOverall = new System.Windows.Forms.Button();
            this.btViewDepartmentStats = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDepartmentStats = new System.Windows.Forms.ComboBox();
            this.btViewEmployeeStats = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNameStats = new System.Windows.Forms.TextBox();
            this.pStock = new System.Windows.Forms.Panel();
            this.btViewStockEmployee = new System.Windows.Forms.Button();
            this.btSendRestockRequest = new System.Windows.Forms.Button();
            this.tbItemIDRestock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btCheckAvailability = new System.Windows.Forms.Button();
            this.tbItemID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pLogin.SuspendLayout();
            this.pEmplyee.SuspendLayout();
            this.pStatistics.SuspendLayout();
            this.pStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.Color.White;
            this.pLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pLogin.Controls.Add(this.btLogin);
            this.pLogin.Controls.Add(this.tbPassword);
            this.pLogin.Controls.Add(this.tbUsername);
            this.pLogin.Location = new System.Drawing.Point(13, 92);
            this.pLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(280, 289);
            this.pLogin.TabIndex = 0;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.Maroon;
            this.btLogin.Font = new System.Drawing.Font("Codec Cold Trial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btLogin.Location = new System.Drawing.Point(18, 148);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(234, 35);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(104, 109);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(148, 33);
            this.tbPassword.TabIndex = 1;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(104, 62);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(148, 33);
            this.tbUsername.TabIndex = 0;
            // 
            // btlogout
            // 
            this.btlogout.BackColor = System.Drawing.Color.Maroon;
            this.btlogout.Font = new System.Drawing.Font("Codec Cold Trial", 20F);
            this.btlogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btlogout.Location = new System.Drawing.Point(1105, 25);
            this.btlogout.Margin = new System.Windows.Forms.Padding(1);
            this.btlogout.Name = "btlogout";
            this.btlogout.Padding = new System.Windows.Forms.Padding(1);
            this.btlogout.Size = new System.Drawing.Size(228, 52);
            this.btlogout.TabIndex = 6;
            this.btlogout.Text = "LOG OUT";
            this.btlogout.UseVisualStyleBackColor = false;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // btStock
            // 
            this.btStock.BackColor = System.Drawing.Color.Maroon;
            this.btStock.Font = new System.Drawing.Font("Codec Cold Trial", 20F);
            this.btStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btStock.Location = new System.Drawing.Point(733, 25);
            this.btStock.Name = "btStock";
            this.btStock.Size = new System.Drawing.Size(365, 52);
            this.btStock.TabIndex = 5;
            this.btStock.Text = "STOCK CONTROL";
            this.btStock.UseVisualStyleBackColor = false;
            this.btStock.Click += new System.EventHandler(this.btStock_Click);
            // 
            // btStatistics
            // 
            this.btStatistics.BackColor = System.Drawing.Color.Maroon;
            this.btStatistics.Font = new System.Drawing.Font("Codec Cold Trial", 20F);
            this.btStatistics.ForeColor = System.Drawing.SystemColors.Control;
            this.btStatistics.Location = new System.Drawing.Point(477, 26);
            this.btStatistics.Margin = new System.Windows.Forms.Padding(1);
            this.btStatistics.Name = "btStatistics";
            this.btStatistics.Padding = new System.Windows.Forms.Padding(1);
            this.btStatistics.Size = new System.Drawing.Size(245, 51);
            this.btStatistics.TabIndex = 4;
            this.btStatistics.Text = "STATISTICS";
            this.btStatistics.UseVisualStyleBackColor = false;
            this.btStatistics.Click += new System.EventHandler(this.btStatistics_Click);
            // 
            // btEmployee
            // 
            this.btEmployee.BackColor = System.Drawing.Color.Maroon;
            this.btEmployee.Font = new System.Drawing.Font("Codec Cold Trial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEmployee.Location = new System.Drawing.Point(223, 25);
            this.btEmployee.Margin = new System.Windows.Forms.Padding(10);
            this.btEmployee.Name = "btEmployee";
            this.btEmployee.Padding = new System.Windows.Forms.Padding(2);
            this.btEmployee.Size = new System.Drawing.Size(244, 51);
            this.btEmployee.TabIndex = 3;
            this.btEmployee.Text = "EMPLOYEE";
            this.btEmployee.UseVisualStyleBackColor = false;
            this.btEmployee.Click += new System.EventHandler(this.btEmployee_Click);
            // 
            // pEmplyee
            // 
            this.pEmplyee.BackColor = System.Drawing.Color.White;
            this.pEmplyee.Controls.Add(this.label16);
            this.pEmplyee.Controls.Add(this.label15);
            this.pEmplyee.Controls.Add(this.label14);
            this.pEmplyee.Controls.Add(this.label13);
            this.pEmplyee.Controls.Add(this.label12);
            this.pEmplyee.Controls.Add(this.label11);
            this.pEmplyee.Controls.Add(this.label10);
            this.pEmplyee.Controls.Add(this.label9);
            this.pEmplyee.Controls.Add(this.label8);
            this.pEmplyee.Controls.Add(this.label2);
            this.pEmplyee.Controls.Add(this.textBox1);
            this.pEmplyee.Controls.Add(this.label1);
            this.pEmplyee.Controls.Add(this.comboBox1);
            this.pEmplyee.Controls.Add(this.btAddToSchedule);
            this.pEmplyee.Controls.Add(this.dtpShiftDate);
            this.pEmplyee.Controls.Add(this.label4);
            this.pEmplyee.Controls.Add(this.tbSalary);
            this.pEmplyee.Controls.Add(this.tbSupervisor);
            this.pEmplyee.Controls.Add(this.tbWorkLocation);
            this.pEmplyee.Controls.Add(this.tbEmailAddress);
            this.pEmplyee.Controls.Add(this.btSearchEmployee);
            this.pEmplyee.Controls.Add(this.tbPhoneNumber);
            this.pEmplyee.Controls.Add(this.cmbDepartment);
            this.pEmplyee.Controls.Add(this.tbStartDay);
            this.pEmplyee.Controls.Add(this.btAddEmployee);
            this.pEmplyee.Controls.Add(this.tbFunction);
            this.pEmplyee.Controls.Add(this.tbAddress);
            this.pEmplyee.Controls.Add(this.tbName);
            this.pEmplyee.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pEmplyee.Location = new System.Drawing.Point(300, 97);
            this.pEmplyee.Name = "pEmplyee";
            this.pEmplyee.Size = new System.Drawing.Size(941, 289);
            this.pEmplyee.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AllowDrop = true;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Codec Cold Trial", 11F);
            this.label16.Location = new System.Drawing.Point(233, 66);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(179, 25);
            this.label16.TabIndex = 137;
            this.label16.Text = "EMAIL ADDRESS";
            // 
            // label15
            // 
            this.label15.AllowDrop = true;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Codec Cold Trial", 11F);
            this.label15.Location = new System.Drawing.Point(289, 191);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 25);
            this.label15.TabIndex = 136;
            this.label15.Text = "SALARY";
            // 
            // label14
            // 
            this.label14.AllowDrop = true;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Codec Cold Trial", 11F);
            this.label14.Location = new System.Drawing.Point(263, 149);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 25);
            this.label14.TabIndex = 135;
            this.label14.Text = "SUPERVISOR";
            // 
            // label13
            // 
            this.label13.AllowDrop = true;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Codec Cold Trial", 11F);
            this.label13.Location = new System.Drawing.Point(221, 108);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(197, 25);
            this.label13.TabIndex = 134;
            this.label13.Text = "WORK LOCATION";
            // 
            // label12
            // 
            this.label12.AllowDrop = true;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Codec Cold Trial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(215, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 25);
            this.label12.TabIndex = 133;
            this.label12.Text = "PHONE NUMBER";
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Codec Cold Trial", 11F);
            this.label11.Location = new System.Drawing.Point(6, 188);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 25);
            this.label11.TabIndex = 132;
            this.label11.Text = "START DATE";
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Codec Cold Trial", 11F);
            this.label10.Location = new System.Drawing.Point(13, 143);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 25);
            this.label10.TabIndex = 131;
            this.label10.Text = "FUNCTION";
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Codec Cold Trial", 11F);
            this.label9.Location = new System.Drawing.Point(-5, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 25);
            this.label9.TabIndex = 130;
            this.label9.Text = "DEPARTMENT";
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Codec Cold Trial", 11F);
            this.label8.Location = new System.Drawing.Point(12, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 129;
            this.label8.Text = "ADDRESS";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Codec Cold Trial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 128;
            this.label2.Text = "NAME";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(582, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 33);
            this.textBox1.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Codec Cold Trial", 11F);
            this.label1.Location = new System.Drawing.Point(511, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 126;
            this.label1.Text = "SHIFT";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(582, 68);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(74, 35);
            this.comboBox1.TabIndex = 125;
            // 
            // btAddToSchedule
            // 
            this.btAddToSchedule.BackColor = System.Drawing.Color.Maroon;
            this.btAddToSchedule.Font = new System.Drawing.Font("Codec Cold Trial", 12F, System.Drawing.FontStyle.Bold);
            this.btAddToSchedule.ForeColor = System.Drawing.SystemColors.Control;
            this.btAddToSchedule.Location = new System.Drawing.Point(666, 67);
            this.btAddToSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAddToSchedule.Name = "btAddToSchedule";
            this.btAddToSchedule.Size = new System.Drawing.Size(239, 35);
            this.btAddToSchedule.TabIndex = 122;
            this.btAddToSchedule.Text = "Add to schedule";
            this.btAddToSchedule.UseVisualStyleBackColor = false;
            // 
            // dtpShiftDate
            // 
            this.dtpShiftDate.Font = new System.Drawing.Font("Coarse Rounded", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShiftDate.Location = new System.Drawing.Point(666, 23);
            this.dtpShiftDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpShiftDate.Name = "dtpShiftDate";
            this.dtpShiftDate.Size = new System.Drawing.Size(239, 32);
            this.dtpShiftDate.TabIndex = 124;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Codec Cold Trial", 11F);
            this.label4.Location = new System.Drawing.Point(511, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 123;
            this.label4.Text = "NAME";
            // 
            // tbSalary
            // 
            this.tbSalary.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbSalary.Location = new System.Drawing.Point(422, 184);
            this.tbSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(47, 33);
            this.tbSalary.TabIndex = 121;
            // 
            // tbSupervisor
            // 
            this.tbSupervisor.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbSupervisor.Location = new System.Drawing.Point(422, 141);
            this.tbSupervisor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSupervisor.Name = "tbSupervisor";
            this.tbSupervisor.Size = new System.Drawing.Size(47, 33);
            this.tbSupervisor.TabIndex = 120;
            // 
            // tbWorkLocation
            // 
            this.tbWorkLocation.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbWorkLocation.Location = new System.Drawing.Point(422, 101);
            this.tbWorkLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWorkLocation.Name = "tbWorkLocation";
            this.tbWorkLocation.Size = new System.Drawing.Size(47, 33);
            this.tbWorkLocation.TabIndex = 119;
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbEmailAddress.Location = new System.Drawing.Point(422, 59);
            this.tbEmailAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(47, 33);
            this.tbEmailAddress.TabIndex = 118;
            // 
            // btSearchEmployee
            // 
            this.btSearchEmployee.BackColor = System.Drawing.Color.Maroon;
            this.btSearchEmployee.Font = new System.Drawing.Font("Codec Cold Trial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchEmployee.ForeColor = System.Drawing.SystemColors.Control;
            this.btSearchEmployee.Location = new System.Drawing.Point(694, 112);
            this.btSearchEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSearchEmployee.Name = "btSearchEmployee";
            this.btSearchEmployee.Size = new System.Drawing.Size(163, 35);
            this.btSearchEmployee.TabIndex = 117;
            this.btSearchEmployee.Text = "Search";
            this.btSearchEmployee.UseVisualStyleBackColor = false;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbPhoneNumber.Location = new System.Drawing.Point(422, 15);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(47, 33);
            this.tbPhoneNumber.TabIndex = 116;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(142, 101);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(73, 35);
            this.cmbDepartment.TabIndex = 115;
            // 
            // tbStartDay
            // 
            this.tbStartDay.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbStartDay.Location = new System.Drawing.Point(140, 184);
            this.tbStartDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbStartDay.Name = "tbStartDay";
            this.tbStartDay.Size = new System.Drawing.Size(75, 33);
            this.tbStartDay.TabIndex = 114;
            // 
            // btAddEmployee
            // 
            this.btAddEmployee.BackColor = System.Drawing.Color.Maroon;
            this.btAddEmployee.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.btAddEmployee.ForeColor = System.Drawing.SystemColors.Control;
            this.btAddEmployee.Location = new System.Drawing.Point(89, 231);
            this.btAddEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAddEmployee.Name = "btAddEmployee";
            this.btAddEmployee.Size = new System.Drawing.Size(329, 35);
            this.btAddEmployee.TabIndex = 113;
            this.btAddEmployee.Text = "Add";
            this.btAddEmployee.UseVisualStyleBackColor = false;
            // 
            // tbFunction
            // 
            this.tbFunction.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbFunction.Location = new System.Drawing.Point(142, 140);
            this.tbFunction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFunction.Name = "tbFunction";
            this.tbFunction.Size = new System.Drawing.Size(73, 33);
            this.tbFunction.TabIndex = 112;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbAddress.Location = new System.Drawing.Point(142, 59);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(73, 33);
            this.tbAddress.TabIndex = 111;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbName.Location = new System.Drawing.Point(140, 15);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(71, 33);
            this.tbName.TabIndex = 110;
            // 
            // pStatistics
            // 
            this.pStatistics.BackColor = System.Drawing.Color.White;
            this.pStatistics.Controls.Add(this.listBox1);
            this.pStatistics.Controls.Add(this.btViewStatsOverall);
            this.pStatistics.Controls.Add(this.btViewDepartmentStats);
            this.pStatistics.Controls.Add(this.label6);
            this.pStatistics.Controls.Add(this.cmbDepartmentStats);
            this.pStatistics.Controls.Add(this.btViewEmployeeStats);
            this.pStatistics.Controls.Add(this.label5);
            this.pStatistics.Controls.Add(this.tbNameStats);
            this.pStatistics.Location = new System.Drawing.Point(13, 395);
            this.pStatistics.Name = "pStatistics";
            this.pStatistics.Size = new System.Drawing.Size(696, 228);
            this.pStatistics.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(75, 161);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(510, 29);
            this.listBox1.TabIndex = 42;
            // 
            // btViewStatsOverall
            // 
            this.btViewStatsOverall.BackColor = System.Drawing.Color.Maroon;
            this.btViewStatsOverall.Font = new System.Drawing.Font("Codec Cold Trial", 12F, System.Drawing.FontStyle.Bold);
            this.btViewStatsOverall.ForeColor = System.Drawing.SystemColors.Control;
            this.btViewStatsOverall.Location = new System.Drawing.Point(584, 68);
            this.btViewStatsOverall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btViewStatsOverall.Name = "btViewStatsOverall";
            this.btViewStatsOverall.Size = new System.Drawing.Size(99, 54);
            this.btViewStatsOverall.TabIndex = 41;
            this.btViewStatsOverall.Text = "View statistics overall";
            this.btViewStatsOverall.UseVisualStyleBackColor = false;
            // 
            // btViewDepartmentStats
            // 
            this.btViewDepartmentStats.BackColor = System.Drawing.Color.Maroon;
            this.btViewDepartmentStats.Font = new System.Drawing.Font("Codec Cold Trial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewDepartmentStats.ForeColor = System.Drawing.SystemColors.Control;
            this.btViewDepartmentStats.Location = new System.Drawing.Point(342, 51);
            this.btViewDepartmentStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btViewDepartmentStats.Name = "btViewDepartmentStats";
            this.btViewDepartmentStats.Size = new System.Drawing.Size(234, 48);
            this.btViewDepartmentStats.TabIndex = 40;
            this.btViewDepartmentStats.Text = "View department statistics";
            this.btViewDepartmentStats.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Codec Cold Trial", 11F);
            this.label6.Location = new System.Drawing.Point(8, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "DEPARTMENT";
            // 
            // cmbDepartmentStats
            // 
            this.cmbDepartmentStats.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.cmbDepartmentStats.FormattingEnabled = true;
            this.cmbDepartmentStats.Location = new System.Drawing.Point(150, 101);
            this.cmbDepartmentStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDepartmentStats.Name = "cmbDepartmentStats";
            this.cmbDepartmentStats.Size = new System.Drawing.Size(180, 35);
            this.cmbDepartmentStats.TabIndex = 38;
            // 
            // btViewEmployeeStats
            // 
            this.btViewEmployeeStats.BackColor = System.Drawing.Color.Maroon;
            this.btViewEmployeeStats.Font = new System.Drawing.Font("Codec Cold Trial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewEmployeeStats.ForeColor = System.Drawing.SystemColors.Control;
            this.btViewEmployeeStats.Location = new System.Drawing.Point(342, 107);
            this.btViewEmployeeStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btViewEmployeeStats.Name = "btViewEmployeeStats";
            this.btViewEmployeeStats.Size = new System.Drawing.Size(234, 35);
            this.btViewEmployeeStats.TabIndex = 36;
            this.btViewEmployeeStats.Text = "View statistics";
            this.btViewEmployeeStats.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Codec Cold Trial", 11F);
            this.label5.Location = new System.Drawing.Point(71, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "NAME";
            // 
            // tbNameStats
            // 
            this.tbNameStats.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbNameStats.Location = new System.Drawing.Point(148, 53);
            this.tbNameStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNameStats.Name = "tbNameStats";
            this.tbNameStats.Size = new System.Drawing.Size(180, 33);
            this.tbNameStats.TabIndex = 35;
            // 
            // pStock
            // 
            this.pStock.BackColor = System.Drawing.Color.White;
            this.pStock.Controls.Add(this.btViewStockEmployee);
            this.pStock.Controls.Add(this.btSendRestockRequest);
            this.pStock.Controls.Add(this.tbItemIDRestock);
            this.pStock.Controls.Add(this.label7);
            this.pStock.Controls.Add(this.btCheckAvailability);
            this.pStock.Controls.Add(this.tbItemID);
            this.pStock.Controls.Add(this.label3);
            this.pStock.Location = new System.Drawing.Point(717, 395);
            this.pStock.Name = "pStock";
            this.pStock.Size = new System.Drawing.Size(524, 228);
            this.pStock.TabIndex = 9;
            // 
            // btViewStockEmployee
            // 
            this.btViewStockEmployee.BackColor = System.Drawing.Color.Maroon;
            this.btViewStockEmployee.Font = new System.Drawing.Font("Codec Cold Trial", 12F, System.Drawing.FontStyle.Bold);
            this.btViewStockEmployee.ForeColor = System.Drawing.SystemColors.Control;
            this.btViewStockEmployee.Location = new System.Drawing.Point(295, 110);
            this.btViewStockEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btViewStockEmployee.Name = "btViewStockEmployee";
            this.btViewStockEmployee.Size = new System.Drawing.Size(182, 37);
            this.btViewStockEmployee.TabIndex = 26;
            this.btViewStockEmployee.Text = "View stock";
            this.btViewStockEmployee.UseVisualStyleBackColor = false;
            // 
            // btSendRestockRequest
            // 
            this.btSendRestockRequest.BackColor = System.Drawing.Color.Maroon;
            this.btSendRestockRequest.Font = new System.Drawing.Font("Codec Cold Trial", 12F, System.Drawing.FontStyle.Bold);
            this.btSendRestockRequest.ForeColor = System.Drawing.Color.White;
            this.btSendRestockRequest.Location = new System.Drawing.Point(26, 161);
            this.btSendRestockRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSendRestockRequest.Name = "btSendRestockRequest";
            this.btSendRestockRequest.Size = new System.Drawing.Size(451, 51);
            this.btSendRestockRequest.TabIndex = 29;
            this.btSendRestockRequest.Text = "Send restock request";
            this.btSendRestockRequest.UseVisualStyleBackColor = false;
            // 
            // tbItemIDRestock
            // 
            this.tbItemIDRestock.Location = new System.Drawing.Point(125, 121);
            this.tbItemIDRestock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbItemIDRestock.Name = "tbItemIDRestock";
            this.tbItemIDRestock.Size = new System.Drawing.Size(153, 26);
            this.tbItemIDRestock.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Codec Cold Trial", 11F);
            this.label7.Location = new System.Drawing.Point(22, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Item ID:";
            // 
            // btCheckAvailability
            // 
            this.btCheckAvailability.BackColor = System.Drawing.Color.Maroon;
            this.btCheckAvailability.Font = new System.Drawing.Font("Codec Cold Trial", 12F, System.Drawing.FontStyle.Bold);
            this.btCheckAvailability.ForeColor = System.Drawing.Color.White;
            this.btCheckAvailability.Location = new System.Drawing.Point(295, 60);
            this.btCheckAvailability.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCheckAvailability.Name = "btCheckAvailability";
            this.btCheckAvailability.Size = new System.Drawing.Size(182, 35);
            this.btCheckAvailability.TabIndex = 25;
            this.btCheckAvailability.Text = "Check availability";
            this.btCheckAvailability.UseVisualStyleBackColor = false;
            // 
            // tbItemID
            // 
            this.tbItemID.Location = new System.Drawing.Point(125, 60);
            this.tbItemID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbItemID.Name = "tbItemID";
            this.tbItemID.Size = new System.Drawing.Size(153, 26);
            this.tbItemID.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Codec Cold Trial", 11F);
            this.label3.Location = new System.Drawing.Point(22, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Item ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(58, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 92);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1423, 675);
            this.Controls.Add(this.pStock);
            this.Controls.Add(this.pStatistics);
            this.Controls.Add(this.pEmplyee);
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.btEmployee);
            this.Controls.Add(this.btStatistics);
            this.Controls.Add(this.btStock);
            this.Controls.Add(this.btlogout);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.pEmplyee.ResumeLayout(false);
            this.pEmplyee.PerformLayout();
            this.pStatistics.ResumeLayout(false);
            this.pStatistics.PerformLayout();
            this.pStock.ResumeLayout(false);
            this.pStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btStock;
        private System.Windows.Forms.Button btStatistics;
        private System.Windows.Forms.Button btEmployee;
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Panel pEmplyee;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btAddToSchedule;
        private System.Windows.Forms.DateTimePicker dtpShiftDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbSupervisor;
        private System.Windows.Forms.TextBox tbWorkLocation;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.Button btSearchEmployee;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.TextBox tbStartDay;
        private System.Windows.Forms.Button btAddEmployee;
        private System.Windows.Forms.TextBox tbFunction;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel pStatistics;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btViewStatsOverall;
        private System.Windows.Forms.Button btViewDepartmentStats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDepartmentStats;
        private System.Windows.Forms.Button btViewEmployeeStats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNameStats;
        private System.Windows.Forms.Panel pStock;
        private System.Windows.Forms.Button btViewStockEmployee;
        private System.Windows.Forms.Button btSendRestockRequest;
        private System.Windows.Forms.TextBox tbItemIDRestock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCheckAvailability;
        private System.Windows.Forms.TextBox tbItemID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

