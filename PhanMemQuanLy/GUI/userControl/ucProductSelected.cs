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
        private DAO_Invoice dao_i = new DAO_Invoice();
        private ucCardProduct card;
        public ucProductSelected()
        {
            InitializeComponent();
        }
        public ucProductSelected(F_SelectProduct f, string id, OrderDetail od)
        {
            InitializeComponent();
            Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
            preComponent = f;
            orderDetail = od;
            lblInfo.Text = $"{od.product.name} - {od.product.memorySpace} - {od.product.color}";
            pictureBox1.Image = Image.FromFile(od.product.image);
            if (dao_i.getById(id) == null)
            {
                numQuantity.Maximum = dao_p.getQuantity(orderDetail.product.id);
            }
            else
            {
                numQuantity.Maximum = orderDetail.quantity + dao_p.getQuantity(orderDetail.product.id);
            }
            numQuantity.Value = orderDetail.quantity;
            lblPrice.Text = $"{orderDetail.product.price.ToString("#,##")}đ";
            txtPrice.Text = $"{orderDetail.getTotal().ToString("#,##")}đ";
        }
        public void capNhatSoLuong(int newQuantity)
        {
            if(newQuantity <= numQuantity.Maximum)
            {
                int step = newQuantity - orderDetail.quantity;
                orderDetail.quantity = newQuantity;
                decimal total = orderDetail.getTotal();
                numQuantity.Value = newQuantity;
                txtPrice.Text = $"{((total == 0) ? "0" : total.ToString("#,##"))}đ";
                preComponent.capNhatTongTien(this, orderDetail);
                if(card != null)
                {
                    preComponent.updateCard(card, orderDetail, step);
                }
            }
            else
            {
                numQuantity.Value = orderDetail.quantity;
                MessageBox.Show("Sản phẩm đã hết, không được thêm tiếp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getCard(ucCardProduct c)
        {
            card = c;
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
