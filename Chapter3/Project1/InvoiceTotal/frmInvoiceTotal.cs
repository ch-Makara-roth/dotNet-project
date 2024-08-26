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
            decimal Subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = 0;
            if (Subtotal >= 500 )
            {
                discountPercent = .2m;
              
            } else if (Subtotal >= 250 &&  Subtotal < 500)
            {
                discountPercent = .15m;
            }else if (Subtotal >=100 && Subtotal < 250)
            {
                discountPercent = .1m;
            }
            decimal discountAmount = Subtotal * discountPercent;
            decimal invoiceTotal = Subtotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c"); 
            txtSubtotal.Focus();

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frmInvoiceTotal_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void frmInvoiceTotal_KeyDown(object sender, KeyEventArgs e)
        {
            // Shortcut ctrl + c 
            if(e.Control == true  && e.KeyCode == Keys.C)
            {
                btnCalculate.PerformClick();
            }
            // shortcut ctrl + x
            if (e.Control == true && e.KeyCode == Keys.X)
            {
                btnExit.PerformClick();
            }
        }   
    }
}
