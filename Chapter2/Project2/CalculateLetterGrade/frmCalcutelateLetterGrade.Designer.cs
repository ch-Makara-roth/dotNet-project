namespace CalculateLetterGrade
{
    partial class frmCalcutelateLetterGrade
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
            this.txtNumericGrade = new System.Windows.Forms.TextBox();
            this.btnCalculateLetterGrade = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtLetterGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(56, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numeric Grade";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(56, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Letter Grade";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNumericGrade
            // 
            this.txtNumericGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumericGrade.Location = new System.Drawing.Point(271, 77);
            this.txtNumericGrade.Name = "txtNumericGrade";
            this.txtNumericGrade.Size = new System.Drawing.Size(134, 34);
            this.txtNumericGrade.TabIndex = 1;
            // 
            // btnCalculateLetterGrade
            // 
            this.btnCalculateLetterGrade.Location = new System.Drawing.Point(85, 256);
            this.btnCalculateLetterGrade.Name = "btnCalculateLetterGrade";
            this.btnCalculateLetterGrade.Size = new System.Drawing.Size(106, 49);
            this.btnCalculateLetterGrade.TabIndex = 2;
            this.btnCalculateLetterGrade.Text = "&CalculateLetterGrade";
            this.btnCalculateLetterGrade.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(254, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 50);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtLetterGrade
            // 
            this.txtLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtLetterGrade.Location = new System.Drawing.Point(268, 160);
            this.txtLetterGrade.Name = "txtLetterGrade";
            this.txtLetterGrade.Size = new System.Drawing.Size(137, 31);
            this.txtLetterGrade.TabIndex = 4;
            this.txtLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCalcutelateLetterGrade
            // 
            this.AcceptButton = this.btnCalculateLetterGrade;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(475, 374);
            this.Controls.Add(this.txtLetterGrade);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateLetterGrade);
            this.Controls.Add(this.txtNumericGrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCalcutelateLetterGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Letter Grade";
            this.Load += new System.EventHandler(this.CalcutelateLetterGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumericGrade;
        private System.Windows.Forms.Button btnCalculateLetterGrade;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label txtLetterGrade;
    }
}

