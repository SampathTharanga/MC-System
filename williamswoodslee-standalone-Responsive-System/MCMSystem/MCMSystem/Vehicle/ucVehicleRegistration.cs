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
    public partial class ucVehicleRegistration : UserControl
    {
        private static ucVehicleRegistration newVehicle_instance;
        private CommonController newCC = CommonController.Instance;

        Color unSelectedBtnColor = ColorTranslator.FromHtml("#ff8000");

        // to laod new vehicle registration view
        public static ucVehicleRegistration NewVehicle
        {
            get
            {
                newVehicle_instance = null;
                if (newVehicle_instance == null)
                {
                    newVehicle_instance = new ucVehicleRegistration();
                }
                return newVehicle_instance;
            }
        }

        public ucVehicleRegistration()
        {
            InitializeComponent();
        }


        private void ucVehicleRegistration_Load(object sender, EventArgs e)
        {
            newCC.changePanelView(pnlVehicle, ucVehicleRegForm.newVehicleReg);

        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            newCC.changeButtonColor(btnAddNewVehicle, btnViewVehicles);
            newCC.changePanelView(pnlVehicle, ucVehicleRegForm.newVehicleReg);

        }

        private void btnViewVehicles_Click(object sender, EventArgs e)
        {
            newCC.changeButtonColor(btnViewVehicles, btnAddNewVehicle);
            newCC.changePanelView(pnlVehicle, ucVehicleRegView.newVehicelRegView);
        }
    }
}
