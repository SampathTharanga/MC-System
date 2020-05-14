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
    public partial class ucQutotationReg : UserControl
    {
        private static ucQutotationReg newInstance;
        private CommonController ccNew;

        public static ucQutotationReg newQuotationReg
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucQutotationReg();
                }
                return newInstance;
            }
        }
        public ucQutotationReg()
        {
            InitializeComponent();
            this.ccNew = CommonController.Instance;
        }
    }
}
