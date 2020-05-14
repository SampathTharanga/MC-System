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
    public partial class ucCustomerReg : UserControl
    {
        private static ucCustomerReg newInstance; // to store instance object
        private Boolean isOnLoad = false; // to check is runs _Load function

        public static ucCustomerReg newCustomerReg
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucCustomerReg();
                }
                return newInstance;
            }
        }

        public ucCustomerReg()
        {
            InitializeComponent();
        }

        private void ucCustomerReg_Load(object sender, EventArgs e)
        {

        }
    }
}
