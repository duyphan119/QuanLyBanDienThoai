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
    public partial class UC_CardProduct : UserControl
    {
        private F_SelectProduct preComponent;
        private Product product = new Product();
        public UC_CardProduct()
        {
            InitializeComponent();
        }
        public UC_CardProduct(F_SelectProduct f, Product p)
        {
            InitializeComponent();
            preComponent = f;
            product = p;
            lblName.Text = product.name;
            product.details.ForEach(detail =>
            {
                if (!cbSpace.Items.Contains(detail.memorySpace))
                {
                    cbSpace.Items.Add(detail.memorySpace);
                }
                if (!cbColor.Items.Contains(detail.color))
                {
                    cbColor.Items.Add(detail.color);
                }
            });
            cbSpace.SelectedIndex = cbColor.SelectedIndex = 0;
            lblPrice.Text = $"{product.details[0].price.ToString("#,##")}đ";
            picture.Image = Image.FromFile(product.images[0]);
        }
        
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.detail = product.details.Find(detail => detail.memorySpace == cbSpace.Text && detail.color == cbColor.Text);
            orderDetail.quantity = 1;
            if (orderDetail.detail != null)
            {
                preComponent.selectProduct(orderDetail);
            }
        }

        private void cbSpace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSpace.SelectedIndex != -1)
            {
                cbColor.Items.Clear();
                product.details.FindAll(detail => detail.memorySpace == cbSpace.Text).ForEach(de =>
                  {
                      if (!cbColor.Items.Contains(de.color))
                      {
                          cbColor.Items.Add(de.color);
                      }
                  });
            }
            if(cbSpace.Text != "" && cbColor.Text != "")
            {
                ProductDetail det = product.details.Find(d => d.memorySpace == cbSpace.Text && d.color == cbColor.Text);
                if (det != null)
                {
                    lblPrice.Text = $"{det.price.ToString("#,##")}đ";
                }
            }
        }

        private void UC_CardProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSpace.Text != "" && cbColor.Text != "")
            {
                ProductDetail det = product.details.Find(d => d.memorySpace == cbSpace.Text && d.color == cbColor.Text);
                if (det != null)
                {
                    lblPrice.Text = $"{det.price.ToString("#,##")}đ";
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
