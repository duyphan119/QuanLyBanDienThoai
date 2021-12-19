using PhanMemQuanLy.DAO;
using PhanMemQuanLy.GUI.userControl;
using PhanMemQuanLy.objects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PhanMemQuanLy.GUI
{
    public partial class F_SelectCustomer : Form
    {
        private ucInvoice preComponent;
        private const string ADD = "Thêm dữ liệu";
        private string action = "";
        private DAO_Customer dao_c = new DAO_Customer();
        private List<Customer> customers = new List<Customer>();
        private int lengthID = 8;
        public F_SelectCustomer(ucInvoice f)
        {
            InitializeComponent();
            preComponent = f;
            dao_c.getAll().ForEach(customer =>
            {
                dgvCustomer.Rows.Add(new object[]
                {
                    customer.id,
                    customer.name,
                    customer.address,
                    customer.phone
                });
            });
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int index = dgvCustomer.SelectedRows[0].Index;
            if(index != -1)
            {
                Customer cust = new Customer()
                {
                    id = dgvCustomer.Rows[index].Cells[0].Value.ToString(),
                    name = dgvCustomer.Rows[index].Cells[1].Value.ToString(),
                    address = dgvCustomer.Rows[index].Cells[2].Value.ToString(),
                    phone = dgvCustomer.Rows[index].Cells[3].Value.ToString(),
                };
                preComponent.getCustomer(cust);
            }
        }

        private void F_SelectCustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            reset();
            if (action != ADD)
            {
                action = ADD;
                txtId.Text = dao_c.generateID(lengthID);
            }
            else if (action == ADD)
            {
                action = "";
                txtId.Text = "";
            }
            setEnabled(action == ADD);
            txtId.Enabled = false;
        }

        public void reset()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }

        public string validate()
        {
            string error = "";
            if (txtId.Text == "")
            {
                error += "Chưa chọn mã khách hàng\n";
            }
            if (txtName.Text == "")
            {
                error += "Tên không được để trống\n";
            }
            if (txtAddress.Text == "")
            {
                error += "Địa chỉ không được để trống\n";
            }

            try
            {
                decimal phone = Convert.ToDecimal(txtPhone.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                error += "Số điện thoại chứa kí tự không hợp lệ\n";
            }

            if (txtPhone.Text.Length < 10)
            {
                error += "Số điện thoại chỉ có 10 số\n";
            }
            return error;
        }
        public Customer getData()
        {
            string error = validate();

            if (error == "")
            {
                Customer customer = new Customer();
                customer.id = txtId.Text;
                customer.name = txtName.Text;
                customer.address = txtAddress.Text;
                customer.phone = txtPhone.Text;
                return customer;
            }
            MessageBox.Show(
                error,
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            return null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        public void setEnabled(bool status)
        {
            txtName.Enabled = status;
            txtAddress.Enabled = status;
            txtPhone.Enabled = status;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = getData();
            if (customer != null)
            {
                if (action == ADD)
                {
                    dao_c.insertOne(customer);
                    customers.Add(customer);
                    dgvCustomer.Rows.Add(new object[]
                    {
                        customer.id,
                        customer.name,
                        customer.address,
                        customer.phone
                    });
                    txtId.Text = dao_c.generateID(lengthID);
                }
                reset();
            }
        }
    }
}
