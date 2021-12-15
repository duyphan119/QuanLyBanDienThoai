using PhanMemQuanLy.DAO;
using PhanMemQuanLy.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLy.GUI.userControl
{
    public partial class ucProductSelected : UserControl
    {
        private F_SelectProduct preComponent;
        private OrderDetail orderDetail = new OrderDetail();
        private DAO_Product dao_p = new DAO_Product();
        public ucProductSelected()
        {
            InitializeComponent();
        }
        public ucProductSelected(F_SelectProduct f, OrderDetail od)
        {
            InitializeComponent();
            Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
            preComponent = f;
            orderDetail = od;
            Product product = dao_p.getByDetail(orderDetail.detail.id);
            if (product != null)
            {
                lblInfo.Text = $"{dao_p.getByDetail(orderDetail.detail.id).name} - {orderDetail.detail.memorySpace} - {orderDetail.detail.color}";
                if(product.images.Count > 0)
                {
                    pictureBox1.Image = Image.FromFile(product.images[0]);
                }
            }
            lblPrice.Text = $"{orderDetail.detail.price.ToString("#,##")}đ";
            numQuantity.Value = orderDetail.quantity;
            txtPrice.Text = $"{orderDetail.getTotal().ToString("#,##")}đ";
        }
        public void capNhatSoLuong(int newQuantity)
        {
            orderDetail.quantity = newQuantity;
            numQuantity.Value = orderDetail.quantity;
            decimal total = orderDetail.getTotal();
            string str = (total == 0) ? "0" : total.ToString("#,##");
            txtPrice.Text = $"{str}đ";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            preComponent.removeProduct(orderDetail);
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            capNhatSoLuong(Convert.ToInt32(numQuantity.Value));
        }

        private void ucProductSelected_Load(object sender, EventArgs e)
        {
            
        }
    }
}
