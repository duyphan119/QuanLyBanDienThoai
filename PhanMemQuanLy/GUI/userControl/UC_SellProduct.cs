﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PhanMemQuanLy.GUI.userControl
{
    public partial class UC_SellProduct : UserControl
    {
        public UC_SellProduct()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void UC_SellProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            new F_ListCardProduct().Visible = true;
        }
    }
}
