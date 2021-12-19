using PhanMemQuanLy.GUI.userControl;
using PhanMemQuanLy.objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PhanMemQuanLy.GUI
{
    public partial class F_Main : Form
    {
        private const string ADD = "Thêm";
        private const string EDIT = "Sửa";
        private const string DELETE = "Xoá";
        private const string REFRESH = "Làm mới";
        private const string SAVE = "Lưu";
        private const string CHANGEPASSWORD = "Đổi mật khẩu";
        private const string LOGOUT = "Đăng xuất";
        private ucHome controlHome = new ucHome();
        private Employee employee;
        private ucInvoice controlInvoice;
        private ucManufacturer controlManufacturer;
        private ucProduct controlProduct;
        private ucCustomer controlCustomer;
        private ucEmployee controlEmployee;
        private ucStatistics controlStatistics;
        private F_Login preComponent;
        private List<ucAction> actions = new List<ucAction>();

        public F_Main(F_Login f, Employee emp)
        {
            InitializeComponent();
            preComponent = f;
            employee = emp;
        }

        private void F_Main_Edited_Load(object sender, EventArgs e)
        {
            pnlView.Controls.Add(controlHome);

            ucAction actionNew = new ucAction(this);
            actionNew.Name = "ucAction" + actions.Count;
            actionNew.setText(ADD);
            actionNew.setImage(@"..\..\public\img\plus-sign.png");
            actions.Add(actionNew);
            fpnlActions.Controls.Add(actionNew);

            ucAction actionEdit = new ucAction(this);
            actionEdit.Name = "ucAction" + actions.Count;
            actionEdit.setText(EDIT);
            actionEdit.setImage(@"..\..\public\img\gear.png");
            actions.Add(actionEdit);
            fpnlActions.Controls.Add(actionEdit);

            ucAction actionDelete = new ucAction(this);
            actionDelete.Name = "ucAction" + actions.Count;
            actionDelete.setText(DELETE);
            actionDelete.setImage(@"..\..\public\img\rubbish-bin.png");
            actions.Add(actionDelete);
            fpnlActions.Controls.Add(actionDelete);

            ucAction actionRefresh = new ucAction(this);
            actionRefresh.Name = "ucAction" + actions.Count;
            actionRefresh.setText(REFRESH);
            actionRefresh.setImage(@"..\..\public\img\refresh-new.png");
            actions.Add(actionRefresh);
            fpnlActions.Controls.Add(actionRefresh);

            ucAction actionSave = new ucAction(this);
            actionSave.Name = "ucAction" + actions.Count;
            actionSave.setText(SAVE);
            actionSave.setImage(@"..\..\public\img\floppy-disk.png");
            actions.Add(actionSave);
            fpnlActions.Controls.Add(actionSave);

            ucAction actionChangePassword = new ucAction(this);
            actionChangePassword.Name = "ucAction" + actions.Count;
            actionChangePassword.setText(CHANGEPASSWORD);
            actionChangePassword.setImage(@"..\..\public\img\reload.png");
            actions.Add(actionChangePassword);
            fpnlActions.Controls.Add(actionChangePassword);

            ucAction actionLogout = new ucAction(this);
            actionLogout.Name = "ucAction" + actions.Count;
            actionLogout.setText(LOGOUT);
            actionLogout.setImage(@"..\..\public\img\log-out.png");
            actions.Add(actionLogout);
            fpnlActions.Controls.Add(actionLogout);
        }

        private void F_Main_Edited_FormClosed(object sender, FormClosedEventArgs e)
        {
            preComponent.Close();
        }

        public void actionClicked(ucAction ua, string actionName)
        {
            switch (actionName)
            {
                case ADD:
                    if(controlEmployee!=null && pnlView.Controls[0].Name == controlEmployee.Name)
                    {
                        controlEmployee.add();
                    }
                    else if (controlCustomer != null && pnlView.Controls[0].Name == controlCustomer.Name)
                    {
                        controlCustomer.add();
                    }
                    else if (controlProduct != null && pnlView.Controls[0].Name == controlProduct.Name)
                    {
                        controlProduct.add();
                    }
                    else if (controlInvoice != null && pnlView.Controls[0].Name == controlInvoice.Name)
                    {
                        controlInvoice.add();
                    }
                    else if (controlManufacturer != null && pnlView.Controls[0].Name == controlManufacturer.Name)
                    {
                        controlManufacturer.add();
                    }
                    break;
                case EDIT:
                    if (controlEmployee != null && pnlView.Controls[0].Name == controlEmployee.Name)
                    {
                        controlEmployee.edit();
                    }
                    else if (controlCustomer != null && pnlView.Controls[0].Name == controlCustomer.Name)
                    {
                        controlCustomer.edit();
                    }
                    else if (controlProduct != null &&  pnlView.Controls[0].Name == controlProduct.Name)
                    {
                        controlProduct.edit();
                    }
                    else if (controlInvoice != null && pnlView.Controls[0].Name == controlInvoice.Name)
                    {
                        controlInvoice.edit();
                    }
                    else if (controlManufacturer != null && pnlView.Controls[0].Name == controlManufacturer.Name)
                    {
                        controlManufacturer.edit();
                    }
                    break;
                case DELETE:
                    if (controlEmployee != null && pnlView.Controls[0].Name == controlEmployee.Name)
                    {
                        controlEmployee.delete();
                    }
                    else if (controlCustomer != null && pnlView.Controls[0].Name == controlCustomer.Name)
                    {
                        controlCustomer.delete();
                    }
                    else if (controlProduct != null && pnlView.Controls[0].Name == controlProduct.Name)
                    {
                        controlProduct.delete();
                    }
                    else if (controlInvoice != null && pnlView.Controls[0].Name == controlInvoice.Name)
                    {
                        controlInvoice.delete();
                    }
                    else if (controlManufacturer != null && pnlView.Controls[0].Name == controlManufacturer.Name)
                    {
                        controlManufacturer.delete();
                    }
                    break;
                case REFRESH:
                    if (controlEmployee != null && pnlView.Controls[0].Name == controlEmployee.Name)
                    {
                        controlEmployee.refresh();
                    }
                    else if (controlCustomer != null && pnlView.Controls[0].Name == controlCustomer.Name)
                    {
                        controlCustomer.refresh();
                    }
                    else if (controlProduct != null && pnlView.Controls[0].Name == controlProduct.Name)
                    {
                        controlProduct.refresh();
                    }
                    else if (controlInvoice != null && pnlView.Controls[0].Name == controlInvoice.Name)
                    {
                        controlInvoice.refresh();
                    }
                    else if (controlManufacturer != null && pnlView.Controls[0].Name == controlManufacturer.Name)
                    {
                        controlManufacturer.refresh();
                    }
                    break;
                case SAVE:
                    if (controlEmployee != null && pnlView.Controls[0].Name == controlEmployee.Name)
                    {
                        controlEmployee.save();
                    }
                    else if (controlCustomer != null && pnlView.Controls[0].Name == controlCustomer.Name)
                    {
                        controlCustomer.save();
                    }
                    else if (controlProduct != null && pnlView.Controls[0].Name == controlProduct.Name)
                    {
                        controlProduct.save();
                    }
                    else if (controlInvoice != null && pnlView.Controls[0].Name == controlInvoice.Name)
                    {
                        controlInvoice.save();
                    }
                    else if (controlManufacturer != null && pnlView.Controls[0].Name == controlManufacturer.Name)
                    {
                        controlManufacturer.save();
                    }
                    break;
                case CHANGEPASSWORD:
                    new F_ChangePassword(employee).Visible = true;
                    break;
            }
            
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlEmployee = new ucEmployee(employee);
            setActiveMenu(employeeToolStripMenuItem);
            pnlView.Controls.Clear();
            pnlView.Controls.Add(controlEmployee);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlProduct = new ucProduct();
            setActiveMenu(productToolStripMenuItem);
            pnlView.Controls.Clear();
            pnlView.Controls.Add(controlProduct);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlCustomer = new ucCustomer();
            setActiveMenu(customerToolStripMenuItem);
            pnlView.Controls.Clear();
            pnlView.Controls.Add(controlCustomer);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlHome = new ucHome();
            setActiveMenu(homeToolStripMenuItem);
            pnlView.Controls.Clear();
            pnlView.Controls.Add(controlHome);
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlInvoice = new ucInvoice(employee);
            setActiveMenu(invoiceToolStripMenuItem);
            pnlView.Controls.Clear();
            pnlView.Controls.Add(controlInvoice);
        }

        public void setActiveMenu(ToolStripMenuItem item)
        {
            for (int i = 0; i < menuStrip.Items.Count; i++)
            {
                menuStrip.Items[i].BackColor = SystemColors.Control;
            }
            item.BackColor = SystemColors.ActiveCaption;
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlStatistics = new ucStatistics();
            setActiveMenu(statisticsToolStripMenuItem);
            pnlView.Controls.Clear();
            pnlView.Controls.Add(controlStatistics);
        }

        private void manufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlManufacturer = new ucManufacturer();
            setActiveMenu(manufacturerToolStripMenuItem);
            pnlView.Controls.Clear();
            pnlView.Controls.Add(controlManufacturer);
        }
    }
}
