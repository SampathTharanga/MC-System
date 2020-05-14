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
        private static ucProjectReg newInstance;
        private CommonController ccNew;

        public static ucProjectReg newProjectReg
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucProjectReg();
                }
                return newInstance;
            }
        }
        public ucProjectReg()
        {
            InitializeComponent();
            this.ccNew = CommonController.Instance;
        }
    }
}
