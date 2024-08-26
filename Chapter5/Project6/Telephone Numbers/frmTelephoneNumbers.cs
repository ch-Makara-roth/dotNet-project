using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Numbers
{
    public partial class frmTelephoneNumbers : Form
    {
        public frmTelephoneNumbers()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertToNumericOnly_Click(object sender, EventArgs e)
        {
            string alphaNumberic = txtAlphanumericNumber.Text;
            string alphaNumbericOfIndex = alphaNumberic.Substring(0,alphaNumberic.IndexOf("-"));
            string alphaNumberic1 = alphaNumberic.Substring ( alphaNumberic.IndexOf("-"));
            string alpahNumbericNew = " ";
            char toNumber = ' ';

            for(int i = 0; i < alphaNumbericOfIndex.Length; i++)
            {
                if (alphaNumbericOfIndex[i] == 'a' || alphaNumbericOfIndex[i] == 'b' || alphaNumbericOfIndex[i] == 'c' || alphaNumbericOfIndex[i] == 'A' || alphaNumbericOfIndex[i] == 'B' || alphaNumbericOfIndex[i] == 'C') 
                {
                    toNumber = '2';
                }
                else if (alphaNumbericOfIndex[i] == 'd' || alphaNumbericOfIndex[i] == 'e' || alphaNumbericOfIndex[i] == 'f' || alphaNumbericOfIndex[i] == 'D' || alphaNumbericOfIndex[i] == 'E' || alphaNumbericOfIndex[i] == 'F')
                {
                    toNumber = '3';
                }
                else if (alphaNumbericOfIndex[i] == 'g' || alphaNumbericOfIndex[i] == 'h' || alphaNumbericOfIndex[i] == 'i' || alphaNumbericOfIndex[i] == 'G' || alphaNumbericOfIndex[i] == 'H' || alphaNumbericOfIndex[i] == 'I')
                {
                    toNumber = '4';
                }
                else if (alphaNumbericOfIndex[i] == 'j' || alphaNumbericOfIndex[i] == 'k' || alphaNumbericOfIndex[i] == 'l' || alphaNumbericOfIndex[i] == 'J' || alphaNumbericOfIndex[i] == 'K' || alphaNumbericOfIndex[i] == 'L')
                {
                    toNumber = '5';
                }
                else if (alphaNumbericOfIndex[i] == 'm' || alphaNumbericOfIndex[i] == 'n' || alphaNumbericOfIndex[i] == 'o' || alphaNumbericOfIndex[i] == 'M' || alphaNumbericOfIndex[i] == 'N' || alphaNumbericOfIndex[i] == 'O')
                {
                    toNumber = '6';
                }
                else if (alphaNumbericOfIndex[i] == 'p' || alphaNumbericOfIndex[i] == 'q' || alphaNumbericOfIndex[i] == 'r' || alphaNumbericOfIndex[i] == 'P' || alphaNumbericOfIndex[i] == 'Q' || alphaNumbericOfIndex[i] == 'R')
                {
                    toNumber = '7';
                }
                else if (alphaNumbericOfIndex[i] == 's' || alphaNumbericOfIndex[i] == 't' || alphaNumbericOfIndex[i] == 'u' || alphaNumbericOfIndex[i] == 'S' || alphaNumbericOfIndex[i] == 'T' || alphaNumbericOfIndex[i] == 'U')
                {
                    toNumber = '8';
                }
                else if (alphaNumbericOfIndex[i] == 'v' || alphaNumbericOfIndex[i] == 'w' || alphaNumbericOfIndex[i] == 'x' || alphaNumbericOfIndex[i] == 'V' || alphaNumbericOfIndex[i] == 'W' || alphaNumbericOfIndex[i] == 'X')
                {
                    toNumber = '9';
                }
                else
                {
                    toNumber = alphaNumbericOfIndex[i];
                }
                alpahNumbericNew =alpahNumbericNew + toNumber;
            }
            alpahNumbericNew += alphaNumberic1;

            txtNumericOnly.Text = alpahNumbericNew; 
            txtAlphanumericNumber.Focus();

        }
    }
}
