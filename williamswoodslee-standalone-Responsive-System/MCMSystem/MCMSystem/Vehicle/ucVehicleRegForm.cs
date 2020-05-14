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
    public partial class ucVehicleRegForm : UserControl
    {

        private static ucVehicleRegForm vehicleInstance;

        public static ucVehicleRegForm newVehicleReg
        {
            get
            {
                vehicleInstance = null;
                if (vehicleInstance == null)
                {
                    vehicleInstance = new ucVehicleRegForm();
                }
                return vehicleInstance;
            }
        }
        public ucVehicleRegForm()
        {
            InitializeComponent();
        }
    }
}
