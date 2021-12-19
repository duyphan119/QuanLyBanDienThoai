using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PhanMemQuanLy.DAO;
using PhanMemQuanLy.objects;

namespace PhanMemQuanLy.GUI.userControl
{
    public partial class ucEmployee : UserControl
    {
        private const string ADD = "Thêm dữ liệu";
        private const string EDIT = "Sửa dữ liệu";
        private string action = "";
        private DAO_Employee dao_e = new DAO_Employee();
        private List<Employee> employees = new List<Employee>();
        private int lengthID = 4;
        private Employee _employee;
        public ucEmployee(Employee e)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            _employee = e;
        }

        private void ucEmployee_Load(object sender, EventArgs e)
        {
            dao_e.getAll().ForEach(employee =>
            {
                employees.Add(employee);
                cbId.Items.Add(employee.id);
                addToDGV(employee);
            });
            dgvEmployee.ClearSelection();
        }

        public void addToDGV(Employee employee)
        {
            dgvEmployee.Rows.Add(new object[]
            {
                employee.id,
                employee.name,
                employee.password,
                employee.permission == 1 ? "ADMIN" : "USER"
            });
        }
        public void setEnabled(bool status)
        {
            txtName.Enabled = status;
            txtPassword.Enabled = status;
            cbPermission.Enabled = status;
        }
        public void add()
        {
            reset();
            if (action != ADD)
            {
                action = ADD;
                cbId.Text = dao_e.generateID(lengthID);
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
            }
            setEnabled(action == EDIT);
            cbId.Text = "";
            cbId.Enabled = (action == EDIT);
        }

        public void delete()
        {
            for (int i = dgvEmployee.SelectedRows.Count - 1; i >= 0; i--)
            {
                int index = dgvEmployee.SelectedRows[i].Index;
                if (index != -1)
                {
                    if(dgvEmployee.Rows[index].Cells[0].Value.ToString() != _employee.id)
                    {
                        DialogResult answer = MessageBox.Show(
                            $"Dữ liệu liên quan đến <{dgvEmployee.Rows[index].Cells[1].Value}> sẽ bị xoá.\nBạn có chắc chắn muốn xoá ?",
                            "Câu hỏi",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question
                        );
                        if (answer == DialogResult.Yes)
                        {
                            int index_employee = employees.FindIndex(emp => emp.id == dgvEmployee.Rows[index].Cells[0].Value.ToString());
                            if (index_employee != -1)
                            {
                                dao_e.deleteOne(employees[index_employee].id);
                                dgvEmployee.Rows.RemoveAt(index);
                                employees.RemoveAt(index_employee);
                                cbId.Items.RemoveAt(index_employee);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá thông tin của bản thân", "Lưu ý");
                    }
                }
            }
            dgvEmployee.ClearSelection();
        }

        

        public void AddEmployee(Employee employee)
        {
            dao_e.insertOne(employee);
            cbId.Items.Add(employee.id);
            employees.Add(employee);
            addToDGV(employee);
            cbId.Text = dao_e.generateID(lengthID);
        }
        public void EditEmployee(Employee employee)
        {
            dao_e.updateOne(employee);
            int index = employees.FindIndex(em => em.id == employee.id);
            if(index != -1)
            {
                employees[index] = employee;
            }
            for (int i = 0; i < dgvEmployee.RowCount; i++)
            {
                if (employee.id == dgvEmployee.Rows[i].Cells[0].Value.ToString())
                {
                    dgvEmployee.Rows[i].Cells[1].Value = employee.name;
                    dgvEmployee.Rows[i].Cells[2].Value = employee.password;
                    dgvEmployee.Rows[i].Cells[3].Value = employee.permission == 1 ? "ADMIN" : "USER";
                    break;
                }
            }
        }
        public string validate()
        {
            string error = "";
            if(cbId.Text == "")
            {
                error += "Chưa chọn mã nhân viên\n";
            }
            if (txtName.Text == "")
            {
                error += "Tên không được để trống\n";
            }
            if (txtPassword.Text.Length < 6)
            {
                error += "Mật khẩu tối thiểu phải 6 kí tự\n";
            }
            if (cbPermission.SelectedIndex == -1)
            {
                error += "Chưa chọn quyền\n";
            }
            return error;
        }
        public Employee getData()
        {
            string error = validate();

            if (error == "")
            {
                Employee employee = new Employee();
                employee.name = txtName.Text;
                employee.password = txtPassword.Text;
                employee.permission = cbPermission.SelectedIndex;
                employee.id = cbId.Text;
                return employee;
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
            Employee employee = getData();
            if (employee != null)
            {
                if (action == ADD)
                {
                    AddEmployee(employee);
                }
                else if (action == EDIT)
                {
                    EditEmployee(employee);
                }
                reset();
                dgvEmployee.ClearSelection();
            }
        }
        public void reset()
        {
            txtName.Text = "";
            txtPassword.Text = "";
            cbPermission.Text = "";
        }
        public void refresh()
        {
            reset();
            setEnabled(false);
            cbId.Text = "";
            cbId.Enabled = false;
            dgvEmployee.ClearSelection();
        }
        private void cbPermission_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(action == EDIT && cbId.Text != "")
            {
                Employee employee = employees.Find(em => em.id == cbId.Text);
                if(employee != null)
                {
                    txtName.Text = employee.name;
                    txtPassword.Text = employee.password;
                    cbPermission.SelectedIndex = employee.permission;
                }
            }
        }
    }
}
