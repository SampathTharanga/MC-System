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
    public partial class ucPaymentReg : UserControl
    {
        private static ucPaymentReg newInstance;
        private CommonController ccNew;

        public static ucPaymentReg newPaymentReg
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucPaymentReg();
                }
                return newInstance;
            }
        }
        public ucPaymentReg()
        {
            InitializeComponent();
            this.ccNew = CommonController.Instance;
        }
    }
}
