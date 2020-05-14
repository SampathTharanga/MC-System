using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem.Order
{
    public partial class ucPurchaseOrderReg : UserControl
    {
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucPurchaseOrderReg> lazy = new Lazy<ucPurchaseOrderReg>(() => new ucPurchaseOrderReg());
        public static ucPurchaseOrderReg newOrder => lazy.Value;

        public ucPurchaseOrderReg()
        {
            InitializeComponent();
        }
    }
}
