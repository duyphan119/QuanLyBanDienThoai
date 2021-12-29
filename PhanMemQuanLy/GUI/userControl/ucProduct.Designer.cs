
namespace PhanMemQuanLy.GUI.userControl
{
    partial class ucProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMemorySpace = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMemorySpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.pictureProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // numPrice
            // 
            this.numPrice.Enabled = false;
            this.numPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPrice.Location = new System.Drawing.Point(141, 234);
            this.numPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(164, 27);
            this.numPrice.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 30);
            this.label5.TabIndex = 38;
            this.label5.Text = "Giá Bán";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numQuantity
            // 
            this.numQuantity.Enabled = false;
            this.numQuantity.Location = new System.Drawing.Point(141, 201);
            this.numQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(164, 27);
            this.numQuantity.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 30);
            this.label4.TabIndex = 36;
            this.label4.Text = "Số Lượng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 30);
            this.label3.TabIndex = 35;
            this.label3.Text = "Bộ Nhớ Trong";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbMemorySpace
            // 
            this.cbMemorySpace.Enabled = false;
            this.cbMemorySpace.FormattingEnabled = true;
            this.cbMemorySpace.IntegralHeight = false;
            this.cbMemorySpace.Items.AddRange(new object[] {
            "2GB",
            "4GB",
            "8GB",
            "16GB",
            "32GB",
            "64GB",
            "128GB",
            "256GB",
            "512GB",
            "1TB"});
            this.cbMemorySpace.Location = new System.Drawing.Point(141, 168);
            this.cbMemorySpace.Name = "cbMemorySpace";
            this.cbMemorySpace.Size = new System.Drawing.Size(164, 27);
            this.cbMemorySpace.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "Màu Sắc";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbColor
            // 
            this.cbColor.Enabled = false;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.IntegralHeight = false;
            this.cbColor.Items.AddRange(new object[] {
            "Trắng",
            "Đen",
            "Xanh Lá",
            "Xanh Dương",
            "Đỏ",
            "Tím",
            "Vàng",
            "Nâu",
            "Hồng",
            "Cam",
            "Bạc",
            "Xám"});
            this.cbColor.Location = new System.Drawing.Point(141, 135);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(164, 27);
            this.cbColor.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label1.Location = new System.Drawing.Point(17, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Hình Ảnh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Enabled = false;
            this.btnSelectImage.Location = new System.Drawing.Point(141, 267);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(164, 27);
            this.btnSelectImage.TabIndex = 29;
            this.btnSelectImage.Text = "Tải Ảnh Lên";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // cbGroup
            // 
            this.cbGroup.Enabled = false;
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.IntegralHeight = false;
            this.cbGroup.Location = new System.Drawing.Point(141, 35);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(164, 27);
            this.cbGroup.TabIndex = 27;
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
            this.cbGroup.TextChanged += new System.EventHandler(this.cbGroup_TextChanged);
            this.cbGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbGroup_KeyPress);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(16, 65);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(99, 30);
            this.lblId.TabIndex = 26;
            this.lblId.Text = "Mã SP";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(141, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 27);
            this.txtName.TabIndex = 23;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblName.Location = new System.Drawing.Point(16, 102);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 28);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Tên SP";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbId
            // 
            this.cbId.Enabled = false;
            this.cbId.FormattingEnabled = true;
            this.cbId.IntegralHeight = false;
            this.cbId.Location = new System.Drawing.Point(141, 68);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(164, 27);
            this.cbId.TabIndex = 21;
            this.cbId.SelectedIndexChanged += new System.EventHandler(this.cbId_SelectedIndexChanged);
            this.cbId.TextChanged += new System.EventHandler(this.cbId_TextChanged);
            // 
            // lblGroup
            // 
            this.lblGroup.Location = new System.Drawing.Point(16, 32);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(119, 30);
            this.lblGroup.TabIndex = 20;
            this.lblGroup.Text = "Nhà Sản Xuất";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cName,
            this.cLogo,
            this.cColor,
            this.cMemorySpace,
            this.cQuantity,
            this.cPrice});
            this.dgvProduct.Location = new System.Drawing.Point(14, 26);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1014, 510);
            this.dgvProduct.TabIndex = 7;
            // 
            // cId
            // 
            this.cId.FillWeight = 60F;
            this.cId.HeaderText = "Mã SP";
            this.cId.MinimumWidth = 6;
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            // 
            // cName
            // 
            this.cName.FillWeight = 200F;
            this.cName.HeaderText = "Tên SP";
            this.cName.MinimumWidth = 6;
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cLogo
            // 
            this.cLogo.FillWeight = 70F;
            this.cLogo.HeaderText = "Nhà sản xuất";
            this.cLogo.MinimumWidth = 6;
            this.cLogo.Name = "cLogo";
            this.cLogo.ReadOnly = true;
            // 
            // cColor
            // 
            this.cColor.FillWeight = 86F;
            this.cColor.HeaderText = "Màu Sắc";
            this.cColor.MinimumWidth = 6;
            this.cColor.Name = "cColor";
            this.cColor.ReadOnly = true;
            // 
            // cMemorySpace
            // 
            this.cMemorySpace.FillWeight = 94F;
            this.cMemorySpace.HeaderText = "Bộ Nhớ Trong";
            this.cMemorySpace.MinimumWidth = 6;
            this.cMemorySpace.Name = "cMemorySpace";
            this.cMemorySpace.ReadOnly = true;
            // 
            // cQuantity
            // 
            this.cQuantity.FillWeight = 80F;
            this.cQuantity.HeaderText = "Số Lượng";
            this.cQuantity.MinimumWidth = 6;
            this.cQuantity.Name = "cQuantity";
            this.cQuantity.ReadOnly = true;
            // 
            // cPrice
            // 
            this.cPrice.FillWeight = 90F;
            this.cPrice.HeaderText = "Giá Bán";
            this.cPrice.MinimumWidth = 6;
            this.cPrice.Name = "cPrice";
            this.cPrice.ReadOnly = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cbGroup);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.pictureProduct);
            this.groupBox1.Controls.Add(this.numPrice);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.btnSelectImage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbColor);
            this.groupBox1.Controls.Add(this.cbId);
            this.groupBox1.Controls.Add(this.numQuantity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblGroup);
            this.groupBox1.Controls.Add(this.cbMemorySpace);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(19, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 594);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvProduct);
            this.groupBox2.Location = new System.Drawing.Point(359, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1039, 554);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(992, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 28);
            this.label6.TabIndex = 44;
            this.label6.Text = "Tìm kiếm";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Mã",
            "Tên"});
            this.cbFilter.Location = new System.Drawing.Point(1077, 25);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(71, 27);
            this.cbFilter.TabIndex = 45;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyword.Location = new System.Drawing.Point(1154, 26);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(233, 27);
            this.txtKeyword.TabIndex = 43;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // pictureProduct
            // 
            this.pictureProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureProduct.Location = new System.Drawing.Point(21, 300);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(284, 276);
            this.pictureProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProduct.TabIndex = 40;
            this.pictureProduct.TabStop = false;
            // 
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(1413, 629);
            this.Load += new System.EventHandler(this.ucProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureProduct;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMemorySpace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMemorySpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox txtKeyword;
    }
}
