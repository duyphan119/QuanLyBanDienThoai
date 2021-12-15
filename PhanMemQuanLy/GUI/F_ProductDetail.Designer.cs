
namespace PhanMemQuanLy.GUI
{
    partial class F_ProductDetail
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlProductDetail = new System.Windows.Forms.Panel();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.cbMemorySpaceValue = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cbMemorySpace = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductDetail = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProductDetail
            // 
            this.pnlProductDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlProductDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProductDetail.Controls.Add(this.numQuantity);
            this.pnlProductDetail.Controls.Add(this.cbMemorySpaceValue);
            this.pnlProductDetail.Controls.Add(this.cbColor);
            this.pnlProductDetail.Controls.Add(this.txtPrice);
            this.pnlProductDetail.Controls.Add(this.label6);
            this.pnlProductDetail.Controls.Add(this.label3);
            this.pnlProductDetail.Controls.Add(this.cbId);
            this.pnlProductDetail.Controls.Add(this.lblId);
            this.pnlProductDetail.Controls.Add(this.cbMemorySpace);
            this.pnlProductDetail.Controls.Add(this.label5);
            this.pnlProductDetail.Controls.Add(this.label4);
            this.pnlProductDetail.Location = new System.Drawing.Point(12, 52);
            this.pnlProductDetail.Name = "pnlProductDetail";
            this.pnlProductDetail.Size = new System.Drawing.Size(304, 503);
            this.pnlProductDetail.TabIndex = 29;
            // 
            // numQuantity
            // 
            this.numQuantity.Enabled = false;
            this.numQuantity.Location = new System.Drawing.Point(127, 112);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(164, 27);
            this.numQuantity.TabIndex = 53;
            // 
            // cbMemorySpaceValue
            // 
            this.cbMemorySpaceValue.Enabled = false;
            this.cbMemorySpaceValue.FormattingEnabled = true;
            this.cbMemorySpaceValue.IntegralHeight = false;
            this.cbMemorySpaceValue.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256",
            "512"});
            this.cbMemorySpaceValue.Location = new System.Drawing.Point(127, 78);
            this.cbMemorySpaceValue.Name = "cbMemorySpaceValue";
            this.cbMemorySpaceValue.Size = new System.Drawing.Size(100, 27);
            this.cbMemorySpaceValue.TabIndex = 52;
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
            this.cbColor.Location = new System.Drawing.Point(127, 45);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(164, 27);
            this.cbColor.TabIndex = 51;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(127, 145);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(164, 27);
            this.txtPrice.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(14, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 28);
            this.label6.TabIndex = 50;
            this.label6.Text = "Giá Bán";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 48;
            this.label3.Text = "Số Lượng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbId
            // 
            this.cbId.Enabled = false;
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(127, 12);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(164, 27);
            this.cbId.TabIndex = 46;
            this.cbId.SelectedIndexChanged += new System.EventHandler(this.cbId_SelectedIndexChanged);
            this.cbId.TextChanged += new System.EventHandler(this.cbId_TextChanged);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(15, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(106, 30);
            this.lblId.TabIndex = 45;
            this.lblId.Text = "Mã CT";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbMemorySpace
            // 
            this.cbMemorySpace.Enabled = false;
            this.cbMemorySpace.FormattingEnabled = true;
            this.cbMemorySpace.Items.AddRange(new object[] {
            "MB",
            "GB",
            "TB"});
            this.cbMemorySpace.Location = new System.Drawing.Point(233, 79);
            this.cbMemorySpace.Name = "cbMemorySpace";
            this.cbMemorySpace.Size = new System.Drawing.Size(58, 27);
            this.cbMemorySpace.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 44;
            this.label5.Text = "Dung Lượng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 28);
            this.label4.TabIndex = 38;
            this.label4.Text = "Màu Sắc";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(12, 652);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(304, 35);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Enabled = false;
            this.txtProductId.Location = new System.Drawing.Point(140, 11);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(164, 27);
            this.txtProductId.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mã SP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvProductDetail
            // 
            this.dgvProductDetail.AllowUserToAddRows = false;
            this.dgvProductDetail.AllowUserToDeleteRows = false;
            this.dgvProductDetail.AllowUserToResizeColumns = false;
            this.dgvProductDetail.AllowUserToResizeRows = false;
            this.dgvProductDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.cColor,
            this.cSpace,
            this.cInventory,
            this.Column2});
            this.dgvProductDetail.EnableHeadersVisualStyles = false;
            this.dgvProductDetail.Location = new System.Drawing.Point(322, 8);
            this.dgvProductDetail.Name = "dgvProductDetail";
            this.dgvProductDetail.RowHeadersVisible = false;
            this.dgvProductDetail.RowHeadersWidth = 51;
            this.dgvProductDetail.RowTemplate.Height = 24;
            this.dgvProductDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductDetail.Size = new System.Drawing.Size(1070, 679);
            this.dgvProductDetail.TabIndex = 47;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(12, 572);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 35);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(166, 611);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 35);
            this.btnRefresh.TabIndex = 49;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(166, 572);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 35);
            this.btnEdit.TabIndex = 50;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(12, 611);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 35);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Chi Tiết";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // cColor
            // 
            this.cColor.HeaderText = "Màu Sắc";
            this.cColor.MinimumWidth = 6;
            this.cColor.Name = "cColor";
            this.cColor.ReadOnly = true;
            // 
            // cSpace
            // 
            this.cSpace.HeaderText = "Dung Lượng";
            this.cSpace.MinimumWidth = 6;
            this.cSpace.Name = "cSpace";
            this.cSpace.ReadOnly = true;
            // 
            // cInventory
            // 
            this.cInventory.HeaderText = "Số Lượng";
            this.cInventory.MinimumWidth = 6;
            this.cInventory.Name = "cInventory";
            this.cInventory.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Giá Bán";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // F_ProductDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1404, 699);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvProductDetail);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlProductDetail);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Name = "F_ProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Sản Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_ProductDetail_FormClosing);
            this.Load += new System.EventHandler(this.F_ProductDetail_Load);
            this.pnlProductDetail.ResumeLayout(false);
            this.pnlProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlProductDetail;
        private System.Windows.Forms.ComboBox cbMemorySpace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProductDetail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ComboBox cbMemorySpaceValue;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}