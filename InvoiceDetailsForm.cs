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
    public partial class InvoiceDetailsForm : Form
    {
        public InvoiceDetailsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblOrNum_Click(object sender, EventArgs e)
        {

        }

        private void lblPaidTo_Click(object sender, EventArgs e)
        {

        }

        private void txtbPtRf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblRef_Click(object sender, EventArgs e)
        {

        }

        private void lblDorC_Click(object sender, EventArgs e)
        {

        }

        private void cmbParticular_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedString = cmbParticular.SelectedItem.ToString();  
            if (selectedString == "Current Assets")
            {
                List<string> itemList = new List<string> {"Cash","Cash in bank","Short Term Investment","Accounts Receivable","Other Receivables",
                 "Office Supplies", "Allowance for Doubtful Accounts", "Merchandise", "Inventory", "Raw Materials Inventory", "Work in Progress Inventory",
                 "Finished Goods Inventory", "Prepaid Expenses", "Employee Advances", "Notes Receivable- Current", "Prepaid Interest", "Fund", "Sales",
                 "Other Current Assets"};
                cmbParticular1.Items.AddRange(itemList.ToArray());
            }
            else if (selectedString == "Non-Current Assests")
            {
                List<string> itemlist = new List<string> { };
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
