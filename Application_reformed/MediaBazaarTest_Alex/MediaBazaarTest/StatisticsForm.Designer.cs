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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btPromoteFire = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbDepCount = new System.Windows.Forms.ComboBox();
            this.cmbDepSalary = new System.Windows.Forms.ComboBox();
            this.btShowEmpCountPerDep = new System.Windows.Forms.Button();
            this.btShowAvgSalaryPerDep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartEmployees = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btAvgSalaryOverall = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btAvgSalaryOverall);
            this.panel1.Controls.Add(this.chartEmployees);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btShowAvgSalaryPerDep);
            this.panel1.Controls.Add(this.btShowEmpCountPerDep);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbDepSalary);
            this.panel1.Controls.Add(this.cmbDepCount);
            this.panel1.Location = new System.Drawing.Point(154, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 450);
            this.panel1.TabIndex = 36;
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
            // btPromoteFire
            // 
            this.btPromoteFire.BackColor = System.Drawing.Color.Maroon;
            this.btPromoteFire.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btPromoteFire.ForeColor = System.Drawing.Color.White;
            this.btPromoteFire.Location = new System.Drawing.Point(9, 80);
            this.btPromoteFire.Name = "btPromoteFire";
            this.btPromoteFire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btPromoteFire.Size = new System.Drawing.Size(140, 74);
            this.btPromoteFire.TabIndex = 33;
            this.btPromoteFire.Text = "Department statistics";
            this.btPromoteFire.UseVisualStyleBackColor = false;
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
            // cmbDepCount
            // 
            this.cmbDepCount.FormattingEnabled = true;
            this.cmbDepCount.Location = new System.Drawing.Point(45, 56);
            this.cmbDepCount.Name = "cmbDepCount";
            this.cmbDepCount.Size = new System.Drawing.Size(146, 21);
            this.cmbDepCount.TabIndex = 0;
            // 
            // cmbDepSalary
            // 
            this.cmbDepSalary.FormattingEnabled = true;
            this.cmbDepSalary.Location = new System.Drawing.Point(580, 66);
            this.cmbDepSalary.Name = "cmbDepSalary";
            this.cmbDepSalary.Size = new System.Drawing.Size(146, 21);
            this.cmbDepSalary.TabIndex = 1;
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
            // chartEmployees
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEmployees.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEmployees.Legends.Add(legend1);
            this.chartEmployees.Location = new System.Drawing.Point(3, 121);
            this.chartEmployees.Name = "chartEmployees";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Employee count";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chartEmployees.Series.Add(series1);
            this.chartEmployees.Size = new System.Drawing.Size(415, 300);
            this.chartEmployees.TabIndex = 40;
            this.chartEmployees.Text = "chart1";
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btPromoteFire);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btPromoteFire;
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