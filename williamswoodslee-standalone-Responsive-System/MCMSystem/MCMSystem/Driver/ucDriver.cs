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
    public partial class ucDriver : UserControl
    {
        private static ucDriver NewDriver_instance;
        private CommonController newCC = CommonController.Instance;
        
        public static ucDriver newDriver
        {
            get{
                NewDriver_instance = null;
                if (NewDriver_instance == null)
                {
                    NewDriver_instance = new ucDriver();
                }
                return NewDriver_instance;
            }
        }

        public ucDriver()
        {
            InitializeComponent();
        }


        private void btnDriverReg_Click(object sender, EventArgs e)
        {
            newCC.changeButtonColor(btnDriverReg, btnDriverView);

            pnlDriver.Controls.Clear();
            if (!pnlDriver.Controls.Contains(ucDriverRegistration.NewDriverInstance))
            {
                pnlDriver.Controls.Add(ucDriverRegistration.NewDriverInstance);
                ucDriverRegistration.NewDriverInstance.Dock = DockStyle.Fill;
                ucDriverRegistration.NewDriverInstance.BringToFront();
            }
        }

        private void btnDriverView_Click(object sender, EventArgs e)
        {
            newCC.changeButtonColor(btnDriverView, btnDriverReg);

            pnlDriver.Controls.Clear();
            if (!pnlDriver.Controls.Contains(ucDriverView.newDriverViewInstance))
            {
                pnlDriver.Controls.Add(ucDriverView.newDriverViewInstance);
                ucDriverView.newDriverViewInstance.Dock = DockStyle.Fill;
                ucDriverView.newDriverViewInstance.BringToFront();
            }

        }

        private void ucDriver_Load(object sender, EventArgs e)
        {
            pnlDriver.Controls.Clear();
            if (!pnlDriver.Controls.Contains(ucDriverRegistration.NewDriverInstance))
            {
                pnlDriver.Controls.Add(ucDriverRegistration.NewDriverInstance);
                ucDriverRegistration.NewDriverInstance.Dock = DockStyle.Fill;
                ucDriverRegistration.NewDriverInstance.BringToFront();
            }
        }
    }
}
