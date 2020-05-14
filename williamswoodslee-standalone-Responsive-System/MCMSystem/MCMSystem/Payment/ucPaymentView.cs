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
    public partial class ucPaymentView : UserControl
    {
        private static ucPaymentView newInstance;
        private CommonController ccNew;

        public static ucPaymentView newPaymentView
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucPaymentView();
                }
                return newInstance;
            }
        }
        public ucPaymentView()
        {
            InitializeComponent();
            this.ccNew = CommonController.Instance;
        }
    }
}
