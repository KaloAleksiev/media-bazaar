namespace MediaBazaarTest
{
    partial class ShiftHubForm
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
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.rbMorning = new System.Windows.Forms.RadioButton();
            this.rbNoon = new System.Windows.Forms.RadioButton();
            this.rbEvening = new System.Windows.Forms.RadioButton();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFinalInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAutoSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMonth.Location = new System.Drawing.Point(132, 58);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 24);
            this.cbMonth.TabIndex = 0;
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Manager",
            "Depot worker",
            "Employee"});
            this.cbPosition.Location = new System.Drawing.Point(132, 146);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(121, 24);
            this.cbPosition.TabIndex = 2;
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.BackColor = System.Drawing.Color.Maroon;
            this.btnViewSchedule.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewSchedule.FlatAppearance.BorderSize = 2;
            this.btnViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnViewSchedule.ForeColor = System.Drawing.Color.White;
            this.btnViewSchedule.Location = new System.Drawing.Point(166, 258);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(165, 38);
            this.btnViewSchedule.TabIndex = 4;
            this.btnViewSchedule.Text = "View Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = false;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // rbMorning
            // 
            this.rbMorning.AutoSize = true;
            this.rbMorning.Checked = true;
            this.rbMorning.Location = new System.Drawing.Point(340, 90);
            this.rbMorning.Name = "rbMorning";
            this.rbMorning.Size = new System.Drawing.Size(80, 21);
            this.rbMorning.TabIndex = 5;
            this.rbMorning.TabStop = true;
            this.rbMorning.Text = "Morning";
            this.rbMorning.UseVisualStyleBackColor = true;
            // 
            // rbNoon
            // 
            this.rbNoon.AutoSize = true;
            this.rbNoon.Location = new System.Drawing.Point(340, 117);
            this.rbNoon.Name = "rbNoon";
            this.rbNoon.Size = new System.Drawing.Size(63, 21);
            this.rbNoon.TabIndex = 6;
            this.rbNoon.Text = "Noon";
            this.rbNoon.UseVisualStyleBackColor = true;
            // 
            // rbEvening
            // 
            this.rbEvening.AutoSize = true;
            this.rbEvening.Location = new System.Drawing.Point(340, 144);
            this.rbEvening.Name = "rbEvening";
            this.rbEvening.Size = new System.Drawing.Size(80, 21);
            this.rbEvening.TabIndex = 7;
            this.rbEvening.Text = "Evening";
            this.rbEvening.UseVisualStyleBackColor = true;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(132, 88);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 22);
            this.tbYear.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Month:";
            // 
            // lblFinalInfo
            // 
            this.lblFinalInfo.AutoSize = true;
            this.lblFinalInfo.Location = new System.Drawing.Point(75, 201);
            this.lblFinalInfo.Name = "lblFinalInfo";
            this.lblFinalInfo.Size = new System.Drawing.Size(0, 17);
            this.lblFinalInfo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Position:";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(132, 116);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(121, 24);
            this.cbDepartment.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Shift type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select the parameters for the schedule you wish to view:";
            // 
            // btnAutoSchedule
            // 
            this.btnAutoSchedule.BackColor = System.Drawing.Color.Maroon;
            this.btnAutoSchedule.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAutoSchedule.FlatAppearance.BorderSize = 2;
            this.btnAutoSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAutoSchedule.ForeColor = System.Drawing.Color.White;
            this.btnAutoSchedule.Location = new System.Drawing.Point(132, 302);
            this.btnAutoSchedule.Name = "btnAutoSchedule";
            this.btnAutoSchedule.Size = new System.Drawing.Size(224, 38);
            this.btnAutoSchedule.TabIndex = 18;
            this.btnAutoSchedule.Text = "Auto-create schedule";
            this.btnAutoSchedule.UseVisualStyleBackColor = false;
            this.btnAutoSchedule.Click += new System.EventHandler(this.btnAutoSchedule_Click);
            // 
            // ShiftHubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(523, 351);
            this.Controls.Add(this.btnAutoSchedule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFinalInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.rbEvening);
            this.Controls.Add(this.rbNoon);
            this.Controls.Add(this.rbMorning);
            this.Controls.Add(this.btnViewSchedule);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.cbMonth);
            this.Name = "ShiftHubForm";
            this.Text = "ShiftHubForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Button btnViewSchedule;
        private System.Windows.Forms.RadioButton rbMorning;
        private System.Windows.Forms.RadioButton rbNoon;
        private System.Windows.Forms.RadioButton rbEvening;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFinalInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAutoSchedule;
    }
}