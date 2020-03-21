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
<<<<<<< HEAD
            this.cmbNameAssign = new System.Windows.Forms.ComboBox();
            this.lbEmployee = new System.Windows.Forms.ListBox();
=======
            this.btnCheckInfoPromot = new System.Windows.Forms.Button();
            this.cmbNamePromote = new System.Windows.Forms.ComboBox();
            this.tbPromoteDepartment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbNameAssign = new System.Windows.Forms.ComboBox();
            this.lbEmployee = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartemntAssign = new System.Windows.Forms.ComboBox();
            this.btAssignToDepartment = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btAddEmployee = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pStatistics = new System.Windows.Forms.Panel();
            this.cmbItemsStats = new System.Windows.Forms.ComboBox();
            this.lbStatistics = new System.Windows.Forms.ListBox();
            this.btViewStatsOverall = new System.Windows.Forms.Button();
            this.btViewDepartmentStats = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDepartmentStats = new System.Windows.Forms.ComboBox();
            this.btViewItemStats = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pStock = new System.Windows.Forms.Panel();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.btViewStockEmployee = new System.Windows.Forms.Button();
            this.btSendRestockRequest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSchedule = new System.Windows.Forms.Button();
            this.pSchedule = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbNamePromote = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPromoteDepartment = new System.Windows.Forms.TextBox();
            this.btPromote = new System.Windows.Forms.Button();
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
            this.pLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pLogin.BackgroundImage")));
            this.pLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pLogin.Controls.Add(this.btLogin);
            this.pLogin.Controls.Add(this.tbPassword);
            this.pLogin.Controls.Add(this.tbUsername);
<<<<<<< HEAD
            this.pLogin.Location = new System.Drawing.Point(14, 92);
            this.pLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(280, 289);
=======
            this.pLogin.Location = new System.Drawing.Point(9, 60);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(187, 188);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.pLogin.TabIndex = 0;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.Maroon;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.SystemColors.Control;
<<<<<<< HEAD
            this.btLogin.Location = new System.Drawing.Point(18, 148);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(234, 35);
=======
            this.btLogin.Location = new System.Drawing.Point(12, 96);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(156, 23);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.tbPassword.Location = new System.Drawing.Point(104, 109);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(148, 35);
=======
            this.tbPassword.Location = new System.Drawing.Point(69, 71);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 26);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.tbPassword.TabIndex = 1;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.tbUsername.Location = new System.Drawing.Point(104, 62);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(148, 35);
=======
            this.tbUsername.Location = new System.Drawing.Point(69, 40);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 26);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.tbUsername.TabIndex = 0;
            // 
            // btlogout
            // 
            this.btlogout.BackColor = System.Drawing.Color.Maroon;
            this.btlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btlogout.ForeColor = System.Drawing.SystemColors.Control;
<<<<<<< HEAD
            this.btlogout.Location = new System.Drawing.Point(1202, 22);
            this.btlogout.Margin = new System.Windows.Forms.Padding(2);
            this.btlogout.Name = "btlogout";
            this.btlogout.Padding = new System.Windows.Forms.Padding(2);
            this.btlogout.Size = new System.Drawing.Size(214, 52);
=======
            this.btlogout.Location = new System.Drawing.Point(801, 14);
            this.btlogout.Margin = new System.Windows.Forms.Padding(1);
            this.btlogout.Name = "btlogout";
            this.btlogout.Padding = new System.Windows.Forms.Padding(1);
            this.btlogout.Size = new System.Drawing.Size(143, 34);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
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
<<<<<<< HEAD
            this.btStock.Location = new System.Drawing.Point(991, 22);
            this.btStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btStock.Name = "btStock";
            this.btStock.Size = new System.Drawing.Size(208, 52);
=======
            this.btStock.Location = new System.Drawing.Point(661, 14);
            this.btStock.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btStock.Name = "btStock";
            this.btStock.Size = new System.Drawing.Size(139, 34);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
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
<<<<<<< HEAD
            this.btStatistics.Location = new System.Drawing.Point(744, 22);
            this.btStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.btStatistics.Name = "btStatistics";
            this.btStatistics.Padding = new System.Windows.Forms.Padding(2);
            this.btStatistics.Size = new System.Drawing.Size(244, 51);
