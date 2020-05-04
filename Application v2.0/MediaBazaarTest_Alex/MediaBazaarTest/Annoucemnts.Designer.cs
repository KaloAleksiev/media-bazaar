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
            this.SuspendLayout();
            // 
            // rtbAnnoucemntText
            // 
            this.rtbAnnoucemntText.Location = new System.Drawing.Point(51, 53);
            this.rtbAnnoucemntText.Name = "rtbAnnoucemntText";
            this.rtbAnnoucemntText.Size = new System.Drawing.Size(655, 138);
            this.rtbAnnoucemntText.TabIndex = 0;
            this.rtbAnnoucemntText.Text = "";
            // 
            // dtpstart_date
            // 
            this.dtpstart_date.Location = new System.Drawing.Point(52, 228);
            this.dtpstart_date.Name = "dtpstart_date";
            this.dtpstart_date.Size = new System.Drawing.Size(304, 26);
            this.dtpstart_date.TabIndex = 1;
            // 
            // dtpend_picker
            // 
            this.dtpend_picker.Location = new System.Drawing.Point(402, 228);
            this.dtpend_picker.Name = "dtpend_picker";
            this.dtpend_picker.Size = new System.Drawing.Size(304, 26);
            this.dtpend_picker.TabIndex = 2;
            // 
            // btnAddAnnoucemnt
            // 
            this.btnAddAnnoucemnt.Location = new System.Drawing.Point(52, 284);
            this.btnAddAnnoucemnt.Name = "btnAddAnnoucemnt";
            this.btnAddAnnoucemnt.Size = new System.Drawing.Size(206, 62);
            this.btnAddAnnoucemnt.TabIndex = 3;
            this.btnAddAnnoucemnt.Text = "Add Annoucemnt";
            this.btnAddAnnoucemnt.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(277, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(206, 62);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Annoucemnt";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(500, 284);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(206, 62);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "EditAnoucemnt";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // Annoucemnts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 388);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddAnnoucemnt);
            this.Controls.Add(this.dtpend_picker);
            this.Controls.Add(this.dtpstart_date);
            this.Controls.Add(this.rtbAnnoucemntText);
            this.Name = "Annoucemnts";
            this.Text = "Annoucemnts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAnnoucemntText;
        private System.Windows.Forms.DateTimePicker dtpstart_date;
        private System.Windows.Forms.DateTimePicker dtpend_picker;
        private System.Windows.Forms.Button btnAddAnnoucemnt;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}