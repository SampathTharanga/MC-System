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
    public partial class ucDeliveryNoteReg : UserControl
    {
        private static ucDeliveryNoteReg newInstance;
        private CommonController ccNew;

        public static ucDeliveryNoteReg newDeliveryNoteReg
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucDeliveryNoteReg();
                }
                return newInstance;
            }
        }
        public ucDeliveryNoteReg()
        {
            InitializeComponent();
        }
    }
}
