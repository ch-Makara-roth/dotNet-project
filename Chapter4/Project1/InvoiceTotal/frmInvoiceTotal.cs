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
        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;
        public frmInvoiceTotal()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscountPercent_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerType_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
                 decimal subTotal = Convert.ToDecimal(txtEnterSubtotal.Text);
            decimal discountPercent = .25m;


            decimal discountAmount = Math.Round(subTotal * discountPercent, 2);
            decimal invoiceTotal = subTotal - discountAmount;

            txtSubtotal.Text = subTotal.ToString("c");
            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            numberOfInvoices++;
            totalOfInvoices += invoiceTotal;
            invoiceAverage = totalOfInvoices / numberOfInvoices;


            txtNumberOfInvoices.Text = numberOfInvoices.ToString();
            txtTotalOfInvoice.Text = totalOfInvoices.ToString("c");
            txtInvoiceAverage.Text = invoiceAverage.ToString("c");
            



            txtEnterSubtotal.Text = " ";
            txtEnterSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearTotal_Click(object sender, EventArgs e)
        {

            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAverage = 0m;


            txtNumberOfInvoices.Text = " "; 
            txtTotalOfInvoice.Text = " ";
            txtInvoiceAverage.Text = " ";

            txtEnterSubtotal.Focus();
            }
    }
}
