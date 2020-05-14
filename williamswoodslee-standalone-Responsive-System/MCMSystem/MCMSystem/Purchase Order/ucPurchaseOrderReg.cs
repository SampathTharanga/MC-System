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
        private static ucPurchaseOrderReg newInsatance;

        public static ucPurchaseOrderReg newOrder
        {
            get
            {
                newInsatance = null;
                if (newInsatance == null)
                {
                    newInsatance = new ucPurchaseOrderReg();
                }
                return newInsatance;
            }
        }
        public ucPurchaseOrderReg()
        {
            InitializeComponent();
        }
    }
}
