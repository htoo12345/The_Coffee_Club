using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffeeClub.Model;

namespace TheCoffeeClub.UI
{
    public partial class CustomerUI : Form
    {
        private double cost;

        public CustomerUI()
        {
            InitializeComponent();
        }

        private void CustomerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            CustomerModel price = new CustomerModel();

            // coffee price
            price.EspressoPrice = 3500D;
            price.DopptoPrice = 7000D;
            price.EspressoMacchiatoPrice = 7000D;
            price.EspressoConpanaPrice = 7000D;
            price.AmericanoPrice = 8000D;
            price.CappuccinoPrice = 10000D;
            price.LattePrice = 10000D;
            price.IrishPrice = 12000D;
            price.FredoPrice = 12000D;
            price.FrappePrice = 12000D;
            price.MochaPrice = 12000D;
            price.CarmelMacchiatoPrice = 12000D;

            // tax price
            double tax = 500;

            try
            {
                // multiplication coffee price and customer order
                double resultEspresso = price.EspressoPrice * Convert.ToDouble(txtEspresso.Text);
                double resultDoppto = price.DopptoPrice * Convert.ToDouble(txtDoppto.Text);
                double resultEspMacc = price.EspressoMacchiatoPrice * Convert.ToDouble(txtEspressoMacchiato.Text);
                double resultEspCon = price.EspressoConpanaPrice * Convert.ToDouble(txtEspressoConpana.Text);
                double resultAmericano = price.AmericanoPrice * Convert.ToDouble(txtAmericano.Text);
                double resultCappuccino = price.CappuccinoPrice * Convert.ToDouble(txtCappuccino.Text);
                double resultLatte = price.LattePrice * Convert.ToDouble(txtLatte.Text);
                double resultIrish = price.IrishPrice * Convert.ToDouble(txtIrish.Text);
                double resultFredo = price.FredoPrice * Convert.ToDouble(txtFredo.Text);
                double resultFrappe = price.FrappePrice * Convert.ToDouble(txtFrappe.Text);
                double resultMocha = price.MochaPrice * Convert.ToDouble(txtMocha.Text);
                double resultCarMacc = price.CarmelMacchiatoPrice * Convert.ToDouble(txtCamelMacchiato.Text);

                // calculate cost
                cost = resultEspresso + resultDoppto + resultEspMacc + resultEspCon + resultAmericano + resultCappuccino + resultLatte + resultIrish + resultFredo + resultFrappe + resultMocha + resultCarMacc;

            } // end of try

            catch (Exception error)
            {
                MessageBox.Show("Please input number only", error.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

            } // end of catch

            
            // calculate total
            double total = (100 / tax) * cost;

            // show price to customer
            txtTax.Text = tax.ToString();
            txtCost.Text = cost.ToString();
            txtTotal.Text = total.ToString();
            
        } // end of btnTotal_Click method

        private void btnReset_Click(object sender, EventArgs e)
        {
            //check box
            chkEspresso.Checked = false;
            chkDoppto.Checked = false;
            chkEspressoMacchiato.Checked = false;
            chkEspressoConpana.Checked = false;
            chkAmericano.Checked = false;
            chkCappuccino.Checked = false;
            chkLatte.Checked = false;
            chkIrish.Checked = false;
            chkFredo.Checked = false;
            chkFrappe.Checked = false;
            chkMocha.Checked = false;
            chkCarmelMacchiato.Checked = false;

            //text box
            txtEspresso.Text = "0";
            txtDoppto.Text = "0"; 
            txtEspressoMacchiato.Text = "0";
            txtEspressoConpana.Text = "0";
            txtAmericano.Text = "0";
            txtCappuccino.Text = "0";
            txtLatte.Text = "0";
            txtIrish.Text = "0";
            txtFredo.Text = "0";
            txtFrappe.Text = "0";
            txtMocha.Text = "0";
            txtCamelMacchiato.Text = "0";

            txtTax.Text=String.Empty;
            txtCost.Text=String.Empty;
            txtTotal.Text=String.Empty;

        } // end of btnReset_Click method

        private void CustomerUI_Load(object sender, EventArgs e)
        {
            // coffee 
            txtEspresso.Enabled=false;
            txtDoppto.Enabled=false;    
            txtEspressoMacchiato.Enabled=false;
            txtEspressoConpana.Enabled=false;
            txtAmericano.Enabled=false;
            txtCappuccino.Enabled=false;
            txtLatte.Enabled=false; 
            txtIrish.Enabled=false;
            txtFredo.Enabled=false;
            txtFrappe.Enabled=false;
            txtMocha.Enabled=false;
            txtCamelMacchiato.Enabled=false;

            //check box
            chkEspresso.Checked = false;
            chkDoppto.Checked = false;
            chkEspressoMacchiato.Checked = false;
            chkEspressoConpana.Checked = false;
            chkAmericano.Checked = false;
            chkCappuccino.Checked = false;
            chkLatte.Checked = false;
            chkIrish.Checked = false;
            chkFredo.Checked = false;
            chkFrappe.Checked = false;
            chkMocha.Checked = false;
            chkCarmelMacchiato.Checked = false;

            //text box
            txtEspresso.Text = "0";
            txtDoppto.Text = "0";
            txtEspressoMacchiato.Text = "0";
            txtEspressoConpana.Text = "0";
            txtAmericano.Text = "0";
            txtCappuccino.Text = "0";
            txtLatte.Text = "0";
            txtIrish.Text = "0";
            txtFredo.Text = "0";
            txtFrappe.Text = "0";
            txtMocha.Text = "0";
            txtCamelMacchiato.Text = "0";

        } // end of customerUI_Load method

