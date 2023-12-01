using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace e_Accounting
{
    public partial class MainForm : Form
    {
        private InvoiceDetailsForm currentInvoiceDetailsForm;
        private TransactionsForm currentTransactionsForm;
        private CashReceiptsJForm currentCashReceiptsJForm;
        private CashDisbursementsJForm currentCashDisbursementsJForm;
        private GenJournalForm currentGenJournalForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OpenChildForm1(InvoiceDetailsForm childForm)
        {
            foreach (Form openForm in MdiChildren)
            {
                openForm.Close();
            }

            currentInvoiceDetailsForm = childForm;
            currentInvoiceDetailsForm.MdiParent = this;
            currentInvoiceDetailsForm.StartPosition = FormStartPosition.Manual;
            currentInvoiceDetailsForm.Location = new Point(0, 0);
            currentInvoiceDetailsForm.Show();
        }

        private void OpenChildForm2(TransactionsForm childForm)
        {
            foreach (Form openForm in MdiChildren)
            {
                openForm.Close();
            }

            currentTransactionsForm = childForm;
            currentTransactionsForm.MdiParent = this;
            currentTransactionsForm.StartPosition = FormStartPosition.Manual;
            currentTransactionsForm.Location = new Point(0, 0);
            currentTransactionsForm.Show();
        }

        private void OpenChildForm3(CashReceiptsJForm childForm)
        {
            foreach (Form openForm in MdiChildren)
            {
                openForm.Close();
            }

            currentCashReceiptsJForm = childForm;
            currentCashReceiptsJForm.MdiParent = this;
            currentCashReceiptsJForm.StartPosition = FormStartPosition.Manual;  
            currentCashReceiptsJForm.Location = new Point(0, 0);    
            currentCashReceiptsJForm.Show();

        }

        private void OpenChildForm4(CashDisbursementsJForm childForm)
        {
            foreach(Form openForm in MdiChildren)
            {
                openForm.Close();
            }

            currentCashDisbursementsJForm = childForm;
            currentCashDisbursementsJForm.MdiParent = this;
            currentCashDisbursementsJForm.StartPosition=FormStartPosition.Manual;
            currentCashDisbursementsJForm.Location=new Point(0, 0);
            currentCashDisbursementsJForm.Show();
        }
        
        private void OpenChildForm5(GenJournalForm childForm)
        {
            foreach(Form openForm in MdiChildren)
            {
                openForm.Close(); 
            }

            currentGenJournalForm = childForm;
            currentGenJournalForm.MdiParent = this;
            currentGenJournalForm.StartPosition=FormStartPosition.Manual;
            currentGenJournalForm.Location = new Point(0, 0);
            currentGenJournalForm.Show();
        }


        private void invoiceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new InvoiceDetailsForm());
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm2(new TransactionsForm());
        }

        private void cshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm3(new CashReceiptsJForm());
        }

        private void cashDisbursementsJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm4(new CashDisbursementsJForm());
        }

        private void generalJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm5(new GenJournalForm());
        }
    }
}
