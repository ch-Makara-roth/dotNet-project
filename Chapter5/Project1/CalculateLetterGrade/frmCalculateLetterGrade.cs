namespace CalculateLetterGrade
{
    public partial class frmCalculateLetterGrade : Form
    {
        public frmCalculateLetterGrade()
        {
            InitializeComponent();
        }

        private void btnCalculateLetterGrade_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(textNumericGrade.Text);

             if (subtotal < 60)
            {
                txtLetterGrade.Text = "F";
            }
            else if (subtotal >= 60 && subtotal < 70)
            {
                txtLetterGrade.Text = "D";
            }
            else if (subtotal >= 70 && subtotal < 80)
            {
                txtLetterGrade.Text = "D";
            }
            else if (subtotal >= 80 && subtotal < 90)
            {
                txtLetterGrade.Text = "B";
            }
            else if (subtotal >= 90 && subtotal <= 100)
            {
                txtLetterGrade.Text = "A";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}