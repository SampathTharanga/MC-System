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
    public partial class ucInvoiceView : UserControl
    {
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucInvoiceView> lazy = new Lazy<ucInvoiceView>(() => new ucInvoiceView());
        public static ucInvoiceView newInvoiceView => lazy.Value;

        public ucInvoiceView()
        {
            InitializeComponent();
        }
    }
}
