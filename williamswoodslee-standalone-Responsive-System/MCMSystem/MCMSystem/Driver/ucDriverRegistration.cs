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
    public partial class ucDriverRegistration : UserControl
    {
        private static ucDriverRegistration NewInstance;

        public static ucDriverRegistration NewDriverInstance
        {
            get
            {
                NewInstance = null;
                if(NewInstance == null)
                {
                    NewInstance = new ucDriverRegistration();
                }
                return NewInstance;
            }
        }
        public ucDriverRegistration()
        {
            InitializeComponent();
        }

        private void ucDriverRegistration_Load(object sender, EventArgs e)
        {
            //USERCONTROL FILL THE SIZE OF IT'S CONTAINER
            this.Dock = DockStyle.Fill;
        }
    }
}
