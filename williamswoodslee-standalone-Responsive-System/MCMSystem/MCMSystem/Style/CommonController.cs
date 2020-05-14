using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace MCMSystem
{
    class CommonController
    {
        private static CommonController instance;
        private static readonly object padlock = new object();

        Color unSelectedBtnColor = ColorTranslator.FromHtml("#ff8000");

        public static CommonController Instance {
            get
            {
                lock (padlock)
                {
                    if(instance == null)
                    {
                        instance = new CommonController();
                    }
                    return instance;
                }
            }
        }

        // to change the color of buttons that selected ones and nons
        public void changeButtonColor(Button selectBtn, Button unselectedBtn1)
        {
            selectBtn.BackColor = Color.White;
            selectBtn.ForeColor = Color.Black;
            unselectedBtn1.BackColor = unSelectedBtnColor;
            unselectedBtn1.ForeColor = Color.White;
        }

        // to load panel for each request
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
