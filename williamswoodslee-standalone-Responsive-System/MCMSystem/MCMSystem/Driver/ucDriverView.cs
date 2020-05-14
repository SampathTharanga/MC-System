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
    public partial class ucDriverView : UserControl
    {
        private static ucDriverView driverViewInstance;

        public static ucDriverView newDriverViewInstance
        {
            get
            {
                driverViewInstance = null;
                if (driverViewInstance == null)
                {
                    driverViewInstance = new ucDriverView();
                }
                return driverViewInstance;
            }
        }
        public ucDriverView()
        {
            InitializeComponent();
        }

        private void ucDriverView_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
