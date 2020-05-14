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
        private static ucPurchaseOrderView newInstance;

        public static ucPurchaseOrderView newOrderView
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucPurchaseOrderView();
                }
                return newInstance;
            }
        }
        public ucPurchaseOrderView()
        {
            InitializeComponent();
        }
    }
}
