using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Guna.UI2.WinForms;
using PhanMemQuanLy.GUI.user_controll;
using PhanMemQuanLy.GUI.userControl;

namespace PhanMemQuanLy.GUI
{
    public partial class F_Main : Form
    {
        private fLogin preComponent;
        private List<Guna2Button> sideBarItems = new List<Guna2Button>();
        public F_Main(fLogin f)
        {
            InitializeComponent();
            preComponent = f;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }


        private void F_Main_Load(object sender, EventArgs e)
        {
            //get sideBarItems from form
            sideBarItems = Enumerable.Range(1, 5)
                .Select(i => (Guna2Button)fpnlSideBar.Controls["btnSideBarItem" + i.ToString()])
                .ToList();
            //Add eventHandler for btnSideBarItem
            sideBarItems.ForEach(item =>
            {
                item.Click -= new EventHandler(sideBarItemClicked);
                item.Click += new EventHandler(sideBarItemClicked);
            });
            //Mặc định là chọn Trang chủ
            pnlView.Controls.Add(new UC_Home());
            //Hiển thị thông tin tài khoản
            pictureAvatar.Image = Image.FromFile("../../public/img/profile.png");
            //Nữ thì profile-female.png
            lblInfoAccount.Text = "Họ Tên: Phan Khánh Duy\nChức Vụ: Giám Đốc";
            //Set ToolTip
            ToolTip tt = new ToolTip();
            tt.SetToolTip(btnExit, "Thoát");
            tt.SetToolTip(btnRestoreDown, "Phóng to");
            tt.SetToolTip(btnMinimize, "Thu nhỏ");
        }

        private void sideBarItemClicked(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            sideBarItems.ForEach(item =>
            {
                
                if (item.Name == btn.Name)
                {
                    setActiveButton(item, true);
                    item.Image = Image.FromFile(@"../../public/img/house-active.png");
                }
                else
                {
                    setActiveButton(item, false);
                    item.Image = Image.FromFile(@"../../public/img/house.png");
                }
                item.ImageAlign = HorizontalAlignment.Left;
                item.ImageSize = new Size(34, 34);
                item.ImageOffset = new Point(4, 0);
            });
        }

        public void setActiveButton(Guna2Button btn, bool status)
        {
            if(status == true)
            {
                btn.FillColor = Color.White;
                btn.ForeColor = Color.FromArgb(0, 118, 212);
            }
            else
            {
                btn.FillColor = Color.FromArgb(0, 118, 212);
                btn.ForeColor = Color.White;
            }
        }

        private void btnSideBarItem1_Click(object sender, EventArgs e)
        {
            setActiveButton(btnSideBarItem1, true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            preComponent.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
            preComponent.Visible = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            //Gọi form đổi mật khẩu
        }

        private void btnSideBarItem3_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();
            pnlView.Controls.Add(new UC_Employee());
        }

        private void btnSideBarItem2_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();
            pnlView.Controls.Add(new UC_SellProduct());
        }

        private void btnSideBarItem4_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();
            pnlView.Controls.Add(new UC_Product());
        }
    }
}
