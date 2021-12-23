namespace TheCoffeeClub.UI
{
    partial class TheCoffeeClubUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheCoffeeClubUI));
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.panelTheCoffeeClub = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTheCoffeeClub.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCustomer.Location = new System.Drawing.Point(0, 101);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(149, 73);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnOwner
            // 
            this.btnOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOwner.Location = new System.Drawing.Point(194, 101);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(151, 73);
            this.btnOwner.TabIndex = 1;
            this.btnOwner.Text = "Owner";
            this.btnOwner.UseVisualStyleBackColor = false;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // panelTheCoffeeClub
            // 
            this.panelTheCoffeeClub.BackColor = System.Drawing.Color.Teal;
            this.panelTheCoffeeClub.Controls.Add(this.panelLogo);
            this.panelTheCoffeeClub.Controls.Add(this.btnOwner);
            this.panelTheCoffeeClub.Controls.Add(this.btnCustomer);
            this.panelTheCoffeeClub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTheCoffeeClub.Location = new System.Drawing.Point(0, 0);
            this.panelTheCoffeeClub.Name = "panelTheCoffeeClub";
            this.panelTheCoffeeClub.Size = new System.Drawing.Size(345, 174);
            this.panelTheCoffeeClub.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(345, 100);
            this.panelLogo.TabIndex = 2;
            // 
            // TheCoffeeClubUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 174);
            this.Controls.Add(this.panelTheCoffeeClub);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TheCoffeeClubUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "The Coffee Club";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TheCoffeeClubUI_FormClosing);
            this.panelTheCoffeeClub.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Panel panelTheCoffeeClub;
        private System.Windows.Forms.Panel panelLogo;
    }
}