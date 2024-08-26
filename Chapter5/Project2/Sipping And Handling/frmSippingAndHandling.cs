using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sipping_And_Handling
{
    public partial class frmSippingAndHandling : Form
    {
        public frmSippingAndHandling()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculateGrandTotal_Click(object sender, EventArgs e)
        {
            decimal orderTotal = Convert.ToDecimal(txtOrderTotal.Text);
            string customerType = Convert.ToString(txtCustomerType.Text);

            decimal sippingCosts = 0;
            decimal salesTax =  .07m;
            switch (customerType)
            {
                case "P":
                    sippingCosts = 0;
                    break;
                case "N":

                    if (orderTotal >= 0 && orderTotal <= 25)
                    {
                        sippingCosts = 5;
                    }
                    else if (orderTotal > 25 && orderTotal <= 500)
                    {
                        sippingCosts = 5;
                    }
                    else if (orderTotal > 500 && orderTotal <= 1000)
                    {
                        sippingCosts = 10;
                    }
                    else if (orderTotal > 1000 && orderTotal <= 5000)
                    {
                        sippingCosts = 15;
                    }
                    else if (orderTotal > 5000)
                    {
                        sippingCosts = 20;
                    }
                    break;
            }

            txtSippingCosts.Text = sippingCosts.ToString("c");


            decimal totalTax = (salesTax * orderTotal);
   
            decimal grendTotal = totalTax + orderTotal + sippingCosts;

            txtSalesTax.Text = totalTax.ToString("c");
            txtGrandTotal.Text = grendTotal.ToString("c");


            txtCustomerType.Focus();
        }
    }
}
