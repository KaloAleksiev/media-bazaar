namespace CashierApp
{
    partial class CashierApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierApp));
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pLogin = new System.Windows.Forms.Panel();
            this.pForgottenPass = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btBackRetrievePass = new System.Windows.Forms.Button();
            this.btRetrievePass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNameRetrievePass = new System.Windows.Forms.TextBox();
            this.tbEmailRetrievePass = new System.Windows.Forms.TextBox();
            this.lblForgottenPass = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btAddItemToSale = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lbCurrentlyInOrder = new System.Windows.Forms.ListBox();
            this.btRemoveItemFromSale = new System.Windows.Forms.Button();
            this.btCompleteSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pLogin.SuspendLayout();
            this.pForgottenPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(157, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "Search:";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(106, 136);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(195, 29);
            this.tbSearch.TabIndex = 37;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.desc,
            this.dept,
            this.amnt});
            this.dgvStock.Location = new System.Drawing.Point(20, 198);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 73;
            this.dgvStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStock.Size = new System.Drawing.Size(634, 296);
            this.dgvStock.TabIndex = 35;
            this.dgvStock.SelectionChanged += new System.EventHandler(this.dgvStock_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // desc
            // 
            this.desc.HeaderText = "Description";
            this.desc.MinimumWidth = 6;
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Width = 250;
            // 
            // dept
            // 
            this.dept.HeaderText = "Department";
            this.dept.MinimumWidth = 6;
            this.dept.Name = "dept";
            this.dept.ReadOnly = true;
            this.dept.Width = 125;
            // 
            // amnt
            // 
            this.amnt.HeaderText = "Amount in stock";
            this.amnt.MinimumWidth = 6;
            this.amnt.Name = "amnt";
            this.amnt.ReadOnly = true;
            this.amnt.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(20, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 60);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // cbDepartment
            // 
            this.cbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(388, 136);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(184, 28);
            this.cbDepartment.TabIndex = 39;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(408, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 40;
            this.label1.Text = "Department";
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.Color.White;
            this.pLogin.Controls.Add(this.pForgottenPass);
            this.pLogin.Controls.Add(this.lblForgottenPass);
            this.pLogin.Controls.Add(this.panel4);
            this.pLogin.Controls.Add(this.panel3);
            this.pLogin.Controls.Add(this.panel2);
            this.pLogin.Controls.Add(this.panel1);
            this.pLogin.Controls.Add(this.lblLoggedIn);
            this.pLogin.Controls.Add(this.btnLogIn);
            this.pLogin.Controls.Add(this.pictureBox2);
            this.pLogin.Controls.Add(this.tbEmail);
            this.pLogin.Controls.Add(this.tbPassword);
            this.pLogin.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pLogin.Location = new System.Drawing.Point(0, 0);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(750, 354);
            this.pLogin.TabIndex = 41;
            // 
            // pForgottenPass
            // 
            this.pForgottenPass.BackColor = System.Drawing.Color.Maroon;
            this.pForgottenPass.Controls.Add(this.label7);
            this.pForgottenPass.Controls.Add(this.btBackRetrievePass);
            this.pForgottenPass.Controls.Add(this.btRetrievePass);
            this.pForgottenPass.Controls.Add(this.label3);
            this.pForgottenPass.Controls.Add(this.tbNameRetrievePass);
            this.pForgottenPass.Controls.Add(this.tbEmailRetrievePass);
            this.pForgottenPass.Location = new System.Drawing.Point(132, 72);
            this.pForgottenPass.Name = "pForgottenPass";
            this.pForgottenPass.Size = new System.Drawing.Size(501, 204);
            this.pForgottenPass.TabIndex = 25;
            this.pForgottenPass.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(85, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Email";
            // 
            // btBackRetrievePass
            // 
            this.btBackRetrievePass.BackColor = System.Drawing.Color.Maroon;
            this.btBackRetrievePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackRetrievePass.ForeColor = System.Drawing.SystemColors.Control;
            this.btBackRetrievePass.Location = new System.Drawing.Point(413, 8);
            this.btBackRetrievePass.Name = "btBackRetrievePass";
            this.btBackRetrievePass.Size = new System.Drawing.Size(64, 33);
            this.btBackRetrievePass.TabIndex = 29;
            this.btBackRetrievePass.Text = "<<<";
            this.btBackRetrievePass.UseVisualStyleBackColor = false;
            this.btBackRetrievePass.Click += new System.EventHandler(this.btBackRetrievePass_Click);
            // 
            // btRetrievePass
            // 
            this.btRetrievePass.BackColor = System.Drawing.Color.Maroon;
            this.btRetrievePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetrievePass.ForeColor = System.Drawing.SystemColors.Control;
            this.btRetrievePass.Location = new System.Drawing.Point(148, 119);
            this.btRetrievePass.Name = "btRetrievePass";
            this.btRetrievePass.Size = new System.Drawing.Size(192, 40);
            this.btRetrievePass.TabIndex = 28;
            this.btRetrievePass.Text = "Retrieve password";
            this.btRetrievePass.UseVisualStyleBackColor = false;
            this.btRetrievePass.Click += new System.EventHandler(this.btRetrievePass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Name";
            // 
            // tbNameRetrievePass
            // 
            this.tbNameRetrievePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameRetrievePass.Location = new System.Drawing.Point(151, 85);
            this.tbNameRetrievePass.Name = "tbNameRetrievePass";
            this.tbNameRetrievePass.Size = new System.Drawing.Size(189, 22);
            this.tbNameRetrievePass.TabIndex = 1;
            // 
            // tbEmailRetrievePass
            // 
            this.tbEmailRetrievePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailRetrievePass.Location = new System.Drawing.Point(151, 56);
            this.tbEmailRetrievePass.Name = "tbEmailRetrievePass";
            this.tbEmailRetrievePass.Size = new System.Drawing.Size(189, 22);
            this.tbEmailRetrievePass.TabIndex = 0;
            // 
            // lblForgottenPass
            // 
            this.lblForgottenPass.AutoSize = true;
            this.lblForgottenPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgottenPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblForgottenPass.Location = new System.Drawing.Point(384, 279);
            this.lblForgottenPass.Name = "lblForgottenPass";
            this.lblForgottenPass.Size = new System.Drawing.Size(200, 25);
            this.lblForgottenPass.TabIndex = 24;
            this.lblForgottenPass.Text = "Forgotten password ?";
            this.lblForgottenPass.Visible = false;
            this.lblForgottenPass.Click += new System.EventHandler(this.lblForgottenPass_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 340);
            this.panel4.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(743, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 340);
            this.panel3.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 7);
            this.panel2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 7);
            this.panel1.TabIndex = 20;
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblLoggedIn.ForeColor = System.Drawing.Color.Red;
            this.lblLoggedIn.Location = new System.Drawing.Point(417, 239);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(117, 25);
            this.lblLoggedIn.TabIndex = 19;
            this.lblLoggedIn.Text = "Login failed!";
            this.lblLoggedIn.Visible = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Maroon;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.Location = new System.Drawing.Point(364, 168);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(232, 55);
            this.btnLogIn.TabIndex = 13;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(145, 98);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 127);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(364, 98);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(232, 27);
            this.tbEmail.TabIndex = 15;
            this.tbEmail.Tag = "Email";
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(364, 131);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(232, 27);
            this.tbPassword.TabIndex = 16;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudAmount
            // 
            this.nudAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.Location = new System.Drawing.Point(339, 559);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(120, 26);
            this.nudAmount.TabIndex = 43;
            // 
            // btAddItemToSale
            // 
            this.btAddItemToSale.BackColor = System.Drawing.Color.Maroon;
            this.btAddItemToSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddItemToSale.ForeColor = System.Drawing.SystemColors.Control;
            this.btAddItemToSale.Location = new System.Drawing.Point(497, 551);
            this.btAddItemToSale.Name = "btAddItemToSale";
            this.btAddItemToSale.Size = new System.Drawing.Size(157, 40);
            this.btAddItemToSale.TabIndex = 44;
            this.btAddItemToSale.Text = "Add item";
            this.btAddItemToSale.UseVisualStyleBackColor = false;
            this.btAddItemToSale.Click += new System.EventHandler(this.btAddItemToSale_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.ForeColor = System.Drawing.Color.White;
            this.lblSelected.Location = new System.Drawing.Point(30, 551);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(199, 32);
            this.lblSelected.TabIndex = 45;
            this.lblSelected.Text = "No item selected";
            // 
            // lbCurrentlyInOrder
            // 
            this.lbCurrentlyInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentlyInOrder.FormattingEnabled = true;
            this.lbCurrentlyInOrder.ItemHeight = 20;
            this.lbCurrentlyInOrder.Location = new System.Drawing.Point(748, 136);
            this.lbCurrentlyInOrder.Name = "lbCurrentlyInOrder";
            this.lbCurrentlyInOrder.Size = new System.Drawing.Size(401, 284);
            this.lbCurrentlyInOrder.TabIndex = 46;
            // 
            // btRemoveItemFromSale
            // 
            this.btRemoveItemFromSale.BackColor = System.Drawing.Color.Maroon;
            this.btRemoveItemFromSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoveItemFromSale.ForeColor = System.Drawing.SystemColors.Control;
            this.btRemoveItemFromSale.Location = new System.Drawing.Point(748, 449);
            this.btRemoveItemFromSale.Name = "btRemoveItemFromSale";
            this.btRemoveItemFromSale.Size = new System.Drawing.Size(157, 40);
            this.btRemoveItemFromSale.TabIndex = 47;
            this.btRemoveItemFromSale.Text = "Remove item";
            this.btRemoveItemFromSale.UseVisualStyleBackColor = false;
            this.btRemoveItemFromSale.Click += new System.EventHandler(this.btRemoveItemFromSale_Click);
            // 
            // btCompleteSale
            // 
            this.btCompleteSale.BackColor = System.Drawing.Color.Maroon;
            this.btCompleteSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCompleteSale.ForeColor = System.Drawing.SystemColors.Control;
            this.btCompleteSale.Location = new System.Drawing.Point(992, 449);
            this.btCompleteSale.Name = "btCompleteSale";
            this.btCompleteSale.Size = new System.Drawing.Size(157, 40);
            this.btCompleteSale.TabIndex = 48;
            this.btCompleteSale.Text = "Complete sale";
            this.btCompleteSale.UseVisualStyleBackColor = false;
            this.btCompleteSale.Click += new System.EventHandler(this.btCompleteSale_Click);
            // 
            // CashierApp
            // 
            this.AcceptButton = this.btnLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.btCompleteSale);
            this.Controls.Add(this.btRemoveItemFromSale);
            this.Controls.Add(this.lbCurrentlyInOrder);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.btAddItemToSale);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CashierApp";
            this.Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.pForgottenPass.ResumeLayout(false);
            this.pForgottenPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn amnt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Panel pForgottenPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btBackRetrievePass;
        private System.Windows.Forms.Button btRetrievePass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNameRetrievePass;
        private System.Windows.Forms.TextBox tbEmailRetrievePass;
        private System.Windows.Forms.Label lblForgottenPass;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btAddItemToSale;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ListBox lbCurrentlyInOrder;
        private System.Windows.Forms.Button btRemoveItemFromSale;
        private System.Windows.Forms.Button btCompleteSale;
    }
}

