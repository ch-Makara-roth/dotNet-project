namespace Payment
{
    partial class frmPayment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBillCustomer = new System.Windows.Forms.RadioButton();
            this.rdoCreditCard = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCreditCardType = new System.Windows.Forms.ListBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboExpiationMonth = new System.Windows.Forms.ComboBox();
            this.cboExpiationYear = new System.Windows.Forms.ComboBox();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBillCustomer);
            this.groupBox1.Controls.Add(this.rdoCreditCard);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Biling";
            // 
            // rdoBillCustomer
            // 
            this.rdoBillCustomer.AutoSize = true;
            this.rdoBillCustomer.Location = new System.Drawing.Point(301, 32);
            this.rdoBillCustomer.Name = "rdoBillCustomer";
            this.rdoBillCustomer.Size = new System.Drawing.Size(106, 20);
            this.rdoBillCustomer.TabIndex = 1;
            this.rdoBillCustomer.Text = "Bill Customer";
            this.rdoBillCustomer.UseVisualStyleBackColor = true;
            this.rdoBillCustomer.CheckedChanged += new System.EventHandler(this.Billing_CheckedChanged);
            // 
            // rdoCreditCard
            // 
            this.rdoCreditCard.AutoSize = true;
            this.rdoCreditCard.Checked = true;
            this.rdoCreditCard.Location = new System.Drawing.Point(84, 32);
            this.rdoCreditCard.Name = "rdoCreditCard";
            this.rdoCreditCard.Size = new System.Drawing.Size(95, 20);
            this.rdoCreditCard.TabIndex = 0;
            this.rdoCreditCard.TabStop = true;
            this.rdoCreditCard.Text = "Credit Card";
            this.rdoCreditCard.UseVisualStyleBackColor = true;
            this.rdoCreditCard.CheckedChanged += new System.EventHandler(this.Billing_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credit Card Type : ";
            // 
            // lstCreditCardType
            // 
            this.lstCreditCardType.FormattingEnabled = true;
            this.lstCreditCardType.ItemHeight = 16;
            this.lstCreditCardType.Location = new System.Drawing.Point(161, 147);
            this.lstCreditCardType.Name = "lstCreditCardType";
            this.lstCreditCardType.Size = new System.Drawing.Size(368, 132);
            this.lstCreditCardType.TabIndex = 0;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(161, 309);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(368, 34);
            this.txtCardNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Card Number : ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expiration Date : ";
            // 
            // cboExpiationMonth
            // 
            this.cboExpiationMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpiationMonth.FormattingEnabled = true;
            this.cboExpiationMonth.Location = new System.Drawing.Point(161, 383);
            this.cboExpiationMonth.Name = "cboExpiationMonth";
            this.cboExpiationMonth.Size = new System.Drawing.Size(167, 24);
            this.cboExpiationMonth.TabIndex = 2;
            this.cboExpiationMonth.SelectedIndexChanged += new System.EventHandler(this.cboExpiationMonth_SelectedIndexChanged);
            // 
            // cboExpiationYear
            // 
            this.cboExpiationYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpiationYear.FormattingEnabled = true;
            this.cboExpiationYear.Location = new System.Drawing.Point(372, 383);
            this.cboExpiationYear.Name = "cboExpiationYear";
            this.cboExpiationYear.Size = new System.Drawing.Size(157, 24);
            this.cboExpiationYear.TabIndex = 3;
            this.cboExpiationYear.SelectedIndexChanged += new System.EventHandler(this.cboExpiationYear_SelectedIndexChanged);
            // 
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Checked = true;
            this.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDefault.Location = new System.Drawing.Point(12, 451);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(196, 20);
            this.chkDefault.TabIndex = 4;
            this.chkDefault.Text = "Set as default billing method";
            this.chkDefault.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(219, 491);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(109, 35);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "&Ok ";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(393, 491);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPayment
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 562);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.cboExpiationYear);
            this.Controls.Add(this.cboExpiationMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lstCreditCardType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPayment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBillCustomer;
        private System.Windows.Forms.RadioButton rdoCreditCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCreditCardType;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboExpiationMonth;
        private System.Windows.Forms.ComboBox cboExpiationYear;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}

