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
            this.panelTheCoffeeClub = new System.Windows.Forms.Panel();
            this.btnNewOwner = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTheCoffeeClub.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTheCoffeeClub
            // 
            this.panelTheCoffeeClub.BackColor = System.Drawing.Color.DimGray;
            this.panelTheCoffeeClub.Controls.Add(this.btnNewOwner);
            this.panelTheCoffeeClub.Controls.Add(this.btnNewCustomer);
            this.panelTheCoffeeClub.Controls.Add(this.panel1);
            this.panelTheCoffeeClub.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTheCoffeeClub.Location = new System.Drawing.Point(0, 0);
            this.panelTheCoffeeClub.Name = "panelTheCoffeeClub";
            this.panelTheCoffeeClub.Size = new System.Drawing.Size(162, 320);
            this.panelTheCoffeeClub.TabIndex = 2;
            // 
            // btnNewOwner
            // 
            this.btnNewOwner.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnNewOwner.Image = ((System.Drawing.Image)(resources.GetObject("btnNewOwner.Image")));
            this.btnNewOwner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewOwner.Location = new System.Drawing.Point(0, 154);
            this.btnNewOwner.Name = "btnNewOwner";
            this.btnNewOwner.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnNewOwner.Size = new System.Drawing.Size(162, 79);
            this.btnNewOwner.TabIndex = 2;
            this.btnNewOwner.Text = "                OWNER";
            this.btnNewOwner.UseVisualStyleBackColor = true;
            this.btnNewOwner.Click += new System.EventHandler(this.btnNewOwner_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnNewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnNewCustomer.Image")));
            this.btnNewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCustomer.Location = new System.Drawing.Point(0, 75);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnNewCustomer.Size = new System.Drawing.Size(162, 79);
            this.btnNewCustomer.TabIndex = 1;
            this.btnNewCustomer.Text = "                   CUSTOMER";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 75);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(162, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 75);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // TheCoffeeClubUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 320);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTheCoffeeClub);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TheCoffeeClubUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "The Coffee Club";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TheCoffeeClubUI_FormClosing);
            this.panelTheCoffeeClub.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTheCoffeeClub;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewOwner;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}