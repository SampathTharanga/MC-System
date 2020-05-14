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
        // CREATE OBJECTS
        private CommonController ObjCommonCon = new CommonController();

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

        private void FormHome_Load(object sender, EventArgs e)
        {
            //START THE APPLICATION THEN LOAD HOME
            ObjCommonCon.changePanelView(pnlMainContainer, Home.ucHome.home);
            lblPath.Text = "Home";
        }

        private void newInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NEW INVOICE
            ObjCommonCon.changePanelView(pnlMainContainer, Invoice.ucInvoiceReg.newInvoiceReg);
            lblPath.Text = "Invoice / New Invoice";
        }

        private void invoiceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //INVOICE HISTORY
            ObjCommonCon.changePanelView(pnlMainContainer, Invoice.ucInvoiceView.newInvoiceView);
            lblPath.Text = "Invoice / Invoice History";
        }

        private void newDeliveryNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NEW DELIVERY NOTE
            ObjCommonCon.changePanelView(pnlMainContainer, DeliveryNote.ucDeliveryNoteReg.newDeliveryNoteReg);
            lblPath.Text = "Delivery / Delivery Note";
        }

        private void deliveryNoteHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DELIVERY NOTE HISTORY
            ObjCommonCon.changePanelView(pnlMainContainer, DeliveryNote.ucDeliveryNoteView.newDeliveryNoteView);
            lblPath.Text = "Delivery / Delivery History";
        }

        private void newPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NEW PAYMENT
            ObjCommonCon.changePanelView(pnlMainContainer, Payment.ucPaymentReg.newPaymentReg);
            lblPath.Text = "Payment / New Payment";
        }

        private void paymentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PAYMENT HISTORY
            ObjCommonCon.changePanelView(pnlMainContainer, Payment.ucPaymentView.newPaymentView);
            lblPath.Text = "Payment / Payment History";
        }

        private void newQuotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NEW QUOTATIONN
            ObjCommonCon.changePanelView(pnlMainContainer, Quotation.ucQutotationReg.newQuotationReg);
            lblPath.Text = "Quotation / New Quotation";
        }

        private void quotationHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NEW QUOTATIONN
            ObjCommonCon.changePanelView(pnlMainContainer, Quotation.ucQuotationView.newQuotationView);
            lblPath.Text = "Quotation / Quotation History";
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NEW PURCHASE ORDER
            ObjCommonCon.changePanelView(pnlMainContainer, Order.ucPurchaseOrderReg.newOrder);
            lblPath.Text = "Purchase Order / New Purchase Order";
        }

        private void orderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PURCHASE ORDER HISTORY
            ObjCommonCon.changePanelView(pnlMainContainer, Order.ucPurchaseOrderView.newOrderView);
            lblPath.Text = "Purchase Order / Purchase Order History";
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NEW PROJECT
            ObjCommonCon.changePanelView(pnlMainContainer, Project.ucProjectReg.newProjectReg);
            lblPath.Text = "Project / New Project";
        }

        private void projectHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PROJECT HISTORY
            ObjCommonCon.changePanelView(pnlMainContainer, Project.ucProjectView.newProjectView);
            lblPath.Text = "Project / Project History";
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NEW CUSTOMER
            ObjCommonCon.changePanelView(pnlMainContainer, Customer.ucCustomerReg.newCustomerReg);
            lblPath.Text = "Customer / New Customer";
        }

        private void customerHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CUSTOMER HISTORY
            ObjCommonCon.changePanelView(pnlMainContainer, Customer.ucCustomerView.newCustomerView);
            lblPath.Text = "Customer / Customer History";
        }

        private void newVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NEW VEHICLE
            ObjCommonCon.changePanelView(pnlMainContainer, ucVehicleRegForm.newVehicleReg);
            lblPath.Text = "Vehicle / New Vehicle";
        }

        private void vehicleHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VEHICLE HISTORY
            ObjCommonCon.changePanelView(pnlMainContainer, ucVehicleRegView.newVehicelRegView);
            lblPath.Text = "Vehicle / Vehicle History";
        }

        private void newDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NEW DRIVER
            ObjCommonCon.changePanelView(pnlMainContainer, ucDriverRegistration.NewDriverInstance);
            lblPath.Text = "Driver / New Driver";
        }

        private void driverHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DRIVER HISTORY
            ObjCommonCon.changePanelView(pnlMainContainer, ucDriverView.newDriverViewInstance);
            lblPath.Text = "Driver / Driver History";
        }

        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NEW PRODUCT
            ObjCommonCon.changePanelView(pnlMainContainer, Product.ucProductReg.newProductReg);
            lblPath.Text = "Product / New Product";
        }

        private void productHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PRODUCT HISTORY
            ObjCommonCon.changePanelView(pnlMainContainer, Product.ucProductView.newProductView);
            lblPath.Text = "Product / Product History";
        }

        private void salesReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SALES RETURN
            ObjCommonCon.changePanelView(pnlMainContainer, Invoice.ucSalesReturn.newSalesReturen);
            lblPath.Text = "Invoice / Sales Return";
        }

        private void pbxSetting_Click(object sender, EventArgs e)
        {
            contextMenuStrip_Setting.Show(pbxSetting, 0, pbxSetting.Height + 8);
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //HOME
            ObjCommonCon.changePanelView(pnlMainContainer, Home.ucHome.home);
            lblPath.Text = "Home";
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObjCommonCon.changePanelView(pnlMainContainer, User.ucUserReg.userReg);
            lblPath.Text = "User / New User";
        }

        private void userHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObjCommonCon.changePanelView(pnlMainContainer, User.ucUsersDetails.usersDetails);
            lblPath.Text = "User / Users Details";
        }

        private void lblGenesip_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://genesip.com/");
        }

        private void pbxExit_MouseHover(object sender, EventArgs e)
        {
            pbxExit.Image = Properties.Resources.close_white;
        }

        private void pbxExit_MouseLeave(object sender, EventArgs e)
        {
            pbxExit.Image = Properties.Resources.icons8_delete_50;
        }

        private void pbxMinimize_MouseHover(object sender, EventArgs e)
        {
            pbxMinimize.Image = Properties.Resources.minimize_white;
        }

        private void pbxMinimize_MouseLeave(object sender, EventArgs e)
        {
            pbxMinimize.Image = Properties.Resources.minimize;
        }

        private void pbxLogOut_MouseHover(object sender, EventArgs e)
        {
            pbxLogOut.Image = Properties.Resources.logout_white;
        }

        private void pbxLogOut_MouseLeave(object sender, EventArgs e)
        {
            pbxLogOut.Image = Properties.Resources.logout;
        }

        private void pbxSetting_MouseHover(object sender, EventArgs e)
        {
            pbxSetting.Image = Properties.Resources.settings_white;
        }

        private void pbxSetting_MouseLeave(object sender, EventArgs e)
        {
            pbxSetting.Image = Properties.Resources.settings;
        }

        private void pbxNotification_MouseHover(object sender, EventArgs e)
        {
            pbxNotification.Image = Properties.Resources.notification_available_white;
        }

        private void pbxNotification_MouseLeave(object sender, EventArgs e)
        {
            pbxNotification.Image = Properties.Resources.notification;
        }

        private void lblGenesip_MouseHover(object sender, EventArgs e)
        {
            lblGenesip.ForeColor = Color.Black;
        }

        private void lblGenesip_MouseLeave(object sender, EventArgs e)
        {
            lblGenesip.ForeColor = Color.White;
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
