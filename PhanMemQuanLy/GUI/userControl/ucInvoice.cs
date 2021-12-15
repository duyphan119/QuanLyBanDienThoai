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
        private int lengthID = 8;
        public ucInvoice()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
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

        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {

        }

        public void getListOrderDetail(List<OrderDetail> list)
        {
            orderDetails = list;
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            if (cbId.Text != "")
            {
                new F_SelectProduct(this, cbId.Text).Visible = true;
            }
            else
            {
                MessageBox.Show("Chưa chọn số hoá đơn", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        }

        public void add()
        {
            reset();
            if (action != ADD)
            {
                action = ADD;
                cbId.Text = dao_i.generateID(lengthID);
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

        }

        public void refresh()
        {
            reset();
            formLoad();
        }

        public string validate()
        {
            string error = "";

            return error;
        }

        public Invoice getData()
        {
            return null;
        }
        public void save()
        {

        }
    }
}
