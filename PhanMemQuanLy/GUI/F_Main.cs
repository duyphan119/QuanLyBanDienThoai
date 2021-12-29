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
        private const string SAVE = "Lưu";
        private Employee employee;
        private ucInvoice controlInvoice;
        private ucManufacturer controlManufacturer;
        private ucProduct controlProduct;
        private ucCustomer controlCustomer;
        private ucEmployee controlEmployee;
        private ucStatistics controlStatistics;
        private F_Login preComponent;
        private List<ucAction> actions = new List<ucAction>();
        private bool isLogOut = false;

        public F_Main(F_Login f, Employee emp)
        {
            InitializeComponent();
            preComponent = f;
            employee = emp;
            if(emp.permission == 0)
            {
                quyenUSER();
                controlInvoice = new ucInvoice(employee);
                pnlView.Controls.Add(controlInvoice);
            }
            else
            {
                controlEmployee = new ucEmployee(employee);
                pnlView.Controls.Add(controlEmployee);
                setActiveMenu(employeeToolStripMenuItem);
            }

        }

        public void quyenUSER()
        {
            menuStrip.Items.Remove(employeeToolStripMenuItem);
            menuStrip.Items.Remove(manufacturerToolStripMenuItem);
            menuStrip.Items.Remove(productToolStripMenuItem);
            setActiveMenu(invoiceToolStripMenuItem);
        }

        private void F_Main_Edited_Load(object sender, EventArgs e)
        {
            

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

            if(employee.permission == 1)
            {
                ucAction actionDelete = new ucAction(this);
                actionDelete.Name = "ucAction" + actions.Count;
                actionDelete.setText(DELETE);
                actionDelete.setImage(@"..\..\public\img\rubbish-bin.png");
                actions.Add(actionDelete);
                fpnlActions.Controls.Add(actionDelete);
            }

            ucAction actionSave = new ucAction(this);
            actionSave.Name = "ucAction" + actions.Count;
            actionSave.setText(SAVE);
            actionSave.setImage(@"..\..\public\img\floppy-disk.png");
            actions.Add(actionSave);
            fpnlActions.Controls.Add(actionSave);

            fpnlActions.Visible = true;
        }

        private void F_Main_Edited_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isLogOut == false)
            {
                preComponent.Close();
            }
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
            }
            
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fpnlActions.Visible = true;
            controlEmployee = new ucEmployee(employee);
            setActiveMenu(employeeToolStripMenuItem);
            pnlView.Controls.Clear();
            pnlView.Controls.Add(controlEmployee);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fpnlActions.Visible = true;
            controlProduct = new ucProduct();
            setActiveMenu(productToolStripMenuItem);
            pnlView.Controls.Clear();
            pnlView.Controls.Add(controlProduct);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fpnlActions.Visible = true;
            controlCustomer = new ucCustomer();
            setActiveMenu(customerToolStripMenuItem);
            pnlView.Controls.Clear();
            pnlView.Controls.Add(controlCustomer);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fpnlActions.Visible = false;
            controlInvoice = new ucInvoice(employee);
            setActiveMenu(invoiceToolStripMenuItem);
            pnlView.Controls.Clear();
            pnlView.Controls.Add(controlInvoice);
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fpnlActions.Visible = true;
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
            fpnlActions.Visible = false;
            controlStatistics = new ucStatistics();
            setActiveMenu(statisticsToolStripMenuItem);
            pnlView.Controls.Clear();
            pnlView.Controls.Add(controlStatistics);
        }

        private void manufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fpnlActions.Visible = true;
            controlManufacturer = new ucManufacturer();
            setActiveMenu(manufacturerToolStripMenuItem);
            pnlView.Controls.Clear();
            pnlView.Controls.Add(controlManufacturer);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new F_ChangePassword(employee).Visible = true;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isLogOut = true;
            Close();
            preComponent.Visible = true;
        }
    }
}
