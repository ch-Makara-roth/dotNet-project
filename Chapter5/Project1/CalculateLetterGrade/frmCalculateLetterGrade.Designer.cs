namespace CalculateLetterGrade
{
    partial class frmCalculateLetterGrade
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textNumericGrade = new TextBox();
            label2 = new Label();
            btnCalculateLetterGrade = new Button();
            btnExit = new Button();
            txtLetterGrade = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 116);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Numeric Grade";
            // 
            // textNumericGrade
            // 
            textNumericGrade.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textNumericGrade.Location = new Point(333, 93);
            textNumericGrade.Name = "textNumericGrade";
            textNumericGrade.Size = new Size(273, 43);
            textNumericGrade.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 211);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 2;
            label2.Text = "Letter Grade";
            // 
            // btnCalculateLetterGrade
            // 
            btnCalculateLetterGrade.FlatAppearance.BorderColor = Color.Blue;
            btnCalculateLetterGrade.FlatStyle = FlatStyle.Popup;
            btnCalculateLetterGrade.Location = new Point(230, 325);
            btnCalculateLetterGrade.Name = "btnCalculateLetterGrade";
            btnCalculateLetterGrade.Size = new Size(166, 50);
            btnCalculateLetterGrade.TabIndex = 4;
            btnCalculateLetterGrade.Text = "&Calculate Letter Grade";
            btnCalculateLetterGrade.UseVisualStyleBackColor = true;
            btnCalculateLetterGrade.Click += btnCalculateLetterGrade_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(441, 325);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(165, 50);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtLetterGrade
            // 
            txtLetterGrade.BorderStyle = BorderStyle.Fixed3D;
            txtLetterGrade.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            txtLetterGrade.Location = new Point(333, 201);
            txtLetterGrade.Name = "txtLetterGrade";
            txtLetterGrade.Size = new Size(273, 53);
            txtLetterGrade.TabIndex = 3;
            txtLetterGrade.TextAlign = ContentAlignment.MiddleCenter;
            txtLetterGrade.Click += label3_Click;
            // 
            // frmCalculateLetterGrade
            // 
            AcceptButton = btnCalculateLetterGrade;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLetterGrade);
            Controls.Add(btnExit);
            Controls.Add(btnCalculateLetterGrade);
            Controls.Add(label2);
            Controls.Add(textNumericGrade);
            Controls.Add(label1);
            Name = "frmCalculateLetterGrade";
            Text = "Calculate Letter Grade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textNumericGrade;
        private Label label2;
        private Button btnCalculateLetterGrade;
        private Button btnExit;
        private Label txtLetterGrade;
    }
}