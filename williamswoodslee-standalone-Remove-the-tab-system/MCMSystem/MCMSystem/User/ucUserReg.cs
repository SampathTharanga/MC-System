using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem.User
{
    public partial class ucUserReg : UserControl
    {
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucUserReg> lazy = new Lazy<ucUserReg>(() => new ucUserReg());
        public static ucUserReg userReg = lazy.Value;

        public ucUserReg()
        {
            InitializeComponent();
        }
    }
}
