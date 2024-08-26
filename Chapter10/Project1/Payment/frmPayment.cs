using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payment
{
 partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Billing_CheckedChanged(object sender, System.EventArgs e)
        {

            if (rdoCreditCard.Checked)
                EnableControls();
            else
                DisableControls();

        }
        private void frmPayment_Load(object sender, EventArgs e)
        {
            lstCreditCardType.Items.Add("Visa");
            lstCreditCardType.Items.Add("Mastercard");
            lstCreditCardType.Items.Add("American Express");
            lstCreditCardType.SelectedIndex = 0;

            string[] months =
            {
                "Select a Month ... " ,
                "January" , "February" ," March" , "April" , "May " , " June" ,
                "August" , "September" , "November" , "December "
            };
            foreach (string month in months)
            {
                cboExpiationMonth.Items.Add(month);
                cboExpiationMonth.SelectedIndex = 0;
            }

            int year = DateTime.Today.Year;
            int endYear = year + 8;

            cboExpiationYear.Items.Add("Select a Year...... ");
            while (year <= endYear)
            {
                cboExpiationYear.Items.Add(year);
                year++;
                cboExpiationYear.SelectedIndex = 0;
            }
        }
        
        private bool IsValidData()
        {
           if (rdoCreditCard.Checked)
            {
                if (lstCreditCardType.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "You must select a credit card type.",
                        "Entry Error");
                    lstCreditCardType.Focus();
                    return false;
                }
                if (txtCardNumber.Text == "")
                {
                    MessageBox.Show(
                        "You must enter a credit card number.",
                        "Entry Error");
                    txtCardNumber.Focus();
                    return false;
                }
                if (cboExpiationMonth.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a month.",
                        "Entry Error");
                    cboExpiationMonth.Focus();
                    return false;
                }
                if (cboExpiationYear.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a year.",
                        "Entry Error");
                    cboExpiationYear.Focus();
                    return false;
                }
            }
            return true; 
        }
        private void SaveData()
        {
            string msg = null;

            if (rdoCreditCard.Checked == true)
            {
                msg += "Charge to credit card." + "\n";
                msg += "\n";
                msg += "Card type: " + lstCreditCardType.Text
                    + "\n";
                msg += "Card number: " + txtCardNumber.Text
                    + "\n";
                msg += "Expiration date: "
                    + cboExpiationMonth.Text + "/"
                    + cboExpiationYear.Text + "\n";
            }
            else
            {
                msg += "Send bill to customer." + "\n";
                msg += "\n";
            }
            bool isDefaultBilling = chkDefault.Checked;
            msg += "Default billing: " + isDefaultBilling;

            this.Tag = msg;
            this.DialogResult = DialogResult.OK;
        }
        private void EnableControls()
        {
            lstCreditCardType.Enabled = true;
            txtCardNumber.Enabled = true;
            cboExpiationMonth.Enabled = true;
            cboExpiationYear.Enabled = true;
        }

        private void DisableControls()
        {
            lstCreditCardType.Enabled = false;
            txtCardNumber.Enabled = false;
            cboExpiationMonth.Enabled = false;
            cboExpiationYear.Enabled = false;
        }

     

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                this.SaveData();
            }
        }
        private void cboExpiationMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

      
        }
        private void cboExpiationYear_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
