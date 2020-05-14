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
    public partial class ucProductView : UserControl
    {
        private static ucProductView newInstance;
        private CommonController ccNew;

        public static ucProductView newProductView
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucProductView();
                }
                return newInstance;
            }
        }
        public ucProductView()
        {
            InitializeComponent();
            this.ccNew = CommonController.Instance;
        }
    }
}
