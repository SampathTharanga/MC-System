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
    public partial class ucProjectView : UserControl
    {
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucProjectView> lazy = new Lazy<ucProjectView>(() => new ucProjectView());
        public static ucProjectView newProjectView => lazy.Value;

        public ucProjectView()
        {
            InitializeComponent();
        }
    }
}
