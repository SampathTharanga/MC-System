using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem.DeliveryNote
{
    public partial class ucDeliveryNote : UserControl
    {
        private static ucDeliveryNote newInstance;
        private CommonController ccNew;

        public static ucDeliveryNote newDeliveryNote
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucDeliveryNote();
                }
                return newInstance;
            }
        }
        public ucDeliveryNote()
        {
            InitializeComponent();
            this.ccNew = CommonController.Instance;
        }

        private void ucDeliveryNote_Load(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnAddDeliveryNote, btnViewDeliveryNote);
            ccNew.changePanelView(pnlDeliveryNote, ucDeliveryNoteReg.newDeliveryNoteReg);
        }

        private void btnAddDeliveryNote_Click(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnAddDeliveryNote, btnViewDeliveryNote);
            ccNew.changePanelView(pnlDeliveryNote, ucDeliveryNoteReg.newDeliveryNoteReg);
        }

        private void btnViewDeliveryNote_Click(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnViewDeliveryNote, btnAddDeliveryNote);
            ccNew.changePanelView(pnlDeliveryNote, ucDeliveryNoteView.newDeliveryNoteView);
        }
    }
}
