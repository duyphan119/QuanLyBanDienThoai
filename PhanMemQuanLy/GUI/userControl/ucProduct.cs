using PhanMemQuanLy.DAO;
using PhanMemQuanLy.objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PhanMemQuanLy.GUI.userControl
{
    public partial class ucProduct : UserControl
    {
        private const string ADD = "Thêm dữ liệu";
        private const string EDIT = "Sửa dữ liệu";
        private string action = "";
        private DAO_Product dao_p = new DAO_Product();
        private DAO_GroupProduct dao_g = new DAO_GroupProduct();
        private List<GroupProduct> groups = new List<GroupProduct>();
        private List<Product> products = new List<Product>();
        private int lengthID = 7;
        private string pathImageDefault = @"..\..\public\img\iphone-x.png";
        private string pathImage = "";
        public ucProduct()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        public void reset()
        {
            txtName.Text = "";
            cbColor.Text = "";
            cbMemorySpace.Text = "";
            numQuantity.Value = 0;
            numPrice.Value = 0;
            pictureProduct.Image = null;
            pathImage = "";
        }
        public void add()
        {
            reset();
            if (action != ADD)
            {
                action = ADD;
                cbId.Text = dao_p.generateID(lengthID);
            }
            else if (action == ADD)
            {
                action = "";
                cbId.Text = "";
            }
            setEnabled(action == ADD);
            cbId.Enabled = false;
        }
        public void setEnabled(bool status)
        {
            cbGroup.Enabled = status;
            txtName.Enabled = status;
            btnSelectImage.Enabled = status;
            cbColor.Enabled = status;
            cbMemorySpace.Enabled = status;
            numPrice.Enabled = status;
            numQuantity.Enabled = status;
        }
        public void edit()
        {
            reset();
            if (action != EDIT)
            {
                action = EDIT;
            }
            else if (action == EDIT)
            {
                action = "";
            }
            setEnabled(action == EDIT);
            cbId.Enabled = (action == EDIT);
            cbId.Text = "";
        }
        public void delete()
        {
            for (int i = dgvProduct.SelectedRows.Count - 1; i >= 0; i--)
            {
                int index = dgvProduct.SelectedRows[i].Index;
                if (index != -1)
                {
                    DialogResult answer = MessageBox.Show(
                        $"Dữ liệu liên quan đến <{dgvProduct.Rows[index].Cells[1].Value}> sẽ bị xoá.\nBạn có chắc chắn muốn xoá ?",
                        "Câu hỏi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    );
                    if (answer == DialogResult.Yes)
                    {
                        int index_product = products.FindIndex(employee => employee.id == dgvProduct.Rows[index].Cells[0].Value.ToString());
                        if (index_product != -1)
                        {
                            dao_p.deleteOne(products[index_product].id);
                            dgvProduct.Rows.RemoveAt(index);
                            products.RemoveAt(index_product);
                            cbId.Items.RemoveAt(index_product);
                        }
                    }
                }
            }
            dgvProduct.ClearSelection();
        }
        public void refresh()
        {
            reset();
            setEnabled(false);
            cbId.Text = "";
            cbId.Enabled = false;
            cbId.Items.Clear();
            groups = new List<GroupProduct>();
            products = new List<Product>();
            dgvProduct.Rows.Clear();
            formLoad();
        }


        public string validate()
        {
            string error = "";
            if(cbId.Text == "")
            {
                error += "Chưa chọn mã sản phẩm\n";
            }
            if(cbGroup.Text == "")
            {
                error += "Chưa chọn nhãn hiệu\n";
            }
            if(txtName.Text == "")
            {
                error += "Tên không được bỏ trống\n";
            }
            if (cbColor.Text == "")
            {
                error += "Chưa chọn nhãn hiệu\n";
            }
            if (cbMemorySpace.Text == "")
            {
                error += "Chưa chọn nhãn hiệu\n";
            }
            if (numQuantity.Value == 0)
            {
                error += "Số lượng > 0\n";
            }
            if (numPrice.Value == 0)
            {
                error += "Giá bán > 0\n";
            }
            if (pathImage == "")
            {
                pathImage = pathImageDefault;
            }
            return error;
        }
        public void AddProduct(Product product)
        {
            dao_p.insertOne(product);
            cbId.Items.Add(product.id);
            products.Add(product);
            addToDGV(product);
            cbId.Text = dao_p.generateID(lengthID);
        }
        public void EditProduct(Product product)
        {
            dao_p.updateOne(product);
            for (int i = 0; i < dgvProduct.RowCount; i++)
            {
                if (product.id == dgvProduct.Rows[i].Cells[0].Value.ToString())
                {
                    dgvProduct.Rows[i].Cells[1].Value = product.name;
                    dgvProduct.Rows[i].Cells[2].Value = product.group.name;
                    dgvProduct.Rows[i].Cells[3].Value = product.color;
                    dgvProduct.Rows[i].Cells[4].Value = product.memorySpace;
                    dgvProduct.Rows[i].Cells[5].Value = product.quantity;
                    dgvProduct.Rows[i].Cells[6].Value = product.price.ToString("#,##");
                    break;
                }
            }
            int index = products.FindIndex(p => p.id == product.id);
            if (index != -1)
            {
                products[index] = product;
            }
        }
        public Product getData()
        {
            string error = validate();
            if (error == "")
            {
                return new Product()
                {
                    id = cbId.Text,
                    group = groups.Find(group => group.name == cbGroup.Text),
                    name = txtName.Text,
                    color = cbColor.Text,
                    memorySpace = cbMemorySpace.Text,
                    quantity = Convert.ToInt32(numQuantity.Value),
                    price = numPrice.Value,
                    image = pathImage
                };
            }
            MessageBox.Show(
                error,
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            return null;

        }
        public void save()
        {
            Product product = getData();
            if (product != null)
            {
                if (action == ADD)
                {
                    AddProduct(product);
                }
                else if (action == EDIT)
                {
                    EditProduct(product);
                }
                reset();
                dgvProduct.ClearSelection();
            }
        }
        public void addToDGV(Product product)
        {
            dgvProduct.Rows.Add(new object[]
            {
                product.id,
                product.name,
                product.group.name,
                product.color,
                product.memorySpace,
                product.quantity,
                product.price.ToString("#,##")
            });
        }

        public void formLoad()
        {
            dao_g.getAll().ForEach(group =>
            {
                groups.Add(group);
                cbGroup.Items.Add(group.name);
            });

            dao_p.getAll().ForEach(product =>
            {
                products.Add(product);
                cbId.Items.Add(product.id);
                addToDGV(product);
            });
            dgvProduct.ClearSelection();
        }
        private void ucProduct_Load(object sender, EventArgs e)
        {
            formLoad();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = $@"..\..\public\img\{Path.GetFileName(openFileDialog.FileName)}";
                    if (!File.Exists(Path.GetFullPath(path)))
                    {
                        File.Copy(openFileDialog.FileName, Path.GetFullPath(path));
                    }
                    pictureProduct.Image = Image.FromFile(path);
                    pathImage = path;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("File không hợp lệ");
                }
            }
        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbId.Text != "")
            {
                Product pro = products.Find(product => product.id == cbId.Text);
                if(pro != null)
                {
                    try
                    {
                        cbGroup.Text = pro.group.name;
                        txtName.Text = pro.name;
                        cbColor.Text = pro.color;
                        cbMemorySpace.Text = pro.memorySpace;
                        numQuantity.Value = pro.quantity;
                        numPrice.Value = pro.price;
                        pictureProduct.Image = Image.FromFile(pro.image);
                        pathImage = pro.image;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbGroup.Text != "")
            {
                GroupProduct g = groups.Find(group=>group.name == cbGroup.Text);
                if (g != null)
                {
                    string id = cbId.Text;
                    cbId.Items.Clear();
                    dao_p.getByGroup(g.id).ForEach(product =>
                    {
                        cbId.Items.Add(product.id);
                    });
                    cbId.Text = id;
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //productEditing.name = txtName.Text;
        }

        private void cbId_TextChanged(object sender, EventArgs e)
        {
            //productEditing.id = cbId.Text;
        }

        private void cbGroup_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
