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
    public partial class ucManufacturer : UserControl
    {
        private const string ADD = "Thêm dữ liệu";
        private const string EDIT = "Sửa dữ liệu";
        private string action = "";
        private DAO_Manufacturer dao_m = new DAO_Manufacturer();
        private List<Manufacturer> manufacturers = new List<Manufacturer>();
        private int lengthID = 3;
        public ucManufacturer()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void ucManufacturer_Load(object sender, EventArgs e)
        {
            dao_m.getAll().ForEach(manufacturer =>
            {
                manufacturers.Add(manufacturer);
                cbId.Items.Add(manufacturer.id);
                addToDGV(manufacturer);
            });
            dgvManufacturer.ClearSelection();
        }

        public void addToDGV(Manufacturer manufacturer)
        {
            dgvManufacturer.Rows.Add(new object[]
            {
                manufacturer.id,
                manufacturer.name
            });
        }
        public void add()
        {
            txtName.Text = "";
            if (action != ADD)
            {
                action = ADD;
                cbId.Text = dao_m.generateID(lengthID);
            }
            else if (action == ADD)
            {
                action = "";
                cbId.Text = "";
            }
            txtName.Enabled = (action == ADD);
            cbId.Enabled = false;
        }
        public void edit()
        {
            txtName.Text = "";
            if (action != EDIT)
            {
                action = EDIT;
            }
            else if (action == EDIT)
            {
                action = "";
            }
            txtName.Enabled = (action == EDIT);
            cbId.Text = "";
            cbId.Enabled = (action == EDIT);
        }
        public void delete()
        {
            for (int i = dgvManufacturer.SelectedRows.Count - 1; i >= 0; i--)
            {
                int index = dgvManufacturer.SelectedRows[i].Index;
                if (index != -1)
                {
                    DialogResult answer = MessageBox.Show(
                        $"Dữ liệu liên quan đến <{dgvManufacturer.Rows[index].Cells[1].Value}> sẽ bị xoá.\nBạn có chắc chắn muốn xoá ?",
                        "Câu hỏi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    );
                    if (answer == DialogResult.Yes)
                    {
                        int index_manufacturer = manufacturers.FindIndex(emp => emp.id == dgvManufacturer.Rows[index].Cells[0].Value.ToString());
                        if (index_manufacturer != -1)
                        {
                            dao_m.deleteOne(manufacturers[index_manufacturer].id);
                            dgvManufacturer.Rows.RemoveAt(index);
                            manufacturers.RemoveAt(index_manufacturer);
                            cbId.Items.RemoveAt(index_manufacturer);
                        }
                    }
                }
            }
            dgvManufacturer.ClearSelection();
        }

        public void AddEmployee(Manufacturer manufacturer)
        {
            dao_m.insertOne(manufacturer);
            cbId.Items.Add(manufacturer.id);
            manufacturers.Add(manufacturer);
            addToDGV(manufacturer);
            cbId.Text = dao_m.generateID(lengthID);
        }
        public void EditEmployee(Manufacturer manufacturer)
        {
            dao_m.updateOne(manufacturer);
            int index = manufacturers.FindIndex(em => em.id == manufacturer.id);
            if (index != -1)
            {
                manufacturers[index] = manufacturer;
            }
            for (int i = 0; i < dgvManufacturer.RowCount; i++)
            {
                if (manufacturer.id == dgvManufacturer.Rows[i].Cells[0].Value.ToString())
                {
                    dgvManufacturer.Rows[i].Cells[1].Value = manufacturer.name;
                    break;
                }
            }
        }

        public string validate()
        {
            string error = "";
            if (cbId.Text == "")
            {
                error += "Chưa chọn mã nhà sản xuất\n";
            }
            if (txtName.Text == "")
            {
                error += "Tên không được để trống\n";
            }
            return error;
        }
        public Manufacturer getData()
        {
            string error = validate();

            if (error == "")
            {
                Manufacturer manufacturer = new Manufacturer();
                manufacturer.name = txtName.Text;
                manufacturer.id = cbId.Text;
                return manufacturer;
            }
            MessageBox.Show(
                error,
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            return null;
        }
        public void refresh()
        {
            txtName.Text = "";
            txtName.Enabled = (false);
            cbId.Text = "";
            cbId.Enabled = false;
            dgvManufacturer.ClearSelection();
        }
        public void save()
        {
            Manufacturer manufacturer = getData();
            if (manufacturer != null)
            {
                if (action == ADD)
                {
                    AddEmployee(manufacturer);
                }
                else if (action == EDIT)
                {
                    EditEmployee(manufacturer);
                }
                txtName.Text = "";
                dgvManufacturer.ClearSelection();
            }
        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (action == EDIT && cbId.Text != "")
            {
                Manufacturer manufacturer = manufacturers.Find(m => m.id == cbId.Text);
                if (manufacturer != null)
                {
                    txtName.Text = manufacturer.name;
                }
            }
        }
    }
}
