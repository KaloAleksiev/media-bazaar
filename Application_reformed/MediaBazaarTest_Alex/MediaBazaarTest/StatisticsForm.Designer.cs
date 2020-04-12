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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            this.pDepStats = new System.Windows.Forms.Panel();
            this.btAvgSalaryOverall = new System.Windows.Forms.Button();
            this.chartEmployees = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.btShowAvgSalaryPerDep = new System.Windows.Forms.Button();
            this.btShowEmpCountPerDep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepSalary = new System.Windows.Forms.ComboBox();
            this.cmbDepCount = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btDepartmentStats = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pDepStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pDepStats
            // 
            this.pDepStats.BackColor = System.Drawing.Color.White;
            this.pDepStats.Controls.Add(this.btAvgSalaryOverall);
            this.pDepStats.Controls.Add(this.chartEmployees);
            this.pDepStats.Controls.Add(this.label2);
            this.pDepStats.Controls.Add(this.btShowAvgSalaryPerDep);
            this.pDepStats.Controls.Add(this.btShowEmpCountPerDep);
            this.pDepStats.Controls.Add(this.label1);
            this.pDepStats.Controls.Add(this.cmbDepSalary);
            this.pDepStats.Controls.Add(this.cmbDepCount);
            this.pDepStats.Location = new System.Drawing.Point(154, 80);
            this.pDepStats.Name = "pDepStats";
            this.pDepStats.Size = new System.Drawing.Size(866, 450);
            this.pDepStats.TabIndex = 36;
            // 
            // btAvgSalaryOverall
            // 
            this.btAvgSalaryOverall.BackColor = System.Drawing.Color.Maroon;
            this.btAvgSalaryOverall.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.btAvgSalaryOverall.ForeColor = System.Drawing.Color.White;
            this.btAvgSalaryOverall.Location = new System.Drawing.Point(558, 169);
            this.btAvgSalaryOverall.Name = "btAvgSalaryOverall";
            this.btAvgSalaryOverall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btAvgSalaryOverall.Size = new System.Drawing.Size(191, 52);
            this.btAvgSalaryOverall.TabIndex = 41;
            this.btAvgSalaryOverall.Text = "Show avarage salary overall";
            this.btAvgSalaryOverall.UseVisualStyleBackColor = false;
            this.btAvgSalaryOverall.Click += new System.EventHandler(this.btAvgSalaryOverall_Click);
            // 
            // chartEmployees
            // 
            chartArea2.Name = "ChartArea1";
            this.chartEmployees.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartEmployees.Legends.Add(legend2);
            this.chartEmployees.Location = new System.Drawing.Point(3, 121);
            this.chartEmployees.Name = "chartEmployees";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Employee count";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chartEmployees.Series.Add(series2);
            this.chartEmployees.Size = new System.Drawing.Size(415, 300);
            this.chartEmployees.TabIndex = 40;
            this.chartEmployees.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(576, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Select department:";
            // 
            // btShowAvgSalaryPerDep
            // 
            this.btShowAvgSalaryPerDep.BackColor = System.Drawing.Color.Maroon;
            this.btShowAvgSalaryPerDep.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.btShowAvgSalaryPerDep.ForeColor = System.Drawing.Color.White;
            this.btShowAvgSalaryPerDep.Location = new System.Drawing.Point(558, 93);
            this.btShowAvgSalaryPerDep.Name = "btShowAvgSalaryPerDep";
            this.btShowAvgSalaryPerDep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btShowAvgSalaryPerDep.Size = new System.Drawing.Size(191, 61);
            this.btShowAvgSalaryPerDep.TabIndex = 38;
            this.btShowAvgSalaryPerDep.Text = "Show avarage salary per department";
            this.btShowAvgSalaryPerDep.UseVisualStyleBackColor = false;
            this.btShowAvgSalaryPerDep.Click += new System.EventHandler(this.btShowAvgSalaryPerDep_Click);
            // 
            // btShowEmpCountPerDep
            // 
            this.btShowEmpCountPerDep.BackColor = System.Drawing.Color.Maroon;
            this.btShowEmpCountPerDep.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.btShowEmpCountPerDep.ForeColor = System.Drawing.Color.White;
            this.btShowEmpCountPerDep.Location = new System.Drawing.Point(211, 28);
            this.btShowEmpCountPerDep.Name = "btShowEmpCountPerDep";
            this.btShowEmpCountPerDep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btShowEmpCountPerDep.Size = new System.Drawing.Size(197, 70);
            this.btShowEmpCountPerDep.TabIndex = 37;
            this.btShowEmpCountPerDep.Text = "Show employee count per position";
            this.btShowEmpCountPerDep.UseVisualStyleBackColor = false;
            this.btShowEmpCountPerDep.Click += new System.EventHandler(this.btShowEmpCountPerDep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Select department:";
            // 
            // cmbDepSalary
            // 
            this.cmbDepSalary.FormattingEnabled = true;
            this.cmbDepSalary.Location = new System.Drawing.Point(580, 66);
            this.cmbDepSalary.Name = "cmbDepSalary";
            this.cmbDepSalary.Size = new System.Drawing.Size(146, 21);
            this.cmbDepSalary.TabIndex = 1;
            // 
            // cmbDepCount
            // 
            this.cmbDepCount.FormattingEnabled = true;
            this.cmbDepCount.Location = new System.Drawing.Point(45, 56);
            this.cmbDepCount.Name = "cmbDepCount";
            this.cmbDepCount.Size = new System.Drawing.Size(146, 21);
            this.cmbDepCount.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(528, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 32);
            this.label9.TabIndex = 35;
            this.label9.Text = "Statistics";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 160);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(140, 74);
            this.button1.TabIndex = 34;
            this.button1.Text = "Item statistics";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btDepartmentStats
            // 
            this.btDepartmentStats.BackColor = System.Drawing.Color.Maroon;
            this.btDepartmentStats.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btDepartmentStats.ForeColor = System.Drawing.Color.White;
            this.btDepartmentStats.Location = new System.Drawing.Point(9, 80);
            this.btDepartmentStats.Name = "btDepartmentStats";
            this.btDepartmentStats.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btDepartmentStats.Size = new System.Drawing.Size(140, 74);
            this.btDepartmentStats.TabIndex = 33;
            this.btDepartmentStats.Text = "Department statistics";
            this.btDepartmentStats.UseVisualStyleBackColor = false;
            this.btDepartmentStats.Click += new System.EventHandler(this.DepartmentStats_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 66);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(578, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 455);
            this.panel2.TabIndex = 42;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1023, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pDepStats);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btDepartmentStats);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.pDepStats.ResumeLayout(false);
            this.pDepStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pDepStats;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btDepartmentStats;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbDepSalary;
        private System.Windows.Forms.ComboBox cmbDepCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btShowAvgSalaryPerDep;
        private System.Windows.Forms.Button btShowEmpCountPerDep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btAvgSalaryOverall;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmployees;
    }
}