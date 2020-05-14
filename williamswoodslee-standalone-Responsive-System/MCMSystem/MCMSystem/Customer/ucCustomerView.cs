using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem.Customer
{
    public partial class ucCustomerView : UserControl
    {
        private static ucCustomerView newInstance;

        public static ucCustomerView newCustomerView
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucCustomerView();
                }
                return newInstance;
            }
        }
        public ucCustomerView()
        {
            InitializeComponent();
        }
    }
}
