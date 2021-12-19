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
    public partial class ucCardProduct : UserControl
    {
        private F_SelectProduct preComponent;
        private List<Product> products = new List<Product>();
        private DAO_Product dao_p = new DAO_Product();
        private string name = "";
        public ucCardProduct()
        {
            InitializeComponent();
        }

        public string getName()
        {
            return name;
        }

        public ucCardProduct(F_SelectProduct f, List<OrderDetail> orderDetails, string productName)
        {
            InitializeComponent();
            preComponent = f;
            name = productName;

            dao_p.getByName(productName).ForEach(product =>
            {
                //if (!cbColor.Items.Contains(product.color))
                //{
                //    cbColor.Items.Add(product.color);
                //}
                if (!cbSpace.Items.Contains(product.memorySpace))
                {
                    cbSpace.Items.Add(product.memorySpace);
                }
                int index = orderDetails.FindIndex(ord => ord.product.id == product.id);
                if(index != -1)
                {
                    product.quantity -= orderDetails[index].quantity;
                }
                products.Add(product);
            });
            cbSpace.SelectedIndex = 0;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int index = products.FindIndex(p => p.memorySpace == cbSpace.Text && p.color == cbColor.Text);
            if(index != -1)
            {
                if(products[index].quantity > 1)
                {
                    products[index].quantity -= 1;
                    OrderDetail orderDetail = new OrderDetail()
                    {
                        product = products[index],
                        quantity = 1
                    };
                    preComponent.selectProduct(this, orderDetail);
                }
                else
                {
                    MessageBox.Show("Sản phẩm đã hết", "Lưu Ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void updateQuantity(OrderDetail orderDetail, int step)
        {
            Product product = products.Find(p => p.id == orderDetail.product.id);
            if (product != null)
            {
                product.quantity -= step;
                lblName.Text = $"{product.name} (Còn: {product.quantity})";
            }
        }

        private void cbSpace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSpace.SelectedIndex != -1)
            {
                cbColor.Items.Clear();
                products.FindAll(product => product.memorySpace == cbSpace.Text).ForEach(pro =>
                  {
                      if (!cbColor.Items.Contains(pro.color))
                      {
                          cbColor.Items.Add(pro.color);
                      }
                  });
                cbColor.SelectedIndex = 0;
            }
            if (cbSpace.Text != "" && cbColor.Text != "")
            {
                Product product = products.Find(p => p.memorySpace == cbSpace.Text && p.color == cbColor.Text);
                if (product != null)
                {
                    picture.Image = Image.FromFile(product.image);
                    lblPrice.Text = $"{product.price.ToString("#,##")}đ";
                }
                lblName.Text = $"{product.name} (Còn: {product.quantity})";
            }
        }

        private void UC_CardProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSpace.Text != "" && cbColor.Text != "")
            {
                Product pr = products.Find(p => p.memorySpace == cbSpace.Text && p.color == cbColor.Text);
                if (pr != null)
                {
                    picture.Image = Image.FromFile(pr.image);
                    lblPrice.Text = $"{pr.price.ToString("#,##")}đ";
                    lblName.Text = $"{pr.name} (Còn: {pr.quantity})";
                }
            }
        }

        private void cbColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbSpace_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
