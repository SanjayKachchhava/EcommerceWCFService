
namespace EcommerceWCFServiceClient
{
    partial class Home
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
            this.createProductLink = new System.Windows.Forms.Button();
            this.allProductsLink = new System.Windows.Forms.Button();
            this.yourProductsLink = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createProductLink
            // 
            this.createProductLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProductLink.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createProductLink.Location = new System.Drawing.Point(234, 132);
            this.createProductLink.Name = "createProductLink";
            this.createProductLink.Size = new System.Drawing.Size(140, 126);
            this.createProductLink.TabIndex = 0;
            this.createProductLink.Text = "Create Product";
            this.createProductLink.UseVisualStyleBackColor = true;
            this.createProductLink.Click += new System.EventHandler(this.createProductLink_Click);
            // 
            // allProductsLink
            // 
            this.allProductsLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allProductsLink.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.allProductsLink.Location = new System.Drawing.Point(52, 132);
            this.allProductsLink.Name = "allProductsLink";
            this.allProductsLink.Size = new System.Drawing.Size(140, 126);
            this.allProductsLink.TabIndex = 1;
            this.allProductsLink.Text = "See All Products";
            this.allProductsLink.UseVisualStyleBackColor = true;
            this.allProductsLink.Click += new System.EventHandler(this.allProductsLink_Click);
            // 
            // yourProductsLink
            // 
            this.yourProductsLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourProductsLink.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.yourProductsLink.Location = new System.Drawing.Point(415, 132);
            this.yourProductsLink.Name = "yourProductsLink";
            this.yourProductsLink.Size = new System.Drawing.Size(140, 126);
            this.yourProductsLink.TabIndex = 2;
            this.yourProductsLink.Text = "Your Products";
            this.yourProductsLink.UseVisualStyleBackColor = true;
            this.yourProductsLink.Click += new System.EventHandler(this.yourProductsLink_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(245, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Home";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.logout_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yourProductsLink);
            this.Controls.Add(this.allProductsLink);
            this.Controls.Add(this.createProductLink);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createProductLink;
        private System.Windows.Forms.Button allProductsLink;
        private System.Windows.Forms.Button yourProductsLink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}