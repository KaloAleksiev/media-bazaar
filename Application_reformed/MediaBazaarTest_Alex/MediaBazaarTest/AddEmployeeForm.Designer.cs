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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btSendEmail = new System.Windows.Forms.Button();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.pAddUser = new System.Windows.Forms.Panel();
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btCreateUserPanel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pPromote = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pPromote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.tbEmail.Location = new System.Drawing.Point(395, 140);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(197, 26);
            this.tbEmail.TabIndex = 0;
            // 
            // btSendEmail
            // 
            this.btSendEmail.BackColor = System.Drawing.Color.Maroon;
            this.btSendEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btSendEmail.ForeColor = System.Drawing.Color.White;
            this.btSendEmail.Location = new System.Drawing.Point(279, 321);
            this.btSendEmail.Name = "btSendEmail";
            this.btSendEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btSendEmail.Size = new System.Drawing.Size(140, 57);
            this.btSendEmail.TabIndex = 1;
            this.btSendEmail.Text = "Create User";
            this.btSendEmail.UseVisualStyleBackColor = false;
            this.btSendEmail.Click += new System.EventHandler(this.btSendEmail_Click);
            // 
            // tbFName
            // 
            this.tbFName.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.tbFName.Location = new System.Drawing.Point(100, 89);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(197, 26);
            this.tbFName.TabIndex = 2;
            this.tbFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFName_KeyPress);
            // 
            // tbSName
            // 
            this.tbSName.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.tbSName.Location = new System.Drawing.Point(395, 89);
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(197, 26);
            this.tbSName.TabIndex = 3;
            this.tbSName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSName_KeyPress);
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.tbAddress.Location = new System.Drawing.Point(100, 140);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(197, 26);
            this.tbAddress.TabIndex = 4;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.tbPhoneNumber.Location = new System.Drawing.Point(395, 190);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(197, 26);
            this.tbPhoneNumber.TabIndex = 6;
            this.tbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneNumber_KeyPress);
            // 
            // pAddUser
            // 
            this.pAddUser.BackColor = System.Drawing.Color.White;
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
            this.pAddUser.Location = new System.Drawing.Point(154, 576);
            this.pAddUser.Name = "pAddUser";
            this.pAddUser.Size = new System.Drawing.Size(697, 418);
            this.pAddUser.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label8.Location = new System.Drawing.Point(392, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Birthday:";
            // 
            // dtpBday
            // 
            this.dtpBday.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.dtpBday.Location = new System.Drawing.Point(395, 244);
            this.dtpBday.Name = "dtpBday";
            this.dtpBday.Size = new System.Drawing.Size(197, 26);
            this.dtpBday.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label7.Location = new System.Drawing.Point(100, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Position:";
            // 
            // cmbPosition
            // 
            this.cmbPosition.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(103, 247);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(197, 24);
            this.cmbPosition.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label6.Location = new System.Drawing.Point(99, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Department:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(103, 192);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(197, 24);
            this.cmbDepartment.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label5.Location = new System.Drawing.Point(392, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label4.Location = new System.Drawing.Point(392, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label3.Location = new System.Drawing.Point(100, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label2.Location = new System.Drawing.Point(392, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(5, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 66);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(425, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Employee";
            // 
            // btCreateUserPanel
            // 
            this.btCreateUserPanel.BackColor = System.Drawing.Color.Maroon;
            this.btCreateUserPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btCreateUserPanel.ForeColor = System.Drawing.Color.White;
            this.btCreateUserPanel.Location = new System.Drawing.Point(5, 84);
            this.btCreateUserPanel.Name = "btCreateUserPanel";
            this.btCreateUserPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btCreateUserPanel.Size = new System.Drawing.Size(140, 70);
            this.btCreateUserPanel.TabIndex = 18;
            this.btCreateUserPanel.Text = "Add a new employee";
            this.btCreateUserPanel.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(5, 160);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(140, 74);
            this.button2.TabIndex = 19;
            this.button2.Text = "Promote / Fire";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pPromote
            // 
            this.pPromote.BackColor = System.Drawing.Color.White;
            this.pPromote.Controls.Add(this.dgvEmployee);
            this.pPromote.Location = new System.Drawing.Point(151, 84);
            this.pPromote.Name = "pPromote";
            this.pPromote.Size = new System.Drawing.Size(1089, 450);
            this.pPromote.TabIndex = 7;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Surname,
            this.Position,
            this.Department,
            this.Rank,
            this.Salary});
            this.dgvEmployee.Location = new System.Drawing.Point(16, 54);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(1055, 376);
            this.dgvEmployee.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            // 
            // Rank
            // 
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1270, 650);
            this.Controls.Add(this.pAddUser);
            this.Controls.Add(this.pPromote);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btCreateUserPanel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            //this.Name = "AddEmployeeForm";
            this.Text = "Form1";
            this.pAddUser.ResumeLayout(false);
            this.pAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pPromote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btSendEmail;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.DateTimePicker dtpBday;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btCreateUserPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pAddUser;
        private System.Windows.Forms.Panel pPromote;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
    }
}

