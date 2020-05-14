using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem.Product
{
    public partial class ucProduct : UserControl
    {
        private static ucProduct newInstance;
        private CommonController ccNew;
        public static ucProduct newProduct
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucProduct();
                }
                return newInstance;
            }
        }
        public ucProduct()
        {
            InitializeComponent();
            this.ccNew = CommonController.Instance;
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnAddNewProduct, btnViewProduct);
            ccNew.changePanelView(pnlProduct, ucProductReg.newProductReg);
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnAddNewProduct, btnViewProduct);
            ccNew.changePanelView(pnlProduct, ucProductReg.newProductReg);
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnViewProduct, btnAddNewProduct);
            ccNew.changePanelView(pnlProduct, ucProductView.newProductView);
        }
    }
}
