using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem.Project
{
    public partial class ucProjectReg : UserControl
    {
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucProjectReg> lazy = new Lazy<ucProjectReg>(() => new ucProjectReg());
        public static ucProjectReg newProjectReg => lazy.Value;

        public ucProjectReg()
        {
            InitializeComponent();
        }
    }
}