=======
            this.btStatistics.Location = new System.Drawing.Point(496, 14);
            this.btStatistics.Margin = new System.Windows.Forms.Padding(1);
            this.btStatistics.Name = "btStatistics";
            this.btStatistics.Padding = new System.Windows.Forms.Padding(1);
            this.btStatistics.Size = new System.Drawing.Size(163, 33);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
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
<<<<<<< HEAD
            this.btEmployee.Location = new System.Drawing.Point(224, 25);
            this.btEmployee.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btEmployee.Name = "btEmployee";
            this.btEmployee.Padding = new System.Windows.Forms.Padding(2);
            this.btEmployee.Size = new System.Drawing.Size(256, 51);
=======
            this.btEmployee.Location = new System.Drawing.Point(149, 16);
            this.btEmployee.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btEmployee.Name = "btEmployee";
            this.btEmployee.Padding = new System.Windows.Forms.Padding(1);
            this.btEmployee.Size = new System.Drawing.Size(171, 33);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.btEmployee.TabIndex = 3;
            this.btEmployee.Text = "EMPLOYEE";
            this.btEmployee.UseVisualStyleBackColor = false;
            this.btEmployee.Click += new System.EventHandler(this.btEmployee_Click);
            // 
            // pEmplyee
            // 
            this.pEmplyee.BackColor = System.Drawing.Color.White;
<<<<<<< HEAD
=======
            this.pEmplyee.Controls.Add(this.btnCheckInfoPromot);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.pEmplyee.Controls.Add(this.cmbNamePromote);
            this.pEmplyee.Controls.Add(this.tbPromoteDepartment);
            this.pEmplyee.Controls.Add(this.label11);
            this.pEmplyee.Controls.Add(this.cmbNameAssign);
            this.pEmplyee.Controls.Add(this.lbEmployee);
            this.pEmplyee.Controls.Add(this.label10);
            this.pEmplyee.Controls.Add(this.label16);
            this.pEmplyee.Controls.Add(this.label13);
            this.pEmplyee.Controls.Add(this.label12);
            this.pEmplyee.Controls.Add(this.label9);
            this.pEmplyee.Controls.Add(this.label8);
            this.pEmplyee.Controls.Add(this.label2);
            this.pEmplyee.Controls.Add(this.label1);
            this.pEmplyee.Controls.Add(this.cmbDepartemntAssign);
            this.pEmplyee.Controls.Add(this.btAssignToDepartment);
            this.pEmplyee.Controls.Add(this.label4);
            this.pEmplyee.Controls.Add(this.tbPhoneNumber);
            this.pEmplyee.Controls.Add(this.tbEmailAddress);
            this.pEmplyee.Controls.Add(this.btPromote);
            this.pEmplyee.Controls.Add(this.tbLastName);
            this.pEmplyee.Controls.Add(this.cmbDepartment);
            this.pEmplyee.Controls.Add(this.btAddEmployee);
            this.pEmplyee.Controls.Add(this.tbAddress);
            this.pEmplyee.Controls.Add(this.tbName);
            this.pEmplyee.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.pEmplyee.Location = new System.Drawing.Point(300, 88);
            this.pEmplyee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pEmplyee.Name = "pEmplyee";
            this.pEmplyee.Size = new System.Drawing.Size(798, 325);
            this.pEmplyee.TabIndex = 7;
            // 
=======
            this.pEmplyee.Location = new System.Drawing.Point(200, 57);
            this.pEmplyee.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pEmplyee.Name = "pEmplyee";
            this.pEmplyee.Size = new System.Drawing.Size(532, 211);
            this.pEmplyee.TabIndex = 7;
            // 
            // btnCheckInfoPromot
            // 
            this.btnCheckInfoPromot.BackColor = System.Drawing.Color.Maroon;
            this.btnCheckInfoPromot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckInfoPromot.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheckInfoPromot.Location = new System.Drawing.Point(285, 188);
            this.btnCheckInfoPromot.Name = "btnCheckInfoPromot";
            this.btnCheckInfoPromot.Size = new System.Drawing.Size(109, 23);
            this.btnCheckInfoPromot.TabIndex = 145;
            this.btnCheckInfoPromot.Text = "Check info";
            this.btnCheckInfoPromot.UseVisualStyleBackColor = false;
            this.btnCheckInfoPromot.Click += new System.EventHandler(this.btnCheckInfoPromot_Click);
            // 
            // cmbNamePromote
            // 
            this.cmbNamePromote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cmbNamePromote.FormattingEnabled = true;
            this.cmbNamePromote.Location = new System.Drawing.Point(334, 120);
            this.cmbNamePromote.Name = "cmbNamePromote";
            this.cmbNamePromote.Size = new System.Drawing.Size(51, 28);
            this.cmbNamePromote.TabIndex = 144;
            // 
            // tbPromoteDepartment
            // 
            this.tbPromoteDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbPromoteDepartment.Location = new System.Drawing.Point(334, 146);
            this.tbPromoteDepartment.Name = "tbPromoteDepartment";
            this.tbPromoteDepartment.Size = new System.Drawing.Size(51, 26);
            this.tbPromoteDepartment.TabIndex = 143;
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(285, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 18);
            this.label11.TabIndex = 142;
            this.label11.Text = "DEPARTMENT";
            // 
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            // cmbNameAssign
            // 
            this.cmbNameAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cmbNameAssign.FormattingEnabled = true;
