namespace Student_Pupolation
{
    partial class frmStudentPopulation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumberOfStudentsToday = new System.Windows.Forms.TextBox();
            this.btnProjectStudentPopulation = new System.Windows.Forms.Button();
            this.txtAnnualGrowthRate = new System.Windows.Forms.TextBox();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtProjectedNumberOfStudents = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(56, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Students Today";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Annual Growth Rate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(56, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number Of Years";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(56, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Projected Number Of Students";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumberOfStudentsToday
            // 
            this.txtNumberOfStudentsToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfStudentsToday.Location = new System.Drawing.Point(314, 70);
            this.txtNumberOfStudentsToday.Name = "txtNumberOfStudentsToday";
            this.txtNumberOfStudentsToday.Size = new System.Drawing.Size(188, 34);
            this.txtNumberOfStudentsToday.TabIndex = 1;
            // 
            // btnProjectStudentPopulation
            // 
            this.btnProjectStudentPopulation.Location = new System.Drawing.Point(106, 409);
            this.btnProjectStudentPopulation.Name = "btnProjectStudentPopulation";
            this.btnProjectStudentPopulation.Size = new System.Drawing.Size(99, 62);
            this.btnProjectStudentPopulation.TabIndex = 4;
            this.btnProjectStudentPopulation.Text = "&Project Student Population";
            this.btnProjectStudentPopulation.UseVisualStyleBackColor = true;
            // 
            // txtAnnualGrowthRate
            // 
            this.txtAnnualGrowthRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnualGrowthRate.Location = new System.Drawing.Point(314, 144);
            this.txtAnnualGrowthRate.Name = "txtAnnualGrowthRate";
            this.txtAnnualGrowthRate.Size = new System.Drawing.Size(188, 34);
            this.txtAnnualGrowthRate.TabIndex = 2;
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfYears.Location = new System.Drawing.Point(314, 216);
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(188, 34);
            this.txtNumberOfYears.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(314, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 62);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtProjectedNumberOfStudents
            // 
            this.txtProjectedNumberOfStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectedNumberOfStudents.Location = new System.Drawing.Point(314, 289);
            this.txtProjectedNumberOfStudents.Name = "txtProjectedNumberOfStudents";
            this.txtProjectedNumberOfStudents.ReadOnly = true;
            this.txtProjectedNumberOfStudents.Size = new System.Drawing.Size(188, 34);
            this.txtProjectedNumberOfStudents.TabIndex = 12;
            this.txtProjectedNumberOfStudents.TabStop = false;
            // 
            // frmStudentPopulation
            // 
            this.AcceptButton = this.btnProjectStudentPopulation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(558, 538);
            this.Controls.Add(this.txtProjectedNumberOfStudents);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtNumberOfYears);
            this.Controls.Add(this.txtAnnualGrowthRate);
            this.Controls.Add(this.btnProjectStudentPopulation);
            this.Controls.Add(this.txtNumberOfStudentsToday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmStudentPopulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studdent Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumberOfStudentsToday;
        private System.Windows.Forms.Button btnProjectStudentPopulation;
        private System.Windows.Forms.TextBox txtAnnualGrowthRate;
        private System.Windows.Forms.TextBox txtNumberOfYears;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtProjectedNumberOfStudents;
    }
}

