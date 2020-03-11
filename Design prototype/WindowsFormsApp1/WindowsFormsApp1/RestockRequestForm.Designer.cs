namespace WindowsFormsApp1
{
    partial class RestockRequestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAmountRestockForm = new System.Windows.Forms.TextBox();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.tbItemIDRestockForm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // tbAmountRestockForm
            // 
            this.tbAmountRestockForm.Location = new System.Drawing.Point(103, 87);
            this.tbAmountRestockForm.Name = "tbAmountRestockForm";
            this.tbAmountRestockForm.Size = new System.Drawing.Size(121, 20);
            this.tbAmountRestockForm.TabIndex = 3;
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(57, 130);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(186, 35);
            this.btnSendRequest.TabIndex = 4;
            this.btnSendRequest.Text = "Send Restock Request";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // tbItemIDRestockForm
            // 
            this.tbItemIDRestockForm.Location = new System.Drawing.Point(103, 48);
            this.tbItemIDRestockForm.Name = "tbItemIDRestockForm";
            this.tbItemIDRestockForm.Size = new System.Drawing.Size(121, 20);
            this.tbItemIDRestockForm.TabIndex = 5;
            // 
            // RestockRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 189);
            this.Controls.Add(this.tbItemIDRestockForm);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.tbAmountRestockForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RestockRequestForm";
            this.Text = "Restock Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAmountRestockForm;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.TextBox tbItemIDRestockForm;
    }
}