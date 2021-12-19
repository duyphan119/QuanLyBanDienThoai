using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PhanMemQuanLy.GUI.userControl
{
    public partial class ucAction : UserControl
    {
        private F_Main parentComponent;
        public ucAction()
        {
            InitializeComponent();
        }
        public ucAction(F_Main f)
        {
            InitializeComponent();
            parentComponent = f;
        }

        public void actionClicked()
        {
            BackColor = pictureBox1.BackColor = label1.BackColor = SystemColors.ControlLight;
            parentComponent.actionClicked(this, label1.Text);
        }

        public void setText(string text)
        {
            label1.Text = text;
        }

        public void setImage(string path)
        {
            pictureBox1.Image = Image.FromFile(path);
        }

        private void ucAction_Load(object sender, EventArgs e)
        {
            //label1.Text = text;
            //pictureBox1.Image = Image.FromFile(pathImage);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            actionClicked();
        }

        private void ucAction_Click(object sender, EventArgs e)
        {
            actionClicked();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            actionClicked();
        }

        private void ucAction_MouseLeave(object sender, EventArgs e)
        {
            hoverState(false);
        }

        private void ucAction_MouseEnter(object sender, EventArgs e)
        {
            hoverState(true);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            hoverState(true);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            hoverState(false);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            hoverState(true);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            hoverState(false);
        }

        public void hoverState(bool status)
        {
            BackColor = pictureBox1.BackColor = label1.BackColor = (status == true) ? SystemColors.ControlLight : SystemColors.Control;
            
        }
    }
}
