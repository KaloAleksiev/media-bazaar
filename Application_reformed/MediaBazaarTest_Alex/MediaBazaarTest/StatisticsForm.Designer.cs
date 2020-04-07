namespace MediaBazaarTest
{
    partial class StatisticsForm
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
            this.btnItemStats = new System.Windows.Forms.Button();
            this.btnDepartmentStats = new System.Windows.Forms.Button();
            this.btnOverallStats = new System.Windows.Forms.Button();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnItemStats
            // 
            this.btnItemStats.BackColor = System.Drawing.Color.Maroon;
            this.btnItemStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemStats.ForeColor = System.Drawing.SystemColors.Control;
            this.btnItemStats.Location = new System.Drawing.Point(317, 12);
            this.btnItemStats.Name = "btnItemStats";
            this.btnItemStats.Size = new System.Drawing.Size(232, 40);
            this.btnItemStats.TabIndex = 14;
            this.btnItemStats.Text = "View item stats";
            this.btnItemStats.UseVisualStyleBackColor = false;
            // 
            // btnDepartmentStats
            // 
            this.btnDepartmentStats.BackColor = System.Drawing.Color.Maroon;
            this.btnDepartmentStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartmentStats.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDepartmentStats.Location = new System.Drawing.Point(317, 320);
            this.btnDepartmentStats.Name = "btnDepartmentStats";
            this.btnDepartmentStats.Size = new System.Drawing.Size(232, 40);
            this.btnDepartmentStats.TabIndex = 15;
            this.btnDepartmentStats.Text = "View department stats";
            this.btnDepartmentStats.UseVisualStyleBackColor = false;
            // 
            // btnOverallStats
            // 
            this.btnOverallStats.BackColor = System.Drawing.Color.Maroon;
            this.btnOverallStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverallStats.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOverallStats.Location = new System.Drawing.Point(317, 366);
            this.btnOverallStats.Name = "btnOverallStats";
            this.btnOverallStats.Size = new System.Drawing.Size(232, 40);
            this.btnOverallStats.TabIndex = 16;
            this.btnOverallStats.Text = "View overall stats";
            this.btnOverallStats.UseVisualStyleBackColor = false;
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(12, 12);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(299, 394);
            this.lbItems.TabIndex = 17;
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(317, 293);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(232, 21);
            this.cbDepartment.TabIndex = 18;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 419);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.btnOverallStats);
            this.Controls.Add(this.btnDepartmentStats);
            this.Controls.Add(this.btnItemStats);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnItemStats;
        private System.Windows.Forms.Button btnDepartmentStats;
        private System.Windows.Forms.Button btnOverallStats;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.ComboBox cbDepartment;
    }
}