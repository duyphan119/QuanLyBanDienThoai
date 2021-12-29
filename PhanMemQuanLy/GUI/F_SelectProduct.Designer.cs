
namespace PhanMemQuanLy.GUI
{
    partial class F_SelectProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_SelectProduct));
            this.fpnlCardProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.uC_CardProduct8 = new PhanMemQuanLy.GUI.userControl.ucCardProduct();
            this.uC_CardProduct9 = new PhanMemQuanLy.GUI.userControl.ucCardProduct();
            this.uC_CardProduct1 = new PhanMemQuanLy.GUI.userControl.ucCardProduct();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.fpnlCardProductSelected = new System.Windows.Forms.FlowLayoutPanel();
            this.ucProductSelected1 = new PhanMemQuanLy.GUI.userControl.ucProductSelected();
            this.ucProductSelected2 = new PhanMemQuanLy.GUI.userControl.ucProductSelected();
            this.ucProductSelected3 = new PhanMemQuanLy.GUI.userControl.ucProductSelected();
            this.ucProductSelected4 = new PhanMemQuanLy.GUI.userControl.ucProductSelected();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalAll = new System.Windows.Forms.TextBox();
            this.fpnlCardProduct.SuspendLayout();
            this.fpnlCardProductSelected.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpnlCardProduct
            // 
            this.fpnlCardProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpnlCardProduct.AutoScroll = true;
            this.fpnlCardProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpnlCardProduct.Controls.Add(this.uC_CardProduct8);
            this.fpnlCardProduct.Controls.Add(this.uC_CardProduct9);
            this.fpnlCardProduct.Controls.Add(this.uC_CardProduct1);
            this.fpnlCardProduct.Location = new System.Drawing.Point(2, 48);
            this.fpnlCardProduct.Name = "fpnlCardProduct";
            this.fpnlCardProduct.Size = new System.Drawing.Size(1197, 323);
            this.fpnlCardProduct.TabIndex = 0;
            // 
            // uC_CardProduct8
            // 
            this.uC_CardProduct8.BackColor = System.Drawing.Color.White;
            this.uC_CardProduct8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_CardProduct8.Location = new System.Drawing.Point(6, 6);
            this.uC_CardProduct8.Margin = new System.Windows.Forms.Padding(6);
            this.uC_CardProduct8.Name = "uC_CardProduct8";
            this.uC_CardProduct8.Size = new System.Drawing.Size(238, 309);
            this.uC_CardProduct8.TabIndex = 7;
            // 
            // uC_CardProduct9
            // 
            this.uC_CardProduct9.BackColor = System.Drawing.Color.White;
            this.uC_CardProduct9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_CardProduct9.Location = new System.Drawing.Point(256, 6);
            this.uC_CardProduct9.Margin = new System.Windows.Forms.Padding(6);
            this.uC_CardProduct9.Name = "uC_CardProduct9";
            this.uC_CardProduct9.Size = new System.Drawing.Size(238, 309);
            this.uC_CardProduct9.TabIndex = 8;
            // 
            // uC_CardProduct1
            // 
            this.uC_CardProduct1.BackColor = System.Drawing.Color.White;
            this.uC_CardProduct1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_CardProduct1.Location = new System.Drawing.Point(506, 6);
            this.uC_CardProduct1.Margin = new System.Windows.Forms.Padding(6);
            this.uC_CardProduct1.Name = "uC_CardProduct1";
            this.uC_CardProduct1.Size = new System.Drawing.Size(238, 309);
            this.uC_CardProduct1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhà sản xuất";
            // 
            // cbGroup
            // 
            this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.IntegralHeight = false;
            this.cbGroup.Location = new System.Drawing.Point(129, 14);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(182, 28);
            this.cbGroup.TabIndex = 2;
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
            this.cbGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbGroup_KeyPress);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnSubmit.Location = new System.Drawing.Point(982, 679);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(206, 66);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Xác Nhận";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // fpnlCardProductSelected
            // 
            this.fpnlCardProductSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fpnlCardProductSelected.AutoScroll = true;
            this.fpnlCardProductSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpnlCardProductSelected.Controls.Add(this.ucProductSelected1);
            this.fpnlCardProductSelected.Controls.Add(this.ucProductSelected2);
            this.fpnlCardProductSelected.Controls.Add(this.ucProductSelected3);
            this.fpnlCardProductSelected.Controls.Add(this.ucProductSelected4);
            this.fpnlCardProductSelected.Location = new System.Drawing.Point(2, 432);
            this.fpnlCardProductSelected.Name = "fpnlCardProductSelected";
            this.fpnlCardProductSelected.Size = new System.Drawing.Size(974, 313);
            this.fpnlCardProductSelected.TabIndex = 4;
            // 
            // ucProductSelected1
            // 
            this.ucProductSelected1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProductSelected1.BackColor = System.Drawing.Color.White;
            this.ucProductSelected1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucProductSelected1.Location = new System.Drawing.Point(3, 5);
            this.ucProductSelected1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucProductSelected1.Name = "ucProductSelected1";
            this.ucProductSelected1.Size = new System.Drawing.Size(940, 90);
            this.ucProductSelected1.TabIndex = 0;
            // 
            // ucProductSelected2
            // 
            this.ucProductSelected2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProductSelected2.BackColor = System.Drawing.Color.White;
            this.ucProductSelected2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucProductSelected2.Location = new System.Drawing.Point(3, 105);
            this.ucProductSelected2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucProductSelected2.Name = "ucProductSelected2";
            this.ucProductSelected2.Size = new System.Drawing.Size(940, 90);
            this.ucProductSelected2.TabIndex = 1;
            // 
            // ucProductSelected3
            // 
            this.ucProductSelected3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProductSelected3.BackColor = System.Drawing.Color.White;
            this.ucProductSelected3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucProductSelected3.Location = new System.Drawing.Point(3, 205);
            this.ucProductSelected3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucProductSelected3.Name = "ucProductSelected3";
            this.ucProductSelected3.Size = new System.Drawing.Size(940, 90);
            this.ucProductSelected3.TabIndex = 2;
            // 
            // ucProductSelected4
            // 
            this.ucProductSelected4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProductSelected4.BackColor = System.Drawing.Color.White;
            this.ucProductSelected4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucProductSelected4.Location = new System.Drawing.Point(3, 305);
            this.ucProductSelected4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucProductSelected4.Name = "ucProductSelected4";
            this.ucProductSelected4.Size = new System.Drawing.Size(940, 90);
            this.ucProductSelected4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 49);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(972, 47);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh Sách Sản Phẩm Đã Chọn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label3.Location = new System.Drawing.Point(978, 649);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng Tiền";
            // 
            // txtTotalAll
            // 
            this.txtTotalAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalAll.Font = new System.Drawing.Font("Arial", 10.2F);
            this.txtTotalAll.Location = new System.Drawing.Point(1065, 646);
            this.txtTotalAll.Name = "txtTotalAll";
            this.txtTotalAll.ReadOnly = true;
            this.txtTotalAll.Size = new System.Drawing.Size(123, 27);
            this.txtTotalAll.TabIndex = 7;
            this.txtTotalAll.Text = "0đ";
            this.txtTotalAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // F_SelectProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 757);
            this.Controls.Add(this.txtTotalAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fpnlCardProductSelected);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fpnlCardProduct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_SelectProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Sản Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_SelectProduct_FormClosing);
            this.Load += new System.EventHandler(this.F_SelectProduct_Load);
            this.fpnlCardProduct.ResumeLayout(false);
            this.fpnlCardProductSelected.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlCardProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGroup;
        private userControl.ucCardProduct uC_CardProduct8;
        private userControl.ucCardProduct uC_CardProduct9;
        private userControl.ucCardProduct uC_CardProduct1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.FlowLayoutPanel fpnlCardProductSelected;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private userControl.ucProductSelected ucProductSelected1;
        private userControl.ucProductSelected ucProductSelected2;
        private userControl.ucProductSelected ucProductSelected3;
        private userControl.ucProductSelected ucProductSelected4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalAll;
    }
}