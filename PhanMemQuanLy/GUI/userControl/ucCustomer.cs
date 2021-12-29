using PhanMemQuanLy.objects;
using PhanMemQuanLy.DAO;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace PhanMemQuanLy.GUI.userControl
{
    public partial class ucCustomer : UserControl
    {
        private const string ADD = "Thêm dữ liệu";
        private const string EDIT = "Sửa dữ liệu";
        private string action = "";
        private DAO_Customer dao_c = new DAO_Customer();
        private List<Customer> customers = new List<Customer>();
        private int lengthID = 8;
        public ucCustomer()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            cbFilter.SelectedIndex = 0;
        }
        public void add()
        {
            reset();
            if (action != ADD)
            {
                action = ADD;
                cbId.Text = dao_c.generateID(lengthID);
            }
            else if (action == ADD)
            {
                action = "";
                cbId.Text = "";
            }
            setEnabled(action == ADD);
            cbId.Enabled = false;
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
                cbId.Text = "";
            }
            setEnabled(action == EDIT);
            cbId.Enabled = (action == EDIT);
        }
        public void save()
        {
            Customer customer = getData();
            if (customer != null)
            {
                if (action == ADD)
                {
                    AddCustomer(customer);
                }
                else if (action == EDIT)
                {
                    EditCustomer(customer);
                }
                reset();
                
            }
        }
        public void refresh()
        {
            reset();
            setEnabled(false);
            cbId.Text = "";
            cbId.Enabled = false;
            
        }
        public void delete()
        {
            for (int i = dgvCustomer.SelectedRows.Count - 1; i >= 0; i--)
            {
                int index = dgvCustomer.SelectedRows[i].Index;
                if (index != -1)
                {
                    DialogResult answer = MessageBox.Show(
                        $"Dữ liệu liên quan đến <{dgvCustomer.Rows[index].Cells[1].Value}> sẽ bị xoá.\nBạn có chắc chắn muốn xoá ?",
                        "Câu hỏi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    );
                    if (answer == DialogResult.Yes)
                    {
                        int index_employee = customers.FindIndex(employee => employee.id == dgvCustomer.Rows[index].Cells[0].Value.ToString());
                        if (index_employee != -1)
                        {
                            dao_c.deleteOne(customers[index_employee].id);
                            dgvCustomer.Rows.RemoveAt(index);
                            customers.RemoveAt(index_employee);
                            cbId.Items.RemoveAt(index_employee);
                        }
                    }
                }
            }
            
        }

        private void ucCustomer_Load(object sender, System.EventArgs e)
        {
            dgvCustomer.Rows.Clear();
            dao_c.getAll().ForEach(customer =>
            {
                customers.Add(customer);
                cbId.Items.Add(customer.id);
                addToDGV(customer);
            });
            
        }

        public void addToDGV(Customer customer)
        {
            dgvCustomer.Rows.Add(new object[]
            {
                customer.id,
                customer.name,
                customer.address,
                customer.phone
            });
        }

        public void setEnabled(bool status)
        {
            txtName.Enabled = status;
            txtAddress.Enabled = status;
            txtPhone.Enabled = status;
        }

        public void reset()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }

        public void AddCustomer(Customer customer)
        {
            dao_c.insertOne(customer);
            cbId.Items.Add(customer.id);
            customers.Add(customer);
            addToDGV(customer);
            cbId.Text = dao_c.generateID(lengthID);
        }
        public void EditCustomer(Customer customer)
        {
            dao_c.updateOne(customer);
            for (int i = 0; i < dgvCustomer.RowCount; i++)
            {
                if (customer.id == dgvCustomer.Rows[i].Cells[0].Value.ToString())
                {
                    dgvCustomer.Rows[i].Cells[1].Value = customer.name;
                    dgvCustomer.Rows[i].Cells[2].Value = customer.address;
                    dgvCustomer.Rows[i].Cells[3].Value = customer.phone;
                    break;
                }
            }
        }

        private void cbId_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (action == EDIT && cbId.Text != "")
            {
                Customer customer = customers.Find(cus => cus.id == cbId.Text);
                if (customer != null)
                {
                    txtName.Text = customer.name;
                    txtAddress.Text = customer.address;
                    txtPhone.Text = customer.phone;
                }
            }
        }
        public Customer getData()
        {
            string error = validate();

            if (error == "")
            {
                Customer customer = new Customer();
                customer.id = cbId.Text;
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

        public string validate()
        {
            string error = "";
            if (cbId.Text == "")
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
            }catch(Exception ex)
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

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        public void search()
        {
            dgvCustomer.Rows.Clear();
            if (cbFilter.SelectedIndex == 0)
            {
                dao_c.searchById(txtKeyword.Text).ForEach(customer =>
                {
                    addToDGV(customer);
                });
            }
            else if (cbFilter.SelectedIndex == 1)
            {
                dao_c.searchByName(txtKeyword.Text).ForEach(customer =>
                {
                    addToDGV(customer);
                });
            }
            else if (cbFilter.SelectedIndex == 2)
            {
                dao_c.searchByAddress(txtKeyword.Text).ForEach(customer =>
                {
                    addToDGV(customer);
                });
            }
            else if (cbFilter.SelectedIndex == 3)
            {
                dao_c.searchByPhone(txtKeyword.Text).ForEach(customer =>
                {
                    addToDGV(customer);
                });
            }
        }
        private void cbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
