using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLy
{
    public partial class UC_CardProductSelected : UserControl
    {
        public UC_CardProductSelected()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }

        private void UC_CardProductSelected_Load(object sender, EventArgs e)
        {
            string name = "Iphone X";
            int price = 50000000;
            lblInfoProduct.Text = $"{name}\n{price.ToString("#,##")} VNĐ";
        }
    }
}
