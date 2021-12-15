using System;
using System.Windows.Forms;

namespace PhanMemQuanLy.GUI.userControl
{
    public partial class UC_NumbericUpDown : UserControl
    {
        public decimal Value = 0;
        public decimal MinValue = 0;
        public decimal MaxValue = Int32.MaxValue;
        public UC_NumbericUpDown()
        {
            InitializeComponent();
            txtValue.Text = "" + Value;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            Value++;
            if(Value > MaxValue)
            {
                Value = MaxValue;
            }
            txtValue.Text = "" + Value;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            Value--;
            if (Value < MinValue)
            {
                Value = MinValue;
            }
            txtValue.Text = "" + Value;
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
            if (e.KeyChar == (char)126) e.Handled = false;
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtValue_Leave(object sender, EventArgs e)
        {
            decimal val = Convert.ToDecimal(txtValue.Text);
            if (val < MinValue)
            {
                val = MinValue;
            }
            if (val > MaxValue)
            {
                val = MaxValue;
            }
            txtValue.Text = "" + val;
        }
    }
}
