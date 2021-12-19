
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
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pictureProduct = new System.Windows.Forms.PictureBox();
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
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.pictureProduct);
            this.pnlInfo.Controls.Add(this.numPrice);
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Controls.Add(this.numQuantity);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.cbMemorySpace);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.cbColor);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Controls.Add(this.btnSelectImage);
            this.pnlInfo.Controls.Add(this.cbGroup);
            this.pnlInfo.Controls.Add(this.lblId);
            this.pnlInfo.Controls.Add(this.txtName);
            this.pnlInfo.Controls.Add(this.lblName);
            this.pnlInfo.Controls.Add(this.cbId);
            this.pnlInfo.Controls.Add(this.lblGroup);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1413, 247);
            this.pnlInfo.TabIndex = 6;
            // 
            // pictureProduct
            // 
            this.pictureProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureProduct.Location = new System.Drawing.Point(304, 49);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(213, 191);
            this.pictureProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProduct.TabIndex = 40;
            this.pictureProduct.TabStop = false;
            // 
            // numPrice
            // 
            this.numPrice.Enabled = false;
            this.numPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPrice.Location = new System.Drawing.Point(130, 214);
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
            this.label5.Location = new System.Drawing.Point(5, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 30);
            this.label5.TabIndex = 38;
            this.label5.Text = "Giá Bán";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numQuantity
            // 
            this.numQuantity.Enabled = false;
            this.numQuantity.Location = new System.Drawing.Point(130, 181);
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
            this.label4.Location = new System.Drawing.Point(5, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 30);
            this.label4.TabIndex = 36;
            this.label4.Text = "Số Lượng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 145);
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
            this.cbMemorySpace.Location = new System.Drawing.Point(130, 148);
            this.cbMemorySpace.Name = "cbMemorySpace";
            this.cbMemorySpace.Size = new System.Drawing.Size(164, 27);
            this.cbMemorySpace.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 112);
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
            this.cbColor.Location = new System.Drawing.Point(130, 115);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(164, 27);
            this.cbColor.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label1.Location = new System.Drawing.Point(300, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Hình Ảnh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Enabled = false;
            this.btnSelectImage.Location = new System.Drawing.Point(404, 16);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(113, 27);
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
            this.cbGroup.Location = new System.Drawing.Point(130, 15);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(164, 27);
            this.cbGroup.TabIndex = 27;
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
            this.cbGroup.TextChanged += new System.EventHandler(this.cbGroup_TextChanged);
            this.cbGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbGroup_KeyPress);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(5, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(99, 30);
            this.lblId.TabIndex = 26;
            this.lblId.Text = "Mã SP";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(130, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 27);
            this.txtName.TabIndex = 23;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblName.Location = new System.Drawing.Point(5, 82);
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
            this.cbId.Location = new System.Drawing.Point(130, 48);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(164, 27);
            this.cbId.TabIndex = 21;
            this.cbId.SelectedIndexChanged += new System.EventHandler(this.cbId_SelectedIndexChanged);
            this.cbId.TextChanged += new System.EventHandler(this.cbId_TextChanged);
            // 
            // lblGroup
            // 
            this.lblGroup.Location = new System.Drawing.Point(5, 12);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
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
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(0, 253);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1413, 398);
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
            this.cLogo.HeaderText = "Nhãn Hiệu";
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
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.pnlInfo);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(1413, 651);
            this.Load += new System.EventHandler(this.ucProduct_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMemorySpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
