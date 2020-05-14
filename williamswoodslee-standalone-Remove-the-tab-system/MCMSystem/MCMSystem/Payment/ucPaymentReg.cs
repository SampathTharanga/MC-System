using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem.Payment
{
    public partial class ucPaymentReg : UserControl
    {
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucPaymentReg> lazy = new Lazy<ucPaymentReg>(() => new ucPaymentReg());
        public static ucPaymentReg newPaymentReg => lazy.Value;

        public ucPaymentReg()
        {
            InitializeComponent();
        }
    }
}
