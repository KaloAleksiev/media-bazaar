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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btAddEmployee = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btlogoutE = new System.Windows.Forms.Button();
            this.btStockE = new System.Windows.Forms.Button();
            this.btStatisticsE = new System.Windows.Forms.Button();
            this.btEmployeeE = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btAddToSchedule = new System.Windows.Forms.Button();
            this.dtpShiftDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbShift = new System.Windows.Forms.ComboBox();
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
            this.cmbDepartmentInfo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btSearchEmployee = new System.Windows.Forms.Button();
            this.tbNameInfo = new System.Windows.Forms.TextBox();
            this.pLogin.SuspendLayout();
            this.pEmplyee.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.pEmplyee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pEmplyee.Controls.Add(this.cmbDepartmentInfo);
            this.pEmplyee.Controls.Add(this.label14);
            this.pEmplyee.Controls.Add(this.label13);
            this.pEmplyee.Controls.Add(this.btSearchEmployee);
            this.pEmplyee.Controls.Add(this.tbNameInfo);
            this.pEmplyee.Controls.Add(this.label12);
            this.pEmplyee.Controls.Add(this.label11);
            this.pEmplyee.Controls.Add(this.cmbDepartment);
            this.pEmplyee.Controls.Add(this.label10);
            this.pEmplyee.Controls.Add(this.label9);
            this.pEmplyee.Controls.Add(this.label8);
            this.pEmplyee.Controls.Add(this.textBox7);
            this.pEmplyee.Controls.Add(this.btAddEmployee);
            this.pEmplyee.Controls.Add(this.textBox6);
            this.pEmplyee.Controls.Add(this.tbPhoneNumber);
            this.pEmplyee.Controls.Add(this.tbName);
            this.pEmplyee.Controls.Add(this.btlogoutE);
            this.pEmplyee.Controls.Add(this.btStockE);
            this.pEmplyee.Controls.Add(this.btStatisticsE);
            this.pEmplyee.Controls.Add(this.btEmployeeE);
            this.pEmplyee.Controls.Add(this.groupBox3);
            this.pEmplyee.Location = new System.Drawing.Point(306, 15);
            this.pEmplyee.Margin = new System.Windows.Forms.Padding(0);
            this.pEmplyee.Name = "pEmplyee";
            this.pEmplyee.Size = new System.Drawing.Size(1015, 360);
            this.pEmplyee.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(101, 250);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 211);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Name:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(172, 164);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(180, 28);
            this.cmbDepartment.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 125);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Phone number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Department:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Name:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(174, 247);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(178, 26);
            this.textBox7.TabIndex = 19;
            // 
            // btAddEmployee
            // 
            this.btAddEmployee.Location = new System.Drawing.Point(174, 283);
            this.btAddEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAddEmployee.Name = "btAddEmployee";
            this.btAddEmployee.Size = new System.Drawing.Size(176, 35);
            this.btAddEmployee.TabIndex = 18;
            this.btAddEmployee.Text = "Add";
            this.btAddEmployee.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(172, 203);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(178, 26);
            this.textBox6.TabIndex = 17;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(174, 122);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(178, 26);
            this.tbPhoneNumber.TabIndex = 16;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(172, 78);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 26);
            this.tbName.TabIndex = 15;
            // 
            // btlogoutE
            // 
            this.btlogoutE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btlogoutE.BackgroundImage")));
            this.btlogoutE.Font = new System.Drawing.Font("Codec Cold Trial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btStockE.Font = new System.Drawing.Font("Codec Cold Trial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btStatisticsE.Font = new System.Drawing.Font("Codec Cold Trial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox3.Controls.Add(this.btAddToSchedule);
            this.groupBox3.Controls.Add(this.dtpShiftDate);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmbShift);
            this.groupBox3.Location = new System.Drawing.Point(638, 105);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(368, 206);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Schedule";
            // 
            // btAddToSchedule
            // 
            this.btAddToSchedule.Location = new System.Drawing.Point(56, 152);
            this.btAddToSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAddToSchedule.Name = "btAddToSchedule";
            this.btAddToSchedule.Size = new System.Drawing.Size(288, 35);
            this.btAddToSchedule.TabIndex = 5;
            this.btAddToSchedule.Text = "Add to schedule";
            this.btAddToSchedule.UseVisualStyleBackColor = true;
            // 
            // dtpShiftDate
            // 
            this.dtpShiftDate.Location = new System.Drawing.Point(46, 116);
            this.dtpShiftDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpShiftDate.Name = "dtpShiftDate";
            this.dtpShiftDate.Size = new System.Drawing.Size(298, 26);
            this.dtpShiftDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Shift:";
            // 
            // cmbShift
            // 
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Location = new System.Drawing.Point(108, 54);
            this.cmbShift.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(180, 28);
            this.cmbShift.TabIndex = 5;
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
            // cmbDepartmentInfo
            // 
            this.cmbDepartmentInfo.FormattingEnabled = true;
            this.cmbDepartmentInfo.Location = new System.Drawing.Point(472, 201);
            this.cmbDepartmentInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDepartmentInfo.Name = "cmbDepartmentInfo";
            this.cmbDepartmentInfo.Size = new System.Drawing.Size(145, 28);
            this.cmbDepartmentInfo.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(370, 205);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Department:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(406, 144);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Name:";
            // 
            // btSearchEmployee
            // 
            this.btSearchEmployee.Location = new System.Drawing.Point(387, 261);
            this.btSearchEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSearchEmployee.Name = "btSearchEmployee";
            this.btSearchEmployee.Size = new System.Drawing.Size(230, 35);
            this.btSearchEmployee.TabIndex = 27;
            this.btSearchEmployee.Text = "Search";
            this.btSearchEmployee.UseVisualStyleBackColor = true;
            // 
            // tbNameInfo
            // 
            this.tbNameInfo.Location = new System.Drawing.Point(472, 139);
            this.tbNameInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNameInfo.Name = "tbNameInfo";
            this.tbNameInfo.Size = new System.Drawing.Size(145, 26);
            this.tbNameInfo.TabIndex = 26;
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
//            this.Load += new System.EventHandler(this.Form1_Load);
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.pEmplyee.ResumeLayout(false);
            this.pEmplyee.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btAddToSchedule;
        private System.Windows.Forms.DateTimePicker dtpShiftDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbShift;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btAddEmployee;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cmbDepartmentInfo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btSearchEmployee;
        private System.Windows.Forms.TextBox tbNameInfo;
    }
}

