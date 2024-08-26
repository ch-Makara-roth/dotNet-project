using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Future_Value
{
    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Defrne Variable 
             decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvesment.Text);
            decimal yearlyInteresRate = Convert.ToDecimal(txtYearlyInterestRate.Text);
            int years = Convert.ToInt32(txtYears.Text);

            // Assigne value to the variable 
            int month = years * 12;
            decimal monthInteresRate = yearlyInteresRate / 12 / 100;
            decimal futureValue = 0m;

            // constrol flow with For loop 

                for ( int i =0 ; i < month; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthInteresRate);
            } 


            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvesment.Focus();            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
