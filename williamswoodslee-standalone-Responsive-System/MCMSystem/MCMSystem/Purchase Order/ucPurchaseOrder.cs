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
    public partial class ucPurchaseOrder : UserControl
    {
        private static ucPurchaseOrder newInstance;

        private CommonController ccNew = CommonController.Instance;

        public static ucPurchaseOrder newOreder
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucPurchaseOrder();
                }
                return newInstance;
            }
        }
        public ucPurchaseOrder()
        {
            InitializeComponent();
        }

        private void ucOrder_Load(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnAddNewOrder, btnOrderView);
            ccNew.changePanelView(pnlOrder, ucPurchaseOrderReg.newOrder);
        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnAddNewOrder, btnOrderView);
            ccNew.changePanelView(pnlOrder, ucPurchaseOrderReg.newOrder);
        }

        private void btnOrderView_Click(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnOrderView, btnAddNewOrder);
            ccNew.changePanelView(pnlOrder, ucPurchaseOrderView.newOrderView);
        }
    }
}
