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
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucVehicleRegView> lazy = new Lazy<ucVehicleRegView>(() => new ucVehicleRegView());
        public static ucVehicleRegView newVehicelRegView => lazy.Value;

        public ucVehicleRegView()
        {
            InitializeComponent();
        }
    }
}
