namespace Sipping_And_Handling
{
    partial class frmSippingAndHandling
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtCustomerType = new System.Windows.Forms.TextBox();
            this.btnCalculateGrandTotal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSippingCosts = new System.Windows.Forms.TextBox();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(44, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Total ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(44, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Type (P=Prefered N=non-Prerred)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(44, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sipping Costs (Free For Preferred Customers)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(47, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sales Tax (7%)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(44, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 43);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grand Total ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderTotal.Location = new System.Drawing.Point(370, 72);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(168, 30);
            this.txtOrderTotal.TabIndex = 1;
            this.txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerType.Location = new System.Drawing.Point(370, 118);
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.Size = new System.Drawing.Size(65, 30);
            this.txtCustomerType.TabIndex = 2;
            this.txtCustomerType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculateGrandTotal
            // 
            this.btnCalculateGrandTotal.Location = new System.Drawing.Point(125, 334);
            this.btnCalculateGrandTotal.Name = "btnCalculateGrandTotal";
            this.btnCalculateGrandTotal.Size = new System.Drawing.Size(99, 65);
            this.btnCalculateGrandTotal.TabIndex = 3;
            this.btnCalculateGrandTotal.Text = "&Calculate Grand Total";
            this.btnCalculateGrandTotal.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(336, 334);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 65);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSippingCosts
            // 
            this.txtSippingCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSippingCosts.Location = new System.Drawing.Point(370, 167);
            this.txtSippingCosts.Name = "txtSippingCosts";
            this.txtSippingCosts.ReadOnly = true;
            this.txtSippingCosts.Size = new System.Drawing.Size(168, 30);
            this.txtSippingCosts.TabIndex = 5;
            this.txtSippingCosts.TabStop = false;
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesTax.Location = new System.Drawing.Point(370, 221);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(168, 30);
            this.txtSalesTax.TabIndex = 6;
            this.txtSalesTax.TabStop = false;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.Location = new System.Drawing.Point(370, 264);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(168, 30);
            this.txtGrandTotal.TabIndex = 7;
            this.txtGrandTotal.TabStop = false;
            // 
            // frmSippingAndHandling
            // 
            this.AcceptButton = this.btnCalculateGrandTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(623, 446);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.txtSalesTax);
            this.Controls.Add(this.txtSippingCosts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateGrandTotal);
            this.Controls.Add(this.txtCustomerType);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSippingAndHandling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipping and Handling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtCustomerType;
        private System.Windows.Forms.Button btnCalculateGrandTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSippingCosts;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.TextBox txtGrandTotal;
    }
}

