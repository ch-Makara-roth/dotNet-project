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

        private decimal CalculateFutureValue( decimal monthlyInvestment, decimal monthInteresRate, int months)
        {
            decimal futureValue = 0m;

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                            * (1 + monthInteresRate);
            }
            return futureValue;

        }
        private void ClearFutureValue (object sender, EventArgs e) 
        {

            txtFutureValue.Text = " "; 
         }
    

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvesment.Text);
            decimal yearlyInterestRate
                = Convert.ToDecimal(txtYearlyInterestRate.Text);
            int years = Convert.ToInt32(txtYears.Text);

            int months = years * 12;
            decimal monthlyInterestRate
                = yearlyInterestRate / 12 / 100;

            decimal futureValue = this.CalculateFutureValue(
                monthlyInvestment, monthlyInterestRate, months);
            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvesment.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMonthlyInvesment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
