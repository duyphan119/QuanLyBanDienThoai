using PhanMemQuanLy.DAO;
using PhanMemQuanLy.GUI.userControl;
using PhanMemQuanLy.objects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PhanMemQuanLy.GUI
{
    public partial class F_SelectProduct : Form
    {
        private ucInvoice preComponent;
        private DAO_Product dao_p = new DAO_Product();
        private DAO_GroupProduct dao_g = new DAO_GroupProduct();
        private List<Product> products = new List<Product>();
        private List<GroupProduct> groups = new List<GroupProduct>();
        private DAO_Invoice dao_i = new DAO_Invoice();
        private DAO_OrderDetail dao_od = new DAO_OrderDetail();
        private List<ucProductSelected> listProductSelected = new List<ucProductSelected>();
        private List<string> productNames = new List<string>();
        private List<OrderDetail> orderDetails = new List<OrderDetail>();
        public F_SelectProduct(ucInvoice f, List<OrderDetail> od)
        {
            InitializeComponent();
            preComponent = f;
            orderDetails = od;
        }

        private void F_SelectProduct_Load(object sender, EventArgs e)
        {
            dao_g.getAll().ForEach(group =>
            {
                cbGroup.Items.Add(group.name);
                groups.Add(group);
            });
            fpnlCardProduct.Controls.Clear();
            dao_p.getAll().ForEach(product =>
            {
                if (!productNames.Contains(product.name))
                {
                    productNames.Add(product.name);
                    fpnlCardProduct.Controls.Add(new UC_CardProduct(this, product.name));
                }
                products.Add(product);
            });
            fpnlCardProductSelected.Controls.Clear();
            orderDetails.ForEach(orderDetail =>
            {
                listProductSelected.Add(new ucProductSelected(this, orderDetail) { 
                    Name = $"CardProductSelected{fpnlCardProductSelected.Controls.Count}"
                });
                fpnlCardProductSelected.Controls.Add(listProductSelected[listProductSelected.Count - 1]);
            });
        }

        public void selectProduct(OrderDetail orderDetail)
        {
            int index = orderDetails.FindIndex(od => od.product.id == orderDetail.product.id);
            if (index != -1)
            {
                orderDetails[index].quantity += orderDetail.quantity;
                listProductSelected[index].capNhatSoLuong(orderDetails[index].quantity);
            }
            else
            {
                orderDetails.Add(orderDetail);
                listProductSelected.Add(new ucProductSelected(this, orderDetail)
                {
                    Name = $"CardProductSelected{fpnlCardProductSelected.Controls.Count}"
                });
                fpnlCardProductSelected.Controls.Add(listProductSelected[listProductSelected.Count - 1]);
            }
            decimal totalPrice = 0;
            orderDetails.ForEach(od =>
            {
                totalPrice += od.getTotal();
            });
            txtTotalAll.Text = $"{(totalPrice == 0 ? "0" : totalPrice.ToString("#,##"))}đ";
        }

        public void removeProduct(OrderDetail orderDetail)
        {
            int index = orderDetails.FindIndex(od => od.product.id == orderDetail.product.id);
            if (index != -1)
            {
                orderDetails.RemoveAt(index);
                listProductSelected.RemoveAt(index);
                fpnlCardProductSelected.Controls.RemoveAt(index);
            }
            decimal totalPrice = 0;
            orderDetails.ForEach(od =>
            {
                totalPrice += od.getTotal();
            });
            txtTotalAll.Text = $"{(totalPrice == 0 ? "0" : totalPrice.ToString("#,##"))}đ";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            preComponent.getListOrderDetail(orderDetails);
        }
        public void capNhatTongTien(OrderDetail orderDetail)
        {
            decimal totalPrice = 0;
            orderDetails.ForEach(od =>
            {
                if(od.product.id == orderDetail.product.id)
                {
                    od = orderDetail;
                }
                totalPrice += od.getTotal();
            });
            txtTotalAll.Text = $"{(totalPrice == 0 ? "0" : totalPrice.ToString("#,##"))}đ";
        }
        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbGroup.Text != "")
            {
                GroupProduct g = groups.Find(group => group.name == cbGroup.Text);
                if (g != null)
                {
                    products.Clear();
                    productNames.Clear();
                    fpnlCardProduct.Controls.Clear();
                    dao_p.getByGroup(g.id).ForEach(product =>
                    {
                        if (!productNames.Contains(product.name))
                        {
                            fpnlCardProduct.Controls.Add(new UC_CardProduct(this, product.name));
                        }
                        products.Add(product);
                    });
                }
            }
        }

        private void cbGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
