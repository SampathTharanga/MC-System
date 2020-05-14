using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem.Product
{
    public partial class ucProductReg : UserControl
    {
        private static ucProductReg newInstance;
        private CommonController ccNew;

        public static ucProductReg newProductReg
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucProductReg();
                }
                return newInstance;
            }
        }
        public ucProductReg()
        {
            InitializeComponent();
            this.ccNew = CommonController.Instance;
        }
    }
}
