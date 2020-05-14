using MCMSystem.Quotation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem
{
    public partial class FormHome : Form
    {
        private CommonController ObjCommonCon = CommonController.Instance;
        public FormHome()
        {
            InitializeComponent();
            //CHANGE COLOR OF MENUSTRIP
            menuStrip_Main.Renderer = new ToolStripProfessionalRenderer(new MainMenuColorTable());
            //AUTOMATICALLY OPEN SUBMENU AFTER THE MOUSE HOVER
            AutoExpanSubmenuMouseHover();
        }



        #region MENU ITEMS CODE SECTION
        //AUTOMATICALLY OPEN SUBMENU AFTER THE MOUSE HOVER
        public void AutoExpanSubmenuMouseHover()
        {
            this.menuStrip_Main.Items.OfType<ToolStripMenuItem>().ToList().ForEach(x =>
            {
                x.MouseHover += (obj, arg) => ((ToolStripDropDownItem)obj).ShowDropDown();
            });
        }

        //MENU ITEMS DISPLAY STYLE CHANGE WITH EXPAND
        public void ExpandMenuItemsDisplayStyleChange()
        {
            List<ToolStripMenuItem> allItems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem toolItem in menuStrip_Main.Items)
            {
                allItems.Add(toolItem);
                toolItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        //MENU ITEMS DISPLAY STYLE CHANGE WITH CONTRACT
        public void ContractdMenuItemsDisplayStyleChange()
        {
            List<ToolStripMenuItem> allItems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem toolItem in menuStrip_Main.Items)
            {
                allItems.Add(toolItem);
                toolItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            }
        }
        #endregion

        //SLIDE MENU EXPAND
        private void pbxExpan_Click(object sender, EventArgs e)
        {
            if (pnlLeftSlideMenu.Width == 190)
                tmrContract.Start();
            else if (pnlLeftSlideMenu.Width == 50)
                tmrExpand.Start();
        }

        private void tmrExpand_Tick(object sender, EventArgs e)
        {
            //CALL THE SLIDE MENU EXPAND METHOD
            SlideMenuExpand();
        }

        private void tmrContract_Tick(object sender, EventArgs e)
        {
            //CALL THE SLIDE MENU CONTRACT METHOD
            SlideMenuContract();
        }

        #region EXPAND AND CONTRACT METHO SECTION
        //SLIDE MENU EXPAND METHOD
        void SlideMenuExpand()
        {
            pbxUserOnline.Visible = false;
            pnlLeftSlideMenu.Width += 10;
            pbxProfile.Width = pbxProfile.Height += 1;
            if (pnlLeftSlideMenu.Width == 190)
            {
                tmrExpand.Stop();
                pbxUserOnline.Visible = true;
            }
            menuStrip_Main.Width += 10;
            pbxProfile.Location = new Point(12, 68);
            pbxUserOnline.Location = new Point(52, 104);
            ExpandMenuItemsDisplayStyleChange(); //MENUNN ITEMS DISPLAY STYLE CHANGE
        }

        //SLIDE MENU CONTRACT METHOD
        void SlideMenuContract()
        {
            pbxUserOnline.Visible = false;
            pnlLeftSlideMenu.Width -= 10;
            pbxProfile.Width = pbxProfile.Height -= 1;
            if (pnlLeftSlideMenu.Width == 50)
            {
                tmrContract.Stop();
                pbxUserOnline.Visible = true;
            }
            menuStrip_Main.Width -= 10;
            pbxProfile.Location = new Point(7, 68);
            pbxUserOnline.Location = new Point(38, 92);
            ContractdMenuItemsDisplayStyleChange(); //MENUNN ITEMS DISPLAY STYLE CHANGE
        }
        #endregion

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //APPLICATION EXIT
            Application.Exit();
        }

        private void pbxExit_Click(object sender, EventArgs e)
        {
            //APPLICATION EXIT
            Application.Exit();
        }

        private void pbxMinimize_Click(object sender, EventArgs e)
        {
            //APPLICATION MINIMIZED
            this.WindowState = FormWindowState.Minimized;
        }

        //newCC.changePanelView(pnlMainContainer, ucQuotation.newQuotation);

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void newInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            ObjCommonCon.changePanelView(pnlMainContainer, ucQuotation.newQuotation);
        }
    }

    #region CHANGE COLOR THE MENU STRIP
    //CHANGE COLOR OF MENUSTRIP
    /*
     * RGB Colors:
                    Dark       - 46,57,75 
                    Light      - 55, 68, 90 
                    Very Light - 121,137,163
    */
    public class MainMenuColorTable : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return Color.FromArgb(46, 57, 75);
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Color.FromArgb(46, 57, 75);
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Color.FromArgb(46, 57, 75);
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Color.FromArgb(46, 57, 75);
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return Color.FromArgb(121, 137, 163);//ok 
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Color.FromArgb(55, 68, 90);//ok
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return Color.FromArgb(55, 68, 90); //ok
            }
        }

        public override Color MenuStripGradientBegin
        {
            get
            {
                return Color.Blue;
            }
        }

        public override Color MenuStripGradientEnd
        {
            get
            {
                return Color.Blue;
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return Color.FromArgb(55, 68, 90);//ok
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return Color.FromArgb(55, 68, 90);//ok
            }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.FromArgb(121, 137, 163);//ok
            }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return Color.FromArgb(121, 137, 163);//ok
            }
        }
    }

    #endregion
}
