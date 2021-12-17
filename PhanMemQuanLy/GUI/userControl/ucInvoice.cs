using PhanMemQuanLy.DAO;
using PhanMemQuanLy.objects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PhanMemQuanLy.GUI.userControl
{
    public partial class ucInvoice : UserControl
    {
        private const string ADD = "Thêm";
        private const string EDIT = "Sửa";
        private string action = "";
        private List<Invoice> invoices = new List<Invoice>();
        private DAO_Invoice dao_i = new DAO_Invoice();
        private List<OrderDetail> orderDetails = new List<OrderDetail>();
        private F_SelectProduct fSelectProduct;
        private F_SelectCustomer fSelectCustomer;
        private Customer customer;
        private int lengthID = 8;
        private Employee employee;
        public ucInvoice(Employee emp)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            employee = emp;
            fSelectCustomer = new F_SelectCustomer(this);
        }

        public void getCustomer(Customer c)
        {
            customer = c;
            lblInfoCustomer.Text = $"Khách Hàng: {customer.name}";
            fSelectCustomer.Visible = false;
        }

        public void formLoad()
        {
            invoices.Clear();
            dgvInvoice.Rows.Clear();
            cbId.Items.Clear();
            dao_i.getAll().ForEach(invoice =>
            {
                invoices.Add(invoice);
                cbId.Items.Add(invoice.id);
                addToDGV(invoice);
            });

            dgvInvoice.ClearSelection();
        }

        private void ucInvoice_Load(object sender, EventArgs e)
        {
            formLoad();
        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbId.Text != "")
            {
                Invoice invoice = invoices.Find(inv => inv.id == cbId.Text);
                if(invoice != null)
                {
                    orderDetails = invoice.list;
                    customer = invoice.customer;
                    lblInfoCustomer.Text = $"Khách Hàng: {customer.name}";
                    decimal totalPrice = 0;
                    orderDetails.ForEach(od =>
                    {
                        totalPrice += od.getTotal();
                    });
                    txtPrice.Text = $"{(totalPrice == 0 ? "0" : totalPrice.ToString("#,##"))}đ";
                }
                fSelectProduct = new F_SelectProduct(this, orderDetails);
            }
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            if(fSelectCustomer.Visible == false)
            {
                fSelectCustomer = new F_SelectCustomer(this);
                fSelectCustomer.Visible = true;
            }
        }

        public void getListOrderDetail(List<OrderDetail> list)
        {
            orderDetails = list;
            decimal totalPrice = 0;
            orderDetails.ForEach(od =>
            {
                totalPrice += od.getTotal();
            });
            txtPrice.Text = $"{(totalPrice == 0 ? "0" : totalPrice.ToString("#,##"))}đ";
            fSelectProduct.Visible = false;
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            if(fSelectProduct.Visible == false)
            {
                fSelectProduct = new F_SelectProduct(this, orderDetails);
                fSelectProduct.Visible = true;
            }
        }

        public void setEnabled(bool status)
        {
            dateTime.Enabled = txtPrice.Enabled = btnSelectProduct.Enabled = btnSelectCustomer.Enabled = status;
            
        }

        public void addToDGV(Invoice invoice)
        {
            dgvInvoice.Rows.Add(new object[]{
                invoice.id,
                invoice.date.ToString("dd/MM/yyyy"),
                invoice.customer.name,
                invoice.getTotal().ToString("#,##"),
                invoice.employee.name
            });
        }

        public void reset()
        {
            customer = null;
            orderDetails = new List<OrderDetail>();
            txtPrice.Text = "0đ";
            lblInfoCustomer.Text = "Khách Hàng";
        }

        public void add()
        {
            reset();
            if (action != ADD)
            {
                action = ADD;
                cbId.Text = dao_i.generateID(lengthID);
                fSelectProduct = new F_SelectProduct(this, orderDetails);
            }
            else
            {
                action = "";
                cbId.Text = "";
            }
            setEnabled(action == ADD);
            dateTime.Enabled = cbId.Enabled = false;
        }

        public void edit()
        {
            reset();
            if (action != EDIT)
            {
                action = EDIT;
            }
            else
            {
                action = "";
            }
            setEnabled(action == EDIT);
            dateTime.Enabled = cbId.Enabled = (action == EDIT);
            cbId.Text = "";
        }

        public void delete()
        {
            for(int i = dgvInvoice.SelectedRows.Count - 1; i >= 0; i--)
            {
                int index = dgvInvoice.SelectedRows[i].Index;
                if (index != -1)
                {
                    DialogResult answer = MessageBox.Show(
                        $"Dữ liệu liên quan đến <{dgvInvoice.Rows[index].Cells[0].Value}> sẽ bị xoá.\nBạn có chắc chắn muốn xoá ?",
                        "Câu hỏi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    );
                    if (answer == DialogResult.Yes)
                    {
                        int index_invoice = invoices.FindIndex(invoice => invoice.id == dgvInvoice.Rows[index].Cells[0].Value.ToString());
                        if (index_invoice != -1)
                        {
                            dao_i.deleteOne(invoices[index_invoice].id);
                            dgvInvoice.Rows.RemoveAt(index);
                            invoices.RemoveAt(index_invoice);
                            cbId.Items.RemoveAt(index_invoice);
                        }
                    }
                }
            }
            dgvInvoice.ClearSelection();
        }

        public void refresh()
        {
            reset();
            formLoad();
        }

        public string validate()
        {
            string error = "";
            if(cbId.Text == "")
            {
                error += "Chưa chọn số hoá đơn\n";
            }
            if(customer == null)
            {
                error += "Chưa chọn khách hàng\n";
            }
            return error;
        }

        public Invoice getData()
        {
            string error = validate();
            if(error == "")
            {
                Invoice invoice = new Invoice()
                {
                    id = cbId.Text,
                    date = dateTime.Value,
                    customer = customer,
                    list = orderDetails,
                    employee = employee
                };
                return invoice;
            }

            return null;
        }
        public void save()
        {
            Invoice invoice = getData();
            if(invoice != null)
            {
                if(action == ADD)
                {
                    dao_i.insertOne(invoice);
                    dgvInvoice.Rows.Add(new object[]
                    {
                        invoice.id,
                        invoice.date.ToString("dd/MM/yy"),
                        invoice.customer.name,
                        invoice.getTotal().ToString("#,##"),
                        invoice.employee.name
                    });
                    cbId.Items.Add(invoice.id);
                    invoices.Add(invoice);
                    cbId.Text = dao_i.generateID(lengthID);
                }
                else if(action == EDIT)
                {
                    dao_i.updateOne(invoice);
                    for(int i = 0; i < dgvInvoice.RowCount; i++)
                    {
                        if(invoice.id == dgvInvoice.Rows[i].Cells[0].Value.ToString())
                        {
                            dgvInvoice.Rows[i].Cells[1].Value = invoice.date.ToString("dd/MM/yy");
                            dgvInvoice.Rows[i].Cells[2].Value = invoice.customer.name;
                            dgvInvoice.Rows[i].Cells[3].Value = invoice.getTotal().ToString("#,##");
                            dgvInvoice.Rows[i].Cells[4].Value = invoice.employee.name;
                        }
                    }
                    cbId.Text = "";
                }
                reset();
                dgvInvoice.ClearSelection();
            }
        }
    }
}
