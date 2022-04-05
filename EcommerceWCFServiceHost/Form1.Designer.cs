
namespace EcommerceWCFServiceHost
{
    partial class Form1
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
            this.productServiceLabel = new System.Windows.Forms.Label();
            this.authenticationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productServiceLabel
            // 
            this.productServiceLabel.AutoSize = true;
            this.productServiceLabel.Location = new System.Drawing.Point(149, 50);
            this.productServiceLabel.Name = "productServiceLabel";
            this.productServiceLabel.Size = new System.Drawing.Size(83, 13);
            this.productServiceLabel.TabIndex = 0;
            this.productServiceLabel.Text = "Product Service";
            // 
            // authenticationLabel
            // 
            this.authenticationLabel.AutoSize = true;
            this.authenticationLabel.Location = new System.Drawing.Point(149, 115);
            this.authenticationLabel.Name = "authenticationLabel";
            this.authenticationLabel.Size = new System.Drawing.Size(114, 13);
            this.authenticationLabel.TabIndex = 1;
            this.authenticationLabel.Text = "Authentication Service";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 217);
            this.Controls.Add(this.authenticationLabel);
            this.Controls.Add(this.productServiceLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productServiceLabel;
        private System.Windows.Forms.Label authenticationLabel;
    }
}

