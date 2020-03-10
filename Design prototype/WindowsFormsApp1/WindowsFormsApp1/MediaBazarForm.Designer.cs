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
            this.pLogin.Location = new System.Drawing.Point(9, 60);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(187, 188);
            this.pLogin.TabIndex = 0;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.Maroon;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btLogin.Location = new System.Drawing.Point(12, 96);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(156, 23);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(69, 71);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 26);
            this.tbPassword.TabIndex = 1;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(69, 40);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 26);
            this.tbUsername.TabIndex = 0;
            // 
            // btlogout
            // 
            this.btlogout.BackColor = System.Drawing.Color.Maroon;
            this.btlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btlogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btlogout.Location = new System.Drawing.Point(737, 16);
            this.btlogout.Margin = new System.Windows.Forms.Padding(1);
            this.btlogout.Name = "btlogout";
            this.btlogout.Padding = new System.Windows.Forms.Padding(1);
            this.btlogout.Size = new System.Drawing.Size(152, 34);
            this.btlogout.TabIndex = 6;
            this.btlogout.Text = "LOG OUT";
            this.btlogout.UseVisualStyleBackColor = false;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // btStock
            // 
            this.btStock.BackColor = System.Drawing.Color.Maroon;
            this.btStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btStock.Location = new System.Drawing.Point(489, 16);
            this.btStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btStock.Name = "btStock";
            this.btStock.Size = new System.Drawing.Size(243, 34);
            this.btStock.TabIndex = 5;
            this.btStock.Text = "STOCK CONTROL";
            this.btStock.UseVisualStyleBackColor = false;
            this.btStock.Click += new System.EventHandler(this.btStock_Click);
            // 
            // btStatistics
            // 
            this.btStatistics.BackColor = System.Drawing.Color.Maroon;
            this.btStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btStatistics.ForeColor = System.Drawing.SystemColors.Control;
            this.btStatistics.Location = new System.Drawing.Point(318, 17);
            this.btStatistics.Margin = new System.Windows.Forms.Padding(1);
            this.btStatistics.Name = "btStatistics";
            this.btStatistics.Padding = new System.Windows.Forms.Padding(1);
            this.btStatistics.Size = new System.Drawing.Size(163, 33);
            this.btStatistics.TabIndex = 4;
            this.btStatistics.Text = "STATISTICS";
            this.btStatistics.UseVisualStyleBackColor = false;
            this.btStatistics.Click += new System.EventHandler(this.btStatistics_Click);
            // 
            // btEmployee
            // 
            this.btEmployee.BackColor = System.Drawing.Color.Maroon;
            this.btEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEmployee.Location = new System.Drawing.Point(149, 16);
            this.btEmployee.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btEmployee.Name = "btEmployee";
            this.btEmployee.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btEmployee.Size = new System.Drawing.Size(163, 33);
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
            this.pEmplyee.Location = new System.Drawing.Point(200, 63);
            this.pEmplyee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pEmplyee.Name = "pEmplyee";
            this.pEmplyee.Size = new System.Drawing.Size(627, 188);
            this.pEmplyee.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AllowDrop = true;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label16.Location = new System.Drawing.Point(155, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 18);
            this.label16.TabIndex = 137;
            this.label16.Text = "EMAIL ADDRESS";
            // 
            // label15
            // 
            this.label15.AllowDrop = true;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label15.Location = new System.Drawing.Point(193, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 18);
            this.label15.TabIndex = 136;
            this.label15.Text = "SALARY";
            // 
            // label14
            // 
            this.label14.AllowDrop = true;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label14.Location = new System.Drawing.Point(175, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 18);
            this.label14.TabIndex = 135;
            this.label14.Text = "SUPERVISOR";
            // 
            // label13
            // 
            this.label13.AllowDrop = true;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label13.Location = new System.Drawing.Point(147, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 18);
            this.label13.TabIndex = 134;
            this.label13.Text = "WORK LOCATION";
            // 
            // label12
            // 
            this.label12.AllowDrop = true;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(143, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 18);
            this.label12.TabIndex = 133;
            this.label12.Text = "PHONE NUMBER";
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(4, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 18);
            this.label11.TabIndex = 132;
            this.label11.Text = "START DATE";
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.Location = new System.Drawing.Point(9, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 18);
            this.label10.TabIndex = 131;
            this.label10.Text = "FUNCTION";
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(-3, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 18);
            this.label9.TabIndex = 130;
            this.label9.Text = "DEPARTMENT";
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(8, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 129;
            this.label8.Text = "ADDRESS";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 128;
            this.label2.Text = "NAME";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(388, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 26);
            this.textBox1.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(341, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 126;
            this.label1.Text = "SHIFT";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(388, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(51, 28);
            this.comboBox1.TabIndex = 125;
            // 
            // btAddToSchedule
            // 
            this.btAddToSchedule.BackColor = System.Drawing.Color.Maroon;
            this.btAddToSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btAddToSchedule.ForeColor = System.Drawing.SystemColors.Control;
            this.btAddToSchedule.Location = new System.Drawing.Point(444, 44);
            this.btAddToSchedule.Name = "btAddToSchedule";
            this.btAddToSchedule.Size = new System.Drawing.Size(159, 23);
            this.btAddToSchedule.TabIndex = 122;
            this.btAddToSchedule.Text = "Add to schedule";
            this.btAddToSchedule.UseVisualStyleBackColor = false;
            // 
            // dtpShiftDate
            // 
            this.dtpShiftDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShiftDate.Location = new System.Drawing.Point(444, 15);
            this.dtpShiftDate.Name = "dtpShiftDate";
            this.dtpShiftDate.Size = new System.Drawing.Size(161, 23);
            this.dtpShiftDate.TabIndex = 124;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(341, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 123;
            this.label4.Text = "NAME";
            // 
            // tbSalary
            // 
            this.tbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbSalary.Location = new System.Drawing.Point(281, 120);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(33, 26);
            this.tbSalary.TabIndex = 121;
            // 
            // tbSupervisor
            // 
            this.tbSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbSupervisor.Location = new System.Drawing.Point(281, 92);
            this.tbSupervisor.Name = "tbSupervisor";
            this.tbSupervisor.Size = new System.Drawing.Size(33, 26);
            this.tbSupervisor.TabIndex = 120;
            // 
            // tbWorkLocation
            // 
            this.tbWorkLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbWorkLocation.Location = new System.Drawing.Point(281, 66);
            this.tbWorkLocation.Name = "tbWorkLocation";
            this.tbWorkLocation.Size = new System.Drawing.Size(33, 26);
            this.tbWorkLocation.TabIndex = 119;
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbEmailAddress.Location = new System.Drawing.Point(281, 38);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(33, 26);
            this.tbEmailAddress.TabIndex = 118;
            // 
            // btSearchEmployee
            // 
            this.btSearchEmployee.BackColor = System.Drawing.Color.Maroon;
            this.btSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchEmployee.ForeColor = System.Drawing.SystemColors.Control;
            this.btSearchEmployee.Location = new System.Drawing.Point(463, 73);
            this.btSearchEmployee.Name = "btSearchEmployee";
            this.btSearchEmployee.Size = new System.Drawing.Size(109, 23);
            this.btSearchEmployee.TabIndex = 117;
            this.btSearchEmployee.Text = "Search";
            this.btSearchEmployee.UseVisualStyleBackColor = false;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbPhoneNumber.Location = new System.Drawing.Point(281, 10);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(33, 26);
            this.tbPhoneNumber.TabIndex = 116;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(95, 66);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(50, 28);
            this.cmbDepartment.TabIndex = 115;
            // 
            // tbStartDay
            // 
            this.tbStartDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbStartDay.Location = new System.Drawing.Point(93, 120);
            this.tbStartDay.Name = "tbStartDay";
            this.tbStartDay.Size = new System.Drawing.Size(51, 26);
            this.tbStartDay.TabIndex = 114;
            // 
            // btAddEmployee
            // 
            this.btAddEmployee.BackColor = System.Drawing.Color.Maroon;
            this.btAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btAddEmployee.ForeColor = System.Drawing.SystemColors.Control;
            this.btAddEmployee.Location = new System.Drawing.Point(59, 150);
            this.btAddEmployee.Name = "btAddEmployee";
            this.btAddEmployee.Size = new System.Drawing.Size(219, 23);
            this.btAddEmployee.TabIndex = 113;
            this.btAddEmployee.Text = "Add";
            this.btAddEmployee.UseVisualStyleBackColor = false;
            // 
            // tbFunction
            // 
            this.tbFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbFunction.Location = new System.Drawing.Point(95, 91);
            this.tbFunction.Name = "tbFunction";
            this.tbFunction.Size = new System.Drawing.Size(50, 26);
            this.tbFunction.TabIndex = 112;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbAddress.Location = new System.Drawing.Point(95, 38);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(50, 26);
            this.tbAddress.TabIndex = 111;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbName.Location = new System.Drawing.Point(93, 10);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(49, 26);
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
            this.pStatistics.Location = new System.Drawing.Point(9, 257);
            this.pStatistics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pStatistics.Name = "pStatistics";
            this.pStatistics.Size = new System.Drawing.Size(464, 148);
            this.pStatistics.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(50, 105);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(341, 4);
            this.listBox1.TabIndex = 42;
            // 
            // btViewStatsOverall
            // 
            this.btViewStatsOverall.BackColor = System.Drawing.Color.Maroon;
            this.btViewStatsOverall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btViewStatsOverall.ForeColor = System.Drawing.SystemColors.Control;
            this.btViewStatsOverall.Location = new System.Drawing.Point(389, 44);
            this.btViewStatsOverall.Name = "btViewStatsOverall";
            this.btViewStatsOverall.Size = new System.Drawing.Size(66, 35);
            this.btViewStatsOverall.TabIndex = 41;
            this.btViewStatsOverall.Text = "View statistics overall";
            this.btViewStatsOverall.UseVisualStyleBackColor = false;
            // 
            // btViewDepartmentStats
            // 
            this.btViewDepartmentStats.BackColor = System.Drawing.Color.Maroon;
            this.btViewDepartmentStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewDepartmentStats.ForeColor = System.Drawing.SystemColors.Control;
            this.btViewDepartmentStats.Location = new System.Drawing.Point(228, 33);
            this.btViewDepartmentStats.Name = "btViewDepartmentStats";
            this.btViewDepartmentStats.Size = new System.Drawing.Size(156, 31);
            this.btViewDepartmentStats.TabIndex = 40;
            this.btViewDepartmentStats.Text = "View department statistics";
            this.btViewDepartmentStats.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(5, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "DEPARTMENT";
            // 
            // cmbDepartmentStats
            // 
            this.cmbDepartmentStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cmbDepartmentStats.FormattingEnabled = true;
            this.cmbDepartmentStats.Location = new System.Drawing.Point(100, 66);
            this.cmbDepartmentStats.Name = "cmbDepartmentStats";
            this.cmbDepartmentStats.Size = new System.Drawing.Size(121, 28);
            this.cmbDepartmentStats.TabIndex = 38;
            // 
            // btViewEmployeeStats
            // 
            this.btViewEmployeeStats.BackColor = System.Drawing.Color.Maroon;
            this.btViewEmployeeStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewEmployeeStats.ForeColor = System.Drawing.SystemColors.Control;
            this.btViewEmployeeStats.Location = new System.Drawing.Point(228, 70);
            this.btViewEmployeeStats.Name = "btViewEmployeeStats";
            this.btViewEmployeeStats.Size = new System.Drawing.Size(156, 23);
            this.btViewEmployeeStats.TabIndex = 36;
            this.btViewEmployeeStats.Text = "View statistics";
            this.btViewEmployeeStats.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(47, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "NAME";
            // 
            // tbNameStats
            // 
            this.tbNameStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbNameStats.Location = new System.Drawing.Point(99, 34);
            this.tbNameStats.Name = "tbNameStats";
            this.tbNameStats.Size = new System.Drawing.Size(121, 26);
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
            this.pStock.Location = new System.Drawing.Point(478, 257);
            this.pStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pStock.Name = "pStock";
            this.pStock.Size = new System.Drawing.Size(349, 148);
            this.pStock.TabIndex = 9;
            // 
            // btViewStockEmployee
            // 
            this.btViewStockEmployee.BackColor = System.Drawing.Color.Maroon;
            this.btViewStockEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btViewStockEmployee.ForeColor = System.Drawing.SystemColors.Control;
            this.btViewStockEmployee.Location = new System.Drawing.Point(197, 71);
            this.btViewStockEmployee.Name = "btViewStockEmployee";
            this.btViewStockEmployee.Size = new System.Drawing.Size(121, 24);
            this.btViewStockEmployee.TabIndex = 26;
            this.btViewStockEmployee.Text = "View stock";
            this.btViewStockEmployee.UseVisualStyleBackColor = false;
            // 
            // btSendRestockRequest
            // 
            this.btSendRestockRequest.BackColor = System.Drawing.Color.Maroon;
            this.btSendRestockRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btSendRestockRequest.ForeColor = System.Drawing.Color.White;
            this.btSendRestockRequest.Location = new System.Drawing.Point(17, 105);
            this.btSendRestockRequest.Name = "btSendRestockRequest";
            this.btSendRestockRequest.Size = new System.Drawing.Size(301, 33);
            this.btSendRestockRequest.TabIndex = 29;
            this.btSendRestockRequest.Text = "Send restock request";
            this.btSendRestockRequest.UseVisualStyleBackColor = false;
            // 
            // tbItemIDRestock
            // 
            this.tbItemIDRestock.Location = new System.Drawing.Point(83, 79);
            this.tbItemIDRestock.Name = "tbItemIDRestock";
            this.tbItemIDRestock.Size = new System.Drawing.Size(103, 20);
            this.tbItemIDRestock.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(15, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Item ID:";
            // 
            // btCheckAvailability
            // 
            this.btCheckAvailability.BackColor = System.Drawing.Color.Maroon;
            this.btCheckAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btCheckAvailability.ForeColor = System.Drawing.Color.White;
            this.btCheckAvailability.Location = new System.Drawing.Point(197, 39);
            this.btCheckAvailability.Name = "btCheckAvailability";
            this.btCheckAvailability.Size = new System.Drawing.Size(121, 23);
            this.btCheckAvailability.TabIndex = 25;
            this.btCheckAvailability.Text = "Check availability";
            this.btCheckAvailability.UseVisualStyleBackColor = false;
            // 
            // tbItemID
            // 
            this.tbItemID.Location = new System.Drawing.Point(83, 39);
            this.tbItemID.Name = "tbItemID";
            this.tbItemID.Size = new System.Drawing.Size(103, 20);
            this.tbItemID.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(15, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Item ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(39, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 60);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(949, 439);
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
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Media Bazar App";
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

