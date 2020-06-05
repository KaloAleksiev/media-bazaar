namespace MediaBazaarTest
{
    partial class AddEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            this.pAllEmployees = new System.Windows.Forms.Panel();
            this.tbFireSelected = new System.Windows.Forms.Button();
            this.btPromoteSelected = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pPromoteEmployee = new System.Windows.Forms.Panel();
            this.btChangeSalary = new System.Windows.Forms.Button();
            this.btChangePosition = new System.Windows.Forms.Button();
            this.btChangeRank = new System.Windows.Forms.Button();
            this.btChangeDep = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.cmbRankChange = new System.Windows.Forms.ComboBox();
            this.cmbPositionChange = new System.Windows.Forms.ComboBox();
            this.cmbDepartmentChange = new System.Windows.Forms.ComboBox();
            this.lblSelectedEmployeeInfo = new System.Windows.Forms.Label();
            this.btGoBack = new System.Windows.Forms.Button();
            this.btPromoteFire = new System.Windows.Forms.Button();
            this.btCreateUserPanel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pAddUser = new System.Windows.Forms.Panel();
            this.tbOtherGender = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbOtherGender = new System.Windows.Forms.CheckBox();
            this.cbFemale = new System.Windows.Forms.CheckBox();
            this.cbMale = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbZipcode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpBday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btSendEmail = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.pAllEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.pPromoteEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pAllEmployees
            // 
            this.pAllEmployees.BackColor = System.Drawing.Color.White;
            this.pAllEmployees.Controls.Add(this.tbFireSelected);
            this.pAllEmployees.Controls.Add(this.btPromoteSelected);
            this.pAllEmployees.Controls.Add(this.dgvEmployee);
            this.pAllEmployees.Controls.Add(this.label10);
            this.pAllEmployees.Controls.Add(this.tbSearch);
            this.pAllEmployees.Location = new System.Drawing.Point(157, 84);
            this.pAllEmployees.Name = "pAllEmployees";
            this.pAllEmployees.Size = new System.Drawing.Size(700, 450);
            this.pAllEmployees.TabIndex = 20;
            // 
            // tbFireSelected
            // 
            this.tbFireSelected.BackColor = System.Drawing.Color.Maroon;
            this.tbFireSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.tbFireSelected.ForeColor = System.Drawing.Color.White;
            this.tbFireSelected.Location = new System.Drawing.Point(407, 397);
            this.tbFireSelected.Name = "tbFireSelected";
            this.tbFireSelected.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbFireSelected.Size = new System.Drawing.Size(140, 50);
            this.tbFireSelected.TabIndex = 21;
            this.tbFireSelected.Text = "Fire";
            this.tbFireSelected.UseVisualStyleBackColor = false;
            this.tbFireSelected.Click += new System.EventHandler(this.tbFireSelected_Click);
            // 
            // btPromoteSelected
            // 
            this.btPromoteSelected.BackColor = System.Drawing.Color.Maroon;
            this.btPromoteSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btPromoteSelected.ForeColor = System.Drawing.Color.White;
            this.btPromoteSelected.Location = new System.Drawing.Point(123, 397);
            this.btPromoteSelected.Name = "btPromoteSelected";
            this.btPromoteSelected.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btPromoteSelected.Size = new System.Drawing.Size(140, 50);
            this.btPromoteSelected.TabIndex = 20;
            this.btPromoteSelected.Text = "Promote";
            this.btPromoteSelected.UseVisualStyleBackColor = false;
            this.btPromoteSelected.Click += new System.EventHandler(this.btPromoteSelected_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.fNameColumn,
            this.SurnameColumn,
            this.PositionColumn,
            this.DepartmentColumn,
            this.RankColum,
            this.SalaryColumn});
            this.dgvEmployee.Location = new System.Drawing.Point(21, 72);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(653, 319);
            this.dgvEmployee.TabIndex = 0;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Width = 42;
            // 
            // fNameColumn
            // 
            this.fNameColumn.HeaderText = "Name";
            this.fNameColumn.Name = "fNameColumn";
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.HeaderText = "Surname";
            this.SurnameColumn.Name = "SurnameColumn";
            // 
            // PositionColumn
            // 
            this.PositionColumn.HeaderText = "Position";
            this.PositionColumn.Name = "PositionColumn";
            // 
            // DepartmentColumn
            // 
            this.DepartmentColumn.HeaderText = "Department";
            this.DepartmentColumn.Name = "DepartmentColumn";
            // 
            // RankColum
            // 
            this.RankColum.HeaderText = "Rank";
            this.RankColum.Name = "RankColum";
            // 
            // SalaryColumn
            // 
            this.SalaryColumn.HeaderText = "Salary";
            this.SalaryColumn.Name = "SalaryColumn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(210, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 28);
            this.label10.TabIndex = 26;
            this.label10.Text = "Search:";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbSearch.Location = new System.Drawing.Point(293, 27);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(162, 23);
            this.tbSearch.TabIndex = 22;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // pPromoteEmployee
            // 
            this.pPromoteEmployee.BackColor = System.Drawing.Color.White;
            this.pPromoteEmployee.Controls.Add(this.btChangeSalary);
            this.pPromoteEmployee.Controls.Add(this.btChangePosition);
            this.pPromoteEmployee.Controls.Add(this.btChangeRank);
            this.pPromoteEmployee.Controls.Add(this.btChangeDep);
            this.pPromoteEmployee.Controls.Add(this.label14);
            this.pPromoteEmployee.Controls.Add(this.label13);
            this.pPromoteEmployee.Controls.Add(this.label12);
            this.pPromoteEmployee.Controls.Add(this.label11);
            this.pPromoteEmployee.Controls.Add(this.tbSalary);
            this.pPromoteEmployee.Controls.Add(this.cmbRankChange);
            this.pPromoteEmployee.Controls.Add(this.cmbPositionChange);
            this.pPromoteEmployee.Controls.Add(this.cmbDepartmentChange);
            this.pPromoteEmployee.Controls.Add(this.lblSelectedEmployeeInfo);
            this.pPromoteEmployee.Controls.Add(this.btGoBack);
            this.pPromoteEmployee.Location = new System.Drawing.Point(157, 84);
            this.pPromoteEmployee.Name = "pPromoteEmployee";
            this.pPromoteEmployee.Size = new System.Drawing.Size(700, 450);
            this.pPromoteEmployee.TabIndex = 20;
            this.pPromoteEmployee.Visible = false;
            // 
            // btChangeSalary
            // 
            this.btChangeSalary.BackColor = System.Drawing.Color.Maroon;
            this.btChangeSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.btChangeSalary.ForeColor = System.Drawing.Color.White;
            this.btChangeSalary.Location = new System.Drawing.Point(498, 351);
            this.btChangeSalary.Name = "btChangeSalary";
            this.btChangeSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btChangeSalary.Size = new System.Drawing.Size(128, 34);
            this.btChangeSalary.TabIndex = 23;
            this.btChangeSalary.Text = "Change";
            this.btChangeSalary.UseVisualStyleBackColor = false;
            this.btChangeSalary.Click += new System.EventHandler(this.btChangeSalary_Click);
            // 
            // btChangePosition
            // 
            this.btChangePosition.BackColor = System.Drawing.Color.Maroon;
            this.btChangePosition.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.btChangePosition.ForeColor = System.Drawing.Color.White;
            this.btChangePosition.Location = new System.Drawing.Point(498, 184);
            this.btChangePosition.Name = "btChangePosition";
            this.btChangePosition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btChangePosition.Size = new System.Drawing.Size(128, 34);
            this.btChangePosition.TabIndex = 22;
            this.btChangePosition.Text = "Change";
            this.btChangePosition.UseVisualStyleBackColor = false;
            this.btChangePosition.Click += new System.EventHandler(this.btChangePosition_Click);
            // 
            // btChangeRank
            // 
            this.btChangeRank.BackColor = System.Drawing.Color.Maroon;
            this.btChangeRank.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.btChangeRank.ForeColor = System.Drawing.Color.White;
            this.btChangeRank.Location = new System.Drawing.Point(498, 267);
            this.btChangeRank.Name = "btChangeRank";
            this.btChangeRank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btChangeRank.Size = new System.Drawing.Size(128, 34);
            this.btChangeRank.TabIndex = 21;
            this.btChangeRank.Text = "Change";
            this.btChangeRank.UseVisualStyleBackColor = false;
            this.btChangeRank.Click += new System.EventHandler(this.btChangeRank_Click);
            // 
            // btChangeDep
            // 
            this.btChangeDep.BackColor = System.Drawing.Color.Maroon;
            this.btChangeDep.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.btChangeDep.ForeColor = System.Drawing.Color.White;
            this.btChangeDep.Location = new System.Drawing.Point(498, 106);
            this.btChangeDep.Name = "btChangeDep";
            this.btChangeDep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btChangeDep.Size = new System.Drawing.Size(128, 34);
            this.btChangeDep.TabIndex = 20;
            this.btChangeDep.Text = "Change";
            this.btChangeDep.UseVisualStyleBackColor = false;
            this.btChangeDep.Click += new System.EventHandler(this.btChangeDep_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(53, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Position";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(53, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Rank";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(53, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Salary";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(53, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Department";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(168, 358);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(122, 20);
            this.tbSalary.TabIndex = 6;
            // 
            // cmbRankChange
            // 
            this.cmbRankChange.FormattingEnabled = true;
            this.cmbRankChange.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbRankChange.Location = new System.Drawing.Point(168, 274);
            this.cmbRankChange.Name = "cmbRankChange";
            this.cmbRankChange.Size = new System.Drawing.Size(121, 21);
            this.cmbRankChange.TabIndex = 5;
            // 
            // cmbPositionChange
            // 
            this.cmbPositionChange.FormattingEnabled = true;
            this.cmbPositionChange.Location = new System.Drawing.Point(168, 193);
            this.cmbPositionChange.Name = "cmbPositionChange";
            this.cmbPositionChange.Size = new System.Drawing.Size(121, 21);
            this.cmbPositionChange.TabIndex = 4;
            // 
            // cmbDepartmentChange
            // 
            this.cmbDepartmentChange.FormattingEnabled = true;
            this.cmbDepartmentChange.Location = new System.Drawing.Point(168, 114);
            this.cmbDepartmentChange.Name = "cmbDepartmentChange";
            this.cmbDepartmentChange.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartmentChange.TabIndex = 3;
            // 
            // lblSelectedEmployeeInfo
            // 
            this.lblSelectedEmployeeInfo.AutoSize = true;
            this.lblSelectedEmployeeInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectedEmployeeInfo.Location = new System.Drawing.Point(52, 30);
            this.lblSelectedEmployeeInfo.Name = "lblSelectedEmployeeInfo";
            this.lblSelectedEmployeeInfo.Size = new System.Drawing.Size(0, 21);
            this.lblSelectedEmployeeInfo.TabIndex = 2;
            // 
            // btGoBack
            // 
            this.btGoBack.BackColor = System.Drawing.Color.Maroon;
            this.btGoBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.btGoBack.ForeColor = System.Drawing.Color.White;
            this.btGoBack.Location = new System.Drawing.Point(605, 10);
            this.btGoBack.Name = "btGoBack";
            this.btGoBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btGoBack.Size = new System.Drawing.Size(84, 34);
            this.btGoBack.TabIndex = 24;
            this.btGoBack.Text = "<<<";
            this.btGoBack.UseVisualStyleBackColor = false;
            this.btGoBack.Click += new System.EventHandler(this.btGoBack_Click);
            // 
            // btPromoteFire
            // 
            this.btPromoteFire.BackColor = System.Drawing.Color.Maroon;
            this.btPromoteFire.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btPromoteFire.ForeColor = System.Drawing.Color.White;
            this.btPromoteFire.Location = new System.Drawing.Point(11, 160);
            this.btPromoteFire.Name = "btPromoteFire";
            this.btPromoteFire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btPromoteFire.Size = new System.Drawing.Size(140, 74);
            this.btPromoteFire.TabIndex = 25;
            this.btPromoteFire.Text = "Employee List";
            this.btPromoteFire.UseVisualStyleBackColor = false;
            this.btPromoteFire.Click += new System.EventHandler(this.btPromoteFire_Click);
            // 
            // btCreateUserPanel
            // 
            this.btCreateUserPanel.BackColor = System.Drawing.Color.Maroon;
            this.btCreateUserPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btCreateUserPanel.ForeColor = System.Drawing.Color.White;
            this.btCreateUserPanel.Location = new System.Drawing.Point(11, 84);
            this.btCreateUserPanel.Name = "btCreateUserPanel";
            this.btCreateUserPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btCreateUserPanel.Size = new System.Drawing.Size(140, 70);
            this.btCreateUserPanel.TabIndex = 22;
            this.btCreateUserPanel.Text = "Add a new employee";
            this.btCreateUserPanel.UseVisualStyleBackColor = false;
            this.btCreateUserPanel.Click += new System.EventHandler(this.btCreateUserPanel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(431, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 32);
            this.label9.TabIndex = 23;
            this.label9.Text = "Employee";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 66);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pAddUser
            // 
            this.pAddUser.BackColor = System.Drawing.Color.White;
            this.pAddUser.Controls.Add(this.tbOtherGender);
            this.pAddUser.Controls.Add(this.label17);
            this.pAddUser.Controls.Add(this.cbOtherGender);
            this.pAddUser.Controls.Add(this.cbFemale);
            this.pAddUser.Controls.Add(this.cbMale);
            this.pAddUser.Controls.Add(this.label16);
            this.pAddUser.Controls.Add(this.tbZipcode);
            this.pAddUser.Controls.Add(this.label15);
            this.pAddUser.Controls.Add(this.tbCity);
            this.pAddUser.Controls.Add(this.label8);
            this.pAddUser.Controls.Add(this.dtpBday);
            this.pAddUser.Controls.Add(this.label7);
            this.pAddUser.Controls.Add(this.cmbPosition);
            this.pAddUser.Controls.Add(this.label6);
            this.pAddUser.Controls.Add(this.cmbDepartment);
            this.pAddUser.Controls.Add(this.label5);
            this.pAddUser.Controls.Add(this.label4);
            this.pAddUser.Controls.Add(this.label3);
            this.pAddUser.Controls.Add(this.label2);
            this.pAddUser.Controls.Add(this.tbPhoneNumber);
            this.pAddUser.Controls.Add(this.label1);
            this.pAddUser.Controls.Add(this.tbEmail);
            this.pAddUser.Controls.Add(this.btSendEmail);
            this.pAddUser.Controls.Add(this.tbAddress);
            this.pAddUser.Controls.Add(this.tbFName);
            this.pAddUser.Controls.Add(this.tbSName);
            this.pAddUser.Location = new System.Drawing.Point(157, 84);
            this.pAddUser.Name = "pAddUser";
            this.pAddUser.Size = new System.Drawing.Size(697, 450);
            this.pAddUser.TabIndex = 24;
            // 
            // tbOtherGender
            // 
            this.tbOtherGender.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.tbOtherGender.Location = new System.Drawing.Point(485, 289);
            this.tbOtherGender.Name = "tbOtherGender";
            this.tbOtherGender.Size = new System.Drawing.Size(197, 26);
            this.tbOtherGender.TabIndex = 26;
            this.tbOtherGender.Visible = false;
            this.tbOtherGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOtherGender_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label17.Location = new System.Drawing.Point(253, 243);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 16);
            this.label17.TabIndex = 25;
            this.label17.Text = "Gender:";
            // 
            // cbOtherGender
            // 
            this.cbOtherGender.AutoSize = true;
            this.cbOtherGender.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.cbOtherGender.Location = new System.Drawing.Point(350, 295);
            this.cbOtherGender.Name = "cbOtherGender";
            this.cbOtherGender.Size = new System.Drawing.Size(63, 20);
            this.cbOtherGender.TabIndex = 24;
            this.cbOtherGender.Text = "Other";
            this.cbOtherGender.UseVisualStyleBackColor = true;
            this.cbOtherGender.CheckedChanged += new System.EventHandler(this.cbOtherGender_CheckedChanged);
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.cbFemale.Location = new System.Drawing.Point(350, 269);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(73, 20);
            this.cbFemale.TabIndex = 23;
            this.cbFemale.Text = "Female";
            this.cbFemale.UseVisualStyleBackColor = true;
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.cbMale.Location = new System.Drawing.Point(350, 243);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(59, 20);
            this.cbMale.TabIndex = 22;
            this.cbMale.Text = "Male";
            this.cbMale.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label16.Location = new System.Drawing.Point(485, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "Zipcode:";
            // 
            // tbZipcode
            // 
            this.tbZipcode.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.tbZipcode.Location = new System.Drawing.Point(485, 123);
            this.tbZipcode.Name = "tbZipcode";
            this.tbZipcode.Size = new System.Drawing.Size(197, 26);
            this.tbZipcode.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label15.Location = new System.Drawing.Point(485, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "City:";
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.tbCity.Location = new System.Drawing.Point(485, 49);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(197, 26);
            this.tbCity.TabIndex = 18;
            this.tbCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCity_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label8.Location = new System.Drawing.Point(16, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Birthday:";
            // 
            // dtpBday
            // 
            this.dtpBday.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.dtpBday.Location = new System.Drawing.Point(19, 262);
            this.dtpBday.Name = "dtpBday";
            this.dtpBday.Size = new System.Drawing.Size(197, 26);
            this.dtpBday.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label7.Location = new System.Drawing.Point(249, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Position:";
            // 
            // cmbPosition
            // 
            this.cmbPosition.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(252, 125);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(197, 24);
            this.cmbPosition.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label6.Location = new System.Drawing.Point(247, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Department:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(251, 51);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(197, 24);
            this.cmbDepartment.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label5.Location = new System.Drawing.Point(249, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label4.Location = new System.Drawing.Point(16, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label3.Location = new System.Drawing.Point(485, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname:";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.tbPhoneNumber.Location = new System.Drawing.Point(252, 189);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(197, 26);
            this.tbPhoneNumber.TabIndex = 6;
            this.tbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.tbEmail.Location = new System.Drawing.Point(19, 189);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(197, 26);
            this.tbEmail.TabIndex = 0;
            // 
            // btSendEmail
            // 
            this.btSendEmail.BackColor = System.Drawing.Color.Maroon;
            this.btSendEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btSendEmail.ForeColor = System.Drawing.Color.White;
            this.btSendEmail.Location = new System.Drawing.Point(280, 363);
            this.btSendEmail.Name = "btSendEmail";
            this.btSendEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btSendEmail.Size = new System.Drawing.Size(140, 57);
            this.btSendEmail.TabIndex = 1;
            this.btSendEmail.Text = "Create User";
            this.btSendEmail.UseVisualStyleBackColor = false;
            this.btSendEmail.Click += new System.EventHandler(this.btSendEmail_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.tbAddress.Location = new System.Drawing.Point(485, 189);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(197, 26);
            this.tbAddress.TabIndex = 4;
            // 
            // tbFName
            // 
            this.tbFName.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.tbFName.Location = new System.Drawing.Point(19, 49);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(197, 26);
            this.tbFName.TabIndex = 2;
            this.tbFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFName_KeyPress);
            // 
            // tbSName
            // 
            this.tbSName.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.tbSName.Location = new System.Drawing.Point(19, 123);
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(197, 26);
            this.tbSName.TabIndex = 3;
            this.tbSName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSName_KeyPress);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(863, 542);
            this.Controls.Add(this.btPromoteFire);
            this.Controls.Add(this.btCreateUserPanel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pPromoteEmployee);
            this.Controls.Add(this.pAddUser);
            this.Controls.Add(this.pAllEmployees);
            this.Name = "AddEmployeeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.pAllEmployees.ResumeLayout(false);
            this.pAllEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.pPromoteEmployee.ResumeLayout(false);
            this.pPromoteEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pAddUser.ResumeLayout(false);
            this.pAddUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pAllEmployees;
        private System.Windows.Forms.Button tbFireSelected;
        private System.Windows.Forms.Button btPromoteSelected;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryColumn;
        private System.Windows.Forms.Panel pPromoteEmployee;
        private System.Windows.Forms.Button btChangeSalary;
        private System.Windows.Forms.Button btChangePosition;
        private System.Windows.Forms.Button btChangeRank;
        private System.Windows.Forms.Button btChangeDep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.ComboBox cmbRankChange;
        private System.Windows.Forms.ComboBox cmbPositionChange;
        private System.Windows.Forms.ComboBox cmbDepartmentChange;
        private System.Windows.Forms.Label lblSelectedEmployeeInfo;
        private System.Windows.Forms.Button btGoBack;
        private System.Windows.Forms.Button btPromoteFire;
        private System.Windows.Forms.Button btCreateUserPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pAddUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpBday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btSendEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbOtherGender;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox cbOtherGender;
        private System.Windows.Forms.CheckBox cbFemale;
        private System.Windows.Forms.CheckBox cbMale;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbZipcode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbCity;
    }
}

