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
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucProductReg> lazy = new Lazy<ucProductReg>(() => new ucProductReg());
        public static ucProductReg newProductReg => lazy.Value;

        public ucProductReg()
        {
            InitializeComponent();
        }
    }
}
