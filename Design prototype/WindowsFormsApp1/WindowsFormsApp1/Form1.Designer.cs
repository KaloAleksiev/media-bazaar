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
            this.pEmplyee = new System.Windows.Forms.Panel();
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
            this.btlogoutE = new System.Windows.Forms.Button();
            this.btStockE = new System.Windows.Forms.Button();
            this.btStatisticsE = new System.Windows.Forms.Button();
            this.btEmployeeE = new System.Windows.Forms.Button();
            this.tbItemID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pStatistics = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btViewStatsOverall = new System.Windows.Forms.Button();
            this.btViewDepartmentStats = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDepartmentStats = new System.Windows.Forms.ComboBox();
            this.btViewEmployeeStats = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNameStats = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.btViewStock = new System.Windows.Forms.Button();
            this.btViewEmployees = new System.Windows.Forms.Button();
            this.pStock = new System.Windows.Forms.Panel();
            this.btViewStockEmployee = new System.Windows.Forms.Button();
            this.btSendRestockRequest = new System.Windows.Forms.Button();
            this.tbItemIDRestock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btCheckAvailability = new System.Windows.Forms.Button();
            this.pLogin.SuspendLayout();
            this.pEmplyee.SuspendLayout();
            this.pStatistics.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.Color.White;
            this.pLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pLogin.BackgroundImage")));
            this.pLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pLogin.Controls.Add(this.btLogin);
            this.pLogin.Controls.Add(this.tbPassword);
            this.pLogin.Controls.Add(this.tbUsername);
            this.pLogin.Location = new System.Drawing.Point(18, 14);
            this.pLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(280, 289);
            this.pLogin.TabIndex = 0;
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(14, 148);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(238, 35);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
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
            // pEmplyee
            // 
            this.pEmplyee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pEmplyee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pEmplyee.BackgroundImage")));
            this.pEmplyee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.pEmplyee.Controls.Add(this.btlogoutE);
            this.pEmplyee.Controls.Add(this.btStockE);
            this.pEmplyee.Controls.Add(this.btStatisticsE);
            this.pEmplyee.Controls.Add(this.btEmployeeE);
            this.pEmplyee.Location = new System.Drawing.Point(306, 15);
            this.pEmplyee.Margin = new System.Windows.Forms.Padding(0);
            this.pEmplyee.Name = "pEmplyee";
            this.pEmplyee.Size = new System.Drawing.Size(1015, 360);
            this.pEmplyee.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(725, 148);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 33);
            this.textBox1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Codec Warm Trial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(653, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "SHIFT:";
            this.label1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(719, 192);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 35);
            this.comboBox1.TabIndex = 35;
            // 
            // btAddToSchedule
            // 
            this.btAddToSchedule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAddToSchedule.BackgroundImage")));
            this.btAddToSchedule.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.btAddToSchedule.Location = new System.Drawing.Point(674, 283);
            this.btAddToSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAddToSchedule.Name = "btAddToSchedule";
            this.btAddToSchedule.Size = new System.Drawing.Size(288, 35);
            this.btAddToSchedule.TabIndex = 32;
            this.btAddToSchedule.Text = "Add to schedule";
            this.btAddToSchedule.UseVisualStyleBackColor = true;
            // 
            // dtpShiftDate
            // 
            this.dtpShiftDate.Font = new System.Drawing.Font("Coarse Rounded", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShiftDate.Location = new System.Drawing.Point(664, 247);
            this.dtpShiftDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpShiftDate.Name = "dtpShiftDate";
            this.dtpShiftDate.Size = new System.Drawing.Size(298, 32);
            this.dtpShiftDate.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Codec Warm Trial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(656, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "NAME:";
            this.label4.Visible = false;
            // 
            // tbSalary
            // 
            this.tbSalary.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbSalary.Location = new System.Drawing.Point(452, 255);
            this.tbSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(145, 33);
            this.tbSalary.TabIndex = 31;
            // 
            // tbSupervisor
            // 
            this.tbSupervisor.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbSupervisor.Location = new System.Drawing.Point(452, 218);
            this.tbSupervisor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSupervisor.Name = "tbSupervisor";
            this.tbSupervisor.Size = new System.Drawing.Size(145, 33);
            this.tbSupervisor.TabIndex = 30;
            // 
            // tbWorkLocation
            // 
            this.tbWorkLocation.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbWorkLocation.Location = new System.Drawing.Point(452, 180);
            this.tbWorkLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWorkLocation.Name = "tbWorkLocation";
            this.tbWorkLocation.Size = new System.Drawing.Size(145, 33);
            this.tbWorkLocation.TabIndex = 29;
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbEmailAddress.Location = new System.Drawing.Point(452, 144);
            this.tbEmailAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(145, 33);
            this.tbEmailAddress.TabIndex = 28;
            // 
            // btSearchEmployee
            // 
            this.btSearchEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSearchEmployee.BackgroundImage")));
            this.btSearchEmployee.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.btSearchEmployee.Location = new System.Drawing.Point(434, 298);
            this.btSearchEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSearchEmployee.Name = "btSearchEmployee";
            this.btSearchEmployee.Size = new System.Drawing.Size(163, 35);
            this.btSearchEmployee.TabIndex = 27;
            this.btSearchEmployee.Text = "Search";
            this.btSearchEmployee.UseVisualStyleBackColor = true;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbPhoneNumber.Location = new System.Drawing.Point(452, 105);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(145, 33);
            this.tbPhoneNumber.TabIndex = 26;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(172, 164);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(180, 35);
            this.cmbDepartment.TabIndex = 23;
            // 
            // tbStartDay
            // 
            this.tbStartDay.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbStartDay.Location = new System.Drawing.Point(174, 247);
            this.tbStartDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbStartDay.Name = "tbStartDay";
            this.tbStartDay.Size = new System.Drawing.Size(178, 33);
            this.tbStartDay.TabIndex = 19;
            // 
            // btAddEmployee
            // 
            this.btAddEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAddEmployee.BackgroundImage")));
            this.btAddEmployee.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.btAddEmployee.Location = new System.Drawing.Point(174, 283);
            this.btAddEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAddEmployee.Name = "btAddEmployee";
            this.btAddEmployee.Size = new System.Drawing.Size(176, 35);
            this.btAddEmployee.TabIndex = 18;
            this.btAddEmployee.Text = "Add";
            this.btAddEmployee.UseVisualStyleBackColor = true;
            // 
            // tbFunction
            // 
            this.tbFunction.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbFunction.Location = new System.Drawing.Point(172, 203);
            this.tbFunction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFunction.Name = "tbFunction";
            this.tbFunction.Size = new System.Drawing.Size(178, 33);
            this.tbFunction.TabIndex = 17;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbAddress.Location = new System.Drawing.Point(174, 122);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(178, 33);
            this.tbAddress.TabIndex = 16;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Codec Warm Trial", 12F, System.Drawing.FontStyle.Bold);
            this.tbName.Location = new System.Drawing.Point(172, 78);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 33);
            this.tbName.TabIndex = 15;
            // 
            // btlogoutE
            // 
            this.btlogoutE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btlogoutE.BackgroundImage")));
            this.btlogoutE.Font = new System.Drawing.Font("Codec Cold Trial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogoutE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btlogoutE.Location = new System.Drawing.Point(746, 54);
            this.btlogoutE.Margin = new System.Windows.Forms.Padding(1);
            this.btlogoutE.Name = "btlogoutE";
            this.btlogoutE.Padding = new System.Windows.Forms.Padding(1);
            this.btlogoutE.Size = new System.Drawing.Size(192, 42);
            this.btlogoutE.TabIndex = 6;
            this.btlogoutE.Text = "Log Out";
            this.btlogoutE.UseVisualStyleBackColor = true;
            // 
            // btStockE
            // 
            this.btStockE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btStockE.BackgroundImage")));
            this.btStockE.Font = new System.Drawing.Font("Codec Cold Trial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStockE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btStockE.Location = new System.Drawing.Point(736, 3);
            this.btStockE.Name = "btStockE";
            this.btStockE.Size = new System.Drawing.Size(279, 42);
            this.btStockE.TabIndex = 5;
            this.btStockE.Text = "Stock Control";
            this.btStockE.UseVisualStyleBackColor = true;
            // 
            // btStatisticsE
            // 
            this.btStatisticsE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btStatisticsE.BackgroundImage")));
            this.btStatisticsE.Font = new System.Drawing.Font("Codec Cold Trial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStatisticsE.ForeColor = System.Drawing.SystemColors.Control;
            this.btStatisticsE.Location = new System.Drawing.Point(499, 49);
            this.btStatisticsE.Margin = new System.Windows.Forms.Padding(1);
            this.btStatisticsE.Name = "btStatisticsE";
            this.btStatisticsE.Padding = new System.Windows.Forms.Padding(1);
            this.btStatisticsE.Size = new System.Drawing.Size(192, 42);
            this.btStatisticsE.TabIndex = 4;
            this.btStatisticsE.Text = "Statistics";
            this.btStatisticsE.UseVisualStyleBackColor = true;
            // 
            // btEmployeeE
            // 
            this.btEmployeeE.BackColor = System.Drawing.Color.White;
            this.btEmployeeE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEmployeeE.BackgroundImage")));
            this.btEmployeeE.Font = new System.Drawing.Font("Codec Cold Trial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmployeeE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEmployeeE.Location = new System.Drawing.Point(502, 3);
            this.btEmployeeE.Name = "btEmployeeE";
            this.btEmployeeE.Padding = new System.Windows.Forms.Padding(2);
            this.btEmployeeE.Size = new System.Drawing.Size(189, 42);
            this.btEmployeeE.TabIndex = 3;
            this.btEmployeeE.Text = "Emplyee";
            this.btEmployeeE.UseVisualStyleBackColor = false;
            // 
            // tbItemID
            // 
            this.tbItemID.Location = new System.Drawing.Point(93, 22);
            this.tbItemID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbItemID.Name = "tbItemID";
            this.tbItemID.Size = new System.Drawing.Size(180, 26);
            this.tbItemID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item ID:";
            // 
            // pStatistics
            // 
            this.pStatistics.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pStatistics.Controls.Add(this.groupBox5);
            this.pStatistics.Controls.Add(this.groupBox4);
            this.pStatistics.Location = new System.Drawing.Point(18, 384);
            this.pStatistics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pStatistics.Name = "pStatistics";
            this.pStatistics.Size = new System.Drawing.Size(814, 260);
            this.pStatistics.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btViewStatsOverall);
            this.groupBox5.Controls.Add(this.btViewDepartmentStats);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.cmbDepartmentStats);
            this.groupBox5.Controls.Add(this.btViewEmployeeStats);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.tbNameStats);
            this.groupBox5.Location = new System.Drawing.Point(324, 26);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(463, 214);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Statistics";
            // 
            // btViewStatsOverall
            // 
            this.btViewStatsOverall.Location = new System.Drawing.Point(239, 126);
            this.btViewStatsOverall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btViewStatsOverall.Name = "btViewStatsOverall";
            this.btViewStatsOverall.Size = new System.Drawing.Size(182, 54);
            this.btViewStatsOverall.TabIndex = 9;
            this.btViewStatsOverall.Text = "View stats overall";
            this.btViewStatsOverall.UseVisualStyleBackColor = true;
            // 
            // btViewDepartmentStats
            // 
            this.btViewDepartmentStats.Location = new System.Drawing.Point(13, 126);
            this.btViewDepartmentStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btViewDepartmentStats.Name = "btViewDepartmentStats";
            this.btViewDepartmentStats.Size = new System.Drawing.Size(182, 54);
            this.btViewDepartmentStats.TabIndex = 8;
            this.btViewDepartmentStats.Text = "View department stats";
            this.btViewDepartmentStats.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Department:";
            // 
            // cmbDepartmentStats
            // 
            this.cmbDepartmentStats.FormattingEnabled = true;
            this.cmbDepartmentStats.Location = new System.Drawing.Point(115, 77);
            this.cmbDepartmentStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDepartmentStats.Name = "cmbDepartmentStats";
            this.cmbDepartmentStats.Size = new System.Drawing.Size(180, 28);
            this.cmbDepartmentStats.TabIndex = 6;
            // 
            // btViewEmployeeStats
            // 
            this.btViewEmployeeStats.Location = new System.Drawing.Point(321, 29);
            this.btViewEmployeeStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btViewEmployeeStats.Name = "btViewEmployeeStats";
            this.btViewEmployeeStats.Size = new System.Drawing.Size(112, 35);
            this.btViewEmployeeStats.TabIndex = 3;
            this.btViewEmployeeStats.Text = "View stats";
            this.btViewEmployeeStats.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name:";
            // 
            // tbNameStats
            // 
            this.tbNameStats.Location = new System.Drawing.Point(115, 29);
            this.tbNameStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNameStats.Name = "tbNameStats";
            this.tbNameStats.Size = new System.Drawing.Size(180, 26);
            this.tbNameStats.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbResult);
            this.groupBox4.Controls.Add(this.btViewStock);
            this.groupBox4.Controls.Add(this.btViewEmployees);
            this.groupBox4.Location = new System.Drawing.Point(14, 23);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(286, 214);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stock/Employee info";
            this.groupBox4.Visible = false;
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 20;
            this.lbResult.Location = new System.Drawing.Point(8, 104);
            this.lbResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(239, 84);
            this.lbResult.TabIndex = 5;
            // 
            // btViewStock
            // 
            this.btViewStock.Location = new System.Drawing.Point(11, 29);
            this.btViewStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btViewStock.Name = "btViewStock";
            this.btViewStock.Size = new System.Drawing.Size(114, 52);
            this.btViewStock.TabIndex = 4;
            this.btViewStock.Text = "View stock";
            this.btViewStock.UseVisualStyleBackColor = true;
            // 
            // btViewEmployees
            // 
            this.btViewEmployees.Location = new System.Drawing.Point(133, 32);
            this.btViewEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btViewEmployees.Name = "btViewEmployees";
            this.btViewEmployees.Size = new System.Drawing.Size(114, 52);
            this.btViewEmployees.TabIndex = 3;
            this.btViewEmployees.Text = "View employees";
            this.btViewEmployees.UseVisualStyleBackColor = true;
            // 
            // pStock
            // 
            this.pStock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pStock.Controls.Add(this.btViewStockEmployee);
            this.pStock.Controls.Add(this.btSendRestockRequest);
            this.pStock.Controls.Add(this.tbItemIDRestock);
            this.pStock.Controls.Add(this.label7);
            this.pStock.Controls.Add(this.btCheckAvailability);
            this.pStock.Controls.Add(this.tbItemID);
            this.pStock.Controls.Add(this.label3);
            this.pStock.Location = new System.Drawing.Point(840, 385);
            this.pStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pStock.Name = "pStock";
            this.pStock.Size = new System.Drawing.Size(481, 259);
            this.pStock.TabIndex = 3;
            // 
            // btViewStockEmployee
            // 
            this.btViewStockEmployee.Location = new System.Drawing.Point(290, 148);
            this.btViewStockEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btViewStockEmployee.Name = "btViewStockEmployee";
            this.btViewStockEmployee.Size = new System.Drawing.Size(182, 52);
            this.btViewStockEmployee.TabIndex = 6;
            this.btViewStockEmployee.Text = "View stock";
            this.btViewStockEmployee.UseVisualStyleBackColor = true;
            // 
            // btSendRestockRequest
            // 
            this.btSendRestockRequest.Location = new System.Drawing.Point(290, 84);
            this.btSendRestockRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSendRestockRequest.Name = "btSendRestockRequest";
            this.btSendRestockRequest.Size = new System.Drawing.Size(182, 56);
            this.btSendRestockRequest.TabIndex = 8;
            this.btSendRestockRequest.Text = "Send restock request";
            this.btSendRestockRequest.UseVisualStyleBackColor = true;
            // 
            // tbItemIDRestock
            // 
            this.tbItemIDRestock.Location = new System.Drawing.Point(93, 83);
            this.tbItemIDRestock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbItemIDRestock.Name = "tbItemIDRestock";
            this.tbItemIDRestock.Size = new System.Drawing.Size(180, 26);
            this.tbItemIDRestock.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Item ID:";
            // 
            // btCheckAvailability
            // 
            this.btCheckAvailability.Location = new System.Drawing.Point(290, 22);
            this.btCheckAvailability.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCheckAvailability.Name = "btCheckAvailability";
            this.btCheckAvailability.Size = new System.Drawing.Size(182, 35);
            this.btCheckAvailability.TabIndex = 5;
            this.btCheckAvailability.Text = "Check availability";
            this.btCheckAvailability.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1329, 652);
            this.Controls.Add(this.pStock);
            this.Controls.Add(this.pStatistics);
            this.Controls.Add(this.pEmplyee);
            this.Controls.Add(this.pLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.pEmplyee.ResumeLayout(false);
            this.pEmplyee.PerformLayout();
            this.pStatistics.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.pStock.ResumeLayout(false);
            this.pStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel pEmplyee;
        private System.Windows.Forms.TextBox tbItemID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pStatistics;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btViewStatsOverall;
        private System.Windows.Forms.Button btViewDepartmentStats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDepartmentStats;
        private System.Windows.Forms.Button btViewEmployeeStats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNameStats;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Button btViewStock;
        private System.Windows.Forms.Button btViewEmployees;
        private System.Windows.Forms.Panel pStock;
        private System.Windows.Forms.Button btViewStockEmployee;
        private System.Windows.Forms.Button btSendRestockRequest;
        private System.Windows.Forms.TextBox tbItemIDRestock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCheckAvailability;
        private System.Windows.Forms.Button btStockE;
        private System.Windows.Forms.Button btStatisticsE;
        private System.Windows.Forms.Button btEmployeeE;
        private System.Windows.Forms.Button btlogoutE;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.TextBox tbStartDay;
        private System.Windows.Forms.Button btAddEmployee;
        private System.Windows.Forms.TextBox tbFunction;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btSearchEmployee;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbSupervisor;
        private System.Windows.Forms.TextBox tbWorkLocation;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btAddToSchedule;
        private System.Windows.Forms.DateTimePicker dtpShiftDate;
        private System.Windows.Forms.Label label4;
    }
}