<<<<<<< HEAD
            this.cmbNameAssign.Location = new System.Drawing.Point(498, 8);
            this.cmbNameAssign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNameAssign.Name = "cmbNameAssign";
            this.cmbNameAssign.Size = new System.Drawing.Size(74, 37);
=======
            this.cmbNameAssign.Location = new System.Drawing.Point(332, 5);
            this.cmbNameAssign.Name = "cmbNameAssign";
            this.cmbNameAssign.Size = new System.Drawing.Size(51, 28);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.cmbNameAssign.TabIndex = 141;
            // 
            // lbEmployee
            // 
            this.lbEmployee.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployee.FormattingEnabled = true;
<<<<<<< HEAD
            this.lbEmployee.ItemHeight = 25;
            this.lbEmployee.Location = new System.Drawing.Point(612, 12);
            this.lbEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(162, 254);
            this.lbEmployee.TabIndex = 140;
            // 
=======
            this.lbEmployee.ItemHeight = 20;
            this.lbEmployee.Location = new System.Drawing.Point(408, 8);
            this.lbEmployee.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(109, 164);
            this.lbEmployee.TabIndex = 140;
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.Location = new System.Drawing.Point(285, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 18);
            this.label10.TabIndex = 138;
            this.label10.Text = "NAME";
            // 
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            // label16
            // 
            this.label16.AllowDrop = true;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
<<<<<<< HEAD
            this.label16.Location = new System.Drawing.Point(3, 184);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(192, 26);
=======
            this.label16.Location = new System.Drawing.Point(2, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 18);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.label16.TabIndex = 137;
            this.label16.Text = "EMAIL ADDRESS";
            // 
            // label13
            // 
            this.label13.AllowDrop = true;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
<<<<<<< HEAD
            this.label13.Location = new System.Drawing.Point(3, 228);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 26);
=======
            this.label13.Location = new System.Drawing.Point(2, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 18);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.label13.TabIndex = 134;
            this.label13.Text = "PHONE NUMBER";
            // 
            // label12
            // 
            this.label12.AllowDrop = true;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label12.Location = new System.Drawing.Point(50, 140);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 26);
=======
            this.label12.Location = new System.Drawing.Point(33, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 18);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.label12.TabIndex = 133;
            this.label12.Text = "LAST NAME";
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
<<<<<<< HEAD
            this.label9.Location = new System.Drawing.Point(28, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 26);
=======
            this.label9.Location = new System.Drawing.Point(19, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 18);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.label9.TabIndex = 130;
            this.label9.Text = "DEPARTMENT";
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
<<<<<<< HEAD
            this.label8.Location = new System.Drawing.Point(74, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 26);
