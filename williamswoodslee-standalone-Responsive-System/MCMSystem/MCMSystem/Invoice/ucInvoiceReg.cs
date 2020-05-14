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
    public partial class ucInvoiceReg : UserControl
    {
        private static ucInvoiceReg newInstance;
        private CommonController ccNew;

        public static ucInvoiceReg newInvoiceReg
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucInvoiceReg();
                }
                return newInstance;
            }
        }
        public ucInvoiceReg()
        {
            InitializeComponent();
            this.ccNew = CommonController.Instance;
        }
    }
}
