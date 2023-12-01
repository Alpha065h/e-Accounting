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
    public partial class CashReceiptsJForm : Form
    {
        public CashReceiptsJForm()
        {
            InitializeComponent();
        }

        private void CashReceiptsJForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
