using PhanMemQuanLy.DAO;
using PhanMemQuanLy.objects;
using System;
using System.Windows.Forms;

namespace PhanMemQuanLy.GUI
{
    public partial class F_Login : Form
    {
        private DAO_Employee dao_e = new DAO_Employee();
        public F_Login()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string password = txtPassword.Text;
            string error1 = "Mã nhân viên không chính xác";
            string error2 = "Mật khẩu không chính xác";
            Employee employee = dao_e.getById(id);
            if (employee != null)
            {
                if (employee.password == password)
                {
                    txtId.Text = txtPassword.Text = "";
                    new F_Main(this, employee).Visible = true;
                }
                else
                {
                    MessageBox.Show(error2, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(error1, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
