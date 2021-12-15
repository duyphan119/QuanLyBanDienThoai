using PhanMemQuanLy.DAO;
using PhanMemQuanLy.GUI.userControl;
using PhanMemQuanLy.objects;
using PhanMemQuanLy.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PhanMemQuanLy.GUI
{
    public partial class F_ProductDetail : Form
    {
        private const string ADD = "Thêm dữ liệu";
        private const string EDIT = "Sửa dữ liệu";
        private string action = "";
        private ucProduct preComponent;
        private Product productEditing;
        private DAO_ProductDetail dao_pd = new DAO_ProductDetail();
        private int lengthID = 7;
        public F_ProductDetail(ucProduct uc, Product product)
        {
            InitializeComponent();
            preComponent = uc;
            txtProductId.Text = product.id;
            productEditing = product;
        }

        public void addToDGV(ProductDetail detail)
        {
            dgvProductDetail.Rows.Add(new object[]
            {
                detail.id,
                detail.color,
                detail.memorySpace,
                detail.quantity,
                detail.price.ToString("#,##")
            });
        }
        private void F_ProductDetail_Load(object sender, EventArgs e)
        {
            productEditing.details.ForEach(detail =>
            {
                addToDGV(detail);
                cbId.Items.Add(detail.id);
                if (!cbColor.Items.Contains(detail.color))
                {
                    cbColor.Items.Add(detail.color);
                }
            });
            dgvProductDetail.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            reset();
            if (action != ADD)
            {
                action = ADD;
                cbId.Text = generateID();
            }
            else if (action == ADD)
            {
                action = "";
                cbId.Text = "";
            }
            setEnabled(action == ADD);
            cbId.Enabled = false;
        }

        public void reset()
        {
            numQuantity.Value = 0;
            txtPrice.Text = "";
        }

        public void setEnabled(bool status)
        {
            cbColor.Enabled = status;
            cbMemorySpaceValue.Enabled = status; 
            cbMemorySpace.Enabled = status;
            numQuantity.Enabled = status;
            txtPrice.Enabled = status;
        }

        public string validate()
        {
            string error = "";
            if(dao_pd.getById(cbId.Text) == null && action == EDIT)
            {
                error += "Mã chi tiết sản phẩm không hợp lệ";
            }
            if(cbColor.Text == "")
            {
                error += "Chưa chọn màu";
            }
            if(cbMemorySpaceValue.Text == "" || cbMemorySpace.Text == "")
            {
                error += "Chưa chọn dung lượng bộ nhớ trong";
            }
            try
            {
                decimal price = Convert.ToDecimal(txtPrice.Text);
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                error += "Giá bán không hợp lệ";
            }
            return error;
        }

        public ProductDetail getData()
        {
            string error = validate();

            if(error == "")
            {
                ProductDetail detail = new ProductDetail();
                detail.id = cbId.Text;
                detail.color = cbColor.Text;
                detail.memorySpace = cbMemorySpaceValue.Text + cbMemorySpace.Text;
                detail.quantity = Convert.ToInt32(numQuantity.Value);
                detail.price = Convert.ToDecimal(txtPrice.Text);
                return detail;
            }
            MessageBox.Show(
                error,
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            return null;
        }
        public void AddDetail(ProductDetail detail)
        {
            productEditing.details.Add(detail);
            cbId.Items.Add(detail.id);
            cbId.Text = generateID();
            addToDGV(detail);
            preComponent.getListProductDetail(productEditing.details);
            dgvProductDetail.ClearSelection();
        }
        public void EditDetail(ProductDetail detail)
        {
            dao_pd.updateOne(productEditing.id, detail);
            int index = productEditing.details.FindIndex(item => item.id == detail.id);
            productEditing.details[index] = detail;
            for(int i = 0; i < dgvProductDetail.RowCount; i++)
            {
                if(dgvProductDetail.Rows[i].Cells[0].Value.ToString() == detail.id)
                {
                    dgvProductDetail.Rows[i].Cells[2].Value = detail.color;
                    dgvProductDetail.Rows[i].Cells[3].Value = detail.memorySpace;
                    dgvProductDetail.Rows[i].Cells[4].Value = detail.quantity;
                    dgvProductDetail.Rows[i].Cells[5].Value = detail.price.ToString("#,##");
                    break;
                }
            }
        }
        public string generateID()
        {
            string result = "";
            MyMethods myMethods = new MyMethods();
            int i = 1;
            string id = myMethods.addZeros(lengthID, i);
            while (true)
            {
                if (dao_pd.getById(id) == null)
                {
                    result = id;
                    break;
                }
                else
                {
                    id = myMethods.addZeros(lengthID, ++i);
                }
            }

            while (true)
            {
                if (productEditing.details.Find(detail=>detail.id == id) == null)
                {
                    result = id;
                    break;
                }
                else
                {
                    id = myMethods.addZeros(lengthID, ++i);
                }
            }

            return result;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ProductDetail detail = getData();
            if(detail != null)
            {
                if(action == ADD)
                {
                    AddDetail(detail);
                }
                if(action == EDIT)
                {
                    EditDetail(detail);
                }
                if (!cbColor.Items.Contains(detail.color))
                {
                    cbColor.Items.Add(detail.color);
                }
                reset();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            reset();
            if (action == "")
            {
                action = EDIT;
            }
            else if (action == EDIT)
            {
                action = "";
                cbId.Text = "";
            }
            setEnabled(action == EDIT);
            cbId.Enabled = (action == EDIT);
        }

        private void F_ProductDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        public void setData(ProductDetail detail)
        {
            int index = 0;
            for(int i = 0; i < detail.memorySpace.Length; i++)
            {
                if (!char.IsDigit(detail.memorySpace[i]))
                {
                    index = i;
                    break;
                }
            }
            cbMemorySpaceValue.Text = detail.memorySpace.Substring(0, index);
            cbMemorySpace.Text = detail.memorySpace.Substring(index);
            cbColor.Text = detail.color;
            numQuantity.Value = detail.quantity;
            txtPrice.Text = detail.price.ToString();
        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbId.Text != "")
            {
                ProductDetail detail = productEditing.details.Find(item => item.id == cbId.Text);
                if(detail != null)
                {
                    setData(detail);
                }
            }
        }

        private void cbId_TextChanged(object sender, EventArgs e)
        {
            if (cbId.Text != "")
            {
                ProductDetail detail = productEditing.details.Find(item => item.id == cbId.Text);
                if (detail != null)
                {
                    setData(detail);
                }
            }
            else
            {
                reset();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = dgvProductDetail.SelectedRows.Count - 1; i >= 0; i--)
            {
                int index = dgvProductDetail.SelectedRows[i].Index;
                if (index != -1)
                {
                    DialogResult answer = MessageBox.Show(
                        $"Dữ liệu liên quan đến <{dgvProductDetail.Rows[index].Cells[0].Value}> sẽ bị xoá.\nBạn có chắc chắn muốn xoá ?",
                        "Câu hỏi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    );
                    if (answer == DialogResult.Yes)
                    {
                        int index_detail = productEditing.details.FindIndex(detail => detail.id == dgvProductDetail.Rows[index].Cells[0].Value.ToString());
                        if (index_detail != -1)
                        {
                            dao_pd.deleteOne(productEditing.details[index_detail].id);
                            dgvProductDetail.Rows.RemoveAt(index);
                            productEditing.details.RemoveAt(index_detail);
                            cbId.Items.RemoveAt(index_detail);
                        }
                    }
                }
            }
            dgvProductDetail.ClearSelection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
