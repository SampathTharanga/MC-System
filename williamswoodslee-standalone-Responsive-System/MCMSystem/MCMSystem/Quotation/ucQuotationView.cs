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
    public partial class ucQuotationView : UserControl
    {
        private static ucQuotationView newInstance;
        private CommonController ccNew;

        public static ucQuotationView newQuotationView
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucQuotationView();
                }
                return newInstance;
            }
        }
        public ucQuotationView()
        {
            InitializeComponent();
            this.ccNew = CommonController.Instance;
        }
    }
}
