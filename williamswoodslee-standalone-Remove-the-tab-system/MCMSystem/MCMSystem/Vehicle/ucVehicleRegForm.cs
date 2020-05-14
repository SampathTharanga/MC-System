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
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        public static readonly Lazy<ucVehicleRegForm> lazy = new Lazy<ucVehicleRegForm>(() => new ucVehicleRegForm());
        public static ucVehicleRegForm newVehicleReg => lazy.Value;

        public ucVehicleRegForm()
        {
            InitializeComponent();
        }
    }
}
