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
        private static ucProjectView newInstance;

        public static ucProjectView newProjectView
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucProjectView();
                }
                return newInstance;
            }
        }
        public ucProjectView()
        {
            InitializeComponent();
        }
    }
}
