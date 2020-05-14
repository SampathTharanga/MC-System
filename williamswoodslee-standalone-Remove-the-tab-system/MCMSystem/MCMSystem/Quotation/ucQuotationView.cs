using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem.Quotation
{
    public partial class ucQuotationView : UserControl
    {
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucQuotationView> lazy = new Lazy<ucQuotationView>(() => new ucQuotationView());
        public static ucQuotationView newQuotationView => lazy.Value;

        public ucQuotationView()
        {
            InitializeComponent();
        }
    }
}
