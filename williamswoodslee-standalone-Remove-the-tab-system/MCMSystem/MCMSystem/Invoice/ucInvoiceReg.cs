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
    public partial class ucInvoiceReg : UserControl
    {
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucInvoiceReg> lazy = new Lazy<ucInvoiceReg>(() => new ucInvoiceReg());
        public static ucInvoiceReg newInvoiceReg => lazy.Value;

        public ucInvoiceReg()
        {
            InitializeComponent();
        }
    }
}
