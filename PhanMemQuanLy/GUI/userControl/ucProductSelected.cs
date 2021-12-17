using PhanMemQuanLy.DAO;
using PhanMemQuanLy.objects;
using System;
using System.Drawing;
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
            lblInfo.Text = $"{od.product.name} - {od.product.memorySpace} - {od.product.color}";
            pictureBox1.Image = Image.FromFile(od.product.image);
            numQuantity.Value = orderDetail.quantity;
            lblPrice.Text = $"{orderDetail.product.price.ToString("#,##")}đ";
            txtPrice.Text = $"{orderDetail.getTotal().ToString("#,##")}đ";
        }
        public void capNhatSoLuong(int newQuantity)
        {
            orderDetail.quantity = newQuantity;
            numQuantity.Value = orderDetail.quantity;
            decimal total = orderDetail.getTotal();
            txtPrice.Text = $"{((total == 0) ? "0" : total.ToString("#,##"))}đ";
            preComponent.capNhatTongTien(orderDetail);
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
