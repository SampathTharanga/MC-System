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
    public partial class ucDeliveryNoteView : UserControl
    {
        private static ucDeliveryNoteView newInstance;
        private CommonController ccNew;

        public static ucDeliveryNoteView newDeliveryNoteView
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucDeliveryNoteView();
                }
                return newInstance;
            }
        }
        public ucDeliveryNoteView()
        {
            InitializeComponent();
        }
    }
}
