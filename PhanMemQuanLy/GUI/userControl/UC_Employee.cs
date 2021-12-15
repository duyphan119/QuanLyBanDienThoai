using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using PhanMemQuanLy.DAO;
using PhanMemQuanLy.objects;

namespace PhanMemQuanLy.GUI.userControl
{
    public partial class UC_Employee : UserControl
    {
        private const string ADD = "Thêm dữ liệu";
        private const string EDIT = "Sửa dữ liệu";
        private string action = "";
        private DAO_Employee dao_e = new DAO_Employee();
        private List<Employee> employees = new List<Employee>();
        public UC_Employee()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            employees = dao_e.getAll();
            employees.ForEach(employee =>
            {
                cbId.Items.Add(employee.id);
                addToDataGridView(employee);
            });
            dgvEmployee.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(action != ADD)
            {
                action = ADD;
            }
            else if(action == ADD)
            {
                action = "";
            }
            setEnabled(action == ADD);
            cbId.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employee = getData();
            if(employee != null)
            {
                if(action == ADD)
                {
                    AddEmployee(employee);
                }
                else if(action == EDIT)
                {
                    EditEmployee(employee);
                }
            }
            reset();
            dgvEmployee.ClearSelection();
            btnDelete.Enabled = false;
        }
        public void reset()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }
        public void setEnabled(bool status)
        {
            txtName.Enabled = status;
            dateTime.Enabled = status;
            rbtnMale.Enabled = status;
            rbtnFemale.Enabled = status;
            txtAddress.Enabled = status;
            txtPhone.Enabled = status;
            cbPosition.Enabled = status;
            btnSave.Enabled = status;
            btnCancel.Enabled = status;
        }

        public string validate()
        {
            string error = "";
            string name = txtName.Text;
            DateTime dateOfBirth = dateTime.Value;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string position = cbPosition.Text;

            if (name == "")
            {
                error += "Tên không được để trống\n";
            }

            if (DateTime.Now.Year - dateOfBirth.Year < 18)
            {
                error += "Tuổi phải lớn hơn 18\n";
            }

            if (address == "")
            {
                error += "Địa chỉ không được để trống\n";
            }

            if (phone.Length != 10)
            {
                error += "Số điện thoại chỉ có 10 chữ số\n";
            }

            if (position == "")
            {
                error += "Chức vụ không được để trống\n";
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
                employee.password = "123456";
                //employee.id = (cbId.Text == "") ? generateID(employee.dateOfBirth, employee.gender) : cbId.Text;

                if (!cbPosition.Items.Contains(cbPosition.Text))
                {
                    cbPosition.Items.Add(cbPosition.Text);
                }

                return employee;
            }
            MessageDialog.Show(
                error,
                "Lỗi",
                MessageDialogButtons.OK,
                MessageDialogIcon.Error,
                MessageDialogStyle.Dark
            );
            return null;
        }

        public string generateID(DateTime dateOfBirth, string gender)
        {
            //2 chữ số đầu tiên là tuổi
            string age = (DateTime.Now.Year - dateOfBirth.Year).ToString();

            //1 chữ số tiếp theo là giới tính
            string strGender = (gender == "Nam") ? "1" : "0";

            //7 chữ số còn lại là 1 dãy số ngẫu nhiên
            Random rand = new Random();

            string id = age + strGender + rand.Next(1000000, 10000000).ToString();
            Employee employee = dao_e.getById(id);
            if (employee == null)
            {
                return id;
            }
            else
            {
                while (employee != null)
                {
                    employee = dao_e.getById(age + strGender + rand.Next(1000000, 10000000).ToString());
                }
                return employee.id;
            }
        }

        public void AddEmployee(Employee employee)
        {
            dao_e.insertOne(employee);
            cbId.Items.Add(employee.id);
            employees.Add(employee);
            addToDataGridView(employee);
        }

        public void addToDataGridView(Employee employee)
        {
            //dgvEmployee.Rows.Add(new object[]
            //{
            //    employee.id,
            //    employee.name,
            //    employee.dateOfBirth.ToString("dd/MM/yyyy"),
            //    employee.gender,
            //    employee.address,
            //    employee.phone,
            //    employee.position
            //});
        }

        public void EditEmployee(Employee employee)
        {
            //dao_e.updateOne(employee);
            //for(int i = 0; i < dgvEmployee.RowCount; i++)
            //{
            //    if(employee.id == dgvEmployee.Rows[i].Cells[0].Value.ToString())
            //    {
            //        dgvEmployee.Rows[i].Cells[1].Value = employee.name;
            //        dgvEmployee.Rows[i].Cells[2].Value = employee.dateOfBirth.ToString("dd/MM/yyyy");
            //        dgvEmployee.Rows[i].Cells[3].Value = employee.gender;
            //        dgvEmployee.Rows[i].Cells[4].Value = employee.address;
            //        dgvEmployee.Rows[i].Cells[5].Value = employee.phone;
            //        dgvEmployee.Rows[i].Cells[6].Value = employee.position;
            //        break;
            //    }
            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(action == "")
            {
                action = EDIT;
            }
            else if(action == EDIT)
            {
                action = "";
            }
            setEnabled(action == EDIT);
            cbId.Enabled = (action == EDIT);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for(int i = dgvEmployee.SelectedRows.Count - 1; i >= 0; i--)
            {
                int index = dgvEmployee.SelectedRows[i].Index;
                if(index != -1)
                {
                    DialogResult answer = MessageBox.Show(
                        $"Dữ liệu liên quan đến <{dgvEmployee.Rows[index].Cells[1].Value}> sẽ bị xoá.\nBạn có chắc chắn muốn xoá ?",
                        "Câu hỏi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    );
                    if (answer == DialogResult.Yes)
                    {
                        int index_employee = employees.FindIndex(employee => employee.id == dgvEmployee.Rows[index].Cells[0].Value.ToString());
                        if(index_employee != -1)
                        {
                            dao_e.deleteOne(employees[index_employee].id);
                            dgvEmployee.Rows.RemoveAt(index);
                            employees.RemoveAt(index_employee);
                            cbId.Items.RemoveAt(index_employee);
                        }
                    }
                }
            }
            dgvEmployee.ClearSelection();
            btnDelete.Enabled = false;
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            dgvEmployee.Rows.Clear();
            dao_e.searchByName(txtKeyword.Text).ForEach(employee =>
            {
                addToDataGridView(employee);
            });
            dgvEmployee.ClearSelection();
            btnDelete.Enabled = false;
        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(action == EDIT && cbId.SelectedIndex != -1)
            //{
            //    Employee employee = employees[cbId.SelectedIndex];
            //    txtName.Text = employee.name;
            //    dateTime.Value = employee.dateOfBirth;
            //    rbtnMale.Checked = (employee.gender == "Nam");
            //    rbtnFemale.Checked = (employee.gender == "Nữ");
            //    txtAddress.Text = employee.address;
            //    txtPhone.Text = employee.phone;
            //    cbPosition.Text = employee.position;
            //}
        }

        private void cbId_TextChanged(object sender, EventArgs e)
        {
            //Employee employee = employees.Find(emp => emp.id == cbId.Text);
            //if(employee != null)
            //{
            //    txtName.Text = employee.name;
            //    dateTime.Value = employee.dateOfBirth;
            //    rbtnMale.Checked = (employee.gender == "Nam");
            //    rbtnFemale.Checked = (employee.gender == "Nữ");
            //    txtAddress.Text = employee.address;
            //    txtPhone.Text = employee.phone;
            //    cbPosition.Text = employee.position;
            //}
            //else
            //{
            //    reset();
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void cbPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
