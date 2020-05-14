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
    public partial class ucQuotation : UserControl
    {
        private static ucQuotation newInstance;
        private CommonController ccNew;
        public static ucQuotation newQuotation
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                    newInstance = new ucQuotation();
                return newInstance;
            }
        }
        public ucQuotation()
        {
            InitializeComponent();
            this.ccNew = CommonController.Instance;
        }

        private void ucQuotation_Load(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnAddNewQuotation, btnViewQuotation);
            ccNew.changePanelView(pnlQuotation, ucQutotationReg.newQuotationReg);
        }

        private void btnAddNewQuotation_Click(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnAddNewQuotation, btnViewQuotation);
            ccNew.changePanelView(pnlQuotation, ucQutotationReg.newQuotationReg);
        }

        private void btnViewQuotation_Click(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnViewQuotation, btnAddNewQuotation);
            ccNew.changePanelView(pnlQuotation, ucQuotationView.newQuotationView);
        }
    }
}
