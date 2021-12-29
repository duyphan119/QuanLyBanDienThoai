using PhanMemQuanLy.DAO;
using PhanMemQuanLy.objects;
using System;
using System.Windows.Forms;

namespace PhanMemQuanLy.GUI
{
    public partial class F_ChangePassword : Form
    {
        private DAO_Employee dao_e = new DAO_Employee();
        private Employee employee;
        public F_ChangePassword(Employee emp)
        {
            InitializeComponent();
            employee = emp;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string old = txtOldPassword.Text;
            string newP = txtNewPassword.Text;
            string confirmNewP = txtConfirmNewPassword.Text;
            string error1 = "Mật khẩu cũ không đúng";
            string error2 = "Mật khẩu mới phải có ít nhất 6 kí tự";
            string error3 = "Nhập lại mật khẩu mới không chính xác";
            string successMsg = "Đổi mật khẩu thành công";

            if (employee.password == old)
            {
                if(newP.Length >= 6)
                {
                    if (newP == confirmNewP)
                    {
                        employee.password = newP;
                        dao_e.updateOne(employee);
                        MessageBox.Show(successMsg, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(error3, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
