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
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucCustomerView> lazy = new Lazy<ucCustomerView>(() => new ucCustomerView());
        public static ucCustomerView newCustomerView => lazy.Value;

        public ucCustomerView()
        {
            InitializeComponent();
        }
    }
}
