
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
            this.rpvStatistics = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rpvStatistics
            // 
            this.rpvStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvStatistics.Location = new System.Drawing.Point(0, 50);
            this.rpvStatistics.Name = "rpvStatistics";
            this.rpvStatistics.ServerReport.BearerToken = null;
            this.rpvStatistics.Size = new System.Drawing.Size(1368, 559);
            this.rpvStatistics.TabIndex = 0;
            this.rpvStatistics.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "dd/MM/yyyy";
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(134, 12);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(143, 27);
            this.dateTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn Thời Gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 18);
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
            this.cbFilter.Location = new System.Drawing.Point(409, 12);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(167, 27);
            this.cbFilter.TabIndex = 4;
            // 
            // ucStatistics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.rpvStatistics);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucStatistics";
            this.Size = new System.Drawing.Size(1368, 609);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvStatistics;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilter;
    }
}
