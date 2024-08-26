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

        private static decimal CalculateFutureValue(decimal monthlyInvestment, decimal yearlyInteresRate, int months)
        {
            decimal futureValue = 0m;
            // constrol flow with For loop 

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + yearlyInteresRate);
            }
            return futureValue;

        }
        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == " ")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        public bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal " + "value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }
        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " +
                    min.ToString() + " and " + max.ToString() +
                    ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        public bool IsValidData()
        {
            return

                // Validate the Monthly Investment text box
                IsPresent(txtMonthlyInvesment, "Monthly Investment") &&
                IsDecimal(txtMonthlyInvesment, "Monthly Investment") &&
                IsWithinRange(txtMonthlyInvesment, "Monthly Investment",
                   1, 1000) &&

                // Validate the Interest Rate text box
                IsPresent(txtYearlyInterestRate, "Yearly Interest Rate") &&
                IsDecimal(txtYearlyInterestRate, "Yearly Interest Rate") &&
                IsWithinRange(txtYearlyInterestRate, "Yearly Interest Rate",
                    1, 20);

        }
       
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    decimal monthlyInvestment =
                        Convert.ToDecimal(txtMonthlyInvesment.Text);
                    decimal yearlyInterestRate =
                        Convert.ToDecimal(txtYearlyInterestRate.Text);
                    int years = Convert.ToInt32(txtYears.Text);

                    int months = years * 12;
                    decimal monthlyInterestRate =
                        yearlyInterestRate / 12 / 100;
                    decimal futureValue = CalculateFutureValue(
                        monthlyInvestment, yearlyInterestRate,
                        months);
                    txtFutureValue.Text = futureValue.ToString("c");
                    txtMonthlyInvesment.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearFutureValue(object sender, EventArgs e)
        {

            txtFutureValue.Text = " ";
        }
       
       

        private void txtMonthlyInvesment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
