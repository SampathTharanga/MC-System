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
    public partial class ucInvoiceView : UserControl
    {
        private static ucInvoiceView newInstance;
        private CommonController ccNew;

        public static ucInvoiceView newInvoiceView
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucInvoiceView();
                }
                return newInstance;
            }
        }
        public ucInvoiceView()
        {
            InitializeComponent();
            this.ccNew = CommonController.Instance;
        }
    }
}
