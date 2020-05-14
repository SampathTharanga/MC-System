using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem.Customer
{
    public partial class ucCustomer : UserControl
    {
        private static ucCustomer newInstance;
        private CommonController ccNew = new CommonController();

        public static ucCustomer newCustomer
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucCustomer();
                }
                return newInstance;
            }
        }

        public ucCustomer()
        {
            InitializeComponent();
        }

        private void ucCustomer_Load(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnAddNewCustomer, btnViewCustomers); // to change button color after clicked
            ccNew.changePanelView(pnlCustomer, ucCustomerReg.newCustomerReg); // to change panel when button add new customer clicked
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnAddNewCustomer, btnViewCustomers); // to change button color after clicked
            ccNew.changePanelView(pnlCustomer, ucCustomerReg.newCustomerReg); // to change panel when button add new customer clicked
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnViewCustomers, btnAddNewCustomer);
            ccNew.changePanelView(pnlCustomer, ucCustomerView.newCustomerView);
        }
    }
}
