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
        private DAO_Manufacturer dao_g = new DAO_Manufacturer();
        private List<Product> products = new List<Product>();
        private List<Manufacturer> groups = new List<Manufacturer>();
        private List<ucCardProduct> cards = new List<ucCardProduct>();
        private List<ucProductSelected> listProductSelected = new List<ucProductSelected>();
        private List<string> productNames = new List<string>();
        private List<OrderDetail> orderDetails = new List<OrderDetail>();
        private string id = "";
        private string action = "";
        private bool submit = false;
        public F_SelectProduct(ucInvoice f, string ac, string invoiceID, List<OrderDetail> od)
        {
            InitializeComponent();
            preComponent = f;
            orderDetails = od;
            id = invoiceID;
            action = ac;
        }

        private void F_SelectProduct_Load(object sender, EventArgs e)
        {
            dao_g.getAll().ForEach(group =>
            {
                cbGroup.Items.Add(group.name);
                groups.Add(group);
            });
            cbGroup.SelectedIndex = 0;
            fpnlCardProductSelected.Controls.Clear();
            orderDetails.ForEach(orderDetail =>
            {
                if(orderDetail.quantity > 0)
                {
                    listProductSelected.Add(new ucProductSelected(this, id, orderDetail)
                    {
                        Name = $"CardProductSelected{fpnlCardProductSelected.Controls.Count}"
                    });
                    fpnlCardProductSelected.Controls.Add(listProductSelected[listProductSelected.Count - 1]);
                }
            });
        }

        public void selectProduct(ucCardProduct card, OrderDetail orderDetail)
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
                listProductSelected.Add(new ucProductSelected(this, id, orderDetail)
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
            cards.Find(card => card.getName() == orderDetail.product.name).updateQuantity(orderDetail, -orderDetail.quantity);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            submit = true;
            preComponent.getListOrderDetail(orderDetails);
            preComponent.finishSelectProduct();
            Close();
        }
        public void capNhatTongTien(ucProductSelected productSelected, OrderDetail orderDetail)
        {
            //Cập nhật số lượng
            //Cập nhật tổng tiền
            decimal totalPrice = 0;
            orderDetails.ForEach(od =>
            {
                if(od.product.id == orderDetail.product.id)
                {
                    od = orderDetail;
                    ucCardProduct _card = cards.Find(card => card.getName() == orderDetail.product.name);
                    if(_card != null)
                    {
                        productSelected.getCard(_card);
                    }
                }
                totalPrice += od.getTotal();
            });
            txtTotalAll.Text = $"{(totalPrice == 0 ? "0" : totalPrice.ToString("#,##"))}đ";
        }

        public void updateCard(ucCardProduct card, OrderDetail orderDetail, int step)
        {
            card.updateQuantity(orderDetail, step);
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbGroup.Text != "")
            {
                Manufacturer g = groups.Find(group => group.name == cbGroup.Text);
                if (g != null)
                {
                    products.Clear();
                    productNames.Clear();
                    cards.Clear();
                    fpnlCardProduct.Controls.Clear();
                    dao_p.getByGroup(g.id).ForEach(product =>
                    {
                        if (!productNames.Contains(product.name))
                        {
                            cards.Add(new ucCardProduct(this, action, orderDetails, product.name));
                            fpnlCardProduct.Controls.Add(cards[cards.Count - 1]);
                            productNames.Add(product.name);
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

        private void F_SelectProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(submit == false)
            {
                DialogResult answer = MessageBox.Show("Bạn có chắc chắn thoát?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    preComponent.finishSelectProduct();
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
