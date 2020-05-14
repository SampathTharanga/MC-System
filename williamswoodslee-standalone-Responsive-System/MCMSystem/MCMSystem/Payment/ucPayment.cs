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
    public partial class ucPayment : UserControl
    {
        private static ucPayment newInstance;
        private CommonController ccNew;

        public static ucPayment newPayments
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucPayment();
                }
                return newInstance;
            }
        }
        public ucPayment()
        {
            InitializeComponent();
            this.ccNew = CommonController.Instance;
        }

        private void ucPayment_Load(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnAddNewPayment, btnPaymentView);
            ccNew.changePanelView(pnlPayment, ucPaymentReg.newPaymentReg);
        }

        private void btnAddNewPayment_Click(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnAddNewPayment, btnPaymentView);
            ccNew.changePanelView(pnlPayment, ucPaymentReg.newPaymentReg);
        }

        private void btnPaymentView_Click(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnPaymentView, btnAddNewPayment);
            ccNew.changePanelView(pnlPayment, ucPaymentView.newPaymentView);
        }
    }
}
