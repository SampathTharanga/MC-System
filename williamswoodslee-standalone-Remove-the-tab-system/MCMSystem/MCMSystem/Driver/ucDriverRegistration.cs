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
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucDriverRegistration> lazy = new Lazy<ucDriverRegistration>(() => new ucDriverRegistration());
        public static ucDriverRegistration NewDriverInstance => lazy.Value;

        public ucDriverRegistration()
        {
            InitializeComponent();
        }

        private void ucDriverRegistration_Load(object sender, EventArgs e)
        {
            //USERCONTROL FILL THE SIZE OF IT'S CONTAINER
            //this.Dock = DockStyle.Fill;
        }
    }
}
