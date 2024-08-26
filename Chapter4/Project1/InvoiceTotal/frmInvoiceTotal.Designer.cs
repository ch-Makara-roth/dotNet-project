namespace InvoiceTotal
{
    partial class frmInvoiceTotal
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
            this.txtDiscountPercent = new System.Windows.Forms.Label();
            this.txtDiscountAmount = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnterSubtotal = new System.Windows.Forms.TextBox();
            this.btnClearTotal = new System.Windows.Forms.Button();
            this.txtInvoiceAverage = new System.Windows.Forms.Label();
            this.txtTotalOfInvoice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumberOfInvoices = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(76, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "SubTotal : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(76, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Discount Percent : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(76, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount Amount : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(76, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDiscountPercent.Location = new System.Drawing.Point(240, 156);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(167, 35);
            this.txtDiscountPercent.TabIndex = 5;
            this.txtDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDiscountPercent.Click += new System.EventHandler(this.txtDiscountPercent_Click);
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDiscountAmount.Location = new System.Drawing.Point(240, 212);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.Size = new System.Drawing.Size(167, 35);
            this.txtDiscountAmount.TabIndex = 6;
            this.txtDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotal.Location = new System.Drawing.Point(240, 266);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(167, 35);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(233, 354);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(152, 52);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(642, 353);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 53);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(76, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enter Subtotal : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEnterSubtotal
            // 
            this.txtEnterSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterSubtotal.Location = new System.Drawing.Point(240, 40);
            this.txtEnterSubtotal.Name = "txtEnterSubtotal";
            this.txtEnterSubtotal.Size = new System.Drawing.Size(167, 34);
            this.txtEnterSubtotal.TabIndex = 1;
            this.txtEnterSubtotal.TextChanged += new System.EventHandler(this.txtCustomerType_TextChanged);
            // 
            // btnClearTotal
            // 
            this.btnClearTotal.Location = new System.Drawing.Point(442, 353);
            this.btnClearTotal.Name = "btnClearTotal";
            this.btnClearTotal.Size = new System.Drawing.Size(154, 53);
            this.btnClearTotal.TabIndex = 3;
            this.btnClearTotal.Text = "Clear Totals";
            this.btnClearTotal.UseVisualStyleBackColor = true;
            this.btnClearTotal.Click += new System.EventHandler(this.btnClearTotal_Click);
            // 
            // txtInvoiceAverage
            // 
            this.txtInvoiceAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtInvoiceAverage.Location = new System.Drawing.Point(695, 220);
            this.txtInvoiceAverage.Name = "txtInvoiceAverage";
            this.txtInvoiceAverage.Size = new System.Drawing.Size(167, 35);
            this.txtInvoiceAverage.TabIndex = 17;
            this.txtInvoiceAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalOfInvoice
            // 
            this.txtTotalOfInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotalOfInvoice.Location = new System.Drawing.Point(695, 161);
            this.txtTotalOfInvoice.Name = "txtTotalOfInvoice";
            this.txtTotalOfInvoice.Size = new System.Drawing.Size(167, 35);
            this.txtTotalOfInvoice.TabIndex = 16;
            this.txtTotalOfInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(487, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 35);
            this.label8.TabIndex = 15;
            this.label8.Text = "Invoice average : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(487, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 35);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total of invoices :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(487, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 35);
            this.label10.TabIndex = 12;
            this.label10.Text = "Number of invoices : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumberOfInvoices
            // 
            this.txtNumberOfInvoices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtNumberOfInvoices.Location = new System.Drawing.Point(696, 98);
            this.txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            this.txtNumberOfInvoices.Size = new System.Drawing.Size(167, 35);
            this.txtNumberOfInvoices.TabIndex = 18;
            this.txtNumberOfInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtSubtotal.Location = new System.Drawing.Point(240, 99);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(167, 35);
            this.txtSubtotal.TabIndex = 19;
            this.txtSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmInvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtNumberOfInvoices);
            this.Controls.Add(this.txtInvoiceAverage);
            this.Controls.Add(this.txtTotalOfInvoice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClearTotal);
            this.Controls.Add(this.txtEnterSubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmInvoiceTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceTotal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtDiscountPercent;
        private System.Windows.Forms.Label txtDiscountAmount;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnterSubtotal;
        private System.Windows.Forms.Button btnClearTotal;
        private System.Windows.Forms.Label txtInvoiceAverage;
        private System.Windows.Forms.Label txtTotalOfInvoice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtNumberOfInvoices;
        private System.Windows.Forms.Label txtSubtotal;
    }
}

