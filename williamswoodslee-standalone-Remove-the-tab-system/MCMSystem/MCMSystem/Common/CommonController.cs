using System;
using System.Drawing;
using System.Windows.Forms;

namespace MCMSystem
{
    class CommonController
    {
        // TO LOAD PANEL FOR EVERY REQUEST
        public void changePanelView(Panel panel, Control instance)
        {
            panel.Controls.Clear();
            if (!panel.Controls.Contains(instance))
            {
                panel.Controls.Add(instance);
                instance.Dock = DockStyle.Fill;
                instance.BringToFront();
            }
        }
    }
}
