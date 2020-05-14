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
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucDeliveryNoteReg> lazy = new Lazy<ucDeliveryNoteReg>(() => new ucDeliveryNoteReg());
        public static ucDeliveryNoteReg newDeliveryNoteReg => lazy.Value;

        public ucDeliveryNoteReg()
        {
            InitializeComponent();
        }
    }
}
