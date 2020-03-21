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
            this.label2 = new System.Windows.Forms.Label();
            this.tbAmountRestockForm = new System.Windows.Forms.TextBox();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // tbAmountRestockForm
            // 
            this.tbAmountRestockForm.Location = new System.Drawing.Point(314, 260);
            this.tbAmountRestockForm.Name = "tbAmountRestockForm";
            this.tbAmountRestockForm.Size = new System.Drawing.Size(75, 20);
            this.tbAmountRestockForm.TabIndex = 3;
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(291, 286);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(108, 46);
            this.btnSendRequest.TabIndex = 4;
            this.btnSendRequest.Text = "Send Restock Request";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // lbItems
            // 
            this.lbItems.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 20;
            this.lbItems.Location = new System.Drawing.Point(12, 28);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(273, 304);
            this.lbItems.TabIndex = 5;
            // 
            // RestockRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 347);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.tbAmountRestockForm);
            this.Controls.Add(this.label2);
            this.Name = "RestockRequestForm";
            this.Text = "Restock Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAmountRestockForm;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.ListBox lbItems;
    }
}