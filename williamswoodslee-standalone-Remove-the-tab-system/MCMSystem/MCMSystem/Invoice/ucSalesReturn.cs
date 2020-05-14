using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem.Invoice
{
    public partial class ucSalesReturn : UserControl
    {
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucSalesReturn> lazy = new Lazy<ucSalesReturn>(() => new ucSalesReturn());
        public static ucSalesReturn newSalesReturen => lazy.Value;

        public ucSalesReturn()
        {
            InitializeComponent();
        }

        private void btnSalesReturn_Click(object sender, EventArgs e)
        {
            FormSalesReturnAgreement frmSalesReturn = new FormSalesReturnAgreement();
            frmSalesReturn.ShowDialog();
        }
    }
}
