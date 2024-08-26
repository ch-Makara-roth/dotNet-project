using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string CustomerType = txtCustomerType.Text;
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = .0m;

            if (CustomerType == "R" || CustomerType == "r")
            {
                if (subtotal < 100)
                {
                    discountPercent = .0m;
                }
                else if (subtotal >= 100 && subtotal < 250)
                {
                    discountPercent = .1m;

                }
                else if (subtotal >= 250)
                {
                    discountPercent = .25m;
                }
            }
            else if (CustomerType == "C " || CustomerType == "c")
            {
                if (subtotal < 250)
                {
                    discountPercent = .2m;
                }
                else { discountPercent = .3m; }
            }
            else discountPercent = .4m;

            decimal discountAmount = subtotal * discountPercent; 
            decimal invoiceTotal = subtotal - discountAmount;

            txtDiscountPercent.Text = invoiceTotal.ToString("p1");
            txtDiscountAmount.Text = invoiceTotal.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtCustomerType.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }




}
