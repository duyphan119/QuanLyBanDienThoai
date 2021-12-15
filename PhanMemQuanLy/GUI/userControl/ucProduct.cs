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
        private F_ProductDetail fProductDetail;
        private const string ADD = "Thêm dữ liệu";
        private const string EDIT = "Sửa dữ liệu";
        private string action = "";
        private DAO_Product dao_p = new DAO_Product();
        private DAO_GroupProduct dao_g = new DAO_GroupProduct();
        private List<GroupProduct> groups = new List<GroupProduct>();
        private List<Product> products = new List<Product>();
        private List<PictureBox> pictures = new List<PictureBox>();
        private Product productEditing = new Product();
        private int lengthID = 7;
        public ucProduct()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void btnProductDetail_Click(object sender, EventArgs e)
        {
            if (productEditing.id != "")
            {
                fProductDetail = new F_ProductDetail(this, productEditing);
                fProductDetail.Visible = true;
            }
            else
            {
                MessageBox.Show(
                    "Chưa chọn mã sản phẩm",
                    "Lưu ý",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        public void reset()
        {
            txtName.Text = "";
            pictures.Clear();
            //fpnlImages.Controls.Clear();
        }
        public void add()
        {
            reset();
            if (action != ADD)
            {
                action = ADD;
                cbId.Text = dao_p.generateID(lengthID);
                productEditing.id = cbId.Text;
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
            btnProductDetail.Enabled = status;
            btnSelectImage.Enabled = status;
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
            btnProductDetail.Enabled = false;
            groups = new List<GroupProduct>();
            products = new List<Product>();
            pictures = new List<PictureBox>();
            productEditing = new Product();
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
                    dgvProduct.Rows[i].Cells[3].Value = product.details.Count;
                    break;
                }
            }
        }

        public void getListProductDetail(List<ProductDetail> details)
        {
            productEditing.details = details;
        }
        public Product getData()
        {
            string error = validate();
            if (error == "")
            {
                return new Product()
                {
                    id = productEditing.id,
                    group = productEditing.group,
                    name = productEditing.name,
                    images = productEditing.images,
                    details = productEditing.details
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
                product.details.Count
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog.FileNames.Length > 0)
                    {
                        productEditing.images.Clear();
                        pictures.Clear();
                        //fpnlImages.Controls.Clear();
                        foreach (string file in openFileDialog.FileNames)
                        {
                            string path = $@"..\..\public\img\{Path.GetFileName(file)}";
                            if (!File.Exists(Path.GetFullPath(path)))
                            {
                                File.Copy(file, Path.GetFullPath(path));
                            }
                            pictures.Add(new PictureBox()
                            {
                                Name = $"picture{pictures.Count}",
                                Image = Image.FromFile(file),
                                Size = new Size(120, 120),
                                SizeMode = PictureBoxSizeMode.Zoom,
                                BackColor = Color.White
                            });
                            //fpnlImages.Controls.Add(pictures[pictures.Count - 1]);
                            pictures[pictures.Count - 1].Click += new EventHandler(removeImage);
                            productEditing.images.Add(path);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("file ko hop le");
                }
            }
        }

        private void removeImage(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            int index = pictures.FindIndex(picture => picture.Name == pic.Name);
            if (index != -1)
            {
                //fpnlImages.Controls.Remove(pic);
                pictures.RemoveAt(index);
                productEditing.images.RemoveAt(index);
            }
        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbId.Text != "")
            {
                productEditing.id = cbId.Text;
                Product pro = products.Find(product => product.id == cbId.Text);
                if(pro != null)
                {
                    txtName.Text = pro.name;
                    cbGroup.Text = pro.group.name;
                    productEditing.name = pro.name;
                    productEditing.group = pro.group;
                    productEditing.images = pro.images;
                    productEditing.details = pro.details;
                    pictures.Clear();
                    //fpnlImages.Controls.Clear();
                    pro.images.ForEach(image =>
                    {
                        pictures.Add(new PictureBox()
                        {
                            Name = $"picture{pictures.Count}",
                            Image = Image.FromFile(image),
                            Size = new Size(120, 120),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            BackColor = Color.White
                        });
                        //fpnlImages.Controls.Add(pictures[pictures.Count - 1]);
                        pictures[pictures.Count - 1].Click += new EventHandler(removeImage);
                    });
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
                    productEditing.group = g;
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
            productEditing.name = txtName.Text;
        }

        private void cbId_TextChanged(object sender, EventArgs e)
        {
            productEditing.id = cbId.Text;
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
