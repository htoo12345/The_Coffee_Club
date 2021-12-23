using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffeeClub.DAO;
using TheCoffeeClub.Model;

namespace TheCoffeeClub.UI
{
    public partial class OwnerLoginUI : Form
    {
        public OwnerLoginUI()
        {
            InitializeComponent();
        }

        private void OwnerLoginUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName=txtUserName.Text;
            string password=txtPassword.Text;

            
            // Check username and password 
            if(userName.Equals("CoffeeMaker") && password.Equals("123"))
            {
                this.Hide();

                // User and password are correct go to OwnerDashBoard 
                OwnerItemControlUI ownerItemControl=new OwnerItemControlUI();
                ownerItemControl.Show();
            }
            else
            {
                MessageBox.Show("User name and password are incorrect", "Error occur!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            TheCoffeeClubUI theCoffeeClubUI = new TheCoffeeClubUI();
            theCoffeeClubUI.Show();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
