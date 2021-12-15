
namespace PhanMemQuanLy.GUI.userControl
{
    partial class UC_NumbericUpDown
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDown = new Guna.UI2.WinForms.Guna2Button();
            this.btnUp = new Guna.UI2.WinForms.Guna2Button();
            this.txtValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btnDown
            // 
            this.btnDown.Animated = true;
            this.btnDown.CheckedState.Parent = this.btnDown;
            this.btnDown.CustomImages.Parent = this.btnDown;
            this.btnDown.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDown.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDown.DisabledState.Parent = this.btnDown;
            this.btnDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDown.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.HoverState.Parent = this.btnDown;
            this.btnDown.Location = new System.Drawing.Point(0, 0);
            this.btnDown.Name = "btnDown";
            this.btnDown.ShadowDecoration.Parent = this.btnDown;
            this.btnDown.Size = new System.Drawing.Size(40, 36);
            this.btnDown.TabIndex = 0;
            this.btnDown.Text = "-";
            this.btnDown.TextOffset = new System.Drawing.Point(0, -2);
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Animated = true;
            this.btnUp.CheckedState.Parent = this.btnUp;
            this.btnUp.CustomImages.Parent = this.btnUp;
            this.btnUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUp.DisabledState.Parent = this.btnUp;
            this.btnUp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUp.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.HoverState.Parent = this.btnUp;
            this.btnUp.Location = new System.Drawing.Point(102, 0);
            this.btnUp.Name = "btnUp";
            this.btnUp.ShadowDecoration.Parent = this.btnUp;
            this.btnUp.Size = new System.Drawing.Size(40, 36);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "+";
            this.btnUp.TextOffset = new System.Drawing.Point(0, -2);
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // txtValue
            // 
            this.txtValue.Animated = true;
            this.txtValue.BorderColor = System.Drawing.Color.White;
            this.txtValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValue.DefaultText = "0";
            this.txtValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValue.DisabledState.Parent = this.txtValue;
            this.txtValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValue.FocusedState.Parent = this.txtValue;
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValue.ForeColor = System.Drawing.Color.Black;
            this.txtValue.HoverState.Parent = this.txtValue;
            this.txtValue.Location = new System.Drawing.Point(40, 0);
            this.txtValue.Name = "txtValue";
            this.txtValue.PasswordChar = '\0';
            this.txtValue.PlaceholderText = "0";
            this.txtValue.SelectedText = "";
            this.txtValue.SelectionStart = 1;
            this.txtValue.ShadowDecoration.Parent = this.txtValue;
            this.txtValue.Size = new System.Drawing.Size(62, 36);
            this.txtValue.TabIndex = 2;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            this.txtValue.Leave += new System.EventHandler(this.txtValue_Leave);
            // 
            // UC_NumbericUpDown
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_NumbericUpDown";
            this.Size = new System.Drawing.Size(142, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDown;
        private Guna.UI2.WinForms.Guna2Button btnUp;
        private Guna.UI2.WinForms.Guna2TextBox txtValue;
    }
}
