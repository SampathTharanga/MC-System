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
    public partial class ucPaymentView : UserControl
    {
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucPaymentView> lazy = new Lazy<ucPaymentView>(() => new ucPaymentView());
        public static ucPaymentView newPaymentView => lazy.Value;

        public ucPaymentView()
        {
            InitializeComponent();
        }
    }
}
