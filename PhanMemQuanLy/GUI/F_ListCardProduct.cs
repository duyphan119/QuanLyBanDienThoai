using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLy.GUI
{
    public partial class F_ListCardProduct : Form
    {
        public F_ListCardProduct()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRestoreDown_Click(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                tt.SetToolTip(btnRestoreDown, "Phóng to");
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                tt.SetToolTip(btnRestoreDown, "Bình thường");
            }
        }

        private void F_ListCardProduct_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(btnExit, "Thoát");
            tt.SetToolTip(btnRestoreDown, "Phóng to");
            tt.SetToolTip(btnMinimize, "Thu nhỏ");
        }
    }
}
