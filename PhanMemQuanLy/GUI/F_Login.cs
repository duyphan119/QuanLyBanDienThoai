using PhanMemQuanLy.GUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhanMemQuanLy
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            new F_Main_Edited(this).Visible = true;
            Visible = false;
        }

        private void picToggleViewPassword_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                picToggleViewPassword.Image = Image.FromFile(@"../../public/img/visibility.png");
            }
            else
            {
                picToggleViewPassword.Image = Image.FromFile(@"../../public/img/view.png");
            }
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
