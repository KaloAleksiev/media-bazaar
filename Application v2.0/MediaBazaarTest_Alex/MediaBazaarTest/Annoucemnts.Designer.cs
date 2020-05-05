namespace MediaBazaarTest
{
    partial class Annoucemnts
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
            this.rtbAnnoucemntText = new System.Windows.Forms.RichTextBox();
            this.dtpstart_date = new System.Windows.Forms.DateTimePicker();
            this.dtpend_picker = new System.Windows.Forms.DateTimePicker();
            this.btnAddAnnoucemnt = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvANnoucemnts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvANnoucemnts)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbAnnoucemntText
            // 
            this.rtbAnnoucemntText.Location = new System.Drawing.Point(51, 86);
            this.rtbAnnoucemntText.Name = "rtbAnnoucemntText";
            this.rtbAnnoucemntText.Size = new System.Drawing.Size(466, 138);
            this.rtbAnnoucemntText.TabIndex = 0;
            this.rtbAnnoucemntText.Text = "";
            // 
            // dtpstart_date
            // 
            this.dtpstart_date.Location = new System.Drawing.Point(204, 249);
            this.dtpstart_date.Name = "dtpstart_date";
            this.dtpstart_date.Size = new System.Drawing.Size(304, 26);
            this.dtpstart_date.TabIndex = 1;
            // 
            // dtpend_picker
            // 
            this.dtpend_picker.Location = new System.Drawing.Point(204, 316);
            this.dtpend_picker.Name = "dtpend_picker";
            this.dtpend_picker.Size = new System.Drawing.Size(304, 26);
            this.dtpend_picker.TabIndex = 2;
            // 
            // btnAddAnnoucemnt
            // 
            this.btnAddAnnoucemnt.Location = new System.Drawing.Point(12, 389);
            this.btnAddAnnoucemnt.Name = "btnAddAnnoucemnt";
            this.btnAddAnnoucemnt.Size = new System.Drawing.Size(496, 62);
            this.btnAddAnnoucemnt.TabIndex = 3;
            this.btnAddAnnoucemnt.Text = "Add Annoucemnt";
            this.btnAddAnnoucemnt.UseVisualStyleBackColor = true;
            this.btnAddAnnoucemnt.Click += new System.EventHandler(this.btnAddAnnoucemnt_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(557, 500);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(493, 51);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Annoucemnt";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 472);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(496, 62);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Update Anoucemnt";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(118, 39);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(351, 26);
            this.tbTitle.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // dgvANnoucemnts
            // 
            this.dgvANnoucemnts.AllowUserToAddRows = false;
            this.dgvANnoucemnts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvANnoucemnts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvANnoucemnts.Location = new System.Drawing.Point(557, 21);
            this.dgvANnoucemnts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvANnoucemnts.Name = "dgvANnoucemnts";
            this.dgvANnoucemnts.RowHeadersWidth = 51;
            this.dgvANnoucemnts.RowTemplate.Height = 73;
            this.dgvANnoucemnts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvANnoucemnts.Size = new System.Drawing.Size(493, 455);
            this.dgvANnoucemnts.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Title";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Start Date";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "End Date";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            // 
            // Annoucemnts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1074, 619);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvANnoucemnts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddAnnoucemnt);
            this.Controls.Add(this.dtpend_picker);
            this.Controls.Add(this.dtpstart_date);
            this.Controls.Add(this.rtbAnnoucemntText);
            this.Name = "Annoucemnts";
            this.Text = "Annoucemnts";
            ((System.ComponentModel.ISupportInitialize)(this.dgvANnoucemnts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAnnoucemntText;
        private System.Windows.Forms.DateTimePicker dtpstart_date;
        private System.Windows.Forms.DateTimePicker dtpend_picker;
        private System.Windows.Forms.Button btnAddAnnoucemnt;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvANnoucemnts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}