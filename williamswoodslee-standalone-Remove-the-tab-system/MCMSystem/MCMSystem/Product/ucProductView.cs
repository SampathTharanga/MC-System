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
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucProductView> lazy = new Lazy<ucProductView>(() => new ucProductView());
        public static ucProductView newProductView => lazy.Value;

        public ucProductView()
        {
            InitializeComponent();
        }
    }
}
