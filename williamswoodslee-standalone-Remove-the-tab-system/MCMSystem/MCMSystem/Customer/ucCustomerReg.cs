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
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucCustomerReg> lazy = new Lazy<ucCustomerReg>(() => new ucCustomerReg());
        public static ucCustomerReg newCustomerReg => lazy.Value;

        public ucCustomerReg()
        {
            InitializeComponent();
        }

        private void ucCustomerReg_Load(object sender, EventArgs e)
        {

        }
    }
}
