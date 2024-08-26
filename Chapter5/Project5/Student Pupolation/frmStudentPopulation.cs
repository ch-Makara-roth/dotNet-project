using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Pupolation
{
    public partial class frmStudentPopulation : Form
    {
        public frmStudentPopulation()
        {
            InitializeComponent();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void btnProjectStudentPopulation_Click(object sender, EventArgs e)

        {
            decimal numberOfStudentToday = Convert.ToDecimal(txtNumberOfStudentsToday.Text);    
            float  annualGrowthRate  =  (float)Convert.ToDouble(txtAnnualGrowthRate.Text);
            int numberOfYears = Convert.ToInt32(txtNumberOfYears.Text);

            int projectNumberOfStudents = 0;


            for(int i = 1; i <= numberOfYears; i++) {
                projectNumberOfStudents = (int)((int)numberOfStudentToday*Math.Pow(1+ annualGrowthRate , i ) );
            }     
          
            txtProjectedNumberOfStudents.Text = projectNumberOfStudents.ToString("c");


        }
    }
}
