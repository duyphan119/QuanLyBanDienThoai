using PhanMemQuanLy.DAO;
using PhanMemQuanLy.GUI.userControl;
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
        private Invoice invoice = new Invoice();
        private List<ucProductSelected> listProductSelected = new List<ucProductSelected>();
        public F_SelectProduct(ucInvoice f, string invoiceId)
        {
            InitializeComponent();
            preComponent = f;
            invoice = dao_i.getById(invoiceId);
            if(invoice == null)
            {
                invoice = new Invoice();
            }
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
                fpnlCardProduct.Controls.Add(new UC_CardProduct(this, product));
                products.Add(product);
            });
            fpnlCardProductSelected.Controls.Clear();
            invoice.list.ForEach(orderDetail =>
            {
                listProductSelected.Add(new ucProductSelected(this, orderDetail) { 
                    Name = $"CardProductSelected{fpnlCardProductSelected.Controls.Count}"
                });
                fpnlCardProductSelected.Controls.Add(listProductSelected[listProductSelected.Count - 1]);
            });
        }

        public void selectProduct(OrderDetail orderDetail)
        {
            int index = invoice.list.FindIndex(od => od.detail.id == orderDetail.detail.id);
            if (index != -1)
            {
                invoice.list[index].quantity += orderDetail.quantity;
                listProductSelected[index].capNhatSoLuong(invoice.list[index].quantity);
            }
            else
            {
                invoice.list.Add(orderDetail);
                listProductSelected.Add(new ucProductSelected(this, orderDetail)
                {
                    Name = $"CardProductSelected{fpnlCardProductSelected.Controls.Count}"
                });
                fpnlCardProductSelected.Controls.Add(listProductSelected[listProductSelected.Count - 1]);
            }
            string str = invoice.getTotal() == 0 ? "0" : invoice.getTotal().ToString("#,##");
            txtTotalAll.Text = $"{str}đ";
        }

        public void removeProduct(OrderDetail orderDetail)
        {
            int index = invoice.list.FindIndex(od => od.detail.id == orderDetail.detail.id);
            if(index != -1)
            {
                invoice.list.RemoveAt(index);
                listProductSelected.RemoveAt(index);
                fpnlCardProductSelected.Controls.RemoveAt(index);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            preComponent.getListOrderDetail(invoice.list);
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbGroup.Text != "")
            {
                GroupProduct g = groups.Find(group => group.name == cbGroup.Text);
                if (g != null)
                {
                    products.Clear();
                    fpnlCardProduct.Controls.Clear();
                    dao_p.getByGroup(g.id).ForEach(product =>
                    {
                        fpnlCardProduct.Controls.Add(new UC_CardProduct(this, product));
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
