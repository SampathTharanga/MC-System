using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem.Home
{
    public partial class ucHome : UserControl
    {
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucHome> lazy = new Lazy<ucHome>(() => new ucHome());
        public static ucHome home = lazy.Value;

        public ucHome()
        {
            InitializeComponent();
        }

        //PANEL BORDER COLOR CHANGE
        public void panelBorderColor(PaintEventArgs e)
        {
            Pen panelPen = new Pen(Color.FromArgb(233, 236, 239));
            e.Graphics.DrawRectangle(panelPen,
            e.ClipRectangle.Left,
            e.ClipRectangle.Top,
            e.ClipRectangle.Width - 1,
            e.ClipRectangle.Height - 1);
            base.OnPaint(e);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panelBorderColor(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panelBorderColor(e);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panelBorderColor(e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panelBorderColor(e);
        }
    }
}
