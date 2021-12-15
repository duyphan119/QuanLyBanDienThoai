
namespace PhanMemQuanLy.GUI.userControl
{
    partial class UC_CardProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CardProduct));
            this.lblName = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbSpace = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial", 10F);
            this.lblName.Location = new System.Drawing.Point(6, 208);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(226, 40);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Iphone X";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(239, 205);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 8.8F);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPrice.Location = new System.Drawing.Point(9, 278);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(130, 26);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "4,000,000đ";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbColor
            // 
            this.cbColor.Font = new System.Drawing.Font("Arial", 8.6F);
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(109, 251);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(119, 24);
            this.cbColor.TabIndex = 9;
            this.cbColor.TabStop = false;
            this.cbColor.Text = "Xanh Dương";
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            this.cbColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbColor_KeyPress);
            // 
            // cbSpace
            // 
            this.cbSpace.Font = new System.Drawing.Font("Arial", 8.6F);
            this.cbSpace.FormattingEnabled = true;
            this.cbSpace.Location = new System.Drawing.Point(9, 251);
            this.cbSpace.Name = "cbSpace";
            this.cbSpace.Size = new System.Drawing.Size(94, 24);
            this.cbSpace.TabIndex = 10;
            this.cbSpace.TabStop = false;
            this.cbSpace.Text = "256GB";
            this.cbSpace.SelectedIndexChanged += new System.EventHandler(this.cbSpace_SelectedIndexChanged);
            this.cbSpace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSpace_KeyPress);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(149, 278);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(79, 28);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.TabStop = false;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // UC_CardProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cbSpace);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picture);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UC_CardProduct";
            this.Size = new System.Drawing.Size(238, 309);
            this.Load += new System.EventHandler(this.UC_CardProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ComboBox cbSpace;
        private System.Windows.Forms.Button btnSelect;
    }
}
