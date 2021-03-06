﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem
{
    public partial class ucDriverView : UserControl
    {
        //USE SINGLETON PATTERN FOR CREATE INSTANCE
        private static readonly Lazy<ucDriverView> lazy = new Lazy<ucDriverView>(() => new ucDriverView());
        public static ucDriverView newDriverViewInstance => lazy.Value;

        public ucDriverView()
        {
            InitializeComponent();
        }

        private void ucDriverView_Load(object sender, EventArgs e)
        {
            //this.Dock = DockStyle.Fill;
        }
    }
}
