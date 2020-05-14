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
    public partial class ucPurchaseOrderView : UserControl
    {
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucPurchaseOrderView> lazy = new Lazy<ucPurchaseOrderView>(() => new ucPurchaseOrderView());
        public static ucPurchaseOrderView newOrderView => lazy.Value;

        public ucPurchaseOrderView()
        {
            InitializeComponent();
        }
    }
}