        private void chkEspresso_CheckedChanged(object sender, EventArgs e)
        {
                if (chkEspresso.Checked == true)
                {
                    txtEspresso.Enabled = true;
                    txtEspresso.Text = "1";

                } // end of if

                else
                {
                    txtEspresso.Enabled = false;
                    txtEspresso.Text = "0";

                } // end of else espresso

        } // end of chkEspresso_CheckedChanged method

        private void chkDoppto_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDoppto.Checked==true)
            {
                txtDoppto.Enabled= true;
                txtDoppto.Text = "1";

            } // end of if

            else
            {
                txtDoppto.Enabled= false;
                txtDoppto.Text = "0";

            } // end of else doppto

        } // end of chkDoppto_CheckedChanged

        private void chkEspressoMacchiato_CheckedChanged(object sender, EventArgs e)
        {
            if(chkEspressoMacchiato.Checked==true)
            {
                txtEspressoMacchiato.Enabled= true;
                txtEspressoMacchiato.Text = "1";

            } // end of if

            else
            {
                txtEspressoMacchiato.Enabled= false;
                txtEspressoMacchiato.Text = "0";

            } // end of else

        } // end of chkEspressoMacchiato_CheckedChanged

        private void chkEspressoConpana_CheckedChanged(object sender, EventArgs e)
        {
            if(chkEspressoConpana.Checked==true)
            {
                txtEspressoConpana.Enabled= true;
                txtEspressoConpana.Text = "1";

            } // end of if

            else
            {
                txtEspressoConpana.Enabled= false;
                txtEspressoConpana.Text = "0";
            } // end of else

        } // end of chkEspressoConpana_CheckedChanged

        private void chkAmericano_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAmericano.Checked==true)
            {
                txtAmericano.Enabled= true;
                txtAmericano.Text = "1";

            } // end of if

            else
            {
                txtAmericano.Enabled = false;
                txtAmericano.Text = "0";
            } // end of else
             
        } // end of chkAmericano_CheckedChanged

        private void chkCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCappuccino.Checked==true)
            {
                txtCappuccino.Enabled= true;
                txtCappuccino.Text = "1";

            } // end of if

            else
            {
                txtCappuccino.Enabled = false;
                txtCappuccino.Text = "0";

            } // end of else

        } // end of chkCappuccino_CheckedChanged

        private void chkLatte_CheckedChanged(object sender, EventArgs e)
        {
            if(chkLatte.Checked==true)
            {
                txtLatte.Enabled= true;
                txtLatte.Text = "1";

            } // end of if

            else
            {
                txtLatte.Enabled = false;
                txtLatte.Text = "0";

            } //end of else

        } // end of chkLatte_CheckedChanged

        private void chkIrish_CheckedChanged(object sender, EventArgs e)
        {
            if(chkIrish.Checked==true)
            {
                txtIrish.Enabled= true;
                txtIrish.Text= "1";

            } // end of if

            else
            {
                txtIrish.Enabled = false;
                txtIrish.Text = "0";

            } // end of else

        } // end of chkIrish_CheckedChanded

        private void chkFredo_CheckedChanged(object sender, EventArgs e)
        {
            if(chkFredo.Checked==true)
            {
                txtFredo.Enabled = true;
                txtFredo.Text= "1";

            } // end of if
            else
            {
                txtFredo.Enabled = false;
                txtFredo.Text = "0";

            } // end of else

        } // end of chkFredo_checkedChanged

        private void chkFrappe_CheckedChanged(object sender, EventArgs e)
        {
            if( chkFrappe.Checked==true)
            {
                txtFrappe.Enabled = true;
                txtFrappe.Text = "1";

            } // end of if

            else
            {
                txtFrappe.Enabled = false;
                txtFrappe.Text = "0";

            } // end of else

        } // end of chkFrappe_checkedChanged

        private void chkMocha_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMocha.Checked==true)
            {
                txtMocha.Enabled = true;
                txtMocha.Text = "1";

            } // end of if

            else
            {
                txtMocha.Enabled = false;
                txtMocha.Text = "0";

            } // end of else

        } // end of chkMocha_CheckedChanged

        private void chkCarmelMacchiato_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCarmelMacchiato.Checked==true)
            {
                txtCamelMacchiato.Enabled = true;
                txtCamelMacchiato.Text = "1";

            } // end of if

            else
            {
                txtCamelMacchiato.Enabled = false;
                txtCamelMacchiato.Text = "0";

            } // end of else

        } // end of chkCarmelMacchiato_CheckedChanged

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();

            TheCoffeeClubUI theCoffeeClub=new TheCoffeeClubUI();
            theCoffeeClub.Show();

        } // end of btnCancel_Click

    } // end of class CustomerUI

} // end of namespace
