namespace MediaBazaarTest
{
    partial class ShiftAssignmentForm
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
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbShiftInfo = new System.Windows.Forms.Label();
            this.lbInShift = new System.Windows.Forms.ListBox();
            this.lbAllPpl = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(503, 58);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 17);
            this.label23.TabIndex = 26;
            this.label23.Text = "Added to shift:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(23, 58);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 17);
            this.label22.TabIndex = 25;
            this.label22.Text = "All employees:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(306, 231);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 27);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.White;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(306, 197);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(149, 27);
            this.btnConfirm.TabIndex = 23;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(306, 165);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(149, 27);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(306, 132);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 27);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbShiftInfo
            // 
            this.lbShiftInfo.AutoSize = true;
            this.lbShiftInfo.BackColor = System.Drawing.Color.White;
            this.lbShiftInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbShiftInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbShiftInfo.ForeColor = System.Drawing.Color.Black;
            this.lbShiftInfo.Location = new System.Drawing.Point(26, 17);
            this.lbShiftInfo.Name = "lbShiftInfo";
            this.lbShiftInfo.Size = new System.Drawing.Size(2, 26);
            this.lbShiftInfo.TabIndex = 2;
            this.lbShiftInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbInShift
            // 
            this.lbInShift.FormattingEnabled = true;
            this.lbInShift.ItemHeight = 16;
            this.lbInShift.Location = new System.Drawing.Point(506, 78);
            this.lbInShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbInShift.Name = "lbInShift";
            this.lbInShift.Size = new System.Drawing.Size(231, 180);
            this.lbInShift.TabIndex = 1;
            // 
            // lbAllPpl
            // 
            this.lbAllPpl.FormattingEnabled = true;
            this.lbAllPpl.ItemHeight = 16;
            this.lbAllPpl.Location = new System.Drawing.Point(26, 78);
            this.lbAllPpl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAllPpl.Name = "lbAllPpl";
            this.lbAllPpl.Size = new System.Drawing.Size(231, 180);
            this.lbAllPpl.TabIndex = 0;
            // 
            // ShiftAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 276);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lbInShift);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbAllPpl);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbShiftInfo);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "ShiftAssignmentForm";
            this.Text = "ShiftAssignmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbShiftInfo;
        private System.Windows.Forms.ListBox lbInShift;
        private System.Windows.Forms.ListBox lbAllPpl;
    }
}