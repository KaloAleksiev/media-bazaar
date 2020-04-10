namespace MediaBazaarTest
{
    partial class RestockForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudLimit = new System.Windows.Forms.NumericUpDown();
            this.btnAutoRequest = new System.Windows.Forms.Button();
            this.lbAutoRequest = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudAmount);
            this.groupBox2.Controls.Add(this.btnConfirm);
            this.groupBox2.Location = new System.Drawing.Point(222, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 183);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pick the amount:";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(40, 63);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(120, 22);
            this.nudAmount.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(40, 119);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(120, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.nudLimit);
            this.groupBox1.Controls.Add(this.btnAutoRequest);
            this.groupBox1.Controls.Add(this.lbAutoRequest);
            this.groupBox1.Location = new System.Drawing.Point(15, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 183);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Auto Restock limit:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(73, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudLimit
            // 
            this.nudLimit.Location = new System.Drawing.Point(45, 119);
            this.nudLimit.Name = "nudLimit";
            this.nudLimit.Size = new System.Drawing.Size(120, 22);
            this.nudLimit.TabIndex = 6;
            // 
            // btnAutoRequest
            // 
            this.btnAutoRequest.Location = new System.Drawing.Point(73, 62);
            this.btnAutoRequest.Name = "btnAutoRequest";
            this.btnAutoRequest.Size = new System.Drawing.Size(75, 23);
            this.btnAutoRequest.TabIndex = 5;
            this.btnAutoRequest.Text = "Turn on";
            this.btnAutoRequest.UseVisualStyleBackColor = true;
            this.btnAutoRequest.Click += new System.EventHandler(this.btnAutoRequest_Click);
            // 
            // lbAutoRequest
            // 
            this.lbAutoRequest.AutoSize = true;
            this.lbAutoRequest.Location = new System.Drawing.Point(30, 31);
            this.lbAutoRequest.Name = "lbAutoRequest";
            this.lbAutoRequest.Size = new System.Drawing.Size(98, 17);
            this.lbAutoRequest.TabIndex = 4;
            this.lbAutoRequest.Text = "Auto Request:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(302, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.Location = new System.Drawing.Point(44, 16);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(136, 17);
            this.lbInfo.TabIndex = 7;
            this.lbInfo.Text = "Restock request for ";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 275);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbInfo);
            this.Name = "RestockForm";
            this.Text = "RestockForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudLimit;
        private System.Windows.Forms.Button btnAutoRequest;
        private System.Windows.Forms.Label lbAutoRequest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbInfo;
    }
}