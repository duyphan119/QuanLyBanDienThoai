using Microsoft.Reporting.WinForms;
using PhanMemQuanLy.DAO;
using PhanMemQuanLy.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLy.GUI.userControl
{
    public partial class ucStatistics : UserControl
    {
        private DAO_Revenue dao_r = new DAO_Revenue();
        private DataTable table = new DataTable();
        public ucStatistics()
        {
            InitializeComponent();

            table.Columns.Add("time", typeof(string));
            table.Columns.Add("value", typeof(decimal));
            cbFilter.SelectedIndex = 0;
        }

        public void loadReport(string title)
        {
            rpvStatistics.LocalReport.ReportPath = @"..\..\GUI\report\Revenue.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "RevenueDataSet";
            rds.Value = table;
            ReportParameter rptTitle = new ReportParameter("title", title);
            rpvStatistics.LocalReport.SetParameters(new ReportParameter[] { rptTitle });
            rpvStatistics.LocalReport.DataSources.Clear();
            rpvStatistics.LocalReport.DataSources.Add(rds);
            rpvStatistics.RefreshReport();
        }

        public void daysOfWeek()
        {
            table.Rows.Clear();
            List<Revenue> revenues = dao_r.getRevenueDaysOfWeek(DateTime.Now);
            Revenue revenue = revenues.Find(item => item.time == 1);
            revenues.Remove(revenue);
            revenues.Add(revenue);
            revenues.ForEach(item =>
            {
                if (item.time != 1)
                {
                    table.Rows.Add("Thứ " + item.time, item.value);
                }
                else
                {
                    table.Rows.Add("Chủ Nhật", item.value);
                }
            });
            string title = "Doanh Thu Các Ngày Trong Tuần";
            loadReport(title);
        }

        public void daysOfMonth()
        {
            table.Rows.Clear();
            DateTime Now = DateTime.Now;
            List<Revenue> revenues = dao_r.getRevenueDaysOfMonth(Now);
            revenues.ForEach(item =>
            {
                table.Rows.Add(item.time, item.value);
            });
            string title = $"Doanh Thu Các Ngày Trong Tháng {Now.Month}";
            loadReport(title);
        }
        public void monthsOfYear()
        {
            table.Rows.Clear();
            DateTime Now = DateTime.Now;
            List<Revenue> revenues = dao_r.getRevenueMonthsOfYear(Now);
            revenues.ForEach(item =>
            {
                table.Rows.Add(item.time, item.value);
            });
            string title = $"Doanh Thu Các Tháng Trong Năm {Now.Year}";
            loadReport(title);
        }
        public void quartersOfYear()
        {
            table.Rows.Clear();
            DateTime Now = DateTime.Now;
            List<Revenue> revenues = dao_r.getRevenueQuartersOfYear(Now);
            revenues.ForEach(item =>
            {
                table.Rows.Add(item.time, item.value);
            });
            string title = $"Doanh Thu Các Quý Trong Năm {Now.Year}";
            loadReport(title);
        }
        public void Years(int num)
        {
            table.Rows.Clear();
            DateTime Now = DateTime.Now;
            List<Revenue> revenues = dao_r.getRevenueYears(num);
            revenues.ForEach(item =>
            {
                table.Rows.Add(item.time, item.value);
            });
            string title = $"Doanh Thu {num} Năm Gần Đây";
            loadReport(title);
        }
        public void filter(int type)
        {
            switch (type)
            {
                case 0:
                    daysOfWeek();
                    break;
                case 1:
                    daysOfMonth();
                    break;
                case 2:
                    monthsOfYear();
                    break;
                case 3:
                    quartersOfYear();
                    break;
                case 4:
                    Years(3);
                    break;
            }

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilter.SelectedIndex != -1)
            {
                filter(cbFilter.SelectedIndex);
            }
        }
    }
}