=======
            this.label8.Location = new System.Drawing.Point(49, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.label8.TabIndex = 129;
            this.label8.Text = "ADDRESS";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(53, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
=======
            this.label2.Location = new System.Drawing.Point(35, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.label2.TabIndex = 128;
            this.label2.Text = "FIRST NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(335, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 26);
=======
            this.label1.Location = new System.Drawing.Point(223, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.label1.TabIndex = 126;
            this.label1.Text = "DEPARTMENT";
            // 
            // cmbDepartemntAssign
            // 
            this.cmbDepartemntAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cmbDepartemntAssign.FormattingEnabled = true;
            this.cmbDepartemntAssign.Items.AddRange(new object[] {
            "Manager ",
            "Employee.Phones",
            "Employee.TV ",
            "Employee.Computer",
            "Depo Workers"});
<<<<<<< HEAD
            this.cmbDepartemntAssign.Location = new System.Drawing.Point(500, 52);
            this.cmbDepartemntAssign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDepartemntAssign.Name = "cmbDepartemntAssign";
            this.cmbDepartemntAssign.Size = new System.Drawing.Size(74, 37);
=======
            this.cmbDepartemntAssign.Location = new System.Drawing.Point(333, 34);
            this.cmbDepartemntAssign.Name = "cmbDepartemntAssign";
            this.cmbDepartemntAssign.Size = new System.Drawing.Size(51, 28);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.cmbDepartemntAssign.TabIndex = 125;
            // 
            // btAssignToDepartment
            // 
            this.btAssignToDepartment.BackColor = System.Drawing.Color.Maroon;
            this.btAssignToDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btAssignToDepartment.ForeColor = System.Drawing.SystemColors.Control;
<<<<<<< HEAD
            this.btAssignToDepartment.Location = new System.Drawing.Point(340, 106);
            this.btAssignToDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAssignToDepartment.Name = "btAssignToDepartment";
            this.btAssignToDepartment.Size = new System.Drawing.Size(234, 71);
=======
            this.btAssignToDepartment.Location = new System.Drawing.Point(227, 69);
            this.btAssignToDepartment.Name = "btAssignToDepartment";
            this.btAssignToDepartment.Size = new System.Drawing.Size(156, 46);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.btAssignToDepartment.TabIndex = 122;
            this.btAssignToDepartment.Text = "Assign to Department";
            this.btAssignToDepartment.UseVisualStyleBackColor = false;
            this.btAssignToDepartment.Click += new System.EventHandler(this.btAssignToDepartment_Click);
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
<<<<<<< HEAD
            this.label4.Location = new System.Drawing.Point(417, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
=======
            this.label4.Location = new System.Drawing.Point(278, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.label4.TabIndex = 123;
            this.label4.Text = "NAME";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
<<<<<<< HEAD
            this.tbPhoneNumber.Location = new System.Drawing.Point(204, 222);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(73, 35);
=======
            this.tbPhoneNumber.Location = new System.Drawing.Point(136, 144);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(50, 26);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.tbPhoneNumber.TabIndex = 119;
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
<<<<<<< HEAD
            this.tbEmailAddress.Location = new System.Drawing.Point(204, 178);
            this.tbEmailAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(73, 35);
            this.tbEmailAddress.TabIndex = 118;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbLastName.Location = new System.Drawing.Point(204, 135);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(73, 35);
=======
            this.tbEmailAddress.Location = new System.Drawing.Point(136, 116);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(50, 26);
            this.tbEmailAddress.TabIndex = 118;
            // 
            // btPromote
            // 
            this.btPromote.BackColor = System.Drawing.Color.Maroon;
            this.btPromote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPromote.ForeColor = System.Drawing.SystemColors.Control;
            this.btPromote.Location = new System.Drawing.Point(285, 168);
            this.btPromote.Name = "btPromote";
            this.btPromote.Size = new System.Drawing.Size(109, 23);
            this.btPromote.TabIndex = 117;
            this.btPromote.Text = "Promote";
            this.btPromote.UseVisualStyleBackColor = false;
            this.btPromote.Click += new System.EventHandler(this.btPromote_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbLastName.Location = new System.Drawing.Point(136, 88);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(50, 26);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.tbLastName.TabIndex = 116;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cmbDepartment.FormattingEnabled = true;
<<<<<<< HEAD
            this.cmbDepartment.Location = new System.Drawing.Point(204, 94);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(73, 37);
=======
            this.cmbDepartment.Location = new System.Drawing.Point(136, 61);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(50, 28);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.cmbDepartment.TabIndex = 115;
            // 
            // btAddEmployee
            // 
            this.btAddEmployee.BackColor = System.Drawing.Color.Maroon;
            this.btAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btAddEmployee.ForeColor = System.Drawing.SystemColors.Control;
<<<<<<< HEAD
            this.btAddEmployee.Location = new System.Drawing.Point(10, 269);
            this.btAddEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAddEmployee.Name = "btAddEmployee";
            this.btAddEmployee.Size = new System.Drawing.Size(268, 35);
=======
            this.btAddEmployee.Location = new System.Drawing.Point(7, 175);
            this.btAddEmployee.Name = "btAddEmployee";
            this.btAddEmployee.Size = new System.Drawing.Size(179, 23);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.btAddEmployee.TabIndex = 113;
            this.btAddEmployee.Text = "Add";
            this.btAddEmployee.UseVisualStyleBackColor = false;
            this.btAddEmployee.Click += new System.EventHandler(this.btAddEmployee_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
<<<<<<< HEAD
            this.tbAddress.Location = new System.Drawing.Point(204, 50);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(73, 35);
=======
            this.tbAddress.Location = new System.Drawing.Point(136, 32);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(50, 26);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.tbAddress.TabIndex = 111;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
<<<<<<< HEAD
            this.tbName.Location = new System.Drawing.Point(202, 8);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(72, 35);
=======
            this.tbName.Location = new System.Drawing.Point(135, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(49, 26);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.tbName.TabIndex = 110;
            // 
            // pStatistics
            // 
            this.pStatistics.BackColor = System.Drawing.Color.White;
            this.pStatistics.Controls.Add(this.cmbItemsStats);
            this.pStatistics.Controls.Add(this.lbStatistics);
            this.pStatistics.Controls.Add(this.btViewStatsOverall);
            this.pStatistics.Controls.Add(this.btViewDepartmentStats);
            this.pStatistics.Controls.Add(this.label6);
            this.pStatistics.Controls.Add(this.cmbDepartmentStats);
            this.pStatistics.Controls.Add(this.btViewItemStats);
            this.pStatistics.Controls.Add(this.label5);
<<<<<<< HEAD
            this.pStatistics.Controls.Add(this.tbNameStats);
            this.pStatistics.Location = new System.Drawing.Point(14, 419);
            this.pStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pStatistics.Name = "pStatistics";
            this.pStatistics.Size = new System.Drawing.Size(616, 256);
=======
            this.pStatistics.Location = new System.Drawing.Point(48, 461);
            this.pStatistics.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pStatistics.Name = "pStatistics";
            this.pStatistics.Size = new System.Drawing.Size(411, 166);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.pStatistics.TabIndex = 8;
            // 
            // cmbItemsStats
            // 
            this.cmbItemsStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cmbItemsStats.FormattingEnabled = true;
            this.cmbItemsStats.Location = new System.Drawing.Point(101, 32);
            this.cmbItemsStats.Name = "cmbItemsStats";
            this.cmbItemsStats.Size = new System.Drawing.Size(121, 28);
            this.cmbItemsStats.TabIndex = 43;
            // 
            // lbStatistics
            // 
            this.lbStatistics.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatistics.FormattingEnabled = true;
<<<<<<< HEAD
            this.lbStatistics.ItemHeight = 25;
            this.lbStatistics.Location = new System.Drawing.Point(18, 162);
            this.lbStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbStatistics.Name = "lbStatistics";
            this.lbStatistics.Size = new System.Drawing.Size(312, 54);
=======
            this.lbStatistics.ItemHeight = 20;
            this.lbStatistics.Location = new System.Drawing.Point(12, 105);
            this.lbStatistics.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbStatistics.Name = "lbStatistics";
            this.lbStatistics.Size = new System.Drawing.Size(209, 24);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.lbStatistics.TabIndex = 42;
            // 
            // btViewStatsOverall
            // 
            this.btViewStatsOverall.BackColor = System.Drawing.Color.Maroon;
            this.btViewStatsOverall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btViewStatsOverall.ForeColor = System.Drawing.SystemColors.Control;
<<<<<<< HEAD
            this.btViewStatsOverall.Location = new System.Drawing.Point(342, 162);
            this.btViewStatsOverall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btViewStatsOverall.Name = "btViewStatsOverall";
            this.btViewStatsOverall.Size = new System.Drawing.Size(234, 51);
=======
            this.btViewStatsOverall.Location = new System.Drawing.Point(228, 105);
            this.btViewStatsOverall.Name = "btViewStatsOverall";
            this.btViewStatsOverall.Size = new System.Drawing.Size(156, 24);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.btViewStatsOverall.TabIndex = 41;
            this.btViewStatsOverall.Text = "View statistics overall";
            this.btViewStatsOverall.UseVisualStyleBackColor = false;
            this.btViewStatsOverall.Click += new System.EventHandler(this.btViewStatsOverall_Click);
            // 
            // btViewDepartmentStats
            // 
            this.btViewDepartmentStats.BackColor = System.Drawing.Color.Maroon;
            this.btViewDepartmentStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewDepartmentStats.ForeColor = System.Drawing.SystemColors.Control;
<<<<<<< HEAD
            this.btViewDepartmentStats.Location = new System.Drawing.Point(342, 51);
            this.btViewDepartmentStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btViewDepartmentStats.Name = "btViewDepartmentStats";
            this.btViewDepartmentStats.Size = new System.Drawing.Size(234, 48);
=======
            this.btViewDepartmentStats.Location = new System.Drawing.Point(228, 33);
            this.btViewDepartmentStats.Name = "btViewDepartmentStats";
            this.btViewDepartmentStats.Size = new System.Drawing.Size(156, 31);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.btViewDepartmentStats.TabIndex = 40;
            this.btViewDepartmentStats.Text = "View department statistics";
            this.btViewDepartmentStats.UseVisualStyleBackColor = false;
            this.btViewDepartmentStats.Click += new System.EventHandler(this.btViewDepartmentStats_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
<<<<<<< HEAD
            this.label6.Location = new System.Drawing.Point(8, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 26);
=======
            this.label6.Location = new System.Drawing.Point(5, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.label6.TabIndex = 39;
            this.label6.Text = "DEPARTMENT";
            // 
            // cmbDepartmentStats
            // 
            this.cmbDepartmentStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cmbDepartmentStats.FormattingEnabled = true;
<<<<<<< HEAD
            this.cmbDepartmentStats.Location = new System.Drawing.Point(150, 102);
            this.cmbDepartmentStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDepartmentStats.Name = "cmbDepartmentStats";
            this.cmbDepartmentStats.Size = new System.Drawing.Size(180, 37);
=======
            this.cmbDepartmentStats.Items.AddRange(new object[] {
            "Depot Worker",
            "Manager ",
            "Administrator",
            "Employee"});
            this.cmbDepartmentStats.Location = new System.Drawing.Point(100, 66);
            this.cmbDepartmentStats.Name = "cmbDepartmentStats";
            this.cmbDepartmentStats.Size = new System.Drawing.Size(121, 28);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.cmbDepartmentStats.TabIndex = 38;
            // 
            // btViewItemStats
            // 
<<<<<<< HEAD
            this.btViewEmployeeStats.BackColor = System.Drawing.Color.Maroon;
            this.btViewEmployeeStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewEmployeeStats.ForeColor = System.Drawing.SystemColors.Control;
            this.btViewEmployeeStats.Location = new System.Drawing.Point(342, 108);
            this.btViewEmployeeStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btViewEmployeeStats.Name = "btViewEmployeeStats";
            this.btViewEmployeeStats.Size = new System.Drawing.Size(234, 35);
            this.btViewEmployeeStats.TabIndex = 36;
            this.btViewEmployeeStats.Text = "View statistics";
            this.btViewEmployeeStats.UseVisualStyleBackColor = false;
=======
            this.btViewItemStats.BackColor = System.Drawing.Color.Maroon;
            this.btViewItemStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewItemStats.ForeColor = System.Drawing.Color.White;
            this.btViewItemStats.Location = new System.Drawing.Point(228, 70);
            this.btViewItemStats.Name = "btViewItemStats";
            this.btViewItemStats.Size = new System.Drawing.Size(156, 23);
            this.btViewItemStats.TabIndex = 36;
            this.btViewItemStats.Text = "View statistics for an item";
            this.btViewItemStats.UseVisualStyleBackColor = false;
            this.btViewItemStats.Click += new System.EventHandler(this.btViewItemStats_Click);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
<<<<<<< HEAD
            this.label5.Location = new System.Drawing.Point(72, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 26);
            this.label5.TabIndex = 37;
            this.label5.Text = "NAME";
            // 
            // tbNameStats
            // 
            this.tbNameStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbNameStats.Location = new System.Drawing.Point(150, 51);
            this.tbNameStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNameStats.Name = "tbNameStats";
            this.tbNameStats.Size = new System.Drawing.Size(180, 35);
            this.tbNameStats.TabIndex = 35;
=======
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "ITEM NAME";
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            // 
            // pStock
            // 
            this.pStock.BackColor = System.Drawing.Color.White;
            this.pStock.Controls.Add(this.lbItems);
            this.pStock.Controls.Add(this.btViewStockEmployee);
            this.pStock.Controls.Add(this.btSendRestockRequest);
<<<<<<< HEAD
            this.pStock.Controls.Add(this.tbItemIDRestock);
            this.pStock.Controls.Add(this.label7);
            this.pStock.Controls.Add(this.btCheckAvailability);
            this.pStock.Controls.Add(this.tbItemID);
            this.pStock.Controls.Add(this.label3);
            this.pStock.Location = new System.Drawing.Point(640, 419);
            this.pStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pStock.Name = "pStock";
            this.pStock.Size = new System.Drawing.Size(688, 244);
=======
            this.pStock.Location = new System.Drawing.Point(427, 272);
            this.pStock.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pStock.Name = "pStock";
            this.pStock.Size = new System.Drawing.Size(511, 159);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.pStock.TabIndex = 9;
            // 
            // lbItems
            // 
            this.lbItems.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItems.FormattingEnabled = true;
<<<<<<< HEAD
            this.lbItems.ItemHeight = 25;
            this.lbItems.Location = new System.Drawing.Point(489, 9);
            this.lbItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(181, 179);
=======
            this.lbItems.ItemHeight = 20;
            this.lbItems.Location = new System.Drawing.Point(11, 10);
            this.lbItems.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(302, 404);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.lbItems.TabIndex = 141;
            // 
            // btViewStockEmployee
            // 
            this.btViewStockEmployee.BackColor = System.Drawing.Color.Maroon;
            this.btViewStockEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btViewStockEmployee.ForeColor = System.Drawing.SystemColors.Control;
<<<<<<< HEAD
            this.btViewStockEmployee.Location = new System.Drawing.Point(289, 114);
            this.btViewStockEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btViewStockEmployee.Name = "btViewStockEmployee";
            this.btViewStockEmployee.Size = new System.Drawing.Size(182, 38);
=======
            this.btViewStockEmployee.Location = new System.Drawing.Point(336, 10);
            this.btViewStockEmployee.Name = "btViewStockEmployee";
            this.btViewStockEmployee.Size = new System.Drawing.Size(147, 33);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.btViewStockEmployee.TabIndex = 26;
            this.btViewStockEmployee.Text = "View stock";
            this.btViewStockEmployee.UseVisualStyleBackColor = false;
            this.btViewStockEmployee.Click += new System.EventHandler(this.btViewStockEmployee_Click);
            // 
            // btSendRestockRequest
            // 
            this.btSendRestockRequest.BackColor = System.Drawing.Color.Maroon;
            this.btSendRestockRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btSendRestockRequest.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.btSendRestockRequest.Location = new System.Drawing.Point(30, 162);
            this.btSendRestockRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSendRestockRequest.Name = "btSendRestockRequest";
            this.btSendRestockRequest.Size = new System.Drawing.Size(452, 51);
=======
            this.btSendRestockRequest.Location = new System.Drawing.Point(336, 49);
            this.btSendRestockRequest.Name = "btSendRestockRequest";
            this.btSendRestockRequest.Size = new System.Drawing.Size(147, 33);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.btSendRestockRequest.TabIndex = 29;
            this.btSendRestockRequest.Text = "Stock request";
            this.btSendRestockRequest.UseVisualStyleBackColor = false;
            this.btSendRestockRequest.Click += new System.EventHandler(this.btSendRestockRequest_Click);
            // 
<<<<<<< HEAD
            // tbItemIDRestock
            // 
            this.tbItemIDRestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbItemIDRestock.Location = new System.Drawing.Point(161, 118);
            this.tbItemIDRestock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbItemIDRestock.Name = "tbItemIDRestock";
            this.tbItemIDRestock.Size = new System.Drawing.Size(118, 35);
            this.tbItemIDRestock.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(-1, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 26);
            this.label7.TabIndex = 28;
            this.label7.Text = "DEPARTMENT";
            // 
            // btCheckAvailability
            // 
            this.btCheckAvailability.BackColor = System.Drawing.Color.Maroon;
            this.btCheckAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btCheckAvailability.ForeColor = System.Drawing.Color.White;
            this.btCheckAvailability.Location = new System.Drawing.Point(290, 60);
            this.btCheckAvailability.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCheckAvailability.Name = "btCheckAvailability";
            this.btCheckAvailability.Size = new System.Drawing.Size(182, 35);
            this.btCheckAvailability.TabIndex = 25;
            this.btCheckAvailability.Text = "Check availability";
            this.btCheckAvailability.UseVisualStyleBackColor = false;
            this.btCheckAvailability.Click += new System.EventHandler(this.btCheckAvailability_Click);
            // 
            // tbItemID
            // 
            this.tbItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbItemID.Location = new System.Drawing.Point(158, 60);
            this.tbItemID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbItemID.Name = "tbItemID";
            this.tbItemID.Size = new System.Drawing.Size(119, 35);
            this.tbItemID.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(57, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "ITEM ID";
            // 
=======
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
<<<<<<< HEAD
            this.pictureBox1.Location = new System.Drawing.Point(58, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 92);
=======
            this.pictureBox1.Location = new System.Drawing.Point(39, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 60);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btSchedule
            // 
            this.btSchedule.BackColor = System.Drawing.Color.Maroon;
            this.btSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchedule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
<<<<<<< HEAD
            this.btSchedule.Location = new System.Drawing.Point(484, 24);
            this.btSchedule.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btSchedule.Name = "btSchedule";
            this.btSchedule.Padding = new System.Windows.Forms.Padding(2);
            this.btSchedule.Size = new System.Drawing.Size(256, 51);
=======
            this.btSchedule.Location = new System.Drawing.Point(323, 16);
            this.btSchedule.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btSchedule.Name = "btSchedule";
            this.btSchedule.Padding = new System.Windows.Forms.Padding(1);
            this.btSchedule.Size = new System.Drawing.Size(171, 33);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.btSchedule.TabIndex = 11;
            this.btSchedule.Text = "SCHEDULE";
            this.btSchedule.UseVisualStyleBackColor = false;
            this.btSchedule.Click += new System.EventHandler(this.btSchedule_Click);
            // 
            // pSchedule
            // 
            this.pSchedule.BackColor = System.Drawing.Color.White;
            this.pSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
<<<<<<< HEAD
            this.pSchedule.Location = new System.Drawing.Point(1117, 95);
            this.pSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pSchedule.Name = "pSchedule";
            this.pSchedule.Size = new System.Drawing.Size(212, 289);
=======
            this.pSchedule.Location = new System.Drawing.Point(745, 62);
            this.pSchedule.Name = "pSchedule";
            this.pSchedule.Size = new System.Drawing.Size(141, 188);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.pSchedule.TabIndex = 12;
            this.pSchedule.Visible = false;
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.Location = new System.Drawing.Point(428, 193);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 26);
            this.label10.TabIndex = 138;
            this.label10.Text = "NAME";
            // 
            // cmbNamePromote
            // 
            this.cmbNamePromote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cmbNamePromote.FormattingEnabled = true;
            this.cmbNamePromote.Location = new System.Drawing.Point(501, 184);
            this.cmbNamePromote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNamePromote.Name = "cmbNamePromote";
            this.cmbNamePromote.Size = new System.Drawing.Size(74, 37);
            this.cmbNamePromote.TabIndex = 144;
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(428, 231);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 26);
            this.label11.TabIndex = 142;
            this.label11.Text = "DEPARTMENT";
            // 
            // tbPromoteDepartment
            // 
            this.tbPromoteDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbPromoteDepartment.Location = new System.Drawing.Point(501, 224);
            this.tbPromoteDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPromoteDepartment.Name = "tbPromoteDepartment";
            this.tbPromoteDepartment.Size = new System.Drawing.Size(74, 35);
            this.tbPromoteDepartment.TabIndex = 143;
            // 
            // btPromote
            // 
            this.btPromote.BackColor = System.Drawing.Color.Maroon;
            this.btPromote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPromote.ForeColor = System.Drawing.SystemColors.Control;
            this.btPromote.Location = new System.Drawing.Point(428, 258);
            this.btPromote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPromote.Name = "btPromote";
            this.btPromote.Size = new System.Drawing.Size(164, 35);
            this.btPromote.TabIndex = 117;
            this.btPromote.Text = "Promote";
            this.btPromote.UseVisualStyleBackColor = false;
            this.btPromote.Click += new System.EventHandler(this.btPromote_Click);
            // 
            // Form1
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1424, 675);
=======
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(949, 664);
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
            this.Controls.Add(this.pSchedule);
            this.Controls.Add(this.pStock);
            this.Controls.Add(this.pStatistics);
            this.Controls.Add(this.pEmplyee);
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.btEmployee);
            this.Controls.Add(this.btStatistics);
            this.Controls.Add(this.btStock);
            this.Controls.Add(this.btlogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSchedule);
            this.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
=======
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartemntAssign;
        private System.Windows.Forms.Button btAssignToDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Button btAddEmployee;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel pStatistics;
        private System.Windows.Forms.ListBox lbStatistics;
        private System.Windows.Forms.Button btViewStatsOverall;
        private System.Windows.Forms.Button btViewDepartmentStats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDepartmentStats;
        private System.Windows.Forms.Button btViewItemStats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pStock;
        private System.Windows.Forms.Button btViewStockEmployee;
        private System.Windows.Forms.Button btSendRestockRequest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbEmployee;
<<<<<<< HEAD
=======
        private System.Windows.Forms.Label label10;
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Button btSchedule;
        private System.Windows.Forms.Panel pSchedule;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbNameAssign;
<<<<<<< HEAD
        private System.Windows.Forms.ComboBox cmbNamePromote;
        private System.Windows.Forms.TextBox tbPromoteDepartment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btPromote;
=======
        private System.Windows.Forms.TextBox tbPromoteDepartment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbNamePromote;
        private System.Windows.Forms.Button btnCheckInfoPromot;
        private System.Windows.Forms.ComboBox cmbItemsStats;
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
    }
}

