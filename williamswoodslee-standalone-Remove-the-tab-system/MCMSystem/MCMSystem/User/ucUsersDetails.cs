using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem.User
{
    public partial class ucUsersDetails : UserControl
    {
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucUsersDetails> lazy = new Lazy<ucUsersDetails>(() => new ucUsersDetails());
        public static ucUsersDetails usersDetails = lazy.Value;

        public ucUsersDetails()
        {
            InitializeComponent();
        }
    }
}
