using Microsoft.Reporting.WinForms;
using PhanMemQuanLy.DAO;
using PhanMemQuanLy.objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PhanMemQuanLy.GUI.userControl
{
    public partial class ucStatistics : UserControl
    {
        private DAO_Revenue dao_r = new DAO_Revenue();
        private DataTable table = new DataTable();
        private string titleStatistics = "";
        public ucStatistics()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            table.Columns.Add("time", typeof(string));
            table.Columns.Add("value", typeof(decimal));
            cbFilter.SelectedIndex = 0;
            statistics(dateTime.Value);
            lblInventory.Text = $"{dao_r.countProductSelledAll()}";
        }

        public void statistics(DateTime date)
        {
            decimal dayRevenue = dao_r.getRevenueOfDate(date);
            lblDayRevenue.Text = $"{dayRevenue.ToString("#,##")}d";
            lblTitleDay.Text = $"Ngày {date.Day}";
            decimal monthRevenue = dao_r.getRevenueOfMonth(date);
            lblMonthRevenue.Text = $"{monthRevenue.ToString("#,##")}d";
            lblTitleMonth.Text = $"Tháng {date.Month}";
            decimal yearRevenue = dao_r.getRevenueOfYear(date);
            lblYearRevenue.Text = $"{yearRevenue.ToString("#,##")}d";
            lblTitleYear.Text = $"Năm {date.Year}";
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
            titleStatistics = "Doanh Thu Các Ngày Trong Tuần";
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
            titleStatistics = $"Doanh Thu Các Ngày Trong Tháng {Now.Month}";
            
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
            titleStatistics = $"Doanh Thu Các Tháng Trong Năm {Now.Year}";
            
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
            titleStatistics = $"Doanh Thu Các Quý Trong Năm {Now.Year}";
            
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
            titleStatistics = $"Doanh Thu {num} Năm Gần Đây";
            
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

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            statistics(dateTime.Value);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            new F_Report(titleStatistics, table).Visible = true;
        }
    }
}
