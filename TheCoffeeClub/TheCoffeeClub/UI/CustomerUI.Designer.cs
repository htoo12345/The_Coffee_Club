namespace TheCoffeeClub.UI
{
    partial class CustomerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerUI));
            this.panelHead = new System.Windows.Forms.Panel();
            this.panelItem = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lTax = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.gbCategory2 = new System.Windows.Forms.GroupBox();
            this.txtCamelMacchiato = new System.Windows.Forms.TextBox();
            this.txtMocha = new System.Windows.Forms.TextBox();
            this.txtFrappe = new System.Windows.Forms.TextBox();
            this.txtFredo = new System.Windows.Forms.TextBox();
            this.txtIrish = new System.Windows.Forms.TextBox();
            this.txtLatte = new System.Windows.Forms.TextBox();
            this.chkCarmelMacchiato = new System.Windows.Forms.CheckBox();
            this.chkMocha = new System.Windows.Forms.CheckBox();
            this.chkFrappe = new System.Windows.Forms.CheckBox();
            this.chkFredo = new System.Windows.Forms.CheckBox();
            this.chkIrish = new System.Windows.Forms.CheckBox();
            this.chkLatte = new System.Windows.Forms.CheckBox();
            this.gbCategory1 = new System.Windows.Forms.GroupBox();
            this.txtCappuccino = new System.Windows.Forms.TextBox();
            this.txtAmericano = new System.Windows.Forms.TextBox();
            this.txtEspressoConpana = new System.Windows.Forms.TextBox();
            this.txtEspresso = new System.Windows.Forms.TextBox();
            this.txtEspressoMacchiato = new System.Windows.Forms.TextBox();
            this.txtDoppto = new System.Windows.Forms.TextBox();
            this.chkCappuccino = new System.Windows.Forms.CheckBox();
            this.chkAmericano = new System.Windows.Forms.CheckBox();
            this.chkEspressoConpana = new System.Windows.Forms.CheckBox();
            this.chkEspressoMacchiato = new System.Windows.Forms.CheckBox();
            this.chkDoppto = new System.Windows.Forms.CheckBox();
            this.chkEspresso = new System.Windows.Forms.CheckBox();
            this.panelItem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbCategory2.SuspendLayout();
            this.gbCategory1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHead.BackgroundImage")));
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(696, 129);
            this.panelHead.TabIndex = 0;
            // 
            // panelItem
            // 
            this.panelItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelItem.Controls.Add(this.panel1);
            this.panelItem.Controls.Add(this.gbCategory2);
            this.panelItem.Controls.Add(this.gbCategory1);
            this.panelItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelItem.Location = new System.Drawing.Point(0, 129);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(696, 322);
            this.panelItem.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnTotal);
            this.panel1.Controls.Add(this.lTax);
            this.panel1.Controls.Add(this.txtCost);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.txtTax);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 123);
            this.panel1.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(452, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 71);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(128, 83);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(66, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(237, 20);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(86, 71);
            this.btnTotal.TabIndex = 6;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lTax
            // 
            this.lTax.AutoSize = true;
            this.lTax.Location = new System.Drawing.Point(46, 14);
            this.lTax.Name = "lTax";
            this.lTax.Size = new System.Drawing.Size(25, 13);
            this.lTax.TabIndex = 0;
            this.lTax.Text = "Tax";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(128, 46);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(66, 20);
            this.txtCost.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(347, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 71);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(128, 11);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(66, 20);
            this.txtTax.TabIndex = 3;
            // 
            // gbCategory2
            // 
            this.gbCategory2.Controls.Add(this.txtCamelMacchiato);
            this.gbCategory2.Controls.Add(this.txtMocha);
            this.gbCategory2.Controls.Add(this.txtFrappe);
            this.gbCategory2.Controls.Add(this.txtFredo);
            this.gbCategory2.Controls.Add(this.txtIrish);
            this.gbCategory2.Controls.Add(this.txtLatte);
            this.gbCategory2.Controls.Add(this.chkCarmelMacchiato);
            this.gbCategory2.Controls.Add(this.chkMocha);
            this.gbCategory2.Controls.Add(this.chkFrappe);
            this.gbCategory2.Controls.Add(this.chkFredo);
            this.gbCategory2.Controls.Add(this.chkIrish);
            this.gbCategory2.Controls.Add(this.chkLatte);
            this.gbCategory2.Location = new System.Drawing.Point(358, 21);
            this.gbCategory2.Name = "gbCategory2";
            this.gbCategory2.Size = new System.Drawing.Size(326, 172);
            this.gbCategory2.TabIndex = 1;
            this.gbCategory2.TabStop = false;
            this.gbCategory2.Text = "Category 2";
            // 
            // txtCamelMacchiato
            // 
            this.txtCamelMacchiato.Location = new System.Drawing.Point(300, 136);
            this.txtCamelMacchiato.Name = "txtCamelMacchiato";
            this.txtCamelMacchiato.Size = new System.Drawing.Size(20, 20);
            this.txtCamelMacchiato.TabIndex = 11;
            // 
            // txtMocha
            // 
            this.txtMocha.Location = new System.Drawing.Point(300, 113);
            this.txtMocha.Name = "txtMocha";
            this.txtMocha.Size = new System.Drawing.Size(20, 20);
            this.txtMocha.TabIndex = 10;
            // 
            // txtFrappe
            // 
            this.txtFrappe.Location = new System.Drawing.Point(300, 89);
            this.txtFrappe.Name = "txtFrappe";
            this.txtFrappe.Size = new System.Drawing.Size(20, 20);
            this.txtFrappe.TabIndex = 9;
            // 
            // txtFredo
            // 
            this.txtFredo.Location = new System.Drawing.Point(300, 65);
            this.txtFredo.Name = "txtFredo";
            this.txtFredo.Size = new System.Drawing.Size(20, 20);
            this.txtFredo.TabIndex = 8;
            // 
            // txtIrish
            // 
            this.txtIrish.Location = new System.Drawing.Point(300, 42);
            this.txtIrish.Name = "txtIrish";
            this.txtIrish.Size = new System.Drawing.Size(20, 20);
            this.txtIrish.TabIndex = 7;
            // 
            // txtLatte
            // 
            this.txtLatte.Location = new System.Drawing.Point(300, 18);
            this.txtLatte.Name = "txtLatte";
            this.txtLatte.Size = new System.Drawing.Size(20, 20);
            this.txtLatte.TabIndex = 6;
            // 
            // chkCarmelMacchiato
            // 
            this.chkCarmelMacchiato.AutoSize = true;
            this.chkCarmelMacchiato.Location = new System.Drawing.Point(16, 139);
            this.chkCarmelMacchiato.Name = "chkCarmelMacchiato";
            this.chkCarmelMacchiato.Size = new System.Drawing.Size(213, 17);
            this.chkCarmelMacchiato.TabIndex = 5;
            this.chkCarmelMacchiato.Text = "Carmel Macchiato                   12000 Ks";
            this.chkCarmelMacchiato.UseVisualStyleBackColor = true;
            this.chkCarmelMacchiato.CheckedChanged += new System.EventHandler(this.chkCarmelMacchiato_CheckedChanged);
            // 
            // chkMocha
            // 
            this.chkMocha.AutoSize = true;
            this.chkMocha.Location = new System.Drawing.Point(16, 115);
            this.chkMocha.Name = "chkMocha";
            this.chkMocha.Size = new System.Drawing.Size(212, 17);
            this.chkMocha.TabIndex = 4;
            this.chkMocha.Text = "Mocha                                    12000 Ks";
            this.chkMocha.UseVisualStyleBackColor = true;
            this.chkMocha.CheckedChanged += new System.EventHandler(this.chkMocha_CheckedChanged);
            // 
            // chkFrappe
            // 
            this.chkFrappe.AutoSize = true;
            this.chkFrappe.Location = new System.Drawing.Point(16, 91);
            this.chkFrappe.Name = "chkFrappe";
            this.chkFrappe.Size = new System.Drawing.Size(212, 17);
            this.chkFrappe.TabIndex = 3;
            this.chkFrappe.Text = "Frappe                                    12000 Ks";
            this.chkFrappe.UseVisualStyleBackColor = true;
            this.chkFrappe.CheckedChanged += new System.EventHandler(this.chkFrappe_CheckedChanged);
            // 
            // chkFredo
            // 
            this.chkFredo.AutoSize = true;
            this.chkFredo.Location = new System.Drawing.Point(16, 68);
            this.chkFredo.Name = "chkFredo";
            this.chkFredo.Size = new System.Drawing.Size(212, 17);
            this.chkFredo.TabIndex = 2;
            this.chkFredo.Text = "Fredo                                    ` 12000 Ks";
            this.chkFredo.UseVisualStyleBackColor = true;
            this.chkFredo.CheckedChanged += new System.EventHandler(this.chkFredo_CheckedChanged);
            // 
            // chkIrish
            // 
            this.chkIrish.AutoSize = true;
            this.chkIrish.Location = new System.Drawing.Point(16, 44);
            this.chkIrish.Name = "chkIrish";
            this.chkIrish.Size = new System.Drawing.Size(210, 17);
            this.chkIrish.TabIndex = 1;
            this.chkIrish.Text = "Irish                                        12000 Ks";
            this.chkIrish.UseVisualStyleBackColor = true;
            this.chkIrish.CheckedChanged += new System.EventHandler(this.chkIrish_CheckedChanged);
            // 
            // chkLatte
            // 
            this.chkLatte.AutoSize = true;
            this.chkLatte.Location = new System.Drawing.Point(16, 20);
            this.chkLatte.Name = "chkLatte";
            this.chkLatte.Size = new System.Drawing.Size(209, 17);
            this.chkLatte.TabIndex = 0;
            this.chkLatte.Text = "Latte                                      10000 Ks";
            this.chkLatte.UseVisualStyleBackColor = true;
            this.chkLatte.CheckedChanged += new System.EventHandler(this.chkLatte_CheckedChanged);
            // 
            // gbCategory1
            // 
            this.gbCategory1.Controls.Add(this.txtCappuccino);
            this.gbCategory1.Controls.Add(this.txtAmericano);
            this.gbCategory1.Controls.Add(this.txtEspressoConpana);
            this.gbCategory1.Controls.Add(this.txtEspresso);
            this.gbCategory1.Controls.Add(this.txtEspressoMacchiato);
            this.gbCategory1.Controls.Add(this.txtDoppto);
            this.gbCategory1.Controls.Add(this.chkCappuccino);
            this.gbCategory1.Controls.Add(this.chkAmericano);
            this.gbCategory1.Controls.Add(this.chkEspressoConpana);
            this.gbCategory1.Controls.Add(this.chkEspressoMacchiato);
            this.gbCategory1.Controls.Add(this.chkDoppto);
            this.gbCategory1.Controls.Add(this.chkEspresso);
            this.gbCategory1.Location = new System.Drawing.Point(12, 21);
            this.gbCategory1.Name = "gbCategory1";
            this.gbCategory1.Size = new System.Drawing.Size(326, 172);
            this.gbCategory1.TabIndex = 0;
            this.gbCategory1.TabStop = false;
            this.gbCategory1.Text = "Category 1";
            // 
            // txtCappuccino
            // 
            this.txtCappuccino.Location = new System.Drawing.Point(291, 136);
            this.txtCappuccino.Name = "txtCappuccino";
            this.txtCappuccino.Size = new System.Drawing.Size(20, 20);
            this.txtCappuccino.TabIndex = 11;
            // 
            // txtAmericano
            // 
            this.txtAmericano.Location = new System.Drawing.Point(291, 113);
            this.txtAmericano.Name = "txtAmericano";
            this.txtAmericano.Size = new System.Drawing.Size(20, 20);
            this.txtAmericano.TabIndex = 10;
            // 
            // txtEspressoConpana
            // 
            this.txtEspressoConpana.Location = new System.Drawing.Point(291, 89);
            this.txtEspressoConpana.Name = "txtEspressoConpana";
            this.txtEspressoConpana.Size = new System.Drawing.Size(20, 20);
            this.txtEspressoConpana.TabIndex = 9;
            // 
            // txtEspresso
            // 
            this.txtEspresso.Location = new System.Drawing.Point(291, 18);
            this.txtEspresso.Name = "txtEspresso";
            this.txtEspresso.Size = new System.Drawing.Size(20, 20);
            this.txtEspresso.TabIndex = 6;
            // 
            // txtEspressoMacchiato
            // 
            this.txtEspressoMacchiato.Location = new System.Drawing.Point(291, 65);
            this.txtEspressoMacchiato.Name = "txtEspressoMacchiato";
            this.txtEspressoMacchiato.Size = new System.Drawing.Size(20, 20);
            this.txtEspressoMacchiato.TabIndex = 8;
            // 
            // txtDoppto
            // 
            this.txtDoppto.Location = new System.Drawing.Point(291, 42);
            this.txtDoppto.Name = "txtDoppto";
            this.txtDoppto.Size = new System.Drawing.Size(20, 20);
            this.txtDoppto.TabIndex = 7;
            // 
            // chkCappuccino
            // 
            this.chkCappuccino.AutoSize = true;
            this.chkCappuccino.Location = new System.Drawing.Point(6, 139);
            this.chkCappuccino.Name = "chkCappuccino";
            this.chkCappuccino.Size = new System.Drawing.Size(209, 17);
            this.chkCappuccino.TabIndex = 5;
            this.chkCappuccino.Text = "Cappuccino                           10000 Ks";
            this.chkCappuccino.UseVisualStyleBackColor = true;
            this.chkCappuccino.CheckedChanged += new System.EventHandler(this.chkCappuccino_CheckedChanged);
            // 
            // chkAmericano
            // 
            this.chkAmericano.AutoSize = true;
            this.chkAmericano.Location = new System.Drawing.Point(6, 115);
            this.chkAmericano.Name = "chkAmericano";
            this.chkAmericano.Size = new System.Drawing.Size(211, 17);
            this.chkAmericano.TabIndex = 4;
            this.chkAmericano.Text = "Americano                                8000 Ks";
            this.chkAmericano.UseVisualStyleBackColor = true;
            this.chkAmericano.CheckedChanged += new System.EventHandler(this.chkAmericano_CheckedChanged);
            // 
            // chkEspressoConpana
            // 
            this.chkEspressoConpana.AutoSize = true;
            this.chkEspressoConpana.Location = new System.Drawing.Point(7, 91);
            this.chkEspressoConpana.Name = "chkEspressoConpana";
            this.chkEspressoConpana.Size = new System.Drawing.Size(211, 17);
            this.chkEspressoConpana.TabIndex = 3;
            this.chkEspressoConpana.Text = "Espresso Conpana                   7000 Ks";
            this.chkEspressoConpana.UseVisualStyleBackColor = true;
            this.chkEspressoConpana.CheckedChanged += new System.EventHandler(this.chkEspressoConpana_CheckedChanged);
            // 
            // chkEspressoMacchiato
            // 
            this.chkEspressoMacchiato.AutoSize = true;
            this.chkEspressoMacchiato.Location = new System.Drawing.Point(6, 67);
            this.chkEspressoMacchiato.Name = "chkEspressoMacchiato";
            this.chkEspressoMacchiato.Size = new System.Drawing.Size(212, 17);
            this.chkEspressoMacchiato.TabIndex = 2;
            this.chkEspressoMacchiato.Text = "Espresso Macchiato                 7000 Ks";
            this.chkEspressoMacchiato.UseVisualStyleBackColor = true;
            this.chkEspressoMacchiato.CheckedChanged += new System.EventHandler(this.chkEspressoMacchiato_CheckedChanged);
            // 
            // chkDoppto
            // 
            this.chkDoppto.AutoSize = true;
            this.chkDoppto.Location = new System.Drawing.Point(7, 44);
            this.chkDoppto.Name = "chkDoppto";
            this.chkDoppto.Size = new System.Drawing.Size(211, 17);
            this.chkDoppto.TabIndex = 1;
            this.chkDoppto.Text = "Doppto                                     7000 Ks";
            this.chkDoppto.UseVisualStyleBackColor = true;
            this.chkDoppto.CheckedChanged += new System.EventHandler(this.chkDoppto_CheckedChanged);
            // 
            // chkEspresso
            // 
            this.chkEspresso.AutoSize = true;
            this.chkEspresso.Location = new System.Drawing.Point(7, 20);
            this.chkEspresso.Name = "chkEspresso";
            this.chkEspresso.Size = new System.Drawing.Size(213, 17);
            this.chkEspresso.TabIndex = 0;
            this.chkEspresso.Text = "Espresso                                   3500 Ks";
            this.chkEspresso.UseVisualStyleBackColor = true;
            this.chkEspresso.CheckedChanged += new System.EventHandler(this.chkEspresso_CheckedChanged);
            // 
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 451);
            this.Controls.Add(this.panelItem);
            this.Controls.Add(this.panelHead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerUI";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerUI_FormClosing);
            this.Load += new System.EventHandler(this.CustomerUI_Load);
            this.panelItem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbCategory2.ResumeLayout(false);
            this.gbCategory2.PerformLayout();
            this.gbCategory1.ResumeLayout(false);
            this.gbCategory1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.GroupBox gbCategory2;
        private System.Windows.Forms.GroupBox gbCategory1;
        private System.Windows.Forms.CheckBox chkCarmelMacchiato;
        private System.Windows.Forms.CheckBox chkMocha;
        private System.Windows.Forms.CheckBox chkFrappe;
        private System.Windows.Forms.CheckBox chkFredo;
        private System.Windows.Forms.CheckBox chkIrish;
        private System.Windows.Forms.CheckBox chkLatte;
        private System.Windows.Forms.CheckBox chkCappuccino;
        private System.Windows.Forms.CheckBox chkAmericano;
        private System.Windows.Forms.CheckBox chkEspressoConpana;
        private System.Windows.Forms.CheckBox chkEspressoMacchiato;
        private System.Windows.Forms.CheckBox chkDoppto;
        private System.Windows.Forms.CheckBox chkEspresso;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lTax;
        private System.Windows.Forms.TextBox txtCappuccino;
        private System.Windows.Forms.TextBox txtAmericano;
        private System.Windows.Forms.TextBox txtEspressoConpana;
        private System.Windows.Forms.TextBox txtEspressoMacchiato;
        private System.Windows.Forms.TextBox txtDoppto;
        private System.Windows.Forms.TextBox txtEspresso;
        private System.Windows.Forms.TextBox txtCamelMacchiato;
        private System.Windows.Forms.TextBox txtMocha;
        private System.Windows.Forms.TextBox txtFrappe;
        private System.Windows.Forms.TextBox txtFredo;
        private System.Windows.Forms.TextBox txtIrish;
        private System.Windows.Forms.TextBox txtLatte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
    }
}