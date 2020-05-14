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
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucDeliveryNoteView> lazy = new Lazy<ucDeliveryNoteView>(() => new ucDeliveryNoteView());
        public static ucDeliveryNoteView newDeliveryNoteView => lazy.Value;

        public ucDeliveryNoteView()
        {
            InitializeComponent();
        }
    }
}
