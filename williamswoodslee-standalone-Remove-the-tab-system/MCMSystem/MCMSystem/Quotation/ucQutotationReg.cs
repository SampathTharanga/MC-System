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
    public partial class ucQutotationReg : UserControl
    {
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucQutotationReg> lazy = new Lazy<ucQutotationReg>(() => new ucQutotationReg());
        public static ucQutotationReg newQuotationReg => lazy.Value;

        public ucQutotationReg()
        {
            InitializeComponent();
        }
    }
}
