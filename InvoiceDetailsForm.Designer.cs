namespace e_Accounting
{
    partial class InvoiceDetailsForm
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblParticulars = new System.Windows.Forms.Label();
            this.lblOrNum = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtbDate = new System.Windows.Forms.TextBox();
            this.txtbOR = new System.Windows.Forms.TextBox();
            this.txtbDesc = new System.Windows.Forms.TextBox();
            this.txtbAmount = new System.Windows.Forms.TextBox();
            this.lblPtRf = new System.Windows.Forms.Label();
            this.txtbPtRf = new System.Windows.Forms.TextBox();
            this.lblRef = new System.Windows.Forms.Label();
            this.txtbRef = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.cmbParticular = new System.Windows.Forms.ComboBox();
            this.cmbParticular1 = new System.Windows.Forms.ComboBox();
            this.cmbCorCb = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(32, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(87, 26);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // lblParticulars
            // 
            this.lblParticulars.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticulars.Location = new System.Drawing.Point(35, 79);
            this.lblParticulars.Name = "lblParticulars";
            this.lblParticulars.Size = new System.Drawing.Size(109, 27);
            this.lblParticulars.TabIndex = 1;
            this.lblParticulars.Text = "Particulars";
            this.lblParticulars.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblOrNum
            // 
            this.lblOrNum.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrNum.Location = new System.Drawing.Point(32, 240);
            this.lblOrNum.Name = "lblOrNum";
            this.lblOrNum.Size = new System.Drawing.Size(269, 25);
            this.lblOrNum.TabIndex = 2;
            this.lblOrNum.Text = "Official Receipt Numbers";
            this.lblOrNum.Click += new System.EventHandler(this.lblOrNum_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(35, 298);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(127, 25);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Description";
            this.lblDesc.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(35, 389);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(127, 25);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount";
            this.lblAmount.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtbDate
            // 
            this.txtbDate.Location = new System.Drawing.Point(307, 27);
            this.txtbDate.Multiline = true;
            this.txtbDate.Name = "txtbDate";
            this.txtbDate.Size = new System.Drawing.Size(229, 34);
            this.txtbDate.TabIndex = 6;
            // 
            // txtbOR
            // 
            this.txtbOR.Location = new System.Drawing.Point(309, 240);
            this.txtbOR.Multiline = true;
            this.txtbOR.Name = "txtbOR";
            this.txtbOR.Size = new System.Drawing.Size(229, 37);
            this.txtbOR.TabIndex = 8;
            // 
            // txtbDesc
            // 
            this.txtbDesc.Location = new System.Drawing.Point(309, 298);
            this.txtbDesc.Multiline = true;
            this.txtbDesc.Name = "txtbDesc";
            this.txtbDesc.Size = new System.Drawing.Size(228, 73);
            this.txtbDesc.TabIndex = 9;
            // 
            // txtbAmount
            // 
            this.txtbAmount.Location = new System.Drawing.Point(308, 389);
            this.txtbAmount.Multiline = true;
            this.txtbAmount.Name = "txtbAmount";
            this.txtbAmount.Size = new System.Drawing.Size(229, 31);
            this.txtbAmount.TabIndex = 10;
            // 
            // lblPtRf
            // 
            this.lblPtRf.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPtRf.Location = new System.Drawing.Point(35, 547);
            this.lblPtRf.Name = "lblPtRf";
            this.lblPtRf.Size = new System.Drawing.Size(216, 25);
            this.lblPtRf.TabIndex = 12;
            this.lblPtRf.Text = "Paid To";
            this.lblPtRf.Visible = false;
            this.lblPtRf.Click += new System.EventHandler(this.lblPaidTo_Click);
            // 
            // txtbPtRf
            // 
            this.txtbPtRf.Location = new System.Drawing.Point(307, 547);
            this.txtbPtRf.Multiline = true;
            this.txtbPtRf.Name = "txtbPtRf";
            this.txtbPtRf.Size = new System.Drawing.Size(229, 31);
            this.txtbPtRf.TabIndex = 13;
            this.txtbPtRf.Visible = false;
            this.txtbPtRf.TextChanged += new System.EventHandler(this.txtbPtRf_TextChanged);
            // 
            // lblRef
            // 
            this.lblRef.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRef.Location = new System.Drawing.Point(35, 446);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(216, 25);
            this.lblRef.TabIndex = 14;
            this.lblRef.Text = "Reference";
            this.lblRef.Click += new System.EventHandler(this.lblRef_Click);
            // 
            // txtbRef
            // 
            this.txtbRef.Location = new System.Drawing.Point(308, 440);
            this.txtbRef.Multiline = true;
            this.txtbRef.Name = "txtbRef";
            this.txtbRef.Size = new System.Drawing.Size(229, 31);
            this.txtbRef.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(592, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 68);
            this.button1.TabIndex = 16;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(35, 496);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(216, 25);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(308, 496);
            this.txtbName.Multiline = true;
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(229, 31);
            this.txtbName.TabIndex = 18;
            this.txtbName.TextChanged += new System.EventHandler(this.txtbName_TextChanged);
            // 
            // cmbParticular
            // 
            this.cmbParticular.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParticular.FormattingEnabled = true;
            this.cmbParticular.ItemHeight = 22;
            this.cmbParticular.Items.AddRange(new object[] {
            "Currents Assets",
            "Non-Current Assets",
            "Current Liabilities",
            "Non-Current Liabilities",
            "Revenue Accounts",
            "Cost of Goods Sold",
            "Expenses",
            "Equity"});
            this.cmbParticular.Location = new System.Drawing.Point(307, 79);
            this.cmbParticular.Name = "cmbParticular";
            this.cmbParticular.Size = new System.Drawing.Size(228, 30);
            this.cmbParticular.TabIndex = 19;
            this.cmbParticular.SelectedIndexChanged += new System.EventHandler(this.cmbParticular_SelectedIndexChanged);
            // 
            // cmbParticular1
            // 
            this.cmbParticular1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParticular1.FormattingEnabled = true;
            this.cmbParticular1.ItemHeight = 22;
            this.cmbParticular1.Location = new System.Drawing.Point(310, 182);
            this.cmbParticular1.Name = "cmbParticular1";
            this.cmbParticular1.Size = new System.Drawing.Size(228, 30);
            this.cmbParticular1.TabIndex = 20;
            // 
            // cmbCorCb
            // 
            this.cmbCorCb.AutoCompleteCustomSource.AddRange(new string[] {
            "Cash",
            "Cash In Bank"});
            this.cmbCorCb.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCorCb.FormattingEnabled = true;
            this.cmbCorCb.ItemHeight = 22;
            this.cmbCorCb.Items.AddRange(new object[] {
            "Cash",
            "Cash In Bank"});
            this.cmbCorCb.Location = new System.Drawing.Point(310, 134);
            this.cmbCorCb.Name = "cmbCorCb";
            this.cmbCorCb.Size = new System.Drawing.Size(228, 30);
            this.cmbCorCb.TabIndex = 21;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(556, 135);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Credit";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(631, 135);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Debit";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(556, 183);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 17);
            this.radioButton3.TabIndex = 24;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Credit";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(631, 183);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(50, 17);
            this.radioButton4.TabIndex = 25;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Debit";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // InvoiceDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 1100);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cmbCorCb);
            this.Controls.Add(this.cmbParticular1);
            this.Controls.Add(this.cmbParticular);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbRef);
            this.Controls.Add(this.lblRef);
            this.Controls.Add(this.txtbPtRf);
            this.Controls.Add(this.lblPtRf);
            this.Controls.Add(this.txtbAmount);
            this.Controls.Add(this.txtbDesc);
            this.Controls.Add(this.txtbOR);
            this.Controls.Add(this.txtbDate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblOrNum);
            this.Controls.Add(this.lblParticulars);
            this.Controls.Add(this.lblDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceDetailsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "InvoiceDetailsForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblParticulars;
        private System.Windows.Forms.Label lblOrNum;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtbDate;
        private System.Windows.Forms.TextBox txtbOR;
        private System.Windows.Forms.TextBox txtbDesc;
        private System.Windows.Forms.TextBox txtbAmount;
        private System.Windows.Forms.Label lblPtRf;
        private System.Windows.Forms.TextBox txtbPtRf;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.TextBox txtbRef;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.ComboBox cmbParticular;
        private System.Windows.Forms.ComboBox cmbParticular1;
        private System.Windows.Forms.ComboBox cmbCorCb;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}