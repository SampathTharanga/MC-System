using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem
{
    public partial class ucVehicleRegView : UserControl
    {
        private static ucVehicleRegView newInstance;

        public static ucVehicleRegView newVehicelRegView
        {
            get
            {
                newInstance = null;
                if(newInstance == null)
                {
                    newInstance = new ucVehicleRegView();
                }
                return newInstance;
            }
        }
        public ucVehicleRegView()
        {
            InitializeComponent();
        }
    }
}
