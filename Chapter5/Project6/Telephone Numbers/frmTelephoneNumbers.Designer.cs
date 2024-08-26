namespace Telephone_Numbers
{
    partial class frmTelephoneNumbers
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
            this.txtAlphanumericNumber = new System.Windows.Forms.TextBox();
            this.txtNumericOnly = new System.Windows.Forms.TextBox();
            this.btnConvertToNumericOnly = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "AIphanumeric Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numeric Only";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAlphanumericNumber
            // 
            this.txtAlphanumericNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlphanumericNumber.Location = new System.Drawing.Point(246, 65);
            this.txtAlphanumericNumber.Name = "txtAlphanumericNumber";
            this.txtAlphanumericNumber.Size = new System.Drawing.Size(182, 34);
            this.txtAlphanumericNumber.TabIndex = 1;
            // 
            // txtNumericOnly
            // 
            this.txtNumericOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumericOnly.Location = new System.Drawing.Point(246, 147);
            this.txtNumericOnly.Name = "txtNumericOnly";
            this.txtNumericOnly.ReadOnly = true;
            this.txtNumericOnly.Size = new System.Drawing.Size(182, 34);
            this.txtNumericOnly.TabIndex = 3;
            // 
            // btnConvertToNumericOnly
            // 
            this.btnConvertToNumericOnly.Location = new System.Drawing.Point(72, 248);
            this.btnConvertToNumericOnly.Name = "btnConvertToNumericOnly";
            this.btnConvertToNumericOnly.Size = new System.Drawing.Size(92, 79);
            this.btnConvertToNumericOnly.TabIndex = 2;
            this.btnConvertToNumericOnly.Text = "&Convert To Numeric Only";
            this.btnConvertToNumericOnly.UseVisualStyleBackColor = true;
            this.btnConvertToNumericOnly.Click += new System.EventHandler(this.btnConvertToNumericOnly_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(274, 248);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 79);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTelephoneNumbers
            // 
            this.AcceptButton = this.btnConvertToNumericOnly;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(491, 387);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvertToNumericOnly);
            this.Controls.Add(this.txtNumericOnly);
            this.Controls.Add(this.txtAlphanumericNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTelephoneNumbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telephone Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlphanumericNumber;
        private System.Windows.Forms.TextBox txtNumericOnly;
        private System.Windows.Forms.Button btnConvertToNumericOnly;
        private System.Windows.Forms.Button btnExit;
    }
}

