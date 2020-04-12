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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.pItemStats = new System.Windows.Forms.Panel();
            this.lbItemStats = new System.Windows.Forms.ListBox();
            this.btShowItemStats = new System.Windows.Forms.Button();
            this.chartItems = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btItemStats = new System.Windows.Forms.Button();
            this.btDepartmentStats = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pDepStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployees)).BeginInit();
            this.pItemStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartItems)).BeginInit();
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
            chartArea9.Name = "ChartArea1";
            this.chartEmployees.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartEmployees.Legends.Add(legend9);
            this.chartEmployees.Location = new System.Drawing.Point(3, 121);
            this.chartEmployees.Name = "chartEmployees";
            series9.ChartArea = "ChartArea1";
            series9.IsVisibleInLegend = false;
            series9.Legend = "Legend1";
            series9.Name = "Employee count";
            series9.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chartEmployees.Series.Add(series9);
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
            // pItemStats
            // 
            this.pItemStats.BackColor = System.Drawing.Color.White;
            this.pItemStats.Controls.Add(this.panel1);
            this.pItemStats.Controls.Add(this.lbItemStats);
            this.pItemStats.Controls.Add(this.btShowItemStats);
            this.pItemStats.Controls.Add(this.chartItems);
            this.pItemStats.Controls.Add(this.label3);
            this.pItemStats.Controls.Add(this.label4);
            this.pItemStats.Location = new System.Drawing.Point(154, 80);
            this.pItemStats.Name = "pItemStats";
            this.pItemStats.Size = new System.Drawing.Size(866, 450);
            this.pItemStats.TabIndex = 42;
            // 
            // lbItemStats
            // 
            this.lbItemStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemStats.FormattingEnabled = true;
            this.lbItemStats.ItemHeight = 16;
            this.lbItemStats.Location = new System.Drawing.Point(472, 59);
            this.lbItemStats.Name = "lbItemStats";
            this.lbItemStats.Size = new System.Drawing.Size(360, 276);
            this.lbItemStats.TabIndex = 42;
            // 
            // btShowItemStats
            // 
            this.btShowItemStats.BackColor = System.Drawing.Color.Maroon;
            this.btShowItemStats.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.btShowItemStats.ForeColor = System.Drawing.Color.White;
            this.btShowItemStats.Location = new System.Drawing.Point(557, 369);
            this.btShowItemStats.Name = "btShowItemStats";
            this.btShowItemStats.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btShowItemStats.Size = new System.Drawing.Size(191, 52);
            this.btShowItemStats.TabIndex = 41;
            this.btShowItemStats.Text = "Show info for an Item";
            this.btShowItemStats.UseVisualStyleBackColor = false;
            this.btShowItemStats.Click += new System.EventHandler(this.btShowItemStats_Click);
            // 
            // chartItems
            // 
            chartArea10.Name = "ChartArea1";
            this.chartItems.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartItems.Legends.Add(legend10);
            this.chartItems.Location = new System.Drawing.Point(3, 121);
            this.chartItems.Name = "chartItems";
            series10.ChartArea = "ChartArea1";
            series10.IsVisibleInLegend = false;
            series10.Legend = "Legend1";
            series10.Name = "count";
            series10.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chartItems.Series.Add(series10);
            this.chartItems.Size = new System.Drawing.Size(415, 300);
            this.chartItems.TabIndex = 40;
            this.chartItems.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(593, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Select item:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(75, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 28);
            this.label4.TabIndex = 37;
            this.label4.Text = "Items count per department:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(532, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 32);
            this.label9.TabIndex = 35;
            this.label9.Text = "Statistics";
            // 
            // btItemStats
            // 
            this.btItemStats.BackColor = System.Drawing.Color.Maroon;
            this.btItemStats.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btItemStats.ForeColor = System.Drawing.Color.White;
            this.btItemStats.Location = new System.Drawing.Point(9, 160);
            this.btItemStats.Name = "btItemStats";
            this.btItemStats.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btItemStats.Size = new System.Drawing.Size(140, 74);
            this.btItemStats.TabIndex = 34;
            this.btItemStats.Text = "Item statistics";
            this.btItemStats.UseVisualStyleBackColor = false;
            this.btItemStats.Click += new System.EventHandler(this.ItemStats_Click);
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
            this.panel2.Location = new System.Drawing.Point(582, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 455);
            this.panel2.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(428, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 455);
            this.panel1.TabIndex = 43;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1023, 534);
            this.Controls.Add(this.pItemStats);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pDepStats);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btItemStats);
            this.Controls.Add(this.btDepartmentStats);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.pDepStats.ResumeLayout(false);
            this.pDepStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployees)).EndInit();
            this.pItemStats.ResumeLayout(false);
            this.pItemStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pDepStats;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btItemStats;
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
        private System.Windows.Forms.Panel pItemStats;
        private System.Windows.Forms.ListBox lbItemStats;
        private System.Windows.Forms.Button btShowItemStats;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}