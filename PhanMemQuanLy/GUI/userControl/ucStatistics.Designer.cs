
namespace PhanMemQuanLy.GUI.userControl
{
    partial class ucStatistics
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
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleDay = new System.Windows.Forms.Label();
            this.lblDayRevenue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMonthRevenue = new System.Windows.Forms.Label();
            this.lblTitleMonth = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblYearRevenue = new System.Windows.Forms.Label();
            this.lblTitleYear = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblInventory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "dd/MM/yyyy";
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(150, 19);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(143, 27);
            this.dateTime.TabIndex = 1;
            this.dateTime.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn Thời Gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thống Kê Theo";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.IntegralHeight = false;
            this.cbFilter.Items.AddRange(new object[] {
            "Các Ngày Trong Tuần",
            "Các Ngày Trong Tháng",
            "Các Tháng Trong Năm",
            "Các Quý Trong Năm",
            "Ba Năm Gần Đây"});
            this.cbFilter.Location = new System.Drawing.Point(136, 34);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(195, 27);
            this.cbFilter.TabIndex = 4;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.cbFilter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1267, 82);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Biểu đồ doanh thu";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Arial", 9F);
            this.btnView.Location = new System.Drawing.Point(337, 34);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(88, 24);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(6, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1267, 185);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblDayRevenue);
            this.panel1.Controls.Add(this.lblTitleDay);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(20, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 118);
            this.panel1.TabIndex = 0;
            // 
            // lblTitleDay
            // 
            this.lblTitleDay.Location = new System.Drawing.Point(89, 3);
            this.lblTitleDay.Name = "lblTitleDay";
            this.lblTitleDay.Size = new System.Drawing.Size(105, 33);
            this.lblTitleDay.TabIndex = 8;
            this.lblTitleDay.Text = "Ngày";
            this.lblTitleDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDayRevenue
            // 
            this.lblDayRevenue.Location = new System.Drawing.Point(3, 85);
            this.lblDayRevenue.Name = "lblDayRevenue";
            this.lblDayRevenue.Size = new System.Drawing.Size(191, 30);
            this.lblDayRevenue.TabIndex = 9;
            this.lblDayRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lblMonthRevenue);
            this.panel2.Controls.Add(this.lblTitleMonth);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(243, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 118);
            this.panel2.TabIndex = 10;
            // 
            // lblMonthRevenue
            // 
            this.lblMonthRevenue.Location = new System.Drawing.Point(3, 85);
            this.lblMonthRevenue.Name = "lblMonthRevenue";
            this.lblMonthRevenue.Size = new System.Drawing.Size(191, 30);
            this.lblMonthRevenue.TabIndex = 9;
            this.lblMonthRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitleMonth
            // 
            this.lblTitleMonth.Location = new System.Drawing.Point(89, 3);
            this.lblTitleMonth.Name = "lblTitleMonth";
            this.lblTitleMonth.Size = new System.Drawing.Size(105, 33);
            this.lblTitleMonth.TabIndex = 8;
            this.lblTitleMonth.Text = "Ngày";
            this.lblTitleMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lblYearRevenue);
            this.panel3.Controls.Add(this.lblTitleYear);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(461, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 118);
            this.panel3.TabIndex = 11;
            // 
            // lblYearRevenue
            // 
            this.lblYearRevenue.Location = new System.Drawing.Point(3, 85);
            this.lblYearRevenue.Name = "lblYearRevenue";
            this.lblYearRevenue.Size = new System.Drawing.Size(191, 30);
            this.lblYearRevenue.TabIndex = 9;
            this.lblYearRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitleYear
            // 
            this.lblTitleYear.Location = new System.Drawing.Point(89, 3);
            this.lblTitleYear.Name = "lblTitleYear";
            this.lblTitleYear.Size = new System.Drawing.Size(105, 33);
            this.lblTitleYear.TabIndex = 8;
            this.lblTitleYear.Text = "Ngày";
            this.lblTitleYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.lblInventory);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Location = new System.Drawing.Point(679, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 118);
            this.panel4.TabIndex = 12;
            // 
            // lblInventory
            // 
            this.lblInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.lblInventory.Location = new System.Drawing.Point(3, 85);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(191, 30);
            this.lblInventory.TabIndex = 9;
            this.lblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(89, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hết hàng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PhanMemQuanLy.Properties.Resources.app_development;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PhanMemQuanLy.Properties.Resources.money;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PhanMemQuanLy.Properties.Resources.money;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhanMemQuanLy.Properties.Resources.money;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ucStatistics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucStatistics";
            this.Size = new System.Drawing.Size(1276, 639);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDayRevenue;
        private System.Windows.Forms.Label lblTitleDay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblYearRevenue;
        private System.Windows.Forms.Label lblTitleYear;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMonthRevenue;
        private System.Windows.Forms.Label lblTitleMonth;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
