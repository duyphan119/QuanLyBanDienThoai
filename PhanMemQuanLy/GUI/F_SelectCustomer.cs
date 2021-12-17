using PhanMemQuanLy.DAO;
using PhanMemQuanLy.GUI.userControl;
using PhanMemQuanLy.objects;
using System;
using System.Windows.Forms;

namespace PhanMemQuanLy.GUI
{
    public partial class F_SelectCustomer : Form
    {
        private ucInvoice preComponent;
        private DAO_Customer dao_c = new DAO_Customer();
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
            dgvCustomer.ClearSelection();
        }
    }
}
