namespace e_Accounting
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.invoiceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashDisbursementsJournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalJournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statementOfFinancialPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statementOfFinancialOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statementOfCashFlowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statementOfChangesInEquityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceDetailsToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.cshToolStripMenuItem,
            this.cashDisbursementsJournalToolStripMenuItem,
            this.generalJournalToolStripMenuItem,
            this.statementOfFinancialPositionToolStripMenuItem,
            this.statementOfFinancialOperationToolStripMenuItem,
            this.statementOfCashFlowsToolStripMenuItem,
            this.statementOfChangesInEquityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1882, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // invoiceDetailsToolStripMenuItem
            // 
            this.invoiceDetailsToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDetailsToolStripMenuItem.Name = "invoiceDetailsToolStripMenuItem";
            this.invoiceDetailsToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.invoiceDetailsToolStripMenuItem.Text = "Invoice Details";
            this.invoiceDetailsToolStripMenuItem.Click += new System.EventHandler(this.invoiceDetailsToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // cshToolStripMenuItem
            // 
            this.cshToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cshToolStripMenuItem.Name = "cshToolStripMenuItem";
            this.cshToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cshToolStripMenuItem.Text = "Cash Receipts Journal";
            this.cshToolStripMenuItem.Click += new System.EventHandler(this.cshToolStripMenuItem_Click);
            // 
            // cashDisbursementsJournalToolStripMenuItem
            // 
            this.cashDisbursementsJournalToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashDisbursementsJournalToolStripMenuItem.Name = "cashDisbursementsJournalToolStripMenuItem";
            this.cashDisbursementsJournalToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cashDisbursementsJournalToolStripMenuItem.Text = "Cash Disbursements Journal";
            this.cashDisbursementsJournalToolStripMenuItem.Click += new System.EventHandler(this.cashDisbursementsJournalToolStripMenuItem_Click);
            // 
            // generalJournalToolStripMenuItem
            // 
            this.generalJournalToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalJournalToolStripMenuItem.Name = "generalJournalToolStripMenuItem";
            this.generalJournalToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.generalJournalToolStripMenuItem.Text = "General Journal";
            this.generalJournalToolStripMenuItem.Click += new System.EventHandler(this.generalJournalToolStripMenuItem_Click);
            // 
            // statementOfFinancialPositionToolStripMenuItem
            // 
            this.statementOfFinancialPositionToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statementOfFinancialPositionToolStripMenuItem.Name = "statementOfFinancialPositionToolStripMenuItem";
            this.statementOfFinancialPositionToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.statementOfFinancialPositionToolStripMenuItem.Text = "Statement of Financial Position";
            // 
            // statementOfFinancialOperationToolStripMenuItem
            // 
            this.statementOfFinancialOperationToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statementOfFinancialOperationToolStripMenuItem.Name = "statementOfFinancialOperationToolStripMenuItem";
            this.statementOfFinancialOperationToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.statementOfFinancialOperationToolStripMenuItem.Text = "Statement of Financial Operation";
            // 
            // statementOfCashFlowsToolStripMenuItem
            // 
            this.statementOfCashFlowsToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statementOfCashFlowsToolStripMenuItem.Name = "statementOfCashFlowsToolStripMenuItem";
            this.statementOfCashFlowsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.statementOfCashFlowsToolStripMenuItem.Text = "Statement of Cash Flows";
            // 
            // statementOfChangesInEquityToolStripMenuItem
            // 
            this.statementOfChangesInEquityToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statementOfChangesInEquityToolStripMenuItem.Name = "statementOfChangesInEquityToolStripMenuItem";
            this.statementOfChangesInEquityToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.statementOfChangesInEquityToolStripMenuItem.Text = "Statement of Changes in Equity";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 930);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "e-ACCOUNTING SYSTEM FOR PEOPLE\'S ORGANIZATION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem invoiceDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashDisbursementsJournalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalJournalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statementOfFinancialPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statementOfFinancialOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statementOfCashFlowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statementOfChangesInEquityToolStripMenuItem;
    }
}

