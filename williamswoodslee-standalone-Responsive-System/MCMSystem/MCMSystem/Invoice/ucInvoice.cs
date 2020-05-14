using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem.Invoice
{
    public partial class ucInvoice : UserControl
    {
        private static ucInvoice newInstance;
        private CommonController ccNew;

        public static ucInvoice newInvoice
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucInvoice();
                }
                return newInstance;
            }
        }
        public ucInvoice()
        {
            InitializeComponent();
            this.ccNew = CommonController.Instance;
        }

        private void ucInvoice_Load(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnAddNewInvoice, btnViewInvoice);
            ccNew.changePanelView(pnlInvoice, ucInvoiceReg.newInvoiceReg);
        }

        private void btnAddNewInvoice_Click(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnAddNewInvoice, btnViewInvoice);
            ccNew.changePanelView(pnlInvoice, ucInvoiceReg.newInvoiceReg);
        }

        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnViewInvoice, btnAddNewInvoice);
            ccNew.changePanelView(pnlInvoice, ucInvoiceView.newInvoiceView);
        }
    }
}
